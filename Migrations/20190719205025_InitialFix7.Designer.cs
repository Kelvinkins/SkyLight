﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SkyLightWeb.Data;

namespace SkyLightWeb.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190719205025_InitialFix7")]
    partial class InitialFix7
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("SkyLightWeb.Models.Allergy", b =>
                {
                    b.Property<string>("AllergyID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AllergyName");

                    b.Property<string>("Comment");

                    b.Property<int>("HospitalID");

                    b.Property<string>("HospitalId");

                    b.Property<DateTime>("LastUpdate");

                    b.Property<string>("Reaction");

                    b.Property<string>("VisitID");

                    b.HasKey("AllergyID");

                    b.HasIndex("HospitalId");

                    b.HasIndex("VisitID");

                    b.ToTable("Allergies");
                });

            modelBuilder.Entity("SkyLightWeb.Models.Appointment", b =>
                {
                    b.Property<string>("AppointmentID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Date");

                    b.Property<int>("HospitalID");

                    b.Property<string>("HospitalId");

                    b.Property<string>("Provider");

                    b.Property<string>("ServiceType");

                    b.Property<string>("Status");

                    b.Property<string>("VisitID");

                    b.HasKey("AppointmentID");

                    b.HasIndex("HospitalId");

                    b.HasIndex("VisitID");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("SkyLightWeb.Models.Attachment", b =>
                {
                    b.Property<string>("AttachmentID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AttachmentCaption");

                    b.Property<DateTime>("Date");

                    b.Property<string>("FileUrl");

                    b.Property<int>("HospitalID");

                    b.Property<string>("HospitalId");

                    b.Property<string>("VisitID");

                    b.HasKey("AttachmentID");

                    b.HasIndex("HospitalId");

                    b.HasIndex("VisitID");

                    b.ToTable("Attachments");
                });

            modelBuilder.Entity("SkyLightWeb.Models.Condition", b =>
                {
                    b.Property<string>("ConditionID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConditionName");

                    b.Property<int>("HospitalID");

                    b.Property<string>("HospitalId");

                    b.Property<string>("Status");

                    b.Property<string>("VisitID");

                    b.HasKey("ConditionID");

                    b.HasIndex("HospitalId");

                    b.HasIndex("VisitID");

                    b.ToTable("Conditions");
                });

            modelBuilder.Entity("SkyLightWeb.Models.Diagnosis", b =>
                {
                    b.Property<string>("DiagnosisID")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Confirmed");

                    b.Property<string>("DiagnosisName");

                    b.Property<int>("HospitalID");

                    b.Property<string>("HospitalId");

                    b.Property<bool>("Primary");

                    b.Property<string>("VisitID");

                    b.HasKey("DiagnosisID");

                    b.HasIndex("HospitalId");

                    b.HasIndex("VisitID");

                    b.ToTable("Diagnoses");
                });

            modelBuilder.Entity("SkyLightWeb.Models.Doctor", b =>
                {
                    b.Property<string>("DoctorID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DoctorAddress");

                    b.Property<string>("DoctorName");

                    b.Property<int>("HospitalID");

                    b.Property<string>("HospitalId");

                    b.HasKey("DoctorID");

                    b.HasIndex("HospitalId");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("SkyLightWeb.Models.Hospital", b =>
                {
                    b.Property<string>("HospitalId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("HospitalAddress");

                    b.Property<string>("HospitalCode");

                    b.Property<int>("HospitalContactPersonID");

                    b.Property<string>("HospitalContactPersonID1");

                    b.Property<string>("HospitalName");

                    b.Property<double>("Latitude");

                    b.Property<double>("Longitude");

                    b.Property<DateTime>("RegistrationDate");

                    b.HasKey("HospitalId");

                    b.HasIndex("HospitalContactPersonID1");

                    b.ToTable("Hospitals");
                });

            modelBuilder.Entity("SkyLightWeb.Models.HospitalContactPerson", b =>
                {
                    b.Property<string>("HospitalContactPersonID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("PhoneNumber");

                    b.HasKey("HospitalContactPersonID");

                    b.ToTable("HospitalContactPersons");
                });

            modelBuilder.Entity("SkyLightWeb.Models.Location", b =>
                {
                    b.Property<string>("LocationID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("HospitalID");

                    b.Property<string>("HospitalId");

                    b.Property<string>("LocationName");

                    b.HasKey("LocationID");

                    b.HasIndex("HospitalId");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("SkyLightWeb.Models.Nurse", b =>
                {
                    b.Property<string>("NurseID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("HospitalID");

                    b.Property<string>("HospitalId");

                    b.Property<string>("NurseAddress");

                    b.Property<string>("NurseName");

                    b.HasKey("NurseID");

                    b.HasIndex("HospitalId");

                    b.ToTable("Nurses");
                });

            modelBuilder.Entity("SkyLightWeb.Models.Patient", b =>
                {
                    b.Property<string>("PatientID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CauseOfDeath");

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<DateTime>("DateDeleted");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<DateTime>("DateOfDeath");

                    b.Property<bool>("Deceased");

                    b.Property<bool>("Deleted");

                    b.Property<string>("DeletedBy");

                    b.Property<string>("FamilyName");

                    b.Property<string>("Gender");

                    b.Property<string>("HospitalID");

                    b.Property<string>("MaritalStatus");

                    b.Property<string>("MarkedBy");

                    b.Property<string>("MiddleName");

                    b.Property<string>("PatientAddress");

                    b.Property<string>("PatientAddressTwo");

                    b.Property<string>("PatientName");

                    b.Property<string>("PatientType");

                    b.Property<string>("PhoneNumber");

                    b.Property<string>("PostalCode");

                    b.Property<string>("Reason");

                    b.Property<string>("State");

                    b.Property<bool>("UnIdentified");

                    b.HasKey("PatientID");

                    b.HasIndex("HospitalID");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("SkyLightWeb.Models.Relative", b =>
                {
                    b.Property<string>("RelativeID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("HospitalID");

                    b.Property<string>("HospitalId");

                    b.Property<int>("PatientID");

                    b.Property<string>("PatientID1");

                    b.Property<string>("RelationshipType");

                    b.Property<string>("RelativeAddress");

                    b.Property<string>("RelativeName");

                    b.HasKey("RelativeID");

                    b.HasIndex("HospitalId");

                    b.HasIndex("PatientID1");

                    b.ToTable("Relatives");
                });

            modelBuilder.Entity("SkyLightWeb.Models.Visit", b =>
                {
                    b.Property<string>("VisitID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("By");

                    b.Property<DateTime>("EndDate");

                    b.Property<int>("HospitalID");

                    b.Property<string>("HospitalId");

                    b.Property<string>("LocationID");

                    b.Property<string>("PatientID");

                    b.Property<DateTime>("StartDate");

                    b.Property<string>("VisitNote");

                    b.HasKey("VisitID");

                    b.HasIndex("HospitalId");

                    b.HasIndex("LocationID");

                    b.HasIndex("PatientID");

                    b.ToTable("Visits");
                });

            modelBuilder.Entity("SkyLightWeb.Models.Vital", b =>
                {
                    b.Property<string>("VitalID")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("BMI");

                    b.Property<double>("BloodOxygenSaturation");

                    b.Property<double>("BloodPressure");

                    b.Property<double>("Height");

                    b.Property<int>("HospitalID");

                    b.Property<string>("HospitalId");

                    b.Property<string>("PatientID");

                    b.Property<double>("Pulse");

                    b.Property<double>("RespiratoryRate");

                    b.Property<double>("Temperature");

                    b.Property<double>("Weight");

                    b.HasKey("VitalID");

                    b.HasIndex("HospitalId");

                    b.HasIndex("PatientID");

                    b.ToTable("Vitals");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SkyLightWeb.Models.Allergy", b =>
                {
                    b.HasOne("SkyLightWeb.Models.Hospital", "Hospital")
                        .WithMany("Allergies")
                        .HasForeignKey("HospitalId");

                    b.HasOne("SkyLightWeb.Models.Visit", "Visit")
                        .WithMany("Allergies")
                        .HasForeignKey("VisitID");
                });

            modelBuilder.Entity("SkyLightWeb.Models.Appointment", b =>
                {
                    b.HasOne("SkyLightWeb.Models.Hospital", "Hospital")
                        .WithMany("Appointments")
                        .HasForeignKey("HospitalId");

                    b.HasOne("SkyLightWeb.Models.Visit", "Visit")
                        .WithMany("Appointments")
                        .HasForeignKey("VisitID");
                });

            modelBuilder.Entity("SkyLightWeb.Models.Attachment", b =>
                {
                    b.HasOne("SkyLightWeb.Models.Hospital", "Hospital")
                        .WithMany("Attachments")
                        .HasForeignKey("HospitalId");

                    b.HasOne("SkyLightWeb.Models.Visit", "Visit")
                        .WithMany("Attachments")
                        .HasForeignKey("VisitID");
                });

            modelBuilder.Entity("SkyLightWeb.Models.Condition", b =>
                {
                    b.HasOne("SkyLightWeb.Models.Hospital", "Hospital")
                        .WithMany("Conditions")
                        .HasForeignKey("HospitalId");

                    b.HasOne("SkyLightWeb.Models.Visit", "Visit")
                        .WithMany("Conditions")
                        .HasForeignKey("VisitID");
                });

            modelBuilder.Entity("SkyLightWeb.Models.Diagnosis", b =>
                {
                    b.HasOne("SkyLightWeb.Models.Hospital", "Hospital")
                        .WithMany("Diagnoses")
                        .HasForeignKey("HospitalId");

                    b.HasOne("SkyLightWeb.Models.Visit", "Visit")
                        .WithMany("Diagnoses")
                        .HasForeignKey("VisitID");
                });

            modelBuilder.Entity("SkyLightWeb.Models.Doctor", b =>
                {
                    b.HasOne("SkyLightWeb.Models.Hospital", "Hospital")
                        .WithMany("Doctors")
                        .HasForeignKey("HospitalId");
                });

            modelBuilder.Entity("SkyLightWeb.Models.Hospital", b =>
                {
                    b.HasOne("SkyLightWeb.Models.HospitalContactPerson", "HospitalContactPerson")
                        .WithMany("Hospitals")
                        .HasForeignKey("HospitalContactPersonID1");
                });

            modelBuilder.Entity("SkyLightWeb.Models.Location", b =>
                {
                    b.HasOne("SkyLightWeb.Models.Hospital", "Hospital")
                        .WithMany("Locations")
                        .HasForeignKey("HospitalId");
                });

            modelBuilder.Entity("SkyLightWeb.Models.Nurse", b =>
                {
                    b.HasOne("SkyLightWeb.Models.Hospital", "Hospital")
                        .WithMany("Nurses")
                        .HasForeignKey("HospitalId");
                });

            modelBuilder.Entity("SkyLightWeb.Models.Patient", b =>
                {
                    b.HasOne("SkyLightWeb.Models.Hospital", "Hospital")
                        .WithMany("Patients")
                        .HasForeignKey("HospitalID");
                });

            modelBuilder.Entity("SkyLightWeb.Models.Relative", b =>
                {
                    b.HasOne("SkyLightWeb.Models.Hospital", "Hospital")
                        .WithMany("Relatives")
                        .HasForeignKey("HospitalId");

                    b.HasOne("SkyLightWeb.Models.Patient", "Patient")
                        .WithMany("Relatives")
                        .HasForeignKey("PatientID1");
                });

            modelBuilder.Entity("SkyLightWeb.Models.Visit", b =>
                {
                    b.HasOne("SkyLightWeb.Models.Hospital", "Hospital")
                        .WithMany("Visits")
                        .HasForeignKey("HospitalId");

                    b.HasOne("SkyLightWeb.Models.Location", "Location")
                        .WithMany("Visits")
                        .HasForeignKey("LocationID");

                    b.HasOne("SkyLightWeb.Models.Patient", "Patient")
                        .WithMany("Visits")
                        .HasForeignKey("PatientID");
                });

            modelBuilder.Entity("SkyLightWeb.Models.Vital", b =>
                {
                    b.HasOne("SkyLightWeb.Models.Hospital", "Hospital")
                        .WithMany("Vitals")
                        .HasForeignKey("HospitalId");

                    b.HasOne("SkyLightWeb.Models.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientID");
                });
#pragma warning restore 612, 618
        }
    }
}