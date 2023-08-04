namespace MariaAssisAppointments.MariaAssisAppointments.Repository.Delete
{
    public static class DeleteCustomerRepository
    {
        public static void Delete(People customer)
        {
            var databaseContext = new DatabaseContext();
            databaseContext.Remove(customer);
            databaseContext.SaveChanges();
        }
    }
}
