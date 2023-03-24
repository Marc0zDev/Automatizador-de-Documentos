namespace GeradorVersão3.Forms
{
    partial class FormPDF
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPDF));
            btnSalvar = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtNomeArquivo = new TextBox();
            lblNomeArquivo = new Label();
            lblDiretorio = new Label();
            txtDiretorio = new TextBox();
            btnPDf = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.White;
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalvar.ForeColor = SystemColors.ControlText;
            btnSalvar.Image = (Image)resources.GetObject("btnSalvar.Image");
            btnSalvar.Location = new Point(640, 389);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(110, 49);
            btnSalvar.TabIndex = 1;
            btnSalvar.Text = "Guardar";
            btnSalvar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.None;
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.0234985F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 72.9765F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.Controls.Add(txtNomeArquivo, 1, 1);
            tableLayoutPanel1.Controls.Add(lblNomeArquivo, 0, 1);
            tableLayoutPanel1.Controls.Add(lblDiretorio, 0, 0);
            tableLayoutPanel1.Controls.Add(txtDiretorio, 1, 0);
            tableLayoutPanel1.Controls.Add(btnPDf, 2, 0);
            tableLayoutPanel1.Location = new Point(-4, 1);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.Size = new Size(803, 54);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // txtNomeArquivo
            // 
            txtNomeArquivo.Dock = DockStyle.Top;
            txtNomeArquivo.Location = new Point(210, 32);
            txtNomeArquivo.Name = "txtNomeArquivo";
            txtNomeArquivo.Size = new Size(553, 23);
            txtNomeArquivo.TabIndex = 3;
            // 
            // lblNomeArquivo
            // 
            lblNomeArquivo.AutoSize = true;
            lblNomeArquivo.Dock = DockStyle.Top;
            lblNomeArquivo.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblNomeArquivo.Location = new Point(3, 29);
            lblNomeArquivo.Name = "lblNomeArquivo";
            lblNomeArquivo.Size = new Size(201, 17);
            lblNomeArquivo.TabIndex = 2;
            lblNomeArquivo.Text = "Digite o nome do Arquivo:";
            // 
            // lblDiretorio
            // 
            lblDiretorio.AutoSize = true;
            lblDiretorio.Dock = DockStyle.Top;
            lblDiretorio.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblDiretorio.Location = new Point(3, 0);
            lblDiretorio.Name = "lblDiretorio";
            lblDiretorio.Size = new Size(201, 17);
            lblDiretorio.TabIndex = 0;
            lblDiretorio.Text = "Escolha o arquivo desejado:";
            // 
            // txtDiretorio
            // 
            txtDiretorio.Dock = DockStyle.Top;
            txtDiretorio.Location = new Point(210, 3);
            txtDiretorio.Name = "txtDiretorio";
            txtDiretorio.Size = new Size(553, 23);
            txtDiretorio.TabIndex = 1;
            // 
            // btnPDf
            // 
            btnPDf.Location = new Point(769, 3);
            btnPDf.Name = "btnPDf";
            btnPDf.Size = new Size(31, 23);
            btnPDf.TabIndex = 4;
            btnPDf.Text = "...";
            btnPDf.UseVisualStyleBackColor = true;
            btnPDf.Click += btnPDf_Click;
            // 
            // FormPDF
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(btnSalvar);
            Name = "FormPDF";
            Text = "Salvar em PDF";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnSalvar;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblDiretorio;
        private TextBox txtDiretorio;
        private TextBox txtNomeArquivo;
        private Label lblNomeArquivo;
        private Button btnPDf;
    }
}