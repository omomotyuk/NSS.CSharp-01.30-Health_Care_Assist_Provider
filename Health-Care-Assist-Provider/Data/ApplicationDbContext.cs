using System;
using System.Collections.Generic;
using System.Text;
using Health_Care_Assist_Provider.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Health_Care_Assist_Provider.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Patient> Patient { get; set; }
        public DbSet<Doctor> Doctor { get; set; }
        public DbSet<Sponsor> Sponsor { get; set; }
        public DbSet<Diagnosis> Diagnosis { get; set; }
        public DbSet<Appointment> Appointment { get; set; }
        public DbSet<Assist> Assist { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
            modelBuilder.Entity<Assist>()
                .Property(b => b.DateCreated)
                .HasDefaultValueSql("GETDATE()");

            ApplicationUser user = new ApplicationUser
            {
                FirstName = "First",
                LastName = "Admin",
                UserType = 1,
                StreetAddress = "123 Infinity Way",
                UserName = "first.admin@hcap.org",
                NormalizedUserName = "FIRST.ADMIN@HCAP.ORG",
                Email = "first.admin@hcap.org",
                NormalizedEmail = "FIRST.ADMIN@HCAP.ORG",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = "7f434309-a4d9-48e9-9ebb-8803db794577",
                Id = "00000000-ffff-ffff-ffff-ffffffffffff"
            };
            var passwordHash = new PasswordHasher<ApplicationUser>();
            user.PasswordHash = passwordHash.HashPassword(user, "QWer-123");
            modelBuilder.Entity<ApplicationUser>().HasData(user);

            ApplicationUser patient = new ApplicationUser
            {
                FirstName = "Patient",
                LastName = "Patientson",
                UserType = 1,
                StreetAddress = "001 Patient Addr",
                UserName = "p.patientson@home.net",
                NormalizedUserName = "P.PATIENTSON@HOME.NET",
                Email = "p.patientson@home.net",
                NormalizedEmail = "P.PATIENTSON@HOME.NET",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = "7f434309-a4d9-48e9-9ebb-8803db794001",
                Id = "11100000-ffff-ffff-ffff-ffffffffffff"
            };
            patient.PasswordHash = passwordHash.HashPassword(patient, "Pat-123-qaz"); //
            modelBuilder.Entity<ApplicationUser>().HasData(patient);

            ApplicationUser doctor = new ApplicationUser
            {
                FirstName = "Doctor",
                LastName = "Doctorson",
                UserType = 2,
                StreetAddress = "002 Doctor Addr",
                UserName = "d.doctorson@work.com",
                NormalizedUserName = "D.DOCTORSON@WORK.COM",
                Email = "d.doctorson@work.com",
                NormalizedEmail = "D.DOCTORSON@WORK.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = "7f434309-a4d9-48e9-9ebb-8803db794002",
                Id = "22200000-ffff-ffff-ffff-ffffffffffff"
            };
            doctor.PasswordHash = passwordHash.HashPassword(doctor, "Doc-123-qaz");
            modelBuilder.Entity<ApplicationUser>().HasData(doctor);

            ApplicationUser sponsor = new ApplicationUser
            {
                FirstName = "Sponsor",
                LastName = "Sponsorson",
                UserType = 3,
                StreetAddress = "003 Sponsor Addr",
                UserName = "s.sponsorson@fund.org",
                NormalizedUserName = "S.SPONSORSON@FUND.ORG",
                Email = "s.sponsorson@fund.net",
                NormalizedEmail = "S.SPONSORSON@FUND.ORG",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = "7f434309-a4d9-48e9-9ebb-8803db794003",
                Id = "33300000-ffff-ffff-ffff-ffffffffffff"
            };
            sponsor.PasswordHash = passwordHash.HashPassword(sponsor, "Spo-123-qaz");
            modelBuilder.Entity<ApplicationUser>().HasData(sponsor);

            // Create some users
            Patient pUser = new Patient
            {
                PatientId = 1,
                PersonId = patient.Id,
                DateOfBirth = new DateTime(2010, 1, 01, 0, 0, 1, DateTimeKind.Local)
            };
            modelBuilder.Entity<Patient>().HasData(pUser);

            Doctor dUser = new Doctor
            {
                DoctorId = 1,
                PersonId = doctor.Id,
                Specialty = "Dantist",
                LicenseNumber = "validLicenseNumber",
                Rating = 0
            };
            modelBuilder.Entity<Doctor>().HasData(dUser);

            Sponsor sUser = new Sponsor
            {
                SponsorId = 1,
                PersonId = sponsor.Id,
                CurrentDonation = 0,
                TotalDonation = 0,
                TotalAssists = 0
            };
            modelBuilder.Entity<Sponsor>().HasData(sUser);
        }
        ////public DbSet<Product> Product { get; set; }

        //public DbSet<Health_Care_Assist_Provider.Models.Patient> Patient { get; set; }
        ////public DbSet<Product> Product { get; set; }

        //public DbSet<Health_Care_Assist_Provider.Models.Doctor> Doctor { get; set; }
        ////public DbSet<Product> Product { get; set; }

        //public DbSet<Health_Care_Assist_Provider.Models.Sponsor> Sponsor { get; set; }
    }
}
