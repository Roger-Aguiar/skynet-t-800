#nullable disable
namespace MariaAssisAppointments.MariaAssisAppointments.Forms
{
    public partial class FormLogin : Form
    {
        private readonly Director directorUser = new();
        private readonly ConcreteUserBuilder userBuilder = new();
        private List<User> users = new();
        public User? CurrentUser { get; set; }

        public FormLogin()
        {
            FormSplashscreen splashScreen = new();
            splashScreen.Show();
            Thread.Sleep(5000);
            splashScreen.Close();
            InitializeComponent();
        }

        #region Private methods

        private User FillUserModel() => new()
        {
            Name = TextBoxUser.Text,
            Password = TextBoxPassword.Text,
        };

        #endregion

        private void LinkLabelNewUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormUser formUser = new(FillUserModel());
            formUser.Show();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            UserService userService = new(FillUserModel(), "");
            userService.Read();
            users = userService.Users;
            var userQuery = from user in users where user.Name == TextBoxUser.Text select user;
            if (userQuery.FirstOrDefault() != null)
            {
                if(userQuery.FirstOrDefault().Name == TextBoxUser.Text && userQuery.FirstOrDefault().Password == TextBoxPassword.Text) 
                {
                    FormAppointments formAppointments = new(userQuery.FirstOrDefault());
                    formAppointments.Show();
                }
                else
                {
                    MessageBox.Show("Usuário não encontrado, verifique os dados e tente novamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Usuário não encontrado, verifique os dados e tente novamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
