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
        public List<Patient> Patients { get; set; }
        public List<Doctor> Doctors { get; set; }
        public List<Nurse> Nurses { get; set; }
        public int HospitalContactPersonID { get; set; }
        public HospitalContactPerson HospitalContactPerson { get; set; }
    }
}