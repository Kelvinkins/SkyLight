namespace SkyLightWeb.Models
{
    public class Diagnosis
    {
        public string DiagnosisID { get; set; }
        public string DiagnosisName { get; set; }
        public bool Primary { get; set; }
        public bool Confirmed { get; set; }
        public string VisitID { get; set; }

        public Visit Visit { get; set; }
        public int HospitalID { get; set; }

        public Hospital Hospital { get; set; }
    }
}