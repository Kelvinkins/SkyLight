using System;
namespace SkyLightWeb.Models
{
    public class Allergy
    {
        public string AllergyID { get; set; }
        public string AllergyName { get; set; }
        public string Reaction { get; set; }
        public string Comment { get; set; }
        public DateTime LastUpdate { get; set; }
        public string VisitID { get; set; }
        public Visit Visit { get; set; }
        public int HospitalID { get; set; }
        public Hospital Hospital { get; set; }
    }
}