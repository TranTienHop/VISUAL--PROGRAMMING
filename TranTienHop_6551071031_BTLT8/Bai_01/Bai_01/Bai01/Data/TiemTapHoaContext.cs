using System;
using System.Collections.Generic;
using Bai01.Models;
using Microsoft.EntityFrameworkCore;

namespace Bai01.Data;

public partial class TiemTapHoaContext : DbContext
{
    public TiemTapHoaContext()
    {
    }

    public TiemTapHoaContext(DbContextOptions<TiemTapHoaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<HangHoa> HangHoas { get; set; }

    public static string ConnectionString { get; set; } = "Server=.\\SQL2025;Database=TiemTapHoa;Trusted_Connection=True;TrustServerCertificate=True;";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<HangHoa>(entity =>
        {
            entity.HasKey(e => e.MaHang).HasName("PK__HangHoa__19C0DB1D9626538C");

            entity.ToTable("HangHoa");

            entity.Property(e => e.ConKinhDoanh).HasDefaultValue(true, "DF_HangHoa_ConKinhDoanh");
            entity.Property(e => e.DonVi).HasMaxLength(20);
            entity.Property(e => e.GiaBan).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.LoaiHang).HasMaxLength(50);
            entity.Property(e => e.NgayNhap).HasColumnType("datetime");
            entity.Property(e => e.TenHang).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
