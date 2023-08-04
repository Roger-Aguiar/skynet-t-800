namespace MariaAssisAppointments.MariaAssisAppointments.Models
{
    public class People
    {
        public int PeopleId { get; set; }
        public string? Name { get; set;}
        public string? Cpf { get; set;}
        public string? Birthdate { get; set; }
        public string? FatherName { get; set;}
        public string? MotherName { get; set; }
        public string? PaymentStatus { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Period { get; set; }
        
        [ForeignKey(nameof(People))]
        public int UserId { get; set; }
        public string? Pac { get; set; }
        public string? AppointmentStatus { get; set; }
        public string? Code { get; set; }
    }
}
