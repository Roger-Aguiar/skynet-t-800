namespace MariaAssisAppointments.MariaAssisAppointments.Models
{
    public class User
    {
        [Required]
        [Key()]
        public int UserId { get; set; }
        public string? Name { get; set; }
        public string? Password { get; set; }
        public List<People>? People { get; set; }
        public string? Email { get; set; }
        public string? RegisterDate { get; set; }
        public string? LinkPac { get; set; }
    }
}
