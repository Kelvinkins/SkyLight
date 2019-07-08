namespace SkyLightWeb.Models
{
    public class Doctor
    {
        public string DoctorID { get; set; }
        public string DoctorName { get; set; }
        public string DoctorAddress { get; set; }
        public int HospitalID { get; set; }
        public Hospital Hospital { get; set; }
    }
}