namespace MariaAssisAppointments.MariaAssisAppointments.Shared
{
    public class DatabaseContext : DbContext
    {
        public DbSet<People> Customer { get; set; }
        public DbSet<User> User { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseMySQL("server=localhost;database=appointments;user=root;password=983453069");
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseMySQL("server=bafigorerp1bxqafiyd7-mysql.services.clever-cloud.com;database=bafigorerp1bxqafiyd7;user=uvs6j89iushczcc2;password=LyaLoWjC3rh0FbsozBjK");
    }
}
