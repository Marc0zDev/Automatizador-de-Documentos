namespace GeradorVersão3.Forms
{
    partial class FormFicha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFicha));
            lblEstudiante = new Label();
            txtEstudiante = new TextBox();
            lblApoderado = new Label();
            txtApoderado = new TextBox();
            lblDerivado = new Label();
            comboDerivado = new ComboBox();
            label1 = new Label();
            comboCurso = new ComboBox();
            lblData = new Label();
            dateTimePicker = new DateTimePicker();
            label2 = new Label();
            maskedRUTE = new MaskedTextBox();
            label3 = new Label();
            maskedRUTA = new MaskedTextBox();
            label4 = new Label();
            radioApoderado = new RadioButton();
            radioEstudiante = new RadioButton();
            lblCompromissoE = new Label();
            lblAcordoA = new Label();
            label7 = new Label();
            label9 = new Label();
            checkedAtividade = new CheckedListBox();
            button1 = new Button();
            label10 = new Label();
            txtDados = new TextBox();
            checkedLMotivo = new CheckedListBox();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            checkedListBoxApoderado = new CheckedListBox();
            label8 = new Label();
            checkedListEstudiante = new CheckedListBox();
            checkedListPsicologa2 = new CheckedListBox();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblEstudiante
            // 
            lblEstudiante.Anchor = AnchorStyles.Top;
            lblEstudiante.AutoSize = true;
            lblEstudiante.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblEstudiante.Location = new Point(5, 3);
            lblEstudiante.Name = "lblEstudiante";
            lblEstudiante.Size = new Size(87, 17);
            lblEstudiante.TabIndex = 0;
            lblEstudiante.Text = "Estudiante:";
            // 
            // txtEstudiante
            // 
            txtEstudiante.Anchor = AnchorStyles.Top;
            txtEstudiante.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtEstudiante.Location = new Point(5, 23);
            txtEstudiante.Name = "txtEstudiante";
            txtEstudiante.Size = new Size(747, 23);
            txtEstudiante.TabIndex = 1;
            // 
            // lblApoderado
            // 
            lblApoderado.Anchor = AnchorStyles.Top;
            lblApoderado.AutoSize = true;
            lblApoderado.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblApoderado.Location = new Point(5, 49);
            lblApoderado.Name = "lblApoderado";
            lblApoderado.Size = new Size(90, 17);
            lblApoderado.TabIndex = 2;
            lblApoderado.Text = "Apoderado:";
            // 
            // txtApoderado
            // 
            txtApoderado.Anchor = AnchorStyles.Top;
            txtApoderado.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtApoderado.Location = new Point(5, 69);
            txtApoderado.Name = "txtApoderado";
            txtApoderado.Size = new Size(747, 23);
            txtApoderado.TabIndex = 3;
            // 
            // lblDerivado
            // 
            lblDerivado.Anchor = AnchorStyles.Top;
            lblDerivado.AutoSize = true;
            lblDerivado.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblDerivado.Location = new Point(5, 104);
            lblDerivado.Name = "lblDerivado";
            lblDerivado.Size = new Size(74, 17);
            lblDerivado.TabIndex = 4;
            lblDerivado.Text = "Derivado:";
            // 
            // comboDerivado
            // 
            comboDerivado.Anchor = AnchorStyles.Top;
            comboDerivado.FormattingEnabled = true;
            comboDerivado.Items.AddRange(new object[] { "Orientador", "Profesor Jefe", "Inspector General", "Encargado de Convivencia Escolar", "UTP de Básica", "UTP de Media", "Director/a", "Capellán" });
            comboDerivado.Location = new Point(5, 124);
            comboDerivado.Name = "comboDerivado";
            comboDerivado.Size = new Size(189, 23);
            comboDerivado.TabIndex = 5;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(200, 104);
            label1.Name = "label1";
            label1.Size = new Size(54, 17);
            label1.TabIndex = 6;
            label1.Text = "Curso:";
            // 
            // comboCurso
            // 
            comboCurso.Anchor = AnchorStyles.Top;
            comboCurso.FormattingEnabled = true;
            comboCurso.Items.AddRange(new object[] { "NT1 ", "NT2", "1ºBásico", "2ºBásico", "3ºBásico", "4ºBásico", "5ºBásico", "6ºBásico", "7ºBásico", "8ºBásico", "1ºMedio", "2ºMedio", "3ºMedio", "4ºMedio" });
            comboCurso.Location = new Point(200, 124);
            comboCurso.Name = "comboCurso";
            comboCurso.Size = new Size(136, 23);
            comboCurso.TabIndex = 7;
            // 
            // lblData
            // 
            lblData.Anchor = AnchorStyles.Top;
            lblData.AutoSize = true;
            lblData.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblData.Location = new Point(355, 104);
            lblData.Name = "lblData";
            lblData.Size = new Size(45, 17);
            lblData.TabIndex = 8;
            lblData.Text = "Data:";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Anchor = AnchorStyles.Top;
            dateTimePicker.CalendarFont = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker.Format = DateTimePickerFormat.Short;
            dateTimePicker.Location = new Point(355, 124);
            dateTimePicker.MinDate = new DateTime(2022, 1, 1, 0, 0, 0, 0);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(120, 23);
            dateTimePicker.TabIndex = 9;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(5, 160);
            label2.Name = "label2";
            label2.Size = new Size(120, 17);
            label2.TabIndex = 10;
            label2.Text = "RUT Estudiante:";
            // 
            // maskedRUTE
            // 
            maskedRUTE.Anchor = AnchorStyles.Top;
            maskedRUTE.Location = new Point(5, 180);
            maskedRUTE.Mask = "00.000.000-0";
            maskedRUTE.Name = "maskedRUTE";
            maskedRUTE.Size = new Size(120, 23);
            maskedRUTE.TabIndex = 11;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(152, 160);
            label3.Name = "label3";
            label3.Size = new Size(123, 17);
            label3.TabIndex = 12;
            label3.Text = "RUT Apoderado:";
            // 
            // maskedRUTA
            // 
            maskedRUTA.Anchor = AnchorStyles.Top;
            maskedRUTA.Location = new Point(152, 180);
            maskedRUTA.Mask = "00.000.000-0";
            maskedRUTA.Name = "maskedRUTA";
            maskedRUTA.Size = new Size(120, 23);
            maskedRUTA.TabIndex = 13;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(496, 104);
            label4.Name = "label4";
            label4.Size = new Size(185, 17);
            label4.TabIndex = 14;
            label4.Text = "Acordos y compromissos:";
            // 
            // radioApoderado
            // 
            radioApoderado.Anchor = AnchorStyles.Top;
            radioApoderado.AutoSize = true;
            radioApoderado.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            radioApoderado.Location = new Point(496, 128);
            radioApoderado.Name = "radioApoderado";
            radioApoderado.Size = new Size(87, 20);
            radioApoderado.TabIndex = 15;
            radioApoderado.TabStop = true;
            radioApoderado.Text = "Apoderado";
            radioApoderado.UseVisualStyleBackColor = true;
            radioApoderado.CheckedChanged += radioApoderado_CheckedChanged;
            // 
            // radioEstudiante
            // 
            radioEstudiante.Anchor = AnchorStyles.Top;
            radioEstudiante.AutoSize = true;
            radioEstudiante.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            radioEstudiante.Location = new Point(594, 128);
            radioEstudiante.Name = "radioEstudiante";
            radioEstudiante.Size = new Size(84, 20);
            radioEstudiante.TabIndex = 16;
            radioEstudiante.TabStop = true;
            radioEstudiante.Text = "Estudiante";
            radioEstudiante.UseVisualStyleBackColor = true;
            radioEstudiante.CheckedChanged += radioEstudiante_CheckedChanged;
            // 
            // lblCompromissoE
            // 
            lblCompromissoE.Anchor = AnchorStyles.Top;
            lblCompromissoE.AutoSize = true;
            lblCompromissoE.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblCompromissoE.Location = new Point(355, 160);
            lblCompromissoE.Name = "lblCompromissoE";
            lblCompromissoE.Size = new Size(148, 17);
            lblCompromissoE.TabIndex = 17;
            lblCompromissoE.Text = "Acordos Estudiante:";
            lblCompromissoE.Visible = false;
            // 
            // lblAcordoA
            // 
            lblAcordoA.Anchor = AnchorStyles.Top;
            lblAcordoA.AutoSize = true;
            lblAcordoA.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblAcordoA.Location = new Point(5, 738);
            lblAcordoA.Name = "lblAcordoA";
            lblAcordoA.Size = new Size(151, 17);
            lblAcordoA.TabIndex = 19;
            lblAcordoA.Text = "Acordos Apoderado:";
            lblAcordoA.Visible = false;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(5, 621);
            label7.Name = "label7";
            label7.Size = new Size(253, 17);
            label7.TabIndex = 21;
            label7.Text = "Acordos y compromissos Psicologa:";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top;
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(5, 378);
            label9.Name = "label9";
            label9.Size = new Size(162, 17);
            label9.TabIndex = 26;
            label9.Text = "Actividades realizadas:\r\n";
            // 
            // checkedAtividade
            // 
            checkedAtividade.Anchor = AnchorStyles.Top;
            checkedAtividade.ColumnWidth = 500;
            checkedAtividade.FormattingEnabled = true;
            checkedAtividade.Items.AddRange(new object[] { "Se realiza la actividad “línea del tiempo” con el objetivo de conocer los antecedentes relevantes del desarrollo del estudiante.", "Se brindan estrategias de afrontamiento en beneficio de la situación presentada.", "Se realiza derivación a un profesional externo.", "Se solicita el consentimiento informado para intervenir al estudiante.", "Se realiza psicoeducación acerca de los conceptos propios de la situación intervenida.", "Se realiza otorga apoyo para el desarrollo del bienestar emocional.", "Se establece los pasos a seguir del plan de intervención personalizado.", "Se siguen las recomendaciones del profesional tratante.", "Se aplica cuestionario de ideación y/o conducta suicida. ", "Se socializa al apoderado el plan de intervención especializado.\t\t\t\t", "Aplicar el uso de distintas estrategias emocionales en la vida cotidiana" });
            checkedAtividade.Location = new Point(5, 398);
            checkedAtividade.MultiColumn = true;
            checkedAtividade.Name = "checkedAtividade";
            checkedAtividade.ScrollAlwaysVisible = true;
            checkedAtividade.Size = new Size(578, 94);
            checkedAtividade.TabIndex = 27;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Control;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(437, 680);
            button1.Name = "button1";
            button1.Size = new Size(146, 55);
            button1.TabIndex = 28;
            button1.Text = "Guardar";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top;
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(5, 272);
            label10.Name = "label10";
            label10.Size = new Size(135, 17);
            label10.TabIndex = 29;
            label10.Text = "Dados Relevantes:";
            // 
            // txtDados
            // 
            txtDados.Anchor = AnchorStyles.Top;
            txtDados.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtDados.Location = new Point(5, 292);
            txtDados.Multiline = true;
            txtDados.Name = "txtDados";
            txtDados.Size = new Size(747, 83);
            txtDados.TabIndex = 30;
            // 
            // checkedLMotivo
            // 
            checkedLMotivo.Anchor = AnchorStyles.Top;
            checkedLMotivo.ColumnWidth = 500;
            checkedLMotivo.FormattingEnabled = true;
            checkedLMotivo.Items.AddRange(new object[] { "Realizar monitoreo y acompañar los avances del estudiante.", "Evaluar la necesidad de derivación a un profesional externo.", "Realizar contención emocional.", "Estudiante solicita atención psicológica.", "Estudiante presenta ideación y/o conducta suicida.", "Estudiante se autolesiona al interior del establecimiento.", "Estudiante presenta desmotivación académica.", "Estudiante presenta estrés académico.", "Estudiante presenta sintomatología depresiva.", "Estudiante presenta conducta disruptiva.", "Estudiante no alcanza los objetivos acordes a su desarrollo.", "Estudiante presenta comportamientos sexualizados.", "Estudiante presenta comportamiento que no condice con su personalidad." });
            checkedLMotivo.Location = new Point(5, 524);
            checkedLMotivo.MultiColumn = true;
            checkedLMotivo.Name = "checkedLMotivo";
            checkedLMotivo.ScrollAlwaysVisible = true;
            checkedLMotivo.Size = new Size(578, 94);
            checkedLMotivo.TabIndex = 31;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1 });
            toolStrip1.Location = new Point(0, 863);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(792, 25);
            toolStrip1.TabIndex = 32;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 22);
            toolStripButton1.Text = "Adicionar";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // checkedListBoxApoderado
            // 
            checkedListBoxApoderado.Anchor = AnchorStyles.Top;
            checkedListBoxApoderado.ColumnWidth = 750;
            checkedListBoxApoderado.FormattingEnabled = true;
            checkedListBoxApoderado.Items.AddRange(new object[] { "Permitir la libre manifestación de sus emociones, orientándolo a la manifestación saludable de cómo resolver las situaciones, sin interferir en el proceso de autonomía. ", "Apoyar al estudiante en la mantención de hábitos de estudio y compromiso con sus responsabilidades escolares. ", "Felicitar sus logros y avances, demostrándole que se valora su esfuerzo y motivación.", "Fortalecer su capacidad para expresar opiniones.", "Reconocer sus características personales, evitando la comparación con otras personas. ", "Ayudar a la expresión libremente sus emociones.", "Otorgar independencia en la ejecución de sus tareas, ayudándole a organizar sus tiempos, que pueda pedir ayuda solo cuando lo necesite. ", "Permitirle autonomía. No ayudarle si no lo necesita, hacerle ver sus capacidades. ", "Reforzar la escucha activa durante el tiempo que sea necesario, participando de las conversaciones familiares de manera apropiada." });
            checkedListBoxApoderado.Location = new Point(5, 758);
            checkedListBoxApoderado.MultiColumn = true;
            checkedListBoxApoderado.Name = "checkedListBoxApoderado";
            checkedListBoxApoderado.ScrollAlwaysVisible = true;
            checkedListBoxApoderado.Size = new Size(747, 94);
            checkedListBoxApoderado.TabIndex = 33;
            checkedListBoxApoderado.Visible = false;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(5, 504);
            label8.Name = "label8";
            label8.Size = new Size(169, 17);
            label8.TabIndex = 24;
            label8.Text = "Motivo de la entrevista:";
            // 
            // checkedListEstudiante
            // 
            checkedListEstudiante.Anchor = AnchorStyles.Top;
            checkedListEstudiante.ColumnWidth = 750;
            checkedListEstudiante.FormattingEnabled = true;
            checkedListEstudiante.Items.AddRange(new object[] { "Seguir las instrucciones brindadas en la entrevista. ", "Buscar ayuda psicológica cuando lo necesite." });
            checkedListEstudiante.Location = new Point(355, 180);
            checkedListEstudiante.MultiColumn = true;
            checkedListEstudiante.Name = "checkedListEstudiante";
            checkedListEstudiante.ScrollAlwaysVisible = true;
            checkedListEstudiante.Size = new Size(363, 58);
            checkedListEstudiante.TabIndex = 34;
            checkedListEstudiante.Visible = false;
            // 
            // checkedListPsicologa2
            // 
            checkedListPsicologa2.Anchor = AnchorStyles.Top;
            checkedListPsicologa2.ColumnWidth = 750;
            checkedListPsicologa2.FormattingEnabled = true;
            checkedListPsicologa2.Items.AddRange(new object[] { "Citar al apoderado/a.", "Realizar derivación al departamento de convivencia escolar.", "Realizar derivación a orientación.", "Crear plan de intervención personalizado." });
            checkedListPsicologa2.Location = new Point(5, 641);
            checkedListPsicologa2.MultiColumn = true;
            checkedListPsicologa2.Name = "checkedListPsicologa2";
            checkedListPsicologa2.ScrollAlwaysVisible = true;
            checkedListPsicologa2.Size = new Size(352, 94);
            checkedListPsicologa2.TabIndex = 35;
            // 
            // FormFicha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(792, 888);
            Controls.Add(checkedListPsicologa2);
            Controls.Add(checkedListEstudiante);
            Controls.Add(checkedListBoxApoderado);
            Controls.Add(toolStrip1);
            Controls.Add(checkedLMotivo);
            Controls.Add(txtDados);
            Controls.Add(label10);
            Controls.Add(button1);
            Controls.Add(checkedAtividade);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(lblAcordoA);
            Controls.Add(lblCompromissoE);
            Controls.Add(radioEstudiante);
            Controls.Add(radioApoderado);
            Controls.Add(label4);
            Controls.Add(maskedRUTA);
            Controls.Add(label3);
            Controls.Add(maskedRUTE);
            Controls.Add(label2);
            Controls.Add(dateTimePicker);
            Controls.Add(lblData);
            Controls.Add(comboCurso);
            Controls.Add(label1);
            Controls.Add(comboDerivado);
            Controls.Add(lblDerivado);
            Controls.Add(txtApoderado);
            Controls.Add(lblApoderado);
            Controls.Add(txtEstudiante);
            Controls.Add(lblEstudiante);
            Name = "FormFicha";
            Text = "Formulario Ficha";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEstudiante;
        private TextBox txtEstudiante;
        private Label lblApoderado;
        private TextBox txtApoderado;
        private Label lblDerivado;
        private ComboBox comboDerivado;
        private Label label1;
        private ComboBox comboCurso;
        private Label lblData;
        private DateTimePicker dateTimePicker;
        private Label label2;
        private MaskedTextBox maskedRUTE;
        private Label label3;
        private MaskedTextBox maskedRUTA;
        private Label label4;
        private RadioButton radioApoderado;
        private RadioButton radioEstudiante;
        private Label lblCompromissoE;
        private Label lblAcordoA;
        private Label label7;
        private Label label9;
        private CheckedListBox checkedAtividade;
        private Button button1;
        private Label label10;
        private TextBox txtDados;
        private CheckedListBox checkedLMotivo;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private CheckedListBox checkedListBoxApoderado;
        private Label label8;
        private CheckedListBox checkedListEstudiante;
        private CheckedListBox checkedListPsicologa2;
    }
}