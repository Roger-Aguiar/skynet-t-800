#nullable disable
namespace MariaAssisAppointments.MariaAssisAppointments.Forms
{
    public partial class FormCustomers : Form
    {
        private User? CurrentUser { get; set; }
        public List<People> Customers { get; set; } = new();
        private WebScrapper webScrapper = new();
        private List<Pacs> listOfPacs = new();

        private bool update;
        private int index = 0;

        public FormCustomers(User? currentUser)
        {
            CurrentUser = currentUser;
            InitializeComponent();
        }

        #region Private methods

        private People FillPeopleModel() => new()
        {
            Name = TextBox1FullName.Text.ToUpper(),
            Cpf = MaskedTextBoxCpf.Text,
            Birthdate = MaskedTextBoxBirthDate.Text,
            FatherName = TextBoxFather.Text.ToUpper(),
            MotherName = TextBoxMother.Text.ToUpper(),
            PhoneNumber = MaskedTextBoxWhatspp.Text,
            Pac = ComboBoxPacs.Text,
            PaymentStatus = ComboBoxAppointmentStatus.Text,
            Period = ComboBoxPeriod.Text,
            AppointmentStatus = ComboBoxAppointmentStatus.Text,
            UserId = CurrentUser.UserId,
            Code = TextBoxCode.Text
        };

        private void ClearFields()
        {
            TextBox1FullName.Clear();
            MaskedTextBoxCpf.Clear();
            MaskedTextBoxBirthDate.Clear();
            TextBoxFather.Clear();
            TextBoxMother.Clear();
            MaskedTextBoxWhatspp.Clear();
            ComboBoxPacs.Text = "SELECIONE";
            ComboBoxAppointmentStatus.Text = "SELECIONE";
            ComboBoxPeriod.Text = "SELECIONE";
            TextBox1FullName.Focus();
            ComboBoxCustomers.Items.Clear();
        }

        private void FillFields()
        {
            if (Customers.Count > 0)
            {
                TextBox1FullName.Text = Customers[index].Name;
                MaskedTextBoxCpf.Text = Customers[index].Cpf;
                MaskedTextBoxBirthDate.Text = Customers[index].Birthdate;
                TextBoxFather.Text = Customers[index].FatherName;
                TextBoxMother.Text = Customers[index].MotherName;
                MaskedTextBoxWhatspp.Text = Customers[index].PhoneNumber;
                ComboBoxPacs.Text = Customers[index].Pac;
                ComboBoxAppointmentStatus.Text = Customers[index].AppointmentStatus;
                ComboBoxPeriod.Text = Customers[index].Period;
                TextBoxCode.Text = Customers[index].Code;
            }
        }

        private void FillComboBoxCustomers()
        {
            if (Customers.Count > 0)
                foreach (var item in Customers)
                    ComboBoxCustomers.Items.Add(item.Name);
        }

        private void LoadResources()
        {
            index = 0;
            update = true;
            Customers.Clear();
            ComboBoxCustomers.Items.Clear();
            CustomerService customerService = new(CurrentUser, FillPeopleModel());
            customerService.Read();
            var customerQuery = from customers in customerService.Customers where customers.UserId == CurrentUser.UserId select customers;
            Customers = customerQuery.ToList();
            FillComboBoxCustomers();
            FillFields();
            Label1NumberOfCustomers.Text = $"Número de clientes para agendar: {Customers.Count}";
        }

        private void GetAvailablePacsWeb() => listOfPacs = webScrapper.GetAvailablePacs("https://amcin.e-instituto.com.br/Vsoft.iDSPS.Agendamento/Agendamento");

        #endregion

        private void ButtonMakeAppointments_Click(object sender, EventArgs e)
        {
            GetAvailablePacsWeb();
            webScrapper.MakeAppointment(listOfPacs, Customers);
        }

        private void ButtonRegisterCustomers_Click(object sender, EventArgs e)
        {
            CustomerService customerService = new(CurrentUser, FillPeopleModel());
            if (update == false)
                customerService.Create();
            else
                customerService.Update();

            LoadResources();
        }

        private void ButtonNew_Click(object sender, EventArgs e)
        {
            update = false;
            TextBoxCode.Text = Guid.NewGuid().ToString();
            ClearFields();
        }

        private void FormCustomers_Load(object sender, EventArgs e)
        {
            LoadResources();
        }

        private void ComboBoxCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxCustomers.Items.Count > 0)
            {
                index = ComboBoxCustomers.SelectedIndex < 0 ? 0 : ComboBoxCustomers.SelectedIndex;
                FillFields();
            }
        }

        private void ButtonFirst_Click(object sender, EventArgs e)
        {
            index = 0;
            FillFields();
        }

        private void ButtonPrevious_Click(object sender, EventArgs e)
        {
            index = index > 0 ? index - 1 : 0;
            FillFields();
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            index = index < Customers.Count - 1 ? index + 1 : Customers.Count - 1;
            FillFields();
        }

        private void ButtonLast_Click(object sender, EventArgs e)
        {
            index = Customers.Count - 1;
            FillFields();
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            var messageBox = MessageBox.Show("Tem certeza que deseja excluir este cliente?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (messageBox == DialogResult.Yes)
            {
                CustomerService customerService = new(CurrentUser, FillPeopleModel());
                customerService.Delete();
                LoadResources();
            }
        }

        private void ButtonSearchAppointments_Click(object sender, EventArgs e) => webScrapper.SearchAppointment(Customers);

        private void ButtonCheckData_Click(object sender, EventArgs e)
        {
            webScrapper.CheckData(FillPeopleModel());
        }
    }
}
