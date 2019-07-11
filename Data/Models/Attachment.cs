using System;
namespace SkyLightWeb.Models
{
    public class Attachment
    {
        public string AttachmentID { get; set; }
        public string AttachmentCaption { get; set; }
        public string FileUrl { get; set; }
        public DateTime Date { get; set; }
        public string VisitID { get; set; }
        public Visit Visit { get; set; }
        public int HospitalID { get; set; }
        public Hospital Hospital { get; set; }
    }
}