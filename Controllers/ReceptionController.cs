using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using SkyLightWeb.Data;
using SkyLightWeb.Models;
using System;
namespace SkyLightWeb.Controllers
{
   
    [Route("api/[controller]")]
    [ApiController]
    public class ReceptionController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public ReceptionController(ApplicationDbContext context)
        {
            _context = context;
            if (_context.Patients.Count() == 0)
            {
                _context.Patients.Add(new Patient { PatientID = Guid.NewGuid().ToString(), PatientName = "Samuel Kingsley", PatientAddress = "2 Jigawa Street, Ikorodu Lagos",HospitalID="8989238429348239hdiho834234" });
                _context.SaveChanges();
            }
        }

        [HttpGet]
        public ActionResult<List<Patient>> GetPatients(string HospitalID)
        {
            return _context.Patients.Where(h=>h.HospitalID==HospitalID).ToList();
        }

        [HttpGet("{id}", Name = "GetPatient1")]
        public ActionResult<Patient> GetById(string id)
        {
            var item = _context.Patients.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return item;
        }
    }
}