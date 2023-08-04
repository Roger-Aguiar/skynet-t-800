namespace MariaAssisAppointments.MariaAssisAppointments.Concrete.Builders
{
    public class ConcreteUserBuilder : IBuilder
    {
        public List<User>? Users { get; set; } = new();
        public void Create<Things>(Things thing) => CreateUserRepository.Create(thing as User);

        public void Delete<Thing>(Thing thing) => DeleteUserRepository.Delete(thing as User);

        public void Read(FormattableString sql) => Users = ReadUserRepository.Read(sql);

        public void Read(string sql)
        {
            throw new NotImplementedException();
        }

        public void Update<Thing>(Thing thing) => UpdateUserRepository.Update(thing as User);
    }
}
