using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace POC.API.Models;

public partial class PocdbContext : DbContext
{
    public PocdbContext()
    {
    }

    public PocdbContext(DbContextOptions<PocdbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Bank> Banks { get; set; }

    public virtual DbSet<Country> Countries { get; set; }

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //    => optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=POCDB;Integrated Security=False;user id=poc;password=poc123;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Bank>(entity =>
        {
            entity.ToTable("Bank");

            entity.Property(e => e.BankId).ValueGeneratedNever();
            entity.Property(e => e.AuthStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.BankAddress).HasMaxLength(100);
            entity.Property(e => e.BankName).HasMaxLength(100);
            entity.Property(e => e.BankShortName).HasMaxLength(10);
            entity.Property(e => e.BankType).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(20)
                .HasColumnName("IPAddress");
            entity.Property(e => e.LastAction)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.LastModifiedBy).HasMaxLength(20);
            entity.Property(e => e.Macaddress)
                .HasMaxLength(50)
                .HasColumnName("MACAddress");

            entity.HasOne(d => d.Country).WithMany(p => p.Banks)
                .HasForeignKey(d => d.CountryId)
                .HasConstraintName("FK_Bank_Country");
        });

        modelBuilder.Entity<Country>(entity =>
        {
            entity.ToTable("Country");

            entity.Property(e => e.CountryId).ValueGeneratedNever();
            entity.Property(e => e.AuthStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.CountryName).HasMaxLength(50);
            entity.Property(e => e.CountryShortName).HasMaxLength(10);
            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(20)
                .HasColumnName("IPAddress");
            entity.Property(e => e.LastAction)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.LastModifiedBy).HasMaxLength(20);
            entity.Property(e => e.Macaddress)
                .HasMaxLength(50)
                .HasColumnName("MACAddress");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
