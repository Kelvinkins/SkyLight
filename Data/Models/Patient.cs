using System;
using System.Collections.Generic;
namespace SkyLightWeb.Models
{
    public class Patient
    {
        //Demographics
        public string PatientID { get; set; }
        public string PatientName { get; set; }
        public string MiddleName { get; set; }
        public string FamilyName { get; set; }
        public bool UnIdentified { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        //Contact Info
        public string PatientAddress { get; set; }
        public string PatientAddressTwo { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string PhoneNumber { get; set; }
        public List<Relative> Relatives { get; set; }

        //Hospital Detail
        public string HospitalID { get; set; }
        public Hospital Hospital { get; set; }
    }
}