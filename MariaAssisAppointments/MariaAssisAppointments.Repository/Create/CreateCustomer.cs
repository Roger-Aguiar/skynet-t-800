namespace MariaAssisAppointments.MariaAssisAppointments.Repository.Create
{
    public static class CreateCustomerRepository
    {
        public static void Create(People customer)
        {
            var databaseContext = new DatabaseContext();
            databaseContext.Add(customer);
            databaseContext.SaveChanges();
        }
    }
}
