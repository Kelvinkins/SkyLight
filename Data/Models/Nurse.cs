namespace SkyLightWeb.Models
{
    public class Nurse
    {
        public string NurseID { get; set; }
        public string NurseName { get; set; }
        public string NurseAddress { get; set; }
        public int HospitalID { get; set; }
        public Hospital Hospital { get; set; }
    }
}