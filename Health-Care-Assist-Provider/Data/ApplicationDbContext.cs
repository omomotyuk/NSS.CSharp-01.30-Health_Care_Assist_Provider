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
        //public DbSet<Product> Product { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
            //modelBuilder.Entity<Order>()
            //    .Property(b => b.DateCreated)
            //    .HasDefaultValueSql("GETDATE()");

            ApplicationUser user = new ApplicationUser
            {
                FirstName = "First",
                LastName = "Admin",
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

        }

    }
}
