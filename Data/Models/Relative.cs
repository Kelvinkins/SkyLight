namespace SkyLightWeb.Models
{
    public class Relative
    {
        public string RelativeID { get; set; }
        public string RelativeName { get; set; }
        public string RelativeAddress { get; set; }
        public string RelationshipType { get; set; }
        public int HospitalID { get; set; }
        public Hospital Hospital { get; set; }

        public int PatientID { get; set; }
        public Patient Patient { get; set; }
    }
}