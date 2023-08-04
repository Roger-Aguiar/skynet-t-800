#nullable disable
namespace MariaAssisAppointments.MariaAssisAppointments.Service
{
    public class UserService
    {
        private readonly Director directorUser = new();
        private readonly ConcreteUserBuilder userBuilder = new();
        private string Message { get; set; }
        public List<User> Users { get; set; }
        private User User { get; set; }

        public UserService(User user, string message)
        {
            User = user;
            Message = message;
        }

        public User FillUserModel() => new() { Name = User.Name, Password = User.Password, Email = User.Email, RegisterDate = User.RegisterDate };

        public void Create()
        {
            try
            {
                directorUser.Builder = userBuilder;
                directorUser.Create(FillUserModel());
                MessageBox.Show(Message, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Read()
        {
            try
            {
                directorUser.Builder = userBuilder;
                directorUser.Read(UserTable.Read());
                Users = userBuilder.Users;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Update()
        {
            try
            {
                directorUser.Builder = userBuilder;
                directorUser.Read(UserTable.Read());
                Users = userBuilder.Users;
                var userQuery = from user in Users where (user.Name?.Trim() == User.Name?.Trim()) select user;
                var userUpdate = userQuery.FirstOrDefault();
                userUpdate.Name = User.Name;
                userUpdate.Password = User.Password;
                userUpdate.Email = User.Email;
                userUpdate.RegisterDate = DateTime.Now.ToString("dd/MM/yyyy");
                userUpdate.LinkPac = User.LinkPac;
                directorUser.Update(userUpdate);
                MessageBox.Show(Message, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Delete()
        {
            try
            {
                directorUser.Builder = userBuilder;
                directorUser.Read(UserTable.Read());
                Users = userBuilder.Users;
                var userQuery = from user in Users where (user.Name?.Trim() == User.Name?.Trim()) select user;
                var userDelete = userQuery.FirstOrDefault();
                directorUser.Delete(userDelete);
                MessageBox.Show(Message, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        
    }
}
