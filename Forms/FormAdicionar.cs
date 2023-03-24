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
    public partial class FormAdicionar : Form
    {
        //Form PAi
        FormFicha fp;
        //Variaveis de Transferencia
        public string Adicionar { get; set; }
        public string componente { get; set; }
        public FormAdicionar(FormFicha ficha)
        {
            InitializeComponent();
            fp = ficha;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            fp.Adicionar = txtAdicionar.Text;
            if (radioAcordoA.Checked == true)
            {
                fp.componente = radioAcordoA.Text;
            }
            else if (radioAcordosE.Checked)
            {
                fp.componente = radioAcordosE.Text;
            }
            else if (radioAcordosP.Checked)
            {
                fp.componente = radioAcordosP.Text;
            }
            else if (radioActividades.Checked)
            {
                fp.componente = radioActividades.Text;
            }
            else if (radioMotivo.Checked)
            {
                fp.componente = radioMotivo.Text;
            }
            else if (radioDerivados.Checked)
            {
                fp.componente = radioDerivados.Text;
            }
            else if (radioCurso.Checked)
            {
                fp.componente = radioCurso.Text;
            }

        }
    }

}
