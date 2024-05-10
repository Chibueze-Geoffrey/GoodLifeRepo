using GoodLifeHospital.Dtos;

namespace GoodLifeHospital.Dtos
{
    public class DoctorDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Specialty { get; set; }
        public Guid LicenseNumber { get; set; } = Guid.NewGuid();
        public ICollection<PatientDto> Patients { get; set; } = new List<PatientDto>();
        public ICollection<AppointmentDto> appointments { get; set; }= new List<AppointmentDto>();
        public int NumberOfAppointment
        {
            get
            {
                return appointments.Count;
            }
        }
        public int NumberOfPatient
        {
            get
            {
                return Patients.Count;
            }
        }
    }
}
