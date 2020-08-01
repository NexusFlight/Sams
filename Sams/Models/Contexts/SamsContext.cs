
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Sams.Models.Contexts
{
    public class SamsContext : DbContext
    {
        public SamsContext(DbContextOptions<SamsContext> options):base(options)
        {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Students>()
                .HasKey(s => s.StudentGuid);

            modelBuilder.Entity<Convenors>()
                .HasKey(c => c.ConvenorID);

            modelBuilder.Entity<Engagements>()
                .HasKey(e => e.EngagementID);
            
            modelBuilder.Entity<Suggestions>()
                .HasKey(s => s.SuggestionID);

            modelBuilder.Entity<Societys>()
                .HasKey(s => s.SocietyID);

            //Society Convenor Joining Table
            modelBuilder.Entity<SocietyConvenor>()
                .HasKey(sc => new { sc.ConvenorID, sc.SocietyID });

            modelBuilder.Entity<SocietyConvenor>()
                .HasOne(sc => sc.Society)
                .WithMany(s => s.SocietyConvenors)
                .HasForeignKey(sc => sc.SocietyID);

            modelBuilder.Entity<SocietyConvenor>()
                .HasOne(sc => sc.Convenor)
                .WithMany(c => c.SocietyConvenors)
                .HasForeignKey(sc => sc.ConvenorID);

            //Student Engagement Joining Table
            modelBuilder.Entity<StudentEngagement>()
                .HasKey(se => new { se.StudentGuid, se.EngagementID });

            modelBuilder.Entity<StudentEngagement>()
                .HasOne(se => se.Student)
                .WithMany(s => s.StudentEngagements)
                .HasForeignKey(se => se.StudentGuid);

            modelBuilder.Entity<StudentEngagement>()
                .HasOne(se => se.Engagement)
                .WithMany(e => e.StudentEngagements)
                .HasForeignKey(se => se.EngagementID);

            //Student Society Joining Table
            modelBuilder.Entity<StudentSociety>()
                .HasKey(ss => new { ss.StudentGuid, ss.SocietyID });

            modelBuilder.Entity<StudentSociety>()
                .HasOne(se => se.Students)
                .WithMany(s => s.StudentSocieties)
                .HasForeignKey(se => se.StudentGuid);

            modelBuilder.Entity<StudentSociety>()
                .HasOne(se => se.Society)
                .WithMany(s => s.StudentSocieties)
                .HasForeignKey(se => se.SocietyID);

            //Student Suggestion Joining Table
            modelBuilder.Entity<StudentSuggestion>()
                .HasKey(ss => new { ss.StudentGuid, ss.SuggestionID });

            modelBuilder.Entity<StudentSuggestion>()
                .HasOne(ss => ss.Student)
                .WithMany(s => s.StudentSuggestions)
                .HasForeignKey(ss => ss.StudentGuid);

            modelBuilder.Entity<StudentSuggestion>()
                .HasOne(ss => ss.Suggestion)
                .WithMany(s => s.StudentSuggestions)
                .HasForeignKey(ss => ss.SuggestionID);

            //Student Convenor Joining Table
            modelBuilder.Entity<StudentConvenor>()
                .HasKey(sc => new { sc.StudentGuid, sc.ConvenorID });

            modelBuilder.Entity<StudentConvenor>()
                .HasOne(sc => sc.Students)
                .WithMany(s => s.StudentConvenors)
                .HasForeignKey(sc => sc.StudentGuid);

            modelBuilder.Entity<StudentConvenor>()
                .HasOne(sc => sc.Convenor)
                .WithMany(c => c.StudentConvenors)
                .HasForeignKey(sc => sc.ConvenorID);
        } 

        public DbSet<Students> Students { get; set; }
        public DbSet<Societys> Societys { get; set; }

        public DbSet<Engagements> Engagements { get; set; }
        public DbSet<Suggestions> Suggestions { get; set; }
        public DbSet<Convenors> Convenors { get; set; }

    }
}
