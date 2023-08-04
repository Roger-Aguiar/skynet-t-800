namespace MariaAssisAppointments.MariaAssisAppointments.Forms
{
    partial class FormAppointments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAppointments));
            panelMain = new Panel();
            ButtonExit = new Button();
            ButtonHome = new Button();
            ButtonMyAccount = new Button();
            ButtonRegisterCustomers = new Button();
            panel2 = new Panel();
            label1 = new Label();
            panelForm = new Panel();
            panelMain.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(64, 64, 64);
            panelMain.BorderStyle = BorderStyle.Fixed3D;
            panelMain.Controls.Add(ButtonExit);
            panelMain.Controls.Add(ButtonHome);
            panelMain.Controls.Add(ButtonMyAccount);
            panelMain.Controls.Add(ButtonRegisterCustomers);
            panelMain.Controls.Add(panel2);
            panelMain.Dock = DockStyle.Left;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(261, 559);
            panelMain.TabIndex = 0;
            // 
            // ButtonExit
            // 
            ButtonExit.BackColor = Color.FromArgb(64, 64, 64);
            ButtonExit.Dock = DockStyle.Top;
            ButtonExit.FlatStyle = FlatStyle.Flat;
            ButtonExit.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonExit.ForeColor = Color.White;
            ButtonExit.Location = new Point(0, 250);
            ButtonExit.Name = "ButtonExit";
            ButtonExit.Size = new Size(257, 50);
            ButtonExit.TabIndex = 5;
            ButtonExit.Text = "Sair";
            ButtonExit.UseVisualStyleBackColor = false;
            ButtonExit.Click += ButtonExit_Click;
            // 
            // ButtonHome
            // 
            ButtonHome.BackColor = Color.FromArgb(64, 64, 64);
            ButtonHome.Dock = DockStyle.Top;
            ButtonHome.FlatStyle = FlatStyle.Flat;
            ButtonHome.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonHome.ForeColor = Color.White;
            ButtonHome.Location = new Point(0, 200);
            ButtonHome.Name = "ButtonHome";
            ButtonHome.Size = new Size(257, 50);
            ButtonHome.TabIndex = 4;
            ButtonHome.Text = "Início";
            ButtonHome.UseVisualStyleBackColor = false;
            ButtonHome.Click += ButtonHome_Click;
            // 
            // ButtonMyAccount
            // 
            ButtonMyAccount.BackColor = Color.FromArgb(64, 64, 64);
            ButtonMyAccount.Dock = DockStyle.Top;
            ButtonMyAccount.FlatStyle = FlatStyle.Flat;
            ButtonMyAccount.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonMyAccount.ForeColor = Color.White;
            ButtonMyAccount.Location = new Point(0, 150);
            ButtonMyAccount.Name = "ButtonMyAccount";
            ButtonMyAccount.Size = new Size(257, 50);
            ButtonMyAccount.TabIndex = 2;
            ButtonMyAccount.Text = "Minha conta";
            ButtonMyAccount.UseVisualStyleBackColor = false;
            ButtonMyAccount.Click += ButtonMyAccount_Click;
            // 
            // ButtonRegisterCustomers
            // 
            ButtonRegisterCustomers.BackColor = Color.FromArgb(64, 64, 64);
            ButtonRegisterCustomers.Dock = DockStyle.Top;
            ButtonRegisterCustomers.FlatStyle = FlatStyle.Flat;
            ButtonRegisterCustomers.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonRegisterCustomers.ForeColor = Color.White;
            ButtonRegisterCustomers.Location = new Point(0, 100);
            ButtonRegisterCustomers.Name = "ButtonRegisterCustomers";
            ButtonRegisterCustomers.Size = new Size(257, 50);
            ButtonRegisterCustomers.TabIndex = 1;
            ButtonRegisterCustomers.Text = "Cadastro de clientes";
            ButtonRegisterCustomers.UseVisualStyleBackColor = false;
            ButtonRegisterCustomers.Click += ButtonRegisterCustomers_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(257, 100);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 11);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 20, 0, 0);
            label1.Size = new Size(246, 57);
            label1.TabIndex = 0;
            label1.Text = "Agendamentos";
            // 
            // panelForm
            // 
            panelForm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelForm.BackColor = Color.Gray;
            panelForm.BackgroundImage = (Image)resources.GetObject("panelForm.BackgroundImage");
            panelForm.BackgroundImageLayout = ImageLayout.Stretch;
            panelForm.BorderStyle = BorderStyle.Fixed3D;
            panelForm.Location = new Point(257, 0);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(989, 559);
            panelForm.TabIndex = 1;
            // 
            // FormAppointments
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1246, 559);
            Controls.Add(panelForm);
            Controls.Add(panelMain);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "FormAppointments";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agendamentos";
            WindowState = FormWindowState.Maximized;
            panelMain.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMain;
        private Panel panel2;
        private Label label1;
        private Button ButtonRegisterCustomers;
        private Button ButtonMyAccount;
        private Panel panelForm;
        private Button ButtonExit;
        private Button ButtonHome;
    }
}