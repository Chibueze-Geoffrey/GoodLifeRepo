using System.ComponentModel.DataAnnotations.Schema;

namespace GoodLifeHospital.Entities
{
    public class Appointment 
    {
        public int AppointmentId { get; set; }
        [ForeignKey("PatientId")]
        public Patient? patient {  get; set; }
        public int  PatientId { get; set; }
        [ForeignKey("doctorId")]
        public Doctor? doctor { get; set; }
        public int doctorId {  get; set; }
        //[ForeignKey("NurseId")]
        //public Nurse? nurse {  get; set; }
        //public string NurseId { get; set; }

        public DateTime DateVisited {  get; set; }
        public string Reason {  get; set; }

    }
}
