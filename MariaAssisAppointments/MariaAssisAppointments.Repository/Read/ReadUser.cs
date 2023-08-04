namespace MariaAssisAppointments.MariaAssisAppointments.Repository.Read
{
    public static class ReadUserRepository
    {
        public static List<User> Read(FormattableString sql)
        {
            using var databaseContext = new DatabaseContext();
            return databaseContext.User.FromSqlInterpolated(sql).ToList();
        }
    }
}
