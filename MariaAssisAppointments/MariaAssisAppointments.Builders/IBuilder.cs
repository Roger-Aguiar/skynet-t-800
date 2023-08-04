namespace MariaAssisAppointments.MariaAssisAppointments.Builders
{
    public interface IBuilder
    {
        void Create<Things>(Things thing);
        void Read(FormattableString sql);
        void Read(string sql);
        void Update<Thing>(Thing thing);
        void Delete<Thing>(Thing thing);
    }
}
