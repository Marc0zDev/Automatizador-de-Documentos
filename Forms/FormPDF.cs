using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorVersão3.Forms
{
    public partial class FormPDF : Form
    {
        //Transferencia
        public string filename { get; set; }
        public FormPDF()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Documento pdf = new Documento();
            pdf.SalvaremPDF(filename, txtNomeArquivo.Text);

        }

        private void btnPDf_Click(object sender, EventArgs e)
        {
            Documento documento = new Documento();
            filename = documento.SelecionarArquivos();
            txtDiretorio.Text = filename;
        }
    }
}
