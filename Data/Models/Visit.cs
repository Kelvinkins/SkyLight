using System;
using SkyLightWeb.Models;
using System.Collections.Generic;
namespace SkyLightWeb.Models
{
    public class Visit
    {
        public string VisitID { get; set; }
        public string VisitNote { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string By { get; set; }
        public string LocationID { get; set; }
        public Location Location { get; set; }
        public string PatientID { get; set; }
        public Patient Patient { get; set; }
        public List<Diagnosis> Diagnoses { get; set; }
        public List<Appointment> Appointments { get; set; }


        public int HospitalID { get; set; }
        public Hospital Hospital { get; set; }

    }
}