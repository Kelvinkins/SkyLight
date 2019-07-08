using System.Collections.Generic;
using System;
namespace SkyLightWeb.Models
{
    public class HospitalContactPerson
    {
        public string HospitalContactPersonID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public List<Hospital> Hospitals { get; set; }

    }
}