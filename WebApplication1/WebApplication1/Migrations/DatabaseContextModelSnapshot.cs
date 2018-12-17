﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Models;

namespace WebApplication1.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-preview3-35497")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication1.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Addition")
                        .IsRequired();

                    b.Property<int>("HouseNumber");

                    b.Property<string>("StreetName")
                        .IsRequired();

                    b.Property<string>("ZipCode")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("WebApplication1.Models.ClosedAnswer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Answered");

                    b.Property<int?>("QuestionId");

                    b.Property<string>("_ClosedAnswer")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.ToTable("ClosedAnswer");
                });

            modelBuilder.Entity("WebApplication1.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("WebApplication1.Models.OpenAnswer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Question");

                    b.Property<string>("UserResponse")
                        .IsRequired();

                    b.Property<string>("_OpenAnswer")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("Question")
                        .IsUnique()
                        .HasFilter("[Question] IS NOT NULL");

                    b.ToTable("OpenAnswer");
                });

            modelBuilder.Entity("WebApplication1.Models.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("QustionType");

                    b.Property<int?>("SurveyId");

                    b.Property<string>("_Question")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("SurveyId");

                    b.ToTable("Question");
                });

            modelBuilder.Entity("WebApplication1.Models.Survey", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompanyId");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<DateTime>("EndDate");

                    b.Property<int>("Income");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<DateTime>("StartDate");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Surveys");
                });

            modelBuilder.Entity("WebApplication1.Models.SurveyUser", b =>
                {
                    b.Property<int>("SurveyId");

                    b.Property<int>("UserId");

                    b.HasKey("SurveyId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("SurveyUser");
                });

            modelBuilder.Entity("WebApplication1.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AddressId");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Mail");

                    b.Property<string>("Password");

                    b.Property<int>("PhoneNumber");

                    b.Property<bool>("Sex");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("WebApplication1.Models.ClosedAnswer", b =>
                {
                    b.HasOne("WebApplication1.Models.Question", "Question")
                        .WithMany("ClosedAnswers")
                        .HasForeignKey("QuestionId");
                });

            modelBuilder.Entity("WebApplication1.Models.OpenAnswer", b =>
                {
                    b.HasOne("WebApplication1.Models.Question", "question")
                        .WithOne("OpenAnswer")
                        .HasForeignKey("WebApplication1.Models.OpenAnswer", "Question");
                });

            modelBuilder.Entity("WebApplication1.Models.Question", b =>
                {
                    b.HasOne("WebApplication1.Models.Survey")
                        .WithMany("Questions")
                        .HasForeignKey("SurveyId");
                });

            modelBuilder.Entity("WebApplication1.Models.Survey", b =>
                {
                    b.HasOne("WebApplication1.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebApplication1.Models.SurveyUser", b =>
                {
                    b.HasOne("WebApplication1.Models.Survey", "Survey")
                        .WithMany("SurveyUsers")
                        .HasForeignKey("SurveyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebApplication1.Models.User", "User")
                        .WithMany("SurveyUsers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebApplication1.Models.User", b =>
                {
                    b.HasOne("WebApplication1.Models.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");
                });
#pragma warning restore 612, 618
        }
    }
}
