#nullable disable
namespace MariaAssisAppointments.MariaAssisAppointments.Service
{
    public class CustomerService
    {
        private readonly Director directorCustomer = new();
        private readonly ConcreteCustomerBuilder customerBuilder = new();
        private readonly People Customer = new();
        private readonly User CurrentUser = new();
        public List<People> Customers { get; set; }
                
        public CustomerService(User user, People customer) 
        { 
            CurrentUser = user;
            Customer = customer;
        }

        public People FillPeopleModel() => new() 
        { 
            Name = Customer.Name,
            Cpf = Customer.Cpf,
            Birthdate = Customer.Birthdate,
            FatherName = Customer.FatherName,
            MotherName = Customer.MotherName,
            PaymentStatus = Customer.PaymentStatus,
            PhoneNumber = Customer.PhoneNumber,
            Period = Customer.Period,
            Pac = Customer.Pac,
            AppointmentStatus = Customer.AppointmentStatus,
            UserId = CurrentUser.UserId,
            Code = Customer.Code
        };

        public void Create()
        {
            try
            {
                directorCustomer.Builder = customerBuilder;
                directorCustomer.Create(FillPeopleModel());
                MessageBox.Show("Cliente cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Read()
        {
            try
            {
                directorCustomer.Builder = customerBuilder;
                directorCustomer.Read(CustomerTable.Read());
                Customers = customerBuilder.Customers;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
                
        public void Update()
        {
            try
            {
                directorCustomer.Builder = customerBuilder;
                directorCustomer.Read(CustomerTable.Read());
                Customers = customerBuilder.Customers;
                var customerQuery = from customer in Customers where (customer.Code == Customer.Code?.Trim()) && (customer.UserId == CurrentUser.UserId) select customer;
                var customerUpdate = customerQuery.FirstOrDefault();
                customerUpdate.Name = Customer.Name;
                customerUpdate.Cpf = Customer.Cpf;
                customerUpdate.Birthdate = Customer.Birthdate;
                customerUpdate.FatherName = Customer.FatherName;
                customerUpdate.MotherName = Customer.MotherName;
                customerUpdate.PaymentStatus = Customer.PaymentStatus;
                customerUpdate.PhoneNumber = Customer.PhoneNumber;
                customerUpdate.Period = Customer.Period;
                customerUpdate.Pac = Customer.Pac;
                customerUpdate.AppointmentStatus = Customer.AppointmentStatus;
                directorCustomer.Update(customerUpdate);
                MessageBox.Show("Dados atualizados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Delete()
        {
            try
            {
                directorCustomer.Builder = customerBuilder;
                directorCustomer.Read(CustomerTable.Read());
                Customers = customerBuilder.Customers;
                var customerQuery = from customer in Customers where (customer.Code == Customer.Code?.Trim()) && (customer.UserId == CurrentUser.UserId) select customer;
                var customerDelete = customerQuery.FirstOrDefault();
                directorCustomer.Delete(customerDelete);
                MessageBox.Show("Cliente removido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
