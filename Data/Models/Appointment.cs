namespace SkyLightWeb.Models
{
    public class Appointment
    {
        public string AppointmentID { get; set; }
        public string Date { get; set; }
        public string ServiceType { get; set; }
        public string Provider { get; set; }
        public string Status { get; set; }
        public string VisitID { get; set; }

        public Visit Visit { get; set; }
        public int HospitalID { get; set; }
        public Hospital Hospital { get; set; }
    }
}