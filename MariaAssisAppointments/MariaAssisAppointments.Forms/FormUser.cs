namespace MariaAssisAppointments.MariaAssisAppointments.Forms
{
    public partial class FormUser : Form
    {
        private List<User> users = new();
        private User CurrentUser { get; set; }
        public new string? Name { get; set; }
        public string? Password { get; set; }

        public FormUser(User user)
        {
            CurrentUser = user;
            InitializeComponent();
        }

        #region Private methods
                
        private User FillUserModel() => new()
        {
            Name = TextBoxName.Text,
            Password = TextBoxPassword.Text,
            Email = TextBoxEmail.Text,
            RegisterDate = TextBoxRegisterDate.Text,
        };

        #endregion

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            UserService userService = new(FillUserModel(), "Conta criada com sucesso!");
            userService.Create();
            this.Close();
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            TextBoxRegisterDate.Text = DateTime.Now.ToString("dd/MM/yyyy");            
        }
    }
}
