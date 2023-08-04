namespace MariaAssisAppointments.MariaAssisAppointments.Forms
{
    partial class FormUser
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
            label1 = new Label();
            label2 = new Label();
            TextBoxName = new TextBox();
            TextBoxPassword = new TextBox();
            label3 = new Label();
            ButtonSave = new Button();
            TextBoxEmail = new TextBox();
            label4 = new Label();
            TextBoxRegisterDate = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(136, 9);
            label1.Name = "label1";
            label1.Size = new Size(173, 32);
            label1.TabIndex = 0;
            label1.Text = "Minha conta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(66, 22);
            label2.TabIndex = 1;
            label2.Text = "Nome:";
            // 
            // TextBoxName
            // 
            TextBoxName.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxName.Location = new Point(168, 59);
            TextBoxName.Name = "TextBoxName";
            TextBoxName.Size = new Size(308, 29);
            TextBoxName.TabIndex = 2;
            // 
            // TextBoxPassword
            // 
            TextBoxPassword.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxPassword.Location = new Point(168, 94);
            TextBoxPassword.Name = "TextBoxPassword";
            TextBoxPassword.Size = new Size(308, 29);
            TextBoxPassword.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 97);
            label3.Name = "label3";
            label3.Size = new Size(69, 22);
            label3.TabIndex = 3;
            label3.Text = "Senha:";
            // 
            // ButtonSave
            // 
            ButtonSave.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonSave.Location = new Point(12, 211);
            ButtonSave.Name = "ButtonSave";
            ButtonSave.Size = new Size(462, 40);
            ButtonSave.TabIndex = 5;
            ButtonSave.Text = "Criar conta";
            ButtonSave.UseVisualStyleBackColor = true;
            ButtonSave.Click += ButtonSave_Click;
            // 
            // TextBoxEmail
            // 
            TextBoxEmail.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxEmail.Location = new Point(168, 129);
            TextBoxEmail.Name = "TextBoxEmail";
            TextBoxEmail.Size = new Size(308, 29);
            TextBoxEmail.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 132);
            label4.Name = "label4";
            label4.Size = new Size(62, 22);
            label4.TabIndex = 6;
            label4.Text = "Email:";
            // 
            // TextBoxRegisterDate
            // 
            TextBoxRegisterDate.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxRegisterDate.Location = new Point(168, 164);
            TextBoxRegisterDate.Name = "TextBoxRegisterDate";
            TextBoxRegisterDate.ReadOnly = true;
            TextBoxRegisterDate.Size = new Size(308, 29);
            TextBoxRegisterDate.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 167);
            label5.Name = "label5";
            label5.Size = new Size(150, 22);
            label5.TabIndex = 8;
            label5.Text = "Data de registro:";
            // 
            // FormUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(486, 263);
            Controls.Add(TextBoxRegisterDate);
            Controls.Add(label5);
            Controls.Add(TextBoxEmail);
            Controls.Add(label4);
            Controls.Add(ButtonSave);
            Controls.Add(TextBoxPassword);
            Controls.Add(label3);
            Controls.Add(TextBoxName);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "FormUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Usuário";
            Load += FormUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TextBoxName;
        private TextBox TextBoxPassword;
        private Label label3;
        private Button ButtonSave;
        private TextBox TextBoxEmail;
        private Label label4;
        private TextBox TextBoxRegisterDate;
        private Label label5;
    }
}