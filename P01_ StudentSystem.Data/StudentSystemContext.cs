using Microsoft.EntityFrameworkCore;
using P01_StudentSystem.P01__StudentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.P01__StudentSystem.Data
{
    internal class StudentSystemContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=StudentSystem;Integrated Security=True;TrustServerCertificate=True");

        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Homework> Homeworks { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
                  

        modelBuilder.Entity<Student>()
      .Property(b => b.Name)
      .IsUnicode(true).HasMaxLength(100);

            modelBuilder.Entity<Student>().Property(b => b.PhoneNumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsRequired(false);


            modelBuilder.Entity<Student>()
                .Property(e => e.Birthday)
                .IsRequired(false);


            modelBuilder.Entity<Course>()
                .Property(e => e.CourseId)
                .HasMaxLength(80)
                .IsUnicode(true);

            modelBuilder.Entity<Course>()
                .Property(e => e.Description)
                .IsUnicode(true)
                .IsRequired(false);

            modelBuilder.Entity<Resource>()
                .Property(e =>e.Name)
                .HasMaxLength(50)
                .IsUnicode(true);
            modelBuilder.Entity<Resource>()
                .Property(e => e.url)
                .HasMaxLength(50)
                .IsUnicode(false);

            modelBuilder.Entity<Homework>()
              .Property(e => e.Content)
              .IsUnicode(false).
               HasColumnType("varchar(80)");

            modelBuilder.Entity<StudentCourse>()
            .HasKey(c => new { c.StudentId, c.CourseId });






        }
    }
}
