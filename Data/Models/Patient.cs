namespace SkyLightWeb.Models
{
    public class Patient
    {
        public string PatientID { get; set; }
        public string PatientName { get; set; }
        public string PatientAddress { get; set; }
        public int HospitalID { get; set; }
        public Hospital Hospital { get; set; }
    }
}