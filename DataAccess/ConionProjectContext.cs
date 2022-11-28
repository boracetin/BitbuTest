using Domain.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ConionProjectContext : DbContext
    {


        public ConionProjectContext()
        {

        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=BORA\BRCTN; Database=ConionProjectDb; Trusted_Connection=SSPI; Encrypt=true; TrustServerCertificate=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Many to many relation between Student and Course
            modelBuilder.Entity<StudentCourse>()
                .HasKey(t => new { t.StudentId, t.CourseId });
            modelBuilder.Entity<StudentCourse>()
                .HasOne(t => t.Student)
                .WithMany(t => t.StudentCourses)
                .HasForeignKey(t => t.StudentId);
            modelBuilder.Entity<StudentCourse>()
                .HasOne(t => t.Course)
                .WithMany(t => t.StudentCourses)
                .HasForeignKey(t => t.CourseId);

            //Many to Many relation between Student and CourseCenter
            modelBuilder.Entity<StudentCourseCenter>()
                .HasKey(t => new { t.StudentId, t.CourseCenterId });
            modelBuilder.Entity<StudentCourseCenter>()
                .HasOne(t => t.Student)
                .WithMany(t => t.StudentCourseCenters)
                .HasForeignKey(t => t.StudentId);
            modelBuilder.Entity<StudentCourseCenter>()
                .HasOne(t => t.CourseCenter)
                .WithMany(t => t.StudentCourseCenters)
                .HasForeignKey(t => t.CourseCenterId);

            ////One to Many relation between Student and CourseCenter
            //modelBuilder.Entity<StudentCourseCenter>()
            //    .HasKey(t => new { t.StudentId, t.CourseCenterId });
            //modelBuilder.Entity<StudentCourseCenter>()
            //    .HasOne(t => t.Student)
            //    .WithMany(t => t.StudentCourseCenters)
            //    .HasForeignKey(t => t.StudentId);
            //modelBuilder.Entity<StudentCourseCenter>()
            //    .HasOne(t => t.CourseCenter)
            //    .WithMany(t => t.StudentCourseCenters)
            //    .HasForeignKey(t => t.CourseCenterId);








        }







        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        public DbSet<CourseCenter> CourseCenters { get; set; }






    }
}
