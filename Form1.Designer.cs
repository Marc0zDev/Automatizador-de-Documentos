namespace GeradorVersão3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelMenu = new Panel();
            btnPDF = new Button();
            btnDocumento = new Button();
            panelLogo = new Panel();
            lblLogo = new Label();
            panelTitulo = new Panel();
            lblTitulo = new Label();
            panelDesktop = new Panel();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            panelTitulo.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(51, 51, 76);
            panelMenu.Controls.Add(btnPDF);
            panelMenu.Controls.Add(btnDocumento);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(200, 542);
            panelMenu.TabIndex = 0;
            // 
            // btnPDF
            // 
            btnPDF.BackColor = Color.FromArgb(51, 51, 76);
            btnPDF.BackgroundImageLayout = ImageLayout.Center;
            btnPDF.Dock = DockStyle.Top;
            btnPDF.FlatAppearance.BorderSize = 0;
            btnPDF.FlatStyle = FlatStyle.Flat;
            btnPDF.Font = new Font("Yu Gothic UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnPDF.ForeColor = SystemColors.Control;
            btnPDF.Image = (Image)resources.GetObject("btnPDF.Image");
            btnPDF.ImageAlign = ContentAlignment.MiddleLeft;
            btnPDF.Location = new Point(0, 140);
            btnPDF.Name = "btnPDF";
            btnPDF.Size = new Size(200, 60);
            btnPDF.TabIndex = 2;
            btnPDF.Text = " Salvar em PDF";
            btnPDF.TextAlign = ContentAlignment.MiddleLeft;
            btnPDF.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPDF.UseVisualStyleBackColor = false;
            btnPDF.Click += btnPDF_Click;
            // 
            // btnDocumento
            // 
            btnDocumento.BackColor = Color.FromArgb(51, 51, 76);
            btnDocumento.BackgroundImageLayout = ImageLayout.Center;
            btnDocumento.Dock = DockStyle.Top;
            btnDocumento.FlatAppearance.BorderSize = 0;
            btnDocumento.FlatStyle = FlatStyle.Flat;
            btnDocumento.Font = new Font("Yu Gothic UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDocumento.ForeColor = SystemColors.Control;
            btnDocumento.Image = (Image)resources.GetObject("btnDocumento.Image");
            btnDocumento.ImageAlign = ContentAlignment.MiddleLeft;
            btnDocumento.Location = new Point(0, 80);
            btnDocumento.Name = "btnDocumento";
            btnDocumento.Size = new Size(200, 60);
            btnDocumento.TabIndex = 1;
            btnDocumento.Text = "Gerar Documento";
            btnDocumento.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDocumento.UseVisualStyleBackColor = false;
            btnDocumento.Click += btnDocumento_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            panelLogo.Controls.Add(lblLogo);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(200, 80);
            panelLogo.TabIndex = 0;
            // 
            // lblLogo
            // 
            lblLogo.Anchor = AnchorStyles.None;
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblLogo.ForeColor = SystemColors.Control;
            lblLogo.Location = new Point(51, 20);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(76, 37);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "MVG";
            lblLogo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelTitulo
            // 
            panelTitulo.BackColor = Color.FromArgb(50, 50, 75);
            panelTitulo.Controls.Add(lblTitulo);
            panelTitulo.Dock = DockStyle.Top;
            panelTitulo.Location = new Point(200, 0);
            panelTitulo.Name = "panelTitulo";
            panelTitulo.Size = new Size(787, 80);
            panelTitulo.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.None;
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Yu Gothic UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = SystemColors.Control;
            lblTitulo.Location = new Point(270, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(247, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Gerar Documentos";
            // 
            // panelDesktop
            // 
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(200, 80);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(787, 462);
            panelDesktop.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(987, 542);
            Controls.Add(panelDesktop);
            Controls.Add(panelTitulo);
            Controls.Add(panelMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Gerador";
            Load += Form1_Load;
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            panelTitulo.ResumeLayout(false);
            panelTitulo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button btnPDF;
        private Button btnDocumento;
        private Panel panelLogo;
        private Label lblLogo;
        private Panel panelTitulo;
        private Label lblTitulo;
        private Panel panelDesktop;
    }
}