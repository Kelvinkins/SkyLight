using System.Collections.Generic;
using System;
namespace SkyLightWeb.Models
{
    public class Hospital
    {
        public string HospitalId { get; set; }
        public string HospitalCode { get; set; }
        public string HospitalName { get; set; }
        public string HospitalAddress { get; set; }
        public DateTime RegistrationDate { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public bool IsActive { get; set; }

        public List<Patient> Patients { get; set; }
        public List<Doctor> Doctors { get; set; }
        public List<Nurse> Nurses { get; set; }
        public List<Appointment> Appointments { get; set; }
        public List<Condition> Conditions { get; set; }
        public List<Diagnosis> Diagnoses { get; set; }
        public List<Allergy> Allergies { get; set; }
        public List<Attachment> Attachments { get; set; }
        public List<Location> Locations { get; set; }
        public List<Relative> Relatives { get; set; }
        public List<Visit> Visits { get; set; }
        public List<Vital> Vitals { get; set; }

        public string HospitalContactPersonID { get; set; }
        public HospitalContactPerson HospitalContactPerson { get; set; }
    }
}