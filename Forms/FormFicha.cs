using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorVersão3.Forms
{
    public partial class FormFicha : Form
    {
        public string Adicionar { get; set; }
        public string componente { get; set; }
        //Diretorio
        public string caminho;


        public FormFicha(string diretorio)
        {
            InitializeComponent();
            caminho = diretorio;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string estudante = txtEstudiante.Text;
            string apoderado = txtApoderado.Text;
            string derivado = comboDerivado.Text;
            string curso = comboCurso.Text;
            List<string> motivos = new List<string>();
            List<string> atividades = new List<string>();
            List<string> psicologa = new List<string>();
            List<string> acordoE = new List<string>();
            string hoje = dateTimePicker.Text;
            string dados = txtDados.Text;
            string RutEstudiante = maskedRUTE.Text;
            string RutApoderado = maskedRUTA.Text;
            //popular lista
            if (radioApoderado.Checked)
            {
                foreach (string a in checkedListBoxApoderado.CheckedItems)
                {
                    acordoE.Add(a);
                }
            }
            else if (radioEstudiante.Checked)
            {
                foreach (string a in checkedListEstudiante.CheckedItems)
                {
                    acordoE.Add(a);
                }
            }
            foreach (string s in checkedAtividade.CheckedItems)
            {
                atividades.Add(s);
            }
            foreach (string a in checkedLMotivo.CheckedItems)
            {
                motivos.Add(a);
            }
            Documento ficha = new Documento();
            ficha.GerarFicha(estudante, apoderado, derivado, curso, psicologa, acordoE, hoje, dados, RutEstudiante, RutApoderado, motivos, atividades, caminho);

        }

        private void radioApoderado_CheckedChanged(object sender, EventArgs e)
        {
            checkedListBoxApoderado.Visible = true;
            lblAcordoA.Visible = true;
        }

        private void radioEstudiante_CheckedChanged(object sender, EventArgs e)
        {
            checkedListEstudiante.Visible = true;
            lblCompromissoE.Visible = true;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FormAdicionar form = new FormAdicionar(this);
            form.ShowDialog();
            if (this.componente.Equals("Curso"))
            {
                comboCurso.Items.Add(this.Adicionar);
            }
            else if (this.componente.Equals("Motivo de lá entrevista"))
            {
                checkedLMotivo.Items.Add(this.Adicionar);
            }
            else if (this.componente.Equals("Actividades realizadas"))
            {
                checkedAtividade.Items.Add(this.Adicionar);
            }
            else if (this.componente.Equals("Acordos Psicologa"))
            {
                checkedListPsicologa2.Items.Add(this.Adicionar);
            }
            else if (this.componente.Equals("Acordos Estudiantes"))
            {
                checkedListEstudiante.Items.Add(this.Adicionar);
            }
            else if (this.componente.Equals("Acordos Apoderados"))
            {
                checkedListBoxApoderado.Items.Add(this.Adicionar);
            }
            else if (this.componente.Equals("Derivados"))
            {
                comboDerivado.Items.Add(this.Adicionar);
            }
            else if (this.componente.Equals(""))
            {
                form.Close();
            }
        }

    }
}
