namespace GeradorVersão3.Forms
{
    partial class FormAdicionar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdicionar));
            btnAdicionar = new Button();
            txtAdicionar = new TextBox();
            radioDerivados = new RadioButton();
            radioAcordoA = new RadioButton();
            radioAcordosE = new RadioButton();
            radioAcordosP = new RadioButton();
            radioActividades = new RadioButton();
            radioMotivo = new RadioButton();
            radioCurso = new RadioButton();
            SuspendLayout();
            // 
            // btnAdicionar
            // 
            btnAdicionar.FlatAppearance.BorderSize = 0;
            btnAdicionar.FlatStyle = FlatStyle.Flat;
            btnAdicionar.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdicionar.Image = (Image)resources.GetObject("btnAdicionar.Image");
            btnAdicionar.Location = new Point(212, 256);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(113, 45);
            btnAdicionar.TabIndex = 1;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // txtAdicionar
            // 
            txtAdicionar.Location = new Point(0, 123);
            txtAdicionar.Multiline = true;
            txtAdicionar.Name = "txtAdicionar";
            txtAdicionar.Size = new Size(548, 127);
            txtAdicionar.TabIndex = 2;
            // 
            // radioDerivados
            // 
            radioDerivados.AutoSize = true;
            radioDerivados.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            radioDerivados.Location = new Point(283, 68);
            radioDerivados.Name = "radioDerivados";
            radioDerivados.Size = new Size(102, 22);
            radioDerivados.TabIndex = 7;
            radioDerivados.TabStop = true;
            radioDerivados.Text = "Derivados";
            radioDerivados.UseVisualStyleBackColor = true;
            // 
            // radioAcordoA
            // 
            radioAcordoA.AutoSize = true;
            radioAcordoA.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            radioAcordoA.Location = new Point(283, 40);
            radioAcordoA.Name = "radioAcordoA";
            radioAcordoA.Size = new Size(178, 22);
            radioAcordoA.TabIndex = 8;
            radioAcordoA.TabStop = true;
            radioAcordoA.Text = "Acordos Apoderados";
            radioAcordoA.UseVisualStyleBackColor = true;
            // 
            // radioAcordosE
            // 
            radioAcordosE.AutoSize = true;
            radioAcordosE.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            radioAcordosE.Location = new Point(283, 12);
            radioAcordosE.Name = "radioAcordosE";
            radioAcordosE.Size = new Size(177, 22);
            radioAcordosE.TabIndex = 9;
            radioAcordosE.TabStop = true;
            radioAcordosE.Text = "Acordos Estudiantes";
            radioAcordosE.UseVisualStyleBackColor = true;
            // 
            // radioAcordosP
            // 
            radioAcordosP.AutoSize = true;
            radioAcordosP.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            radioAcordosP.Location = new Point(49, 96);
            radioAcordosP.Name = "radioAcordosP";
            radioAcordosP.Size = new Size(162, 22);
            radioAcordosP.TabIndex = 10;
            radioAcordosP.TabStop = true;
            radioAcordosP.Text = "Acordos Psicologa";
            radioAcordosP.UseVisualStyleBackColor = true;
            // 
            // radioActividades
            // 
            radioActividades.AutoSize = true;
            radioActividades.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            radioActividades.Location = new Point(49, 68);
            radioActividades.Name = "radioActividades";
            radioActividades.Size = new Size(195, 22);
            radioActividades.TabIndex = 6;
            radioActividades.TabStop = true;
            radioActividades.Text = "Actividades realizadas";
            radioActividades.UseVisualStyleBackColor = true;
            // 
            // radioMotivo
            // 
            radioMotivo.AutoSize = true;
            radioMotivo.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            radioMotivo.Location = new Point(49, 40);
            radioMotivo.Name = "radioMotivo";
            radioMotivo.Size = new Size(198, 22);
            radioMotivo.TabIndex = 5;
            radioMotivo.TabStop = true;
            radioMotivo.Text = "Motivo de lá entrevista";
            radioMotivo.UseVisualStyleBackColor = true;
            // 
            // radioCurso
            // 
            radioCurso.AutoSize = true;
            radioCurso.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            radioCurso.Location = new Point(49, 12);
            radioCurso.Name = "radioCurso";
            radioCurso.Size = new Size(69, 22);
            radioCurso.TabIndex = 4;
            radioCurso.TabStop = true;
            radioCurso.Text = "Curso";
            radioCurso.UseVisualStyleBackColor = true;
            // 
            // FormAdicionar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 309);
            Controls.Add(radioDerivados);
            Controls.Add(radioAcordoA);
            Controls.Add(radioAcordosE);
            Controls.Add(radioAcordosP);
            Controls.Add(radioActividades);
            Controls.Add(radioMotivo);
            Controls.Add(radioCurso);
            Controls.Add(txtAdicionar);
            Controls.Add(btnAdicionar);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormAdicionar";
            Text = "Adicionar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAdicionar;
        private TextBox txtAdicionar;
        private RadioButton radioDerivados;
        private RadioButton radioAcordoA;
        private RadioButton radioAcordosE;
        private RadioButton radioAcordosP;
        private RadioButton radioActividades;
        private RadioButton radioMotivo;
        private RadioButton radioCurso;
    }
}