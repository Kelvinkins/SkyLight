﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SkyLightWeb.Models;

namespace SkyLightWeb.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public string HospitalID { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<Hospital> Hospitals { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Nurse> Nurses { get; set; }
        public DbSet<HospitalContactPerson> HospitalContactPersons { get; set; }
        public DbSet<Vital> Vitals { get; set; }
        public DbSet<Relative> Relatives { get; set; }
        public DbSet<Visit> Visits { get; set; }
        public DbSet<Diagnosis> Diagnoses { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Allergy> Allergies { get; set; }
        public DbSet<Attachment> Attachments { get; set; }
        public DbSet<Condition> Conditions { get; set; }
        public DbSet<Log> Logs { get; set; }



    }
}
