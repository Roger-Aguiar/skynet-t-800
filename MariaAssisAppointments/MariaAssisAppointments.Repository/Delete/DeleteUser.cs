namespace MariaAssisAppointments.MariaAssisAppointments.Repository.Delete
{
    public class DeleteUserRepository
    {
        public static void Delete(User user)
        {
            var databaseContext = new DatabaseContext();
            databaseContext.Remove(user);
            databaseContext.SaveChanges();
        }
    }
}
