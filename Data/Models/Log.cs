using System;
namespace SkyLightWeb.Models
{
    public class Log
    {
        public string LogID { get; set; }
        public string Location { get; set; }
        public int OperationCode { get; set; }
        public string UserId { get; set; }
        public DateTime LogDate { get; set; }
        public string Extra { get; set; }
        public int HospitalID { get; set; }
        public Hospital Hospital { get; set; }
    }
}