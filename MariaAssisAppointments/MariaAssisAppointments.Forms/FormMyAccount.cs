#nullable disable
namespace MariaAssisAppointments.MariaAssisAppointments.Forms
{
    public partial class FormMyAccount : Form
    {
        private User CurrentUser { get; set; }

        public FormMyAccount(User currentUser)
        {
            CurrentUser = currentUser;
            InitializeComponent();
        }

        #region Private methods

        private void LoadResources()
        {
            TextBoxName.Text = CurrentUser.Name;
            TextBoxPassword.Text = CurrentUser.Password;
            TextBoxEmail.Text = CurrentUser.Email;
            TextBoxRegisterDate.Text = CurrentUser.RegisterDate;
        }

        private User FillModel() => new()
        {
            Name = TextBoxName.Text,
            Password = TextBoxPassword.Text,
            Email = TextBoxEmail.Text
        };

        #endregion

        private void FormMyAccount_Load(object sender, EventArgs e)
        {
            LoadResources();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            UserService userService = new(FillModel(), "Dados atualizados com sucesso!");
            userService.Update();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            UserService userService = new(FillModel(), "Conta excluída com sucesso!");
            var question = MessageBox.Show("Tem certeza que deseja excluir sua conta?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (question == DialogResult.Yes)
                userService.Delete();
        }
    }
}
