﻿// <auto-generated />
using System;
using Health_Care_Assist_Provider.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Health_Care_Assist_Provider.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200211180111_DateCreated")]
    partial class DateCreated
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Health_Care_Assist_Provider.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<int>("UserType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "00000000-ffff-ffff-ffff-ffffffffffff",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "1e659a3a-61a6-43f7-9319-62e23cf11040",
                            Email = "first.admin@hcap.org",
                            EmailConfirmed = true,
                            FirstName = "First",
                            LastName = "Admin",
                            LockoutEnabled = false,
                            NormalizedEmail = "FIRST.ADMIN@HCAP.ORG",
                            NormalizedUserName = "FIRST.ADMIN@HCAP.ORG",
                            PasswordHash = "AQAAAAEAACcQAAAAEJvOYOWynrnBUb5TgXiLN3ddrtcNUIAOcbquG2aWSv4TA9u6CwpsCSghj/d5UhQPUA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "7f434309-a4d9-48e9-9ebb-8803db794577",
                            StreetAddress = "123 Infinity Way",
                            TwoFactorEnabled = false,
                            UserName = "first.admin@hcap.org",
                            UserType = 1
                        },
                        new
                        {
                            Id = "11100000-ffff-ffff-ffff-ffffffffffff",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "3e518ce4-2c31-4968-814a-fae47f32c44d",
                            Email = "p.patientson@home.net",
                            EmailConfirmed = true,
                            FirstName = "Patient",
                            LastName = "Patientson",
                            LockoutEnabled = false,
                            NormalizedEmail = "P.PATIENTSON@HOME.NET",
                            NormalizedUserName = "P.PATIENTSON@HOME.NET",
                            PasswordHash = "AQAAAAEAACcQAAAAEOToM5yj2Cmx7kS2FdbAaJzE+unOvTsV9ZOavfkuSn7y/8mq0akzY9YvrH38BTovDA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "7f434309-a4d9-48e9-9ebb-8803db794001",
                            StreetAddress = "001 Patient Addr",
                            TwoFactorEnabled = false,
                            UserName = "p.patientson@home.net",
                            UserType = 1
                        },
                        new
                        {
                            Id = "22200000-ffff-ffff-ffff-ffffffffffff",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "e6f2dd92-b15a-4509-a40b-27eccf13db18",
                            Email = "d.doctorson@work.com",
                            EmailConfirmed = true,
                            FirstName = "Doctor",
                            LastName = "Doctorson",
                            LockoutEnabled = false,
                            NormalizedEmail = "D.DOCTORSON@WORK.COM",
                            NormalizedUserName = "D.DOCTORSON@WORK.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEAtomnwo/OsUisnR9jPvL+KDxHBuZTvqIJSlsI27+D6C+LmUHQaF7kOYlCSMFBVtcQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "7f434309-a4d9-48e9-9ebb-8803db794002",
                            StreetAddress = "002 Doctor Addr",
                            TwoFactorEnabled = false,
                            UserName = "d.doctorson@work.com",
                            UserType = 2
                        },
                        new
                        {
                            Id = "33300000-ffff-ffff-ffff-ffffffffffff",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "bcab5cd4-9c62-4948-8eb6-dcdc0d34af73",
                            Email = "s.sponsorson@fund.net",
                            EmailConfirmed = true,
                            FirstName = "Sponsor",
                            LastName = "Sponsorson",
                            LockoutEnabled = false,
                            NormalizedEmail = "S.SPONSORSON@FUND.ORG",
                            NormalizedUserName = "S.SPONSORSON@FUND.ORG",
                            PasswordHash = "AQAAAAEAACcQAAAAEGvr9P+44t1BETUseK6pDHo1X3F+C5KHXkuwxCWFG/qUGkqo0mVHJJmpouPTVlPO9w==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "7f434309-a4d9-48e9-9ebb-8803db794003",
                            StreetAddress = "003 Sponsor Addr",
                            TwoFactorEnabled = false,
                            UserName = "s.sponsorson@fund.org",
                            UserType = 3
                        });
                });

            modelBuilder.Entity("Health_Care_Assist_Provider.Models.Appointment", b =>
                {
                    b.Property<int>("AppointmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Available")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DateAndTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DoctorId")
                        .HasColumnType("int");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.HasKey("AppointmentId");

                    b.HasIndex("DoctorId");

                    b.ToTable("Appointment");
                });

            modelBuilder.Entity("Health_Care_Assist_Provider.Models.Assist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<int?>("AppointmentId")
                        .HasColumnType("int");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.Property<int?>("DiagnosisId")
                        .HasColumnType("int");

                    b.Property<float>("Rating")
                        .HasColumnType("real");

                    b.Property<int?>("SponsorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AppointmentId");

                    b.HasIndex("DiagnosisId");

                    b.HasIndex("SponsorId");

                    b.ToTable("Assist");
                });

            modelBuilder.Entity("Health_Care_Assist_Provider.Models.Diagnosis", b =>
                {
                    b.Property<int>("DiagnosisId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<int?>("PatientId")
                        .HasColumnType("int");

                    b.Property<string>("Specialty")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.HasKey("DiagnosisId");

                    b.HasIndex("PatientId");

                    b.ToTable("Diagnosis");
                });

            modelBuilder.Entity("Health_Care_Assist_Provider.Models.Doctor", b =>
                {
                    b.Property<int>("DoctorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LicenseNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<float>("Rating")
                        .HasColumnType("real");

                    b.Property<string>("Specialty")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DoctorId");

                    b.HasIndex("PersonId");

                    b.ToTable("Doctor");

                    b.HasData(
                        new
                        {
                            DoctorId = 1,
                            LicenseNumber = "validLicenseNumber",
                            PersonId = "22200000-ffff-ffff-ffff-ffffffffffff",
                            Rating = 0f,
                            Specialty = "Dantist"
                        });
                });

            modelBuilder.Entity("Health_Care_Assist_Provider.Models.Patient", b =>
                {
                    b.Property<int>("PatientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("PersonId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("PatientId");

                    b.HasIndex("PersonId");

                    b.ToTable("Patient");

                    b.HasData(
                        new
                        {
                            PatientId = 1,
                            DateOfBirth = new DateTime(2010, 1, 1, 0, 0, 1, 0, DateTimeKind.Local),
                            PersonId = "11100000-ffff-ffff-ffff-ffffffffffff"
                        });
                });

            modelBuilder.Entity("Health_Care_Assist_Provider.Models.Sponsor", b =>
                {
                    b.Property<int>("SponsorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("CurrentDonation")
                        .HasColumnType("real");

                    b.Property<string>("PersonId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("TotalAssists")
                        .HasColumnType("int");

                    b.Property<float>("TotalDonation")
                        .HasColumnType("real");

                    b.HasKey("SponsorId");

                    b.HasIndex("PersonId");

                    b.ToTable("Sponsor");

                    b.HasData(
                        new
                        {
                            SponsorId = 1,
                            CurrentDonation = 0f,
                            PersonId = "33300000-ffff-ffff-ffff-ffffffffffff",
                            TotalAssists = 0,
                            TotalDonation = 0f
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Health_Care_Assist_Provider.Models.Appointment", b =>
                {
                    b.HasOne("Health_Care_Assist_Provider.Models.Doctor", "Doctor")
                        .WithMany("Appointments")
                        .HasForeignKey("DoctorId");
                });

            modelBuilder.Entity("Health_Care_Assist_Provider.Models.Assist", b =>
                {
                    b.HasOne("Health_Care_Assist_Provider.Models.Appointment", "Appointment")
                        .WithMany()
                        .HasForeignKey("AppointmentId");

                    b.HasOne("Health_Care_Assist_Provider.Models.Diagnosis", "Diagnosis")
                        .WithMany()
                        .HasForeignKey("DiagnosisId");

                    b.HasOne("Health_Care_Assist_Provider.Models.Sponsor", "Sponsor")
                        .WithMany("Assists")
                        .HasForeignKey("SponsorId");
                });

            modelBuilder.Entity("Health_Care_Assist_Provider.Models.Diagnosis", b =>
                {
                    b.HasOne("Health_Care_Assist_Provider.Models.Patient", "Patient")
                        .WithMany("Diagnoses")
                        .HasForeignKey("PatientId");
                });

            modelBuilder.Entity("Health_Care_Assist_Provider.Models.Doctor", b =>
                {
                    b.HasOne("Health_Care_Assist_Provider.Models.ApplicationUser", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId");
                });

            modelBuilder.Entity("Health_Care_Assist_Provider.Models.Patient", b =>
                {
                    b.HasOne("Health_Care_Assist_Provider.Models.ApplicationUser", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId");
                });

            modelBuilder.Entity("Health_Care_Assist_Provider.Models.Sponsor", b =>
                {
                    b.HasOne("Health_Care_Assist_Provider.Models.ApplicationUser", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Health_Care_Assist_Provider.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Health_Care_Assist_Provider.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Health_Care_Assist_Provider.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Health_Care_Assist_Provider.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
