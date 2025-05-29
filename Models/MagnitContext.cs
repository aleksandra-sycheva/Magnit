using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace magnit.Models;

public partial class MagnitContext : DbContext
{
    public MagnitContext()
    {
    }

    public MagnitContext(DbContextOptions<MagnitContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<RevenueHistory> RevenueHistories { get; set; }

    public virtual DbSet<SalesRegister> SalesRegisters { get; set; }

    public virtual DbSet<TypesOfEmployee> TypesOfEmployees { get; set; }

    public virtual DbSet<TypesOfSalesRegister> TypesOfSalesRegisters { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=magnit;Username=postgres;Password=1111");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("employees_pkey");

            entity.ToTable("employees");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DateOfBirth).HasColumnName("date_of_birth");
            entity.Property(e => e.DateOfDismissal).HasColumnName("date_of_dismissal");
            entity.Property(e => e.DateOfEmployment).HasColumnName("date_of_employment");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.IdTypeOfEmployee).HasColumnName("id_type_of_employee");
            entity.Property(e => e.MiddleName).HasColumnName("middle_name");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Password).HasColumnName("password");
            entity.Property(e => e.Phone).HasColumnName("phone");
            entity.Property(e => e.Photo).HasColumnName("photo");
            entity.Property(e => e.ResidentialAddress).HasColumnName("residential_address");
            entity.Property(e => e.Surname).HasColumnName("surname");

            entity.HasOne(d => d.IdTypeOfEmployeeNavigation).WithMany(p => p.Employees)
                .HasForeignKey(d => d.IdTypeOfEmployee)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_employees_types_of_employees");
        });

        modelBuilder.Entity<RevenueHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("revenue_history_pkey");

            entity.ToTable("revenue_history");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.IdEmployee).HasColumnName("id_employee");
            entity.Property(e => e.IdSalesRegisters).HasColumnName("id_sales_registers");
            entity.Property(e => e.Revenue)
                .HasColumnType("money")
                .HasColumnName("revenue");
            entity.Property(e => e.TimeEnd)
                .HasColumnType("time with time zone")
                .HasColumnName("time_end");
            entity.Property(e => e.TimeStart).HasColumnName("time_start");

            entity.HasOne(d => d.IdEmployeeNavigation).WithMany(p => p.RevenueHistories)
                .HasForeignKey(d => d.IdEmployee)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_revenue_history_employees");

            entity.HasOne(d => d.IdSalesRegistersNavigation).WithMany(p => p.RevenueHistories)
                .HasForeignKey(d => d.IdSalesRegisters)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_revenue_history_sales_registers");
        });

        modelBuilder.Entity<SalesRegister>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("sales_registers_pkey");

            entity.ToTable("sales_registers");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdTypeOfSalesRegisters).HasColumnName("id_type_of_sales_registers");
            entity.Property(e => e.Name).HasColumnName("name");

            entity.HasOne(d => d.IdTypeOfSalesRegistersNavigation).WithMany(p => p.SalesRegisters)
                .HasForeignKey(d => d.IdTypeOfSalesRegisters)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_sales_registers_types_of_sales_registers");
        });

        modelBuilder.Entity<TypesOfEmployee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("types_of_employees_pkey");

            entity.ToTable("types_of_employees");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.TypeOfEmployee).HasColumnName("type_of_employee");
        });

        modelBuilder.Entity<TypesOfSalesRegister>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("types_of_box_office_pkey");

            entity.ToTable("types_of_sales_registers");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('types_of_box_office_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.TypeOfSalesRegisters).HasColumnName("type_of_sales_registers");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
