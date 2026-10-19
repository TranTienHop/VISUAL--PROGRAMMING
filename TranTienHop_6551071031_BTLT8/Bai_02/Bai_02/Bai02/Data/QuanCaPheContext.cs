using System;
using System.Collections.Generic;
using Bai02.Models;
using Microsoft.EntityFrameworkCore;

namespace Bai02.Data;

public partial class QuanCaPheContext : DbContext
{
    public QuanCaPheContext()
    {
    }

    public QuanCaPheContext(DbContextOptions<QuanCaPheContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ChiTietHoaDon> ChiTietHoaDons { get; set; }

    public virtual DbSet<HoaDon> HoaDons { get; set; }

    public virtual DbSet<Mon> Mons { get; set; }

    public static string ConnectionString { get; set; } = "Server=.\\SQL2025;Database=QuanCaPhe;Trusted_Connection=True;TrustServerCertificate=True;";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ChiTietHoaDon>(entity =>
        {
            entity.HasKey(e => e.MaCT);

            entity.ToTable("ChiTietHoaDon");

            entity.Property(e => e.DonGia).HasColumnType("decimal(18, 0)");

            entity.HasOne(d => d.MaHDNavigation)
                .WithMany(p => p.ChiTietHoaDons)
                .HasForeignKey(d => d.MaHD)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ChiTietHoaDon_HoaDon");

            entity.HasOne(d => d.MaMonNavigation)
                .WithMany(p => p.ChiTietHoaDons)
                .HasForeignKey(d => d.MaMon)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ChiTietHoaDon_Mon");
        });

        modelBuilder.Entity<HoaDon>(entity =>
        {
            entity.HasKey(e => e.MaHD);

            entity.ToTable("HoaDon");

            entity.Property(e => e.GhiChu).HasMaxLength(200);
            entity.Property(e => e.HinhThucTT).HasMaxLength(20);
            entity.Property(e => e.NgayLap).HasColumnType("datetime");
        });

        modelBuilder.Entity<Mon>(entity =>
        {
            entity.HasKey(e => e.MaMon);

            entity.ToTable("Mon");

            entity.Property(e => e.DonGia).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.NhomMon).HasMaxLength(30);
            entity.Property(e => e.TenMon).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
