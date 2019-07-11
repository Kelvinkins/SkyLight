namespace SkyLightWeb.Models
{
    public class Condition
    {
        public string ConditionID { get; set; }
        public string ConditionName { get; set; }
        public string Status { get; set; } //ACTIVE, INACTIVE, HISTORY_OF
        public string VisitID { get; set; }
        public Visit Visit { get; set; }
        public int HospitalID { get; set; }
        public Hospital Hospital { get; set; }
    }
}