﻿// <auto-generated />
using System;
using CVDatabaseTest.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CVDatabaseTest.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230821064916_InitialMg")]
    partial class InitialMg
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CVDatabaseTest.Data.Cv", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DemoUserId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Linkdin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<string>("Skype")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Summary")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Trainings")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DemoUserId");

                    b.ToTable("Cvs");
                });

            modelBuilder.Entity("CVDatabaseTest.Data.DemoUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DemoUser");
                });

            modelBuilder.Entity("CVDatabaseTest.Data.Education", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CvId")
                        .HasColumnType("int");

                    b.Property<string>("Grade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Level")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PassingYear")
                        .HasColumnType("datetime2");

                    b.Property<string>("University")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CvId");

                    b.ToTable("Education");
                });

            modelBuilder.Entity("CVDatabaseTest.Data.Experience", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Companay")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CvId")
                        .HasColumnType("int");

                    b.Property<DateTime>("JoiningDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ResignationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Responsibilities")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CvId");

                    b.ToTable("Experience");
                });

            modelBuilder.Entity("CVDatabaseTest.Data.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CvId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CvId");

                    b.ToTable("Project");
                });

            modelBuilder.Entity("CVDatabaseTest.Data.Reference", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Compnay")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CvId")
                        .HasColumnType("int");

                    b.Property<string>("Designation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CvId");

                    b.ToTable("Reference");
                });

            modelBuilder.Entity("CVDatabaseTest.Data.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Skill");
                });

            modelBuilder.Entity("CVDatabaseTest.Data.SkillCv", b =>
                {
                    b.Property<int>("CvId")
                        .HasColumnType("int");

                    b.Property<int>("SkillId")
                        .HasColumnType("int");

                    b.HasKey("CvId", "SkillId");

                    b.HasIndex("SkillId");

                    b.ToTable("SkillCv");
                });

            modelBuilder.Entity("CVDatabaseTest.Data.Cv", b =>
                {
                    b.HasOne("CVDatabaseTest.Data.DemoUser", "DemoUser")
                        .WithMany("Cvs")
                        .HasForeignKey("DemoUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DemoUser");
                });

            modelBuilder.Entity("CVDatabaseTest.Data.Education", b =>
                {
                    b.HasOne("CVDatabaseTest.Data.Cv", "Cv")
                        .WithMany("Educations")
                        .HasForeignKey("CvId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cv");
                });

            modelBuilder.Entity("CVDatabaseTest.Data.Experience", b =>
                {
                    b.HasOne("CVDatabaseTest.Data.Cv", "Cv")
                        .WithMany("Experiences")
                        .HasForeignKey("CvId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cv");
                });

            modelBuilder.Entity("CVDatabaseTest.Data.Project", b =>
                {
                    b.HasOne("CVDatabaseTest.Data.Cv", "Cv")
                        .WithMany("Projects")
                        .HasForeignKey("CvId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cv");
                });

            modelBuilder.Entity("CVDatabaseTest.Data.Reference", b =>
                {
                    b.HasOne("CVDatabaseTest.Data.Cv", "Cv")
                        .WithMany("References")
                        .HasForeignKey("CvId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cv");
                });

            modelBuilder.Entity("CVDatabaseTest.Data.SkillCv", b =>
                {
                    b.HasOne("CVDatabaseTest.Data.Cv", "Cv")
                        .WithMany("Skills")
                        .HasForeignKey("CvId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CVDatabaseTest.Data.Skill", "Skill")
                        .WithMany("Cvs")
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cv");

                    b.Navigation("Skill");
                });

            modelBuilder.Entity("CVDatabaseTest.Data.Cv", b =>
                {
                    b.Navigation("Educations");

                    b.Navigation("Experiences");

                    b.Navigation("Projects");

                    b.Navigation("References");

                    b.Navigation("Skills");
                });

            modelBuilder.Entity("CVDatabaseTest.Data.DemoUser", b =>
                {
                    b.Navigation("Cvs");
                });

            modelBuilder.Entity("CVDatabaseTest.Data.Skill", b =>
                {
                    b.Navigation("Cvs");
                });
#pragma warning restore 612, 618
        }
    }
}
