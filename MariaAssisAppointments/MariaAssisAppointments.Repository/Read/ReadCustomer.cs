namespace MariaAssisAppointments.MariaAssisAppointments.Repository.Read
{
    public static class ReadCustomerRepository
    {
        public static List<People> Read(FormattableString sql)
        {
            using var databaseContext = new DatabaseContext();
            return databaseContext.Customer.FromSqlInterpolated(sql).ToList();
        }
    }
}
