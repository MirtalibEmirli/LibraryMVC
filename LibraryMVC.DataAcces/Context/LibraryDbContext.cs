using System;
using System.Collections.Generic;
using LibraryMVC.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LibraryMVC.Domain.Entities;

public partial class LibraryDbContext : DbContext
{
    public LibraryDbContext()
    {
    }

    public LibraryDbContext(DbContextOptions<LibraryDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Book> Books { get; set; }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-U9UFRFT\\SQLEXPRESS;Initial Catalog=LibraryDb;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Books__3214EC076BC7A647");

            entity.Property(e => e.Author)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BookImage)
                .HasMaxLength(600)
                .HasDefaultValue("https://upload.wikimedia.org/wikipedia/en/f/fa/%22Twenty_Four_Hours_in_the_Life_of_a_Woman%22.jpg");
            entity.Property(e => e.Description)
                .HasMaxLength(600)
                .IsUnicode(false);
            entity.Property(e => e.Genre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ReadCount).HasDefaultValue(0);
            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Course>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Courses__3214EC078A9CA45E");

            entity.Property(e => e.CourseImg)
                .HasMaxLength(1000)
                .HasDefaultValue("https://www.ajans4.com/wp-content/uploads/2024/04/asp-nedir-asp-ne-ise-yarar.jpg");
            entity.Property(e => e.Duration)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Mentor)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Skills)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Users__3214EC0748A7C477");

            entity.Property(e => e.FirstName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ProfileImageUrl)
                .HasMaxLength(600)
                .HasDefaultValue("https://www.shutterstock.com/image-vector/user-profile-icon-vector-avatar-600nw-2247726673.jpg");
            entity.Property(e => e.Speciality)
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.HasMany(d => d.Books).WithMany(p => p.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "UserBook",
                    r => r.HasOne<Book>().WithMany()
                        .HasForeignKey("BookId")
                        .HasConstraintName("FK__UserBooks__BookI__5EBF139D"),
                    l => l.HasOne<User>().WithMany()
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK__UserBooks__UserI__5DCAEF64"),
                    j =>
                    {
                        j.HasKey("UserId", "BookId").HasName("PK__UserBook__7456C06C093DFED8");
                        j.ToTable("UserBooks");
                    });

            entity.HasMany(d => d.Courses).WithMany(p => p.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "UserCourse",
                    r => r.HasOne<Course>().WithMany()
                        .HasForeignKey("CourseId")
                        .HasConstraintName("FK__UserCours__Cours__628FA481"),
                    l => l.HasOne<User>().WithMany()
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK__UserCours__UserI__619B8048"),
                    j =>
                    {
                        j.HasKey("UserId", "CourseId").HasName("PK__UserCour__7B1A1B562B1D39AA");
                        j.ToTable("UserCourses");
                    });
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
