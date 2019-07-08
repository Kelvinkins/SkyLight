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
    public class HospitalsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public HospitalsController(ApplicationDbContext context)
        {
            _context = context;
            if (_context.Hospitals.Count() == 0)
            {
                _context.Hospitals.Add(new Hospital { HospitalId = Guid.NewGuid().ToString(), HospitalName = "Hulia Health Care", HospitalAddress = "2 Jigawa Street, Ikorodu Lagos" });
                _context.SaveChanges();
            }
        }

        [HttpGet]
        public ActionResult<List<Hospital>> GetAll()
        {
            return _context.Hospitals.ToList();
        }

        [HttpGet("{id}", Name = "GetHospital")]
        public ActionResult<Hospital> GetById(long id)
        {
            var item = _context.Hospitals.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return item;
        }
    }
}