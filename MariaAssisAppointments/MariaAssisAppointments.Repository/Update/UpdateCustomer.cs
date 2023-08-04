namespace MariaAssisAppointments.MariaAssisAppointments.Repository.Update
{
    public static class UpdateCustomerRepository
    {
        public static void Update(People customer)
        {
            var databaseContext = new DatabaseContext();
            var customerQuery = databaseContext.Customer.First(currentCustomer => currentCustomer.Code == customer.Code);

            customerQuery.Name = customer.Name;
            customerQuery.Cpf = customer.Cpf;
            customerQuery.Birthdate = customer.Birthdate;
            customerQuery.FatherName = customer.FatherName;
            customerQuery.MotherName = customer.MotherName;
            customerQuery.PaymentStatus = customer.PaymentStatus;
            customerQuery.PhoneNumber = customer.PhoneNumber;
            customerQuery.Period = customer.Period;
            customerQuery.Pac = customer.Pac;
            customerQuery.AppointmentStatus = customer.AppointmentStatus;
            databaseContext.SaveChanges();
        }
    }
}
