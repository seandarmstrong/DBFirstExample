using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DBFirstExample.DAL
{
    public partial class GrandCircusLmsDatabaseContext : DbContext
    {
        public GrandCircusLmsDatabaseContext()
        {
        }

        public GrandCircusLmsDatabaseContext(DbContextOptions<GrandCircusLmsDatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Courses> Courses { get; set; }
        public virtual DbSet<Enrollments> Enrollments { get; set; }
        public virtual DbSet<InstructorCourse> InstructorCourse { get; set; }
        public virtual DbSet<Instructors> Instructors { get; set; }
        public virtual DbSet<Locations> Locations { get; set; }
        public virtual DbSet<Students> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("data source=LAPTOP-0FFESSLQ\\SQLEXPRESS;Initial Catalog=GrandCircusLmsDatabase;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Courses>(entity =>
            {
                entity.HasIndex(e => e.LocationId);

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.Courses)
                    .HasForeignKey(d => d.LocationId);
            });

            modelBuilder.Entity<Enrollments>(entity =>
            {
                entity.HasIndex(e => e.CourseId);

                entity.HasIndex(e => e.StudentId);

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.Enrollments)
                    .HasForeignKey(d => d.CourseId);

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.Enrollments)
                    .HasForeignKey(d => d.StudentId);
            });

            modelBuilder.Entity<InstructorCourse>(entity =>
            {
                entity.HasIndex(e => e.CourseId);

                entity.HasIndex(e => e.InstructorId);

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.InstructorCourse)
                    .HasForeignKey(d => d.CourseId);

                entity.HasOne(d => d.Instructor)
                    .WithMany(p => p.InstructorCourse)
                    .HasForeignKey(d => d.InstructorId);
            });

            modelBuilder.Entity<Instructors>(entity =>
            {
                entity.Property(e => e.GcidentificationNumbe).HasColumnName("GCIdentificationNumbe");
            });

            modelBuilder.Entity<Students>(entity =>
            {
                entity.Property(e => e.GcidentificationNumbe).HasColumnName("GCIdentificationNumbe");
            });
        }
    }
}
