using GoodLifeHospital.Entities;
using Microsoft.EntityFrameworkCore;

namespace GoodLifeHospital.DatabaseContext
{
    public class GoodLifeContext : DbContext
    {
        public DbSet<Doctor> doctors { get; set; }
        public DbSet<Patient> patients { get; set; }
        public DbSet<Appointment> appointments { get; set; }
        public GoodLifeContext(DbContextOptions<GoodLifeContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Doctor>().
                HasData(
               new Doctor()
               {
                    FirstName="Chibueze",
                    LastName="Josh",
                    Id=1,
                    LicenseNumber= Guid.NewGuid(),
                    Specialty="cardioVascular"
               });
            modelBuilder.Entity<Patient>().
               HasData(
              new Patient()
              {
                  PatientId = 112,
                  FirstName = "Chiboy",
                  LastName = "Josh",
                  doctorId= 1,
                 // doctor.Id=1,
                 
              });
            base.OnModelCreating(modelBuilder);
        }
    }
}
