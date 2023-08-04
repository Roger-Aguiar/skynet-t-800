namespace MariaAssisAppointments.MariaAssisAppointments.Forms
{
    public partial class FormAppointments : Form
    {
        private Form? activeForm;
        private User? CurrentUser { get; set; }
        private bool update;

        public FormAppointments(User currentUser)
        {
            CurrentUser = currentUser;
            update = CurrentUser == null ? false : true;
            InitializeComponent();
        }

        #region Private methods

        private void ShowForm(Form form)
        {
            CloseActiveForm();
            this.activeForm = form;
            form.TopLevel = false;
            panelForm.Controls.Add(this.activeForm);
            form.BringToFront();
            form.Show();
        }

        private void CloseActiveForm() => activeForm?.Close();

        private void ActiveButton(Button activeForm)
        {
            foreach (Control control in panelMain.Controls)
            {
                control.ForeColor = Color.Black;
            }
            activeForm.ForeColor = Color.White;
        }

        #endregion

        private void ButtonRegisterCustomers_Click(object sender, EventArgs e)
        {
            ActiveButton(ButtonRegisterCustomers);
            ShowForm(new FormCustomers(CurrentUser));
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonHome_Click(object sender, EventArgs e)
        {
            ActiveButton(ButtonHome);
            CloseActiveForm();
        }

        private void ButtonMyAccount_Click(object sender, EventArgs e)
        {
            ActiveButton(ButtonMyAccount);
            ShowForm(new FormMyAccount(CurrentUser));
        }
    }
}
