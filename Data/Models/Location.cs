using System.Collections.Generic;
namespace SkyLightWeb.Models
{
    public class Location
    {
        public string LocationID { get; set; }
        public string LocationName { get; set; }
        public List<Visit> Visits { get; set; }

        public int HospitalID { get; set; }
        public Hospital Hospital { get; set; }
    }
}