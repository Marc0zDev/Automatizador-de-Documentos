using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorVersão3
{
    public class Documento
    {
        public Documento() { }
        public void GerarFicha(string estudante, string apoderado, string derivado, string curso, List<string> psicologa, List<string> acordoE, string data, string dados, string RutEstudiante, string RutApoderado, List<string> motivos, List<string> atividades, string caminho)
        {
            // Abre o Documento
            Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
            Document wordDoc = wordApp.Documents.Open(@caminho);

            // Seleciona a tabela e a linha desejada
            Table table = wordDoc.Tables[1];
            int row, col;

            // Estudante
            row = 1;
            col = 2;
            table.Cell(row, col).Range.Text = estudante;
            table.Cell(++row, col).Range.Text = RutEstudiante;

            // Apoderado
            row += 1;
            table.Cell(row, col).Range.Text = apoderado;
            table.Cell(++row, col).Range.Text = RutApoderado;

            // Curso
            row += 1;
            table.Cell(row, col).Range.Text = curso;

            // Data
            row += 1;
            table.Cell(row, col).Range.Text = data;

            // Derivado
            row += 3;
            table.Cell(row, col).Range.Text = derivado;

            // Tabela 2 - Motivos
            table = wordDoc.Tables[2];
            row = 1;
            col = 2;
            table.Cell(row, col).Range.Text = string.Join("\n", motivos.Select(m => $"*{m}"));

            // Tabela 3 - Dados
            table = wordDoc.Tables[3];
            row = 1;
            col = 2;
            table.Cell(row, col).Range.Text = dados;

            // Tabela 4 - Atividades
            table = wordDoc.Tables[4];
            row = 1;
            col = 2;
            table.Cell(row, col).Range.Text = string.Join("\n", atividades.Select(a => $"*{a}"));

            // Tabela 5 - Psicologa e acordoE
            table = wordDoc.Tables[5];
            row = 2;
            col = 1;
            table.Cell(row, col).Range.Text = string.Join("\n", psicologa.Select(p => $"*{p}"));

            col += 1;
            table.Cell(row, col).Range.Text = string.Join("\n", acordoE.Select(a => $"*{a}"));
            SalvarArquivoWord(estudante, wordDoc);
            wordApp.Quit();
        }

        public void SalvarArquivoWord(string estudante, Document wordDoc)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                // Define as propriedades do FolderBrowserDialog
                folderBrowserDialog.Description = "Selecione um diretório";
                folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;
                folderBrowserDialog.ShowNewFolderButton = true;

                //Verifica se o usuario selecionou algum diretorio
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    //Obtem o caminho do arquivo
                    string selectPath = folderBrowserDialog.SelectedPath;

                    //Mostra o camiho para o usuario
                    MessageBox.Show("O arquivo foi salvo em: " + selectPath);
                    //Alteramos o nome do arquivo e salvamos
                    wordDoc.SaveAs(selectPath + "\\" + estudante + ".docx");
                    wordDoc.Close();
                }

            }
        }

        public void SalvaremPDF(string filename, string nomefinal)
        {
            //Selecionar Lugar para salvar 
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            // Define as propriedades do FolderBrowserDialog
            folderBrowserDialog.Description = "Selecione um diretório";
            folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;
            folderBrowserDialog.ShowNewFolderButton = true;
            //Verifica se o usuário selecionou um diretório
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                // Obtém o caminho do diretório selecionado
                string selectedPath = folderBrowserDialog.SelectedPath;
                Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
                Document wordDoc = wordApp.Documents.Open(filename);
                // Salva o documento como PDF
                wordDoc.ExportAsFixedFormat(selectedPath + "\\" + nomefinal + ".pdf", WdExportFormat.wdExportFormatPDF);
                // Fecha o documento e o aplicativo do Word
                wordDoc.Close();
                wordApp.Quit();
            }
            
        }

        public string SelecionarArquivos()
        {
            string erro = "ERROR";
            //Seleciona arquivo em um diretorio
            OpenFileDialog doc = new OpenFileDialog();
            doc.Filter = "Arquivos Word (*.doc; *.docx)| *.doc;*.docx";
            if(doc.ShowDialog() == DialogResult.OK)
            {
                return doc.FileName;
            }
            else
            {
                return erro;
            }
        }

        

    }
}
