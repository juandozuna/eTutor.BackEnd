﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using eTutor.Persistence;

namespace eTutor.Persistence.Migrations
{
    [DbContext(typeof(ETutorContext))]
    [Migration("20200104213352_addedCancelerUserToMeetings")]
    partial class addedCancelerUserToMeetings
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("eTutor.Core.Models.ChangePassword", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("ChangeRequestId");

                    b.Property<string>("ChangeToken");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<DateTime>("ExpirationDate");

                    b.Property<bool>("IsUsed");

                    b.Property<DateTime>("UpdatedDate");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("ChangePasswordRequests");
                });

            modelBuilder.Entity("eTutor.Core.Models.Device", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("FcmToken");

                    b.Property<string>("Platform");

                    b.Property<DateTime>("UpdatedDate");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("FcmToken");

                    b.HasIndex("UserId");

                    b.ToTable("Devices");
                });

            modelBuilder.Entity("eTutor.Core.Models.EmailValidation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedDate");

                    b.Property<DateTime>("UpdatedDate");

                    b.Property<int>("UserId");

                    b.Property<Guid>("ValidationToken");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("EmailValidations");
                });

            modelBuilder.Entity("eTutor.Core.Models.Invoice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Amount");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int>("MeetingId");

                    b.Property<DateTime>("UpdatedDate");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("MeetingId");

                    b.HasIndex("UserId");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("eTutor.Core.Models.Meeting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CancelerUserId");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<DateTime>("EndDateTime");

                    b.Property<int?>("ParentAuthorizationId");

                    b.Property<DateTime>("RealStartedDateTime");

                    b.Property<DateTime>("StartDateTime");

                    b.Property<int>("Status");

                    b.Property<int>("StudentId");

                    b.Property<int>("SubjectId");

                    b.Property<int>("TutorId");

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("Id");

                    b.HasIndex("CancelerUserId");

                    b.HasIndex("ParentAuthorizationId");

                    b.HasIndex("StudentId");

                    b.HasIndex("SubjectId");

                    b.HasIndex("TutorId");

                    b.ToTable("Meetings");
                });

            modelBuilder.Entity("eTutor.Core.Models.ParentAuthorization", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("AuthorizationDate");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int?>("ParentId");

                    b.Property<string>("Reason");

                    b.Property<int>("Status");

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("ParentAuthorizations");
                });

            modelBuilder.Entity("eTutor.Core.Models.ParentStudent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int>("ParentId");

                    b.Property<int>("Relationship");

                    b.Property<int>("StudentId");

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.HasIndex("StudentId");

                    b.ToTable("ParentStudents");
                });

            modelBuilder.Entity("eTutor.Core.Models.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int>("InvoiceId");

                    b.Property<double>("PayedAmount");

                    b.Property<DateTime>("UpdatedDate");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("InvoiceId");

                    b.HasIndex("UserId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("eTutor.Core.Models.Rating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Calification");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int>("MeetingId");

                    b.Property<DateTime>("UpdatedDate");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("MeetingId");

                    b.HasIndex("UserId");

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("eTutor.Core.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ConcurrencyStamp = "6d487de9-b0b6-4eb6-b249-71bec603ebc1",
                            CreatedDate = new DateTime(2019, 11, 2, 12, 12, 22, 916, DateTimeKind.Local).AddTicks(8769),
                            Name = "admin",
                            NormalizedName = "admin",
                            UpdatedDate = new DateTime(2019, 11, 2, 12, 12, 22, 916, DateTimeKind.Local).AddTicks(8769)
                        },
                        new
                        {
                            Id = 2,
                            ConcurrencyStamp = "674518cc-a2be-4265-9443-9cb93b1f11d1",
                            CreatedDate = new DateTime(2019, 11, 2, 12, 12, 22, 916, DateTimeKind.Local).AddTicks(8769),
                            Name = "tutor",
                            NormalizedName = "tutor",
                            UpdatedDate = new DateTime(2019, 11, 2, 12, 12, 22, 916, DateTimeKind.Local).AddTicks(8769)
                        },
                        new
                        {
                            Id = 3,
                            ConcurrencyStamp = "f9b2499a-5352-439a-af1f-4b84f0666014",
                            CreatedDate = new DateTime(2019, 11, 2, 12, 12, 22, 916, DateTimeKind.Local).AddTicks(8769),
                            Name = "student",
                            NormalizedName = "student",
                            UpdatedDate = new DateTime(2019, 11, 2, 12, 12, 22, 916, DateTimeKind.Local).AddTicks(8769)
                        },
                        new
                        {
                            Id = 4,
                            ConcurrencyStamp = "f81396ef-2898-4c6a-accf-7194c240f8b7",
                            CreatedDate = new DateTime(2019, 11, 2, 12, 12, 22, 916, DateTimeKind.Local).AddTicks(8769),
                            Name = "parent",
                            NormalizedName = "parent",
                            UpdatedDate = new DateTime(2019, 11, 2, 12, 12, 22, 916, DateTimeKind.Local).AddTicks(8769)
                        });
                });

            modelBuilder.Entity("eTutor.Core.Models.RoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("RoleId");

                    b.Property<int?>("RoleId1");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("RoleId1");

                    b.ToTable("RoleClaims");
                });

            modelBuilder.Entity("eTutor.Core.Models.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("Id");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("eTutor.Core.Models.TopicInterest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int>("StudentId");

                    b.Property<int?>("SubjectId");

                    b.Property<int>("TopicId");

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.HasIndex("SubjectId");

                    b.ToTable("TopicInterests");
                });

            modelBuilder.Entity("eTutor.Core.Models.TutorSubject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int>("SubjectId");

                    b.Property<int>("TutorId");

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("Id");

                    b.HasIndex("SubjectId");

                    b.HasIndex("TutorId");

                    b.ToTable("TutorSubjects");
                });

            modelBuilder.Entity("eTutor.Core.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AboutMe");

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("Address");

                    b.Property<DateTime>("BirthDate");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FileReference");

                    b.Property<int>("Gender");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsEmailValidated");

                    b.Property<bool>("IsTemporaryPassword");

                    b.Property<string>("LastName");

                    b.Property<float?>("Latitude");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<float?>("Longitude");

                    b.Property<string>("Name");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PersonalId");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("ProfileImageUrl");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<DateTime>("UpdatedDate");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.HasIndex("PersonalId")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("eTutor.Core.Models.UserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<DateTime>("UpdatedDate");

                    b.Property<int>("UserId");

                    b.Property<int?>("UserId1");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.HasIndex("UserId1");

                    b.ToTable("UserClaims");
                });

            modelBuilder.Entity("eTutor.Core.Models.UserLogin", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ProviderDisplayName");

                    b.Property<DateTime>("UpdatedDate");

                    b.Property<int>("UserId");

                    b.Property<int?>("UserId1");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasAlternateKey("Id");

                    b.HasIndex("UserId");

                    b.HasIndex("UserId1");

                    b.ToTable("UserLogins");
                });

            modelBuilder.Entity("eTutor.Core.Models.UserRole", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<int>("RoleId");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("UserId", "RoleId");

                    b.HasAlternateKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("eTutor.Core.Models.UserToken", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("UpdatedDate");

                    b.Property<int?>("UserId1");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.HasAlternateKey("Id");

                    b.HasIndex("UserId1");

                    b.ToTable("UserTokens");
                });

            modelBuilder.Entity("eTutor.Core.Models.ChangePassword", b =>
                {
                    b.HasOne("eTutor.Core.Models.User", "User")
                        .WithMany("ChangeRequests")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("eTutor.Core.Models.Device", b =>
                {
                    b.HasOne("eTutor.Core.Models.User", "User")
                        .WithMany("Devices")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("eTutor.Core.Models.EmailValidation", b =>
                {
                    b.HasOne("eTutor.Core.Models.User", "User")
                        .WithOne("EmailValidation")
                        .HasForeignKey("eTutor.Core.Models.EmailValidation", "UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("eTutor.Core.Models.Invoice", b =>
                {
                    b.HasOne("eTutor.Core.Models.Meeting", "Meeting")
                        .WithMany("Invoices")
                        .HasForeignKey("MeetingId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("eTutor.Core.Models.User", "User")
                        .WithMany("Invoices")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("eTutor.Core.Models.Meeting", b =>
                {
                    b.HasOne("eTutor.Core.Models.User", "CancelerUser")
                        .WithMany()
                        .HasForeignKey("CancelerUserId");

                    b.HasOne("eTutor.Core.Models.ParentAuthorization", "ParentAuthorization")
                        .WithMany("Meetings")
                        .HasForeignKey("ParentAuthorizationId");

                    b.HasOne("eTutor.Core.Models.User", "Student")
                        .WithMany("StudentMeetings")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("eTutor.Core.Models.Subject", "Subject")
                        .WithMany("Meetings")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("eTutor.Core.Models.User", "Tutor")
                        .WithMany("TutorMeetings")
                        .HasForeignKey("TutorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("eTutor.Core.Models.ParentAuthorization", b =>
                {
                    b.HasOne("eTutor.Core.Models.User", "Parent")
                        .WithMany("Autorizations")
                        .HasForeignKey("ParentId");
                });

            modelBuilder.Entity("eTutor.Core.Models.ParentStudent", b =>
                {
                    b.HasOne("eTutor.Core.Models.User", "Parent")
                        .WithMany("Students")
                        .HasForeignKey("ParentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("eTutor.Core.Models.User", "Student")
                        .WithMany("Parents")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("eTutor.Core.Models.Payment", b =>
                {
                    b.HasOne("eTutor.Core.Models.Invoice", "Invoice")
                        .WithMany("Payments")
                        .HasForeignKey("InvoiceId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("eTutor.Core.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("eTutor.Core.Models.Rating", b =>
                {
                    b.HasOne("eTutor.Core.Models.Meeting", "Meeting")
                        .WithMany("Ratings")
                        .HasForeignKey("MeetingId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("eTutor.Core.Models.User", "User")
                        .WithMany("Ratings")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("eTutor.Core.Models.RoleClaim", b =>
                {
                    b.HasOne("eTutor.Core.Models.Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("eTutor.Core.Models.Role")
                        .WithMany("RoleClaims")
                        .HasForeignKey("RoleId1");
                });

            modelBuilder.Entity("eTutor.Core.Models.TopicInterest", b =>
                {
                    b.HasOne("eTutor.Core.Models.User", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("eTutor.Core.Models.Subject", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectId");
                });

            modelBuilder.Entity("eTutor.Core.Models.TutorSubject", b =>
                {
                    b.HasOne("eTutor.Core.Models.Subject", "Subject")
                        .WithMany("Tutors")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("eTutor.Core.Models.User", "Tutor")
                        .WithMany("TutorSubjects")
                        .HasForeignKey("TutorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("eTutor.Core.Models.UserClaim", b =>
                {
                    b.HasOne("eTutor.Core.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("eTutor.Core.Models.User")
                        .WithMany("UserClaims")
                        .HasForeignKey("UserId1");
                });

            modelBuilder.Entity("eTutor.Core.Models.UserLogin", b =>
                {
                    b.HasOne("eTutor.Core.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("eTutor.Core.Models.User")
                        .WithMany("UserLogins")
                        .HasForeignKey("UserId1");
                });

            modelBuilder.Entity("eTutor.Core.Models.UserRole", b =>
                {
                    b.HasOne("eTutor.Core.Models.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("eTutor.Core.Models.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("eTutor.Core.Models.UserToken", b =>
                {
                    b.HasOne("eTutor.Core.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("eTutor.Core.Models.User")
                        .WithMany("UserTokens")
                        .HasForeignKey("UserId1");
                });
#pragma warning restore 612, 618
        }
    }
}
