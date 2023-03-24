namespace GeradorVersão3
{
    public partial class Form1 : Form
    {
        //Diretorio
        public string diretorio = Properties.Settings.Default.DiretorioInicial;
        private Form activateForm;
        public Form1()
        {
            InitializeComponent();
        }

        //Metodos
        private void ActivateChildForm(Form childForm, object Ativar)
        {
            if (activateForm != null)
            {
                activateForm.Close();
            }
            activateForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitulo.Text = childForm.Text;
        }

        private void btnDocumento_Click(object sender, EventArgs e)
        {
            ActivateChildForm(new Forms.FormFicha(diretorio), sender);
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            ActivateChildForm(new Forms.FormPDF(), sender);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string diretorio = Properties.Settings.Default.DiretorioInicial;
            if(string.IsNullOrEmpty(diretorio))
            {
                Documento ficha = new Documento();
                string caminho = ficha.SelecionarArquivos();
                Properties.Settings.Default.DiretorioInicial = caminho;
                Properties.Settings.Default.Save();
            }
        }
    }
}