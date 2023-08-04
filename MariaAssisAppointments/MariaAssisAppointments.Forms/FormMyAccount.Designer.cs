namespace MariaAssisAppointments.MariaAssisAppointments.Forms
{
    partial class FormMyAccount
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
            TextBoxName = new TextBox();
            TextBoxEmail = new TextBox();
            label3 = new Label();
            TextBoxPassword = new TextBox();
            label4 = new Label();
            ButtonSave = new Button();
            panel2 = new Panel();
            buttonDelete = new Button();
            TextBoxRegisterDate = new TextBox();
            label5 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(746, 100);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(319, 27);
            label1.Name = "label1";
            label1.Size = new Size(237, 44);
            label1.TabIndex = 0;
            label1.Text = "Minha conta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(0, 109);
            label2.Name = "label2";
            label2.Size = new Size(93, 32);
            label2.TabIndex = 1;
            label2.Text = "Nome:";
            // 
            // TextBoxName
            // 
            TextBoxName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBoxName.Font = new Font("Arial", 20F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxName.Location = new Point(223, 106);
            TextBoxName.Name = "TextBoxName";
            TextBoxName.Size = new Size(260, 38);
            TextBoxName.TabIndex = 2;
            // 
            // TextBoxEmail
            // 
            TextBoxEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBoxEmail.Font = new Font("Arial", 20F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxEmail.Location = new Point(223, 150);
            TextBoxEmail.Name = "TextBoxEmail";
            TextBoxEmail.Size = new Size(260, 38);
            TextBoxEmail.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(0, 153);
            label3.Name = "label3";
            label3.Size = new Size(89, 32);
            label3.TabIndex = 3;
            label3.Text = "Email:";
            // 
            // TextBoxPassword
            // 
            TextBoxPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBoxPassword.Font = new Font("Arial", 20F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxPassword.Location = new Point(223, 194);
            TextBoxPassword.Name = "TextBoxPassword";
            TextBoxPassword.PasswordChar = '*';
            TextBoxPassword.Size = new Size(260, 38);
            TextBoxPassword.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(0, 197);
            label4.Name = "label4";
            label4.Size = new Size(100, 32);
            label4.TabIndex = 5;
            label4.Text = "Senha:";
            // 
            // ButtonSave
            // 
            ButtonSave.Dock = DockStyle.Top;
            ButtonSave.FlatStyle = FlatStyle.Flat;
            ButtonSave.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonSave.ForeColor = Color.White;
            ButtonSave.Location = new Point(0, 0);
            ButtonSave.Name = "ButtonSave";
            ButtonSave.Size = new Size(253, 44);
            ButtonSave.TabIndex = 7;
            ButtonSave.Text = "Salvar";
            ButtonSave.UseVisualStyleBackColor = true;
            ButtonSave.Click += ButtonSave_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 64, 64);
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(buttonDelete);
            panel2.Controls.Add(ButtonSave);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(489, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(257, 350);
            panel2.TabIndex = 8;
            // 
            // buttonDelete
            // 
            buttonDelete.Dock = DockStyle.Top;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDelete.ForeColor = Color.White;
            buttonDelete.Location = new Point(0, 44);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(253, 44);
            buttonDelete.TabIndex = 8;
            buttonDelete.Text = "Excluir conta";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // TextBoxRegisterDate
            // 
            TextBoxRegisterDate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBoxRegisterDate.Font = new Font("Arial", 20F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxRegisterDate.Location = new Point(223, 238);
            TextBoxRegisterDate.Name = "TextBoxRegisterDate";
            TextBoxRegisterDate.ReadOnly = true;
            TextBoxRegisterDate.Size = new Size(260, 38);
            TextBoxRegisterDate.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(0, 241);
            label5.Name = "label5";
            label5.Size = new Size(217, 32);
            label5.TabIndex = 9;
            label5.Text = "Data de registro:";
            // 
            // FormMyAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(746, 450);
            Controls.Add(TextBoxRegisterDate);
            Controls.Add(label5);
            Controls.Add(panel2);
            Controls.Add(TextBoxPassword);
            Controls.Add(label4);
            Controls.Add(TextBoxEmail);
            Controls.Add(label3);
            Controls.Add(TextBoxName);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMyAccount";
            Text = "FormMyAccount";
            WindowState = FormWindowState.Maximized;
            Load += FormMyAccount_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox TextBoxName;
        private TextBox TextBoxEmail;
        private Label label3;
        private TextBox TextBoxPassword;
        private Label label4;
        private Button ButtonSave;
        private Panel panel2;
        private Button buttonDelete;
        private TextBox TextBoxRegisterDate;
        private Label label5;
    }
}