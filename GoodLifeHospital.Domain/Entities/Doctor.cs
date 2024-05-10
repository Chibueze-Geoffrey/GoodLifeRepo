using GoodLifeHospital.Entities;

namespace GoodLifeHospital.Entities
{
    public class Doctor 
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Specialty { get; set; }
        public Guid LicenseNumber { get; set; }
        public ICollection<Patient> Patients { get; set; } = new List<Patient>();
        public ICollection<Appointment> appointments { get; set; } = new List<Appointment>();
    }
}
