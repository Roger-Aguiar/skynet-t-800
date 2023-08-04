namespace MariaAssisAppointments.MariaAssisAppointments.Shared
{
    public static class UserTable
    {
        public static FormattableString Read() => $"SELECT * FROM User;";
    }
}
