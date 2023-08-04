namespace MariaAssisAppointments.MariaAssisAppointments.Repository.Update
{
    public static class UpdateUserRepository
    {
        public static void Update(User user)
        {
            var databaseContext = new DatabaseContext();
            var userQuery = databaseContext.User.First(currentUser => currentUser.UserId == user.UserId);

            userQuery.Name = user.Name;
            userQuery.Password = user.Password;
            userQuery.Email = user.Email;
            userQuery.RegisterDate = user.RegisterDate;
            userQuery.LinkPac = user.LinkPac;
            databaseContext.SaveChanges();
        }
    }
}
