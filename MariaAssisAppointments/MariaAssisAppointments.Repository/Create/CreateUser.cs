namespace MariaAssisAppointments.MariaAssisAppointments.Repository.Create
{
    public static class CreateUserRepository
    {
        public static void Create(User user)
        {
            var databaseContext = new DatabaseContext();
            databaseContext.Add(user);
            databaseContext.SaveChanges();
        }
    }
}
