namespace MariaAssisAppointments.MariaAssisAppointments.Forms
{
    partial class FormCustomers
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
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            TextBox1FullName = new TextBox();
            MaskedTextBoxCpf = new MaskedTextBox();
            label3 = new Label();
            label4 = new Label();
            MaskedTextBoxBirthDate = new MaskedTextBox();
            TextBoxFather = new TextBox();
            label5 = new Label();
            TextBoxMother = new TextBox();
            label6 = new Label();
            label7 = new Label();
            MaskedTextBoxWhatspp = new MaskedTextBox();
            ComboBoxPacs = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            ComboBoxPeriod = new ComboBox();
            panel2 = new Panel();
            ButtonCheckData = new Button();
            ButtonLast = new Button();
            ButtonNext = new Button();
            ButtonPrevious = new Button();
            ButtonFirst = new Button();
            ButtonSearchAppointments = new Button();
            ButtonMakeAppointments = new Button();
            ButtonDelete = new Button();
            ButtonNew = new Button();
            ButtonRegisterCustomers = new Button();
            label10 = new Label();
            ComboBoxCustomers = new ComboBox();
            panel3 = new Panel();
            label11 = new Label();
            ComboBoxAppointmentStatus = new ComboBox();
            Label1NumberOfCustomers = new Label();
            TextBoxCode = new TextBox();
            label12 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1253, 100);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 26F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(335, 25);
            label1.Name = "label1";
            label1.Size = new Size(417, 50);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de clientes";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(0, 109);
            label2.Name = "label2";
            label2.Size = new Size(211, 32);
            label2.TabIndex = 1;
            label2.Text = "Nome completo:";
            // 
            // TextBox1FullName
            // 
            TextBox1FullName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBox1FullName.Font = new Font("Arial", 20F, FontStyle.Regular, GraphicsUnit.Point);
            TextBox1FullName.Location = new Point(316, 106);
            TextBox1FullName.Name = "TextBox1FullName";
            TextBox1FullName.Size = new Size(632, 38);
            TextBox1FullName.TabIndex = 2;
            // 
            // MaskedTextBoxCpf
            // 
            MaskedTextBoxCpf.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            MaskedTextBoxCpf.Font = new Font("Arial", 20F, FontStyle.Regular, GraphicsUnit.Point);
            MaskedTextBoxCpf.Location = new Point(316, 150);
            MaskedTextBoxCpf.Mask = "000.000.000-00";
            MaskedTextBoxCpf.Name = "MaskedTextBoxCpf";
            MaskedTextBoxCpf.Size = new Size(632, 38);
            MaskedTextBoxCpf.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(0, 153);
            label3.Name = "label3";
            label3.Size = new Size(76, 32);
            label3.TabIndex = 4;
            label3.Text = "CPF:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(0, 197);
            label4.Name = "label4";
            label4.Size = new Size(265, 32);
            label4.TabIndex = 6;
            label4.Text = "Data de nascimento:";
            // 
            // MaskedTextBoxBirthDate
            // 
            MaskedTextBoxBirthDate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            MaskedTextBoxBirthDate.Font = new Font("Arial", 20F, FontStyle.Regular, GraphicsUnit.Point);
            MaskedTextBoxBirthDate.Location = new Point(316, 194);
            MaskedTextBoxBirthDate.Mask = "00/00/0000";
            MaskedTextBoxBirthDate.Name = "MaskedTextBoxBirthDate";
            MaskedTextBoxBirthDate.Size = new Size(632, 38);
            MaskedTextBoxBirthDate.TabIndex = 5;
            MaskedTextBoxBirthDate.ValidatingType = typeof(DateTime);
            // 
            // TextBoxFather
            // 
            TextBoxFather.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBoxFather.Font = new Font("Arial", 20F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxFather.Location = new Point(316, 238);
            TextBoxFather.Name = "TextBoxFather";
            TextBoxFather.Size = new Size(632, 38);
            TextBoxFather.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(0, 241);
            label5.Name = "label5";
            label5.Size = new Size(175, 32);
            label5.TabIndex = 7;
            label5.Text = "Nome do pai:";
            // 
            // TextBoxMother
            // 
            TextBoxMother.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBoxMother.Font = new Font("Arial", 20F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxMother.Location = new Point(316, 282);
            TextBoxMother.Name = "TextBoxMother";
            TextBoxMother.Size = new Size(632, 38);
            TextBoxMother.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(0, 285);
            label6.Name = "label6";
            label6.Size = new Size(191, 32);
            label6.TabIndex = 9;
            label6.Text = "Nome da mãe:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(0, 329);
            label7.Name = "label7";
            label7.Size = new Size(150, 32);
            label7.TabIndex = 12;
            label7.Text = "WhatsApp:";
            // 
            // MaskedTextBoxWhatspp
            // 
            MaskedTextBoxWhatspp.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            MaskedTextBoxWhatspp.Font = new Font("Arial", 20F, FontStyle.Regular, GraphicsUnit.Point);
            MaskedTextBoxWhatspp.Location = new Point(316, 326);
            MaskedTextBoxWhatspp.Mask = "(99) 00000-0000";
            MaskedTextBoxWhatspp.Name = "MaskedTextBoxWhatspp";
            MaskedTextBoxWhatspp.Size = new Size(632, 38);
            MaskedTextBoxWhatspp.TabIndex = 11;
            // 
            // ComboBoxPacs
            // 
            ComboBoxPacs.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ComboBoxPacs.Font = new Font("Arial", 20F, FontStyle.Regular, GraphicsUnit.Point);
            ComboBoxPacs.FormattingEnabled = true;
            ComboBoxPacs.Items.AddRange(new object[] { "PAC-COMPENSA", "PAC - SHOPPING LESTE", "PAC-MUNICIPAL T4", "PAC - SÃO JOSÉ", "PAC - MUN. GALERIA ESP. SANTO", "PAC - GALERIA DOS REMÉDIOS", "PAC - STUDIO 5", "PAC - ALVORADA", "PAC - SHOPPING PARQUE 10 MALL", "PAC - SUMAÚMA", "PAC - SHOPPING VIA NORTE", "PAC - Móvel Açaí", "PAC - Móvel Buriti", "PAC - Móvel Cupuaçu", "PAC - Móvel Tucumã", "Municipio - HUMAITÁ" });
            ComboBoxPacs.Location = new Point(316, 370);
            ComboBoxPacs.Name = "ComboBoxPacs";
            ComboBoxPacs.Size = new Size(632, 40);
            ComboBoxPacs.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(0, 373);
            label8.Name = "label8";
            label8.Size = new Size(75, 32);
            label8.TabIndex = 14;
            label8.Text = "PAC:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(1, 419);
            label9.Name = "label9";
            label9.Size = new Size(114, 32);
            label9.TabIndex = 16;
            label9.Text = "Período:";
            // 
            // ComboBoxPeriod
            // 
            ComboBoxPeriod.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ComboBoxPeriod.Font = new Font("Arial", 20F, FontStyle.Regular, GraphicsUnit.Point);
            ComboBoxPeriod.FormattingEnabled = true;
            ComboBoxPeriod.Items.AddRange(new object[] { "Manhã", "Tarde" });
            ComboBoxPeriod.Location = new Point(317, 416);
            ComboBoxPeriod.Name = "ComboBoxPeriod";
            ComboBoxPeriod.Size = new Size(632, 40);
            ComboBoxPeriod.TabIndex = 15;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 64, 64);
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(ButtonCheckData);
            panel2.Controls.Add(ButtonLast);
            panel2.Controls.Add(ButtonNext);
            panel2.Controls.Add(ButtonPrevious);
            panel2.Controls.Add(ButtonFirst);
            panel2.Controls.Add(ButtonSearchAppointments);
            panel2.Controls.Add(ButtonMakeAppointments);
            panel2.Controls.Add(ButtonDelete);
            panel2.Controls.Add(ButtonNew);
            panel2.Controls.Add(ButtonRegisterCustomers);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(954, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(299, 614);
            panel2.TabIndex = 17;
            // 
            // ButtonCheckData
            // 
            ButtonCheckData.BackColor = Color.FromArgb(64, 64, 64);
            ButtonCheckData.Dock = DockStyle.Top;
            ButtonCheckData.FlatStyle = FlatStyle.Flat;
            ButtonCheckData.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonCheckData.ForeColor = Color.White;
            ButtonCheckData.Location = new Point(0, 450);
            ButtonCheckData.Name = "ButtonCheckData";
            ButtonCheckData.Size = new Size(295, 50);
            ButtonCheckData.TabIndex = 11;
            ButtonCheckData.Text = "Conferir dados";
            ButtonCheckData.UseVisualStyleBackColor = false;
            ButtonCheckData.Click += ButtonCheckData_Click;
            // 
            // ButtonLast
            // 
            ButtonLast.BackColor = Color.FromArgb(64, 64, 64);
            ButtonLast.Dock = DockStyle.Top;
            ButtonLast.FlatStyle = FlatStyle.Flat;
            ButtonLast.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonLast.ForeColor = Color.White;
            ButtonLast.Location = new Point(0, 400);
            ButtonLast.Name = "ButtonLast";
            ButtonLast.Size = new Size(295, 50);
            ButtonLast.TabIndex = 10;
            ButtonLast.Text = "Último";
            ButtonLast.UseVisualStyleBackColor = false;
            ButtonLast.Click += ButtonLast_Click;
            // 
            // ButtonNext
            // 
            ButtonNext.BackColor = Color.FromArgb(64, 64, 64);
            ButtonNext.Dock = DockStyle.Top;
            ButtonNext.FlatStyle = FlatStyle.Flat;
            ButtonNext.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonNext.ForeColor = Color.White;
            ButtonNext.Location = new Point(0, 350);
            ButtonNext.Name = "ButtonNext";
            ButtonNext.Size = new Size(295, 50);
            ButtonNext.TabIndex = 9;
            ButtonNext.Text = "Próximo";
            ButtonNext.UseVisualStyleBackColor = false;
            ButtonNext.Click += ButtonNext_Click;
            // 
            // ButtonPrevious
            // 
            ButtonPrevious.BackColor = Color.FromArgb(64, 64, 64);
            ButtonPrevious.Dock = DockStyle.Top;
            ButtonPrevious.FlatStyle = FlatStyle.Flat;
            ButtonPrevious.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonPrevious.ForeColor = Color.White;
            ButtonPrevious.Location = new Point(0, 300);
            ButtonPrevious.Name = "ButtonPrevious";
            ButtonPrevious.Size = new Size(295, 50);
            ButtonPrevious.TabIndex = 8;
            ButtonPrevious.Text = "Anterior";
            ButtonPrevious.UseVisualStyleBackColor = false;
            ButtonPrevious.Click += ButtonPrevious_Click;
            // 
            // ButtonFirst
            // 
            ButtonFirst.BackColor = Color.FromArgb(64, 64, 64);
            ButtonFirst.Dock = DockStyle.Top;
            ButtonFirst.FlatStyle = FlatStyle.Flat;
            ButtonFirst.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonFirst.ForeColor = Color.White;
            ButtonFirst.Location = new Point(0, 250);
            ButtonFirst.Name = "ButtonFirst";
            ButtonFirst.Size = new Size(295, 50);
            ButtonFirst.TabIndex = 7;
            ButtonFirst.Text = "Primeiro";
            ButtonFirst.UseVisualStyleBackColor = false;
            ButtonFirst.Click += ButtonFirst_Click;
            // 
            // ButtonSearchAppointments
            // 
            ButtonSearchAppointments.BackColor = Color.FromArgb(64, 64, 64);
            ButtonSearchAppointments.Dock = DockStyle.Top;
            ButtonSearchAppointments.FlatStyle = FlatStyle.Flat;
            ButtonSearchAppointments.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonSearchAppointments.ForeColor = Color.White;
            ButtonSearchAppointments.Location = new Point(0, 200);
            ButtonSearchAppointments.Name = "ButtonSearchAppointments";
            ButtonSearchAppointments.Size = new Size(295, 50);
            ButtonSearchAppointments.TabIndex = 6;
            ButtonSearchAppointments.Text = "Consultar agendamentos";
            ButtonSearchAppointments.UseVisualStyleBackColor = false;
            ButtonSearchAppointments.Click += ButtonSearchAppointments_Click;
            // 
            // ButtonMakeAppointments
            // 
            ButtonMakeAppointments.BackColor = Color.FromArgb(64, 64, 64);
            ButtonMakeAppointments.Dock = DockStyle.Top;
            ButtonMakeAppointments.FlatStyle = FlatStyle.Flat;
            ButtonMakeAppointments.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonMakeAppointments.ForeColor = Color.White;
            ButtonMakeAppointments.Location = new Point(0, 150);
            ButtonMakeAppointments.Name = "ButtonMakeAppointments";
            ButtonMakeAppointments.Size = new Size(295, 50);
            ButtonMakeAppointments.TabIndex = 5;
            ButtonMakeAppointments.Text = "Fazer agendamentos";
            ButtonMakeAppointments.UseVisualStyleBackColor = false;
            ButtonMakeAppointments.Click += ButtonMakeAppointments_Click;
            // 
            // ButtonDelete
            // 
            ButtonDelete.BackColor = Color.FromArgb(64, 64, 64);
            ButtonDelete.Dock = DockStyle.Top;
            ButtonDelete.FlatStyle = FlatStyle.Flat;
            ButtonDelete.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonDelete.ForeColor = Color.White;
            ButtonDelete.Location = new Point(0, 100);
            ButtonDelete.Name = "ButtonDelete";
            ButtonDelete.Size = new Size(295, 50);
            ButtonDelete.TabIndex = 4;
            ButtonDelete.Text = "Deletar";
            ButtonDelete.UseVisualStyleBackColor = false;
            ButtonDelete.Click += ButtonDelete_Click;
            // 
            // ButtonNew
            // 
            ButtonNew.BackColor = Color.FromArgb(64, 64, 64);
            ButtonNew.Dock = DockStyle.Top;
            ButtonNew.FlatStyle = FlatStyle.Flat;
            ButtonNew.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonNew.ForeColor = Color.White;
            ButtonNew.Location = new Point(0, 50);
            ButtonNew.Name = "ButtonNew";
            ButtonNew.Size = new Size(295, 50);
            ButtonNew.TabIndex = 3;
            ButtonNew.Text = "Novo";
            ButtonNew.UseVisualStyleBackColor = false;
            ButtonNew.Click += ButtonNew_Click;
            // 
            // ButtonRegisterCustomers
            // 
            ButtonRegisterCustomers.BackColor = Color.FromArgb(64, 64, 64);
            ButtonRegisterCustomers.Dock = DockStyle.Top;
            ButtonRegisterCustomers.FlatStyle = FlatStyle.Flat;
            ButtonRegisterCustomers.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonRegisterCustomers.ForeColor = Color.White;
            ButtonRegisterCustomers.Location = new Point(0, 0);
            ButtonRegisterCustomers.Name = "ButtonRegisterCustomers";
            ButtonRegisterCustomers.Size = new Size(295, 50);
            ButtonRegisterCustomers.TabIndex = 2;
            ButtonRegisterCustomers.Text = "Salvar";
            ButtonRegisterCustomers.UseVisualStyleBackColor = false;
            ButtonRegisterCustomers.Click += ButtonRegisterCustomers_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(0, 0);
            label10.Name = "label10";
            label10.Size = new Size(270, 32);
            label10.TabIndex = 19;
            label10.Text = "Clientes cadastrados";
            // 
            // ComboBoxCustomers
            // 
            ComboBoxCustomers.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ComboBoxCustomers.Font = new Font("Arial", 20F, FontStyle.Regular, GraphicsUnit.Point);
            ComboBoxCustomers.FormattingEnabled = true;
            ComboBoxCustomers.Items.AddRange(new object[] { "Manhã", "Tarde" });
            ComboBoxCustomers.Location = new Point(3, 35);
            ComboBoxCustomers.Name = "ComboBoxCustomers";
            ComboBoxCustomers.Size = new Size(941, 40);
            ComboBoxCustomers.TabIndex = 18;
            ComboBoxCustomers.SelectedIndexChanged += ComboBoxCustomers_SelectedIndexChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(64, 64, 64);
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(ComboBoxCustomers);
            panel3.Controls.Add(label10);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 614);
            panel3.Name = "panel3";
            panel3.Size = new Size(954, 100);
            panel3.TabIndex = 20;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(0, 465);
            label11.Name = "label11";
            label11.Size = new Size(311, 32);
            label11.TabIndex = 22;
            label11.Text = "Status do agendamento:";
            // 
            // ComboBoxAppointmentStatus
            // 
            ComboBoxAppointmentStatus.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ComboBoxAppointmentStatus.Font = new Font("Arial", 20F, FontStyle.Regular, GraphicsUnit.Point);
            ComboBoxAppointmentStatus.FormattingEnabled = true;
            ComboBoxAppointmentStatus.Items.AddRange(new object[] { "Agendado", "Pendente" });
            ComboBoxAppointmentStatus.Location = new Point(317, 462);
            ComboBoxAppointmentStatus.Name = "ComboBoxAppointmentStatus";
            ComboBoxAppointmentStatus.Size = new Size(631, 40);
            ComboBoxAppointmentStatus.TabIndex = 21;
            // 
            // Label1NumberOfCustomers
            // 
            Label1NumberOfCustomers.AutoSize = true;
            Label1NumberOfCustomers.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            Label1NumberOfCustomers.ForeColor = Color.Black;
            Label1NumberOfCustomers.Location = new Point(2, 579);
            Label1NumberOfCustomers.Name = "Label1NumberOfCustomers";
            Label1NumberOfCustomers.Size = new Size(0, 32);
            Label1NumberOfCustomers.TabIndex = 23;
            // 
            // TextBoxCode
            // 
            TextBoxCode.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBoxCode.Font = new Font("Arial", 20F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxCode.Location = new Point(316, 508);
            TextBoxCode.Name = "TextBoxCode";
            TextBoxCode.ReadOnly = true;
            TextBoxCode.Size = new Size(632, 38);
            TextBoxCode.TabIndex = 25;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(0, 511);
            label12.Name = "label12";
            label12.Size = new Size(233, 32);
            label12.TabIndex = 24;
            label12.Text = "Código do cliente:";
            // 
            // FormCustomers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1253, 714);
            Controls.Add(TextBoxCode);
            Controls.Add(label12);
            Controls.Add(Label1NumberOfCustomers);
            Controls.Add(label11);
            Controls.Add(ComboBoxAppointmentStatus);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label9);
            Controls.Add(ComboBoxPeriod);
            Controls.Add(label8);
            Controls.Add(ComboBoxPacs);
            Controls.Add(label7);
            Controls.Add(MaskedTextBoxWhatspp);
            Controls.Add(TextBoxMother);
            Controls.Add(label6);
            Controls.Add(TextBoxFather);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(MaskedTextBoxBirthDate);
            Controls.Add(label3);
            Controls.Add(MaskedTextBoxCpf);
            Controls.Add(TextBox1FullName);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCustomers";
            Text = "FormCustomers";
            WindowState = FormWindowState.Maximized;
            Load += FormCustomers_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox TextBox1FullName;
        private MaskedTextBox MaskedTextBoxCpf;
        private Label label3;
        private Label label4;
        private MaskedTextBox MaskedTextBoxBirthDate;
        private TextBox TextBoxFather;
        private Label label5;
        private TextBox TextBoxMother;
        private Label label6;
        private Label label7;
        private MaskedTextBox MaskedTextBoxWhatspp;
        private ComboBox ComboBoxPacs;
        private Label label8;
        private Label label9;
        private ComboBox ComboBoxPeriod;
        private Panel panel2;
        private Button ButtonNew;
        private Button ButtonRegisterCustomers;
        private Button ButtonDelete;
        private Button ButtonSearchAppointments;
        private Button ButtonMakeAppointments;
        private Button ButtonLast;
        private Button ButtonNext;
        private Button ButtonPrevious;
        private Button ButtonFirst;
        private Label label10;
        private ComboBox ComboBoxCustomers;
        private Panel panel3;
        private Label label11;
        private ComboBox ComboBoxAppointmentStatus;
        private Label Label1NumberOfCustomers;
        private Button ButtonCheckData;
        private TextBox TextBoxCode;
        private Label label12;
    }
}