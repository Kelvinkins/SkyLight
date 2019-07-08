using System.Collections.Generic;
namespace SkyLightWeb.Models
{
    public class Hospital
    {
        public string HospitalId { get; set; }
        public string HospitalName { get; set; }
        public string HospitalAddress { get; set; }
        public List<Patient> Patients { get; set; }
        public List<Doctor> Doctors { get; set; }

        public List<Nurse> Nurses { get; set; }
    }
}