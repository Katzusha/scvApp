﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using scvApp.dbcontext;

#nullable disable

namespace scvApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("scvApp.Models.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("SchoolId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("isMasterAdmin")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("scvApp.Models.Date", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("MaxNumberOfStudents")
                        .HasColumnType("INTEGER");

                    b.Property<TimeOnly>("Start")
                        .HasColumnType("TEXT");

                    b.Property<DateOnly>("Term")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Dates");
                });

            modelBuilder.Entity("scvApp.Models.School", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Schools");
                });

            modelBuilder.Entity("scvApp.Models.SchoolSubmit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("SchoolId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SubmitId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("SchoolSubmits");
                });

            modelBuilder.Entity("scvApp.Models.Submit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateOnly>("Birth")
                        .HasColumnType("TEXT");

                    b.Property<TimeOnly>("Break")
                        .HasColumnType("TEXT");

                    b.Property<string>("Class")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("Date")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<TimeOnly>("End")
                        .HasColumnType("TEXT");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("NumberOfStudents")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SchoolTitle")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<TimeOnly>("Start")
                        .HasColumnType("TEXT");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("isConfirmed")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Submits");
                });

            modelBuilder.Entity("scvApp.Models.SubmitTeacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("SchoolId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SubmitId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TeacherId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("SubmitTeachers");
                });

            modelBuilder.Entity("scvApp.Models.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PhonrNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("isGuide")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Teachers");
                });
#pragma warning restore 612, 618
        }
    }
}
