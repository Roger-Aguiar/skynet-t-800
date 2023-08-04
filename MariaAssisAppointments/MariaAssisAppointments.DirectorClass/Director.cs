namespace MariaAssisAppointments.MariaAssisAppointments.DirectorClass
{
    public class Director
    {
        private IBuilder? _builder;

        public IBuilder Builder
        {
            set { _builder = value; }
        }

        public void Create<Things>(Things thing)
        {
            _builder?.Create(thing);
        }

        public void Delete<Thing>(Thing thing)
        {
            _builder?.Delete(thing);
        }

        public void Read(FormattableString sql) => _builder?.Read(sql);

        public void Read(string key) => _builder?.Read(key);

        public void Update<Thing>(Thing thing)
        {
            _builder?.Update(thing);
        }
    }
}
