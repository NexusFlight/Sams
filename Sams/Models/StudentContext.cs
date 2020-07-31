
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Sams.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options):base(options)
        {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasOne(b => b.ContactDetails)
                .WithOne(i => i.Student);

            modelBuilder.Entity<Student>()
                .HasOne(b => b.ContactPreferences)
                .WithOne(i => i.Student);

            modelBuilder.Entity<ContactDetails>()
                .HasKey(b => b.StudentID);

            modelBuilder.Entity<ContactPreferences>()
                .HasKey(b => b.StudentID);

            modelBuilder.Entity<ContactDetails>()
                .HasOne(b => b.Address)
                .WithOne(i => i.ContactDetails)
                .HasForeignKey<Address>(i => i.StudentID);

            modelBuilder.Entity<Address>()
                .HasKey(b => b.StudentID);
        } 

        public DbSet<Student> Students { get; set; }
    }
}
