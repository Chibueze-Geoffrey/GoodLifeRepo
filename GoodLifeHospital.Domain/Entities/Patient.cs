using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoodLifeHospital.Entities
{
    public class Patient 
    {
        [Key]
        public int PatientId {  get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [ForeignKey("doctorId")]
        public int doctorId { get; set; }
        public Doctor? doctor { get; set; } = default!;
        // public DateOnly DateOfBirth { get; set; }
        //public int PhoneNumber { get; set; }
        //public ICollection<Doctor> doctors { get; set; } = new List<Doctor>();
    }
}
