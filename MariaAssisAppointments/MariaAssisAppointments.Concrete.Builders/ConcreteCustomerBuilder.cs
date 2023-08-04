namespace MariaAssisAppointments.MariaAssisAppointments.Concrete.Builders
{
    internal class ConcreteCustomerBuilder : IBuilder
    {
        public List<People>? Customers { get; set; } = new();

        public void Create<Things>(Things thing) => CreateCustomerRepository.Create(thing as People);

        public void Delete<Thing>(Thing thing) => DeleteCustomerRepository.Delete(thing as People);

        public void Read(FormattableString sql) => Customers = ReadCustomerRepository.Read(sql);

        public void Read(string sql)
        {
            throw new NotImplementedException();
        }

        public void Update<Thing>(Thing thing) => UpdateCustomerRepository.Update(thing as People);
    }
}
