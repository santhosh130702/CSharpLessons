using Microsoft.EntityFrameworkCore;
namespace MVCefapp.Models
{
    public class HospitalDbContext:DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            String conString = @"server=200411LTP2830\SQLEXPRESS;database=HospitalDB1;integrated security = true;Encrypt=false";
            options.UseSqlServer(conString);
        }
    }
}
