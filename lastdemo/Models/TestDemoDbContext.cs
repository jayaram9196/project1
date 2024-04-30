using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace lastdemo.Models;

public partial class TestDemoDbContext : DbContext
{
    public TestDemoDbContext()
    {
    }

    public TestDemoDbContext(DbContextOptions<TestDemoDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AdminModel> AdminModels { get; set; }

    public virtual DbSet<AdmissionTable> AdmissionTables { get; set; }

    public virtual DbSet<CourseModel> CourseModels { get; set; }

    public virtual DbSet<InstituteModel> InstituteModels { get; set; }

    public virtual DbSet<Login> Logins { get; set; }

    public virtual DbSet<RatingsModel> RatingsModels { get; set; }

    public virtual DbSet<StudentModel> StudentModels { get; set; }

    public virtual DbSet<UserMode> UserModes { get; set; }

    public virtual DbSet<ProgressModel> ProgressModels {get;set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){

    }
// #warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//         => optionsBuilder.UseSqlServer("Server=DESKTOP-9537ONK\\SQLEXPRESS;database=TestDemoDB;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AdminModel>(entity =>
        {
            entity.HasKey(e => e.AdminId).HasName("PK__AdminMod__719FE488B1AEBB0F");

            entity.ToTable("AdminModel");

            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MobileNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.UserRole)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AdmissionTable>(entity =>
        {
            entity.HasKey(e => e.AdmissionId).HasName("PK__Admissio__C97EEC427D98A701");

            entity.ToTable("AdmissionTable");

            entity.Property(e => e.DateOfJoining).HasColumnType("datetime");
            entity.Property(e => e.EndDate).HasColumnType("datetime");

            entity.HasOne(d => d.Course).WithMany(p => p.AdmissionTables)
                .HasForeignKey(d => d.CourseId)
                .HasConstraintName("FK__Admission__Cours__47DBAE45");

            entity.HasOne(d => d.Institute).WithMany(p => p.AdmissionTables)
                .HasForeignKey(d => d.InstituteId)
                .HasConstraintName("FK__Admission__Insti__48CFD27E");

            entity.HasOne(d => d.Student).WithMany(p => p.AdmissionTables)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK__Admission__Stude__46E78A0C");

            entity.HasOne(d => d.User).WithMany(p => p.AdmissionTables)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__Admission__UserI__49C3F6B7");
        });

        modelBuilder.Entity<CourseModel>(entity =>
        {
            entity.HasKey(e => e.CourseId).HasName("PK__CourseMo__C92D71A76569F47A");

            entity.ToTable("CourseModel");

            entity.Property(e => e.CourseDescription)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.CourseName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.CourseTiming)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Institute).WithMany(p => p.CourseModels)
                .HasForeignKey(d => d.InstituteId)
                .HasConstraintName("FK__CourseMod__Insti__3D5E1FD2");
        });

        modelBuilder.Entity<InstituteModel>(entity =>
        {
            entity.HasKey(e => e.InstituteId).HasName("PK__Institut__09EC0DBB8F738F99");

            entity.ToTable("InstituteModel");

            entity.Property(e => e.Email)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ImageUrl)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.InstituteAddress)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InstituteDescription)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InstituteName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Mobile)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Login>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Login");

            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("password");
        });

        modelBuilder.Entity<RatingsModel>(entity =>
        {
            entity.HasKey(e => e.RatingId).HasName("PK__RatingsM__FCCDF87C5B359E5B");

            entity.ToTable("RatingsModel");

            entity.Property(e => e.Comments)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Rating)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Institute).WithMany(p => p.RatingsModels)
                .HasForeignKey(d => d.InstituteId)
                .HasConstraintName("FK__RatingsMo__Insti__4316F928");
        });

        modelBuilder.Entity<StudentModel>(entity =>
        {
            entity.HasKey(e => e.StudentId).HasName("PK__StudentM__32C52B99A72A76DB");

            entity.ToTable("StudentModel");

            entity.Property(e => e.Address)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.AlternateMobile)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FatherName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Mobile)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("mobile");
            entity.Property(e => e.MotherName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StudentDob)
                .HasColumnType("date")
                .HasColumnName("StudentDOB");
            entity.Property(e => e.StudentName)
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.HasOne(d => d.Course).WithMany(p => p.StudentModels)
                .HasForeignKey(d => d.CourseId)
                .HasConstraintName("FK__StudentMo__Cours__403A8C7D");
        });

        modelBuilder.Entity<UserMode>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__UserMode__1788CC4CFC31DC40");

            entity.ToTable("UserMode");

            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MobileNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.UserRole)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
