namespace MariaAssisAppointments.MariaAssisAppointments.Forms
{
    partial class FormLogin
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
            TextBoxUser = new TextBox();
            label3 = new Label();
            TextBoxPassword = new TextBox();
            ButtonLogin = new Button();
            LinkLabelForgottenPassword = new LinkLabel();
            LinkLabelNewUser = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(115, 9);
            label1.Name = "label1";
            label1.Size = new Size(151, 33);
            label1.TabIndex = 0;
            label1.Text = "Bem vindo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 65);
            label2.Name = "label2";
            label2.Size = new Size(107, 32);
            label2.TabIndex = 1;
            label2.Text = "Usuário";
            // 
            // TextBoxUser
            // 
            TextBoxUser.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxUser.Location = new Point(12, 100);
            TextBoxUser.Name = "TextBoxUser";
            TextBoxUser.Size = new Size(350, 39);
            TextBoxUser.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 142);
            label3.Name = "label3";
            label3.Size = new Size(92, 32);
            label3.TabIndex = 3;
            label3.Text = "Senha";
            // 
            // TextBoxPassword
            // 
            TextBoxPassword.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxPassword.Location = new Point(12, 177);
            TextBoxPassword.Name = "TextBoxPassword";
            TextBoxPassword.PasswordChar = '*';
            TextBoxPassword.Size = new Size(350, 39);
            TextBoxPassword.TabIndex = 4;
            // 
            // ButtonLogin
            // 
            ButtonLogin.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonLogin.Location = new Point(12, 222);
            ButtonLogin.Name = "ButtonLogin";
            ButtonLogin.Size = new Size(350, 42);
            ButtonLogin.TabIndex = 5;
            ButtonLogin.Text = "Entrar";
            ButtonLogin.UseVisualStyleBackColor = true;
            ButtonLogin.Click += ButtonLogin_Click;
            // 
            // LinkLabelForgottenPassword
            // 
            LinkLabelForgottenPassword.AutoSize = true;
            LinkLabelForgottenPassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LinkLabelForgottenPassword.Location = new Point(110, 267);
            LinkLabelForgottenPassword.Name = "LinkLabelForgottenPassword";
            LinkLabelForgottenPassword.Size = new Size(146, 20);
            LinkLabelForgottenPassword.TabIndex = 6;
            LinkLabelForgottenPassword.TabStop = true;
            LinkLabelForgottenPassword.Text = "Esqueci minha senha";
            // 
            // LinkLabelNewUser
            // 
            LinkLabelNewUser.AutoSize = true;
            LinkLabelNewUser.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LinkLabelNewUser.Location = new Point(136, 303);
            LinkLabelNewUser.Name = "LinkLabelNewUser";
            LinkLabelNewUser.Size = new Size(97, 20);
            LinkLabelNewUser.TabIndex = 7;
            LinkLabelNewUser.TabStop = true;
            LinkLabelNewUser.Text = "Novo usuário";
            LinkLabelNewUser.LinkClicked += LinkLabelNewUser_LinkClicked;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 332);
            Controls.Add(LinkLabelNewUser);
            Controls.Add(LinkLabelForgottenPassword);
            Controls.Add(ButtonLogin);
            Controls.Add(TextBoxPassword);
            Controls.Add(label3);
            Controls.Add(TextBoxUser);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TextBoxUser;
        private Label label3;
        private TextBox TextBoxPassword;
        private Button ButtonLogin;
        private LinkLabel LinkLabelForgottenPassword;
        private LinkLabel LinkLabelNewUser;
    }
}