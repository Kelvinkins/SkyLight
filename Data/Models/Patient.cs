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
        public string MaritalStatus { get; set; }
        //Contact Info
        public string PatientAddress { get; set; }
        public string PatientAddressTwo { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string PhoneNumber { get; set; }
        public List<Relative> Relatives { get; set; }
        public List<Visit> Visits { get; set; }

        //Danger zone
        public bool Deceased { get; set; }
        public DateTime DateOfDeath { get; set; }
        public string CauseOfDeath { get; set; }
        public string MarkedBy { get; set; }
        public bool Deleted { get; set; }
        public DateTime DateDeleted { get; set; }
        public string Reason { get; set; }
        public string DeletedBy { get; set; }

        //Status
        public string PatientType { get; set; }//In Or Out Patient

        //Hospital Detail
        public string HospitalID { get; set; }
        public Hospital Hospital { get; set; }
    }
}