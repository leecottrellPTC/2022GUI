using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AuthLecture2022.Models
{
    public partial class cottrelldbContext : DbContext
    {
        public cottrelldbContext()
        {
        }

        public cottrelldbContext(DbContextOptions<cottrelldbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Author> Authors { get; set; } = null!;
        public virtual DbSet<Book> Books { get; set; } = null!;
        public virtual DbSet<Branch> Branches { get; set; } = null!;
        public virtual DbSet<Copy> Copies { get; set; } = null!;
        public virtual DbSet<Course> Courses { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<LeeOrder> LeeOrders { get; set; } = null!;
        public virtual DbSet<LeeOrderDetail> LeeOrderDetails { get; set; } = null!;
        public virtual DbSet<Publisher> Publishers { get; set; } = null!;
        public virtual DbSet<Wrote> Wrotes { get; set; } = null!;



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>(entity =>
            {
                entity.HasKey(e => e.AuthorNum)
                    .HasName("PK__Author__7E6BD29C57CE72FF");

                entity.ToTable("Author");

                entity.Property(e => e.AuthorNum).HasColumnType("decimal(2, 0)");

                entity.Property(e => e.AuthorFirst)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AuthorLast)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ImgPath)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("imgPath");
            });

            modelBuilder.Entity<Book>(entity =>
            {
                entity.HasKey(e => e.BookCode)
                    .HasName("PK__Book__0A5FFCC627B5D693");

                entity.ToTable("Book");

                entity.Property(e => e.BookCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Paperback)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PublisherCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Stuff)
                    .HasMaxLength(10)
                    .HasColumnName("stuff")
                    .IsFixedLength();

                entity.Property(e => e.Title)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Type)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Branch>(entity =>
            {
                entity.HasKey(e => e.BranchNum)
                    .HasName("PK__Branch__0E8D21C572C8B7D3");

                entity.ToTable("Branch");

                entity.Property(e => e.BranchNum).HasColumnType("decimal(2, 0)");

                entity.Property(e => e.BranchLocation)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BranchName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Copy>(entity =>
            {
                entity.HasKey(e => new { e.BookCode, e.BranchNum, e.CopyNum })
                    .HasName("PK__Copy__3462780CB3DC56D4");

                entity.ToTable("Copy");

                entity.Property(e => e.BookCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BranchNum).HasColumnType("decimal(2, 0)");

                entity.Property(e => e.CopyNum).HasColumnType("decimal(2, 0)");

                entity.Property(e => e.Price).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Quality)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Course>(entity =>
            {
                entity.ToTable("courses");

                entity.Property(e => e.Id)
                    .HasMaxLength(6)
                    .HasColumnName("ID");

                entity.Property(e => e.Instructor).HasMaxLength(50);

                entity.Property(e => e.Title).HasMaxLength(50);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.CustId);

                entity.ToTable("customer");

                entity.Property(e => e.CustId)
                    .ValueGeneratedNever()
                    .HasColumnName("custID");

                entity.Property(e => e.Fname)
                    .HasMaxLength(20)
                    .HasColumnName("fname")
                    .IsFixedLength();

                entity.Property(e => e.Lname)
                    .HasMaxLength(20)
                    .HasColumnName("lname")
                    .IsFixedLength();

                entity.Property(e => e.PayDetails)
                    .HasMaxLength(16)
                    .HasColumnName("payDetails")
                    .IsFixedLength();
            });

            modelBuilder.Entity<LeeOrder>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");
            });

            modelBuilder.Entity<LeeOrderDetail>(entity =>
            {
                entity.HasKey(e => e.OrderDetailId);

                entity.HasIndex(e => e.OrderId, "IX_LeeOrderDetails_OrderID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.LeeOrderDetails)
                    .HasForeignKey(d => d.OrderId);
            });

            modelBuilder.Entity<Publisher>(entity =>
            {
                entity.HasKey(e => e.PublisherCode)
                    .HasName("PK__Publishe__DFB88E284C2CB07A");

                entity.ToTable("Publisher");

                entity.Property(e => e.PublisherCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PublisherName)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Wrote>(entity =>
            {
                entity.HasKey(e => new { e.BookCode, e.AuthorNum })
                    .HasName("PK__Wrote__DDB941EFBD78F392");

                entity.ToTable("Wrote");

                entity.Property(e => e.BookCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AuthorNum).HasColumnType("decimal(2, 0)");

                entity.Property(e => e.Sequence).HasColumnType("decimal(2, 0)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
