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
    public class PatientsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public PatientsController(ApplicationDbContext context)
        {
            _context = context;
            if (_context.Patients.Count() == 0)
            {
                _context.Patients.Add(new Patient { PatientID = Guid.NewGuid().ToString(), PatientName = "Samuel Kingsley", PatientAddress = "2 Jigawa Street, Ikorodu Lagos",HospitalID="25cbde11-4d10-4dee-b872-f732d3744ab3" });
                _context.SaveChanges();
            }
        }

        [HttpGet]
        public ActionResult<List<Patient>> GetAll()
        {
            return _context.Patients.ToList();
        }

        [HttpGet("{id}", Name = "GetPatient")]
        public ActionResult<Patient> GetById(long id)
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