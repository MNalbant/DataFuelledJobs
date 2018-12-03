using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SurveyUser>()
                .HasKey(su => new { su.SurveyId, su.UserId });

            modelBuilder.Entity<SurveyUser>()
                .HasOne(su => su.Survey)
                .WithMany(p => p.SurveyUsers)
                .HasForeignKey(su => su.SurveyId);

            modelBuilder.Entity<SurveyUser>()
                .HasOne(su => su.User)
                .WithMany(c => c.SurveyUsers)
                .HasForeignKey(su => su.UserId);
        }


        public DbSet<Survey> Surveys { get; set; }

        public DbSet<WebApplication1.Models.Address> Address { get; set; }

        public DbSet<WebApplication1.Models.Company> Company { get; set; }

        public DbSet<WebApplication1.Models.User> User { get; set; }

        public DbSet<WebApplication1.Models.SurveyUser> SurveyUser { get; set; }
    }
}
