namespace SkyLightWeb.Models
{
    public class Vital
    {
        public string VitalID { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public double BMI { get; set; }// Calculated
        public double Temperature { get; set; }
        public double Pulse { get; set; }
        public double RespiratoryRate { get; set; }
        public double BloodPressure { get; set; }
        public double BloodOxygenSaturation { get; set; }

        public int HospitalID { get; set; }
        public Hospital Hospital { get; set; }
        public string PatientID { get; set; }
        public Patient Patient { get; set; }
    }
}