using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Project_Entity.Models
{
    public partial class QuanLyQuanCaFeContext : DbContext
    {
        public QuanLyQuanCaFeContext()
        {
        }

        public QuanLyQuanCaFeContext(DbContextOptions<QuanLyQuanCaFeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Ban> Bans { get; set; }
        public virtual DbSet<Catruc> Catrucs { get; set; }
        public virtual DbSet<CtHd> CtHds { get; set; }
        public virtual DbSet<Douong> Douongs { get; set; }
        public virtual DbSet<Hoadon> Hoadons { get; set; }
        public virtual DbSet<Nhanvien> Nhanviens { get; set; }
        public virtual DbSet<Thongke> Thongkes { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=localhost; database=QuanLyQuanCaFe;user=sa;password=123");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Ban>(entity =>
            {
                entity.HasKey(e => e.Soban)
                    .HasName("PK__ban__29BC6CEC3454AACD");

                entity.ToTable("ban");

                entity.Property(e => e.Soban).ValueGeneratedNever();

                entity.Property(e => e.Tinhtrang)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<Catruc>(entity =>
            {
                entity.ToTable("CATRUC");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ca)
                    .HasMaxLength(20)
                    .HasColumnName("ca");

                entity.Property(e => e.Idnhanvien).HasColumnName("IDnhanvien");

                entity.Property(e => e.Ngaytruc)
                    .HasColumnType("datetime")
                    .HasColumnName("ngaytruc");

                entity.HasOne(d => d.IdnhanvienNavigation)
                    .WithMany(p => p.Catrucs)
                    .HasForeignKey(d => d.Idnhanvien)
                    .HasConstraintName("FK__CATRUC__IDnhanvi__32E0915F");
            });

            modelBuilder.Entity<CtHd>(entity =>
            {
                entity.ToTable("ct_hd");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MaSp).HasColumnName("MaSP");

                entity.Property(e => e.Ngayban)
                    .HasColumnType("date")
                    .HasColumnName("ngayban");

                entity.Property(e => e.Soban).HasColumnName("soban");

                entity.HasOne(d => d.MaHoaDonNavigation)
                    .WithMany(p => p.CtHds)
                    .HasForeignKey(d => d.MaHoaDon)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MaHoaDon");

                entity.HasOne(d => d.MaSpNavigation)
                    .WithMany(p => p.CtHds)
                    .HasForeignKey(d => d.MaSp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MaSP");

                entity.HasOne(d => d.SobanNavigation)
                    .WithMany(p => p.CtHds)
                    .HasForeignKey(d => d.Soban)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Maban");
            });

            modelBuilder.Entity<Douong>(entity =>
            {
                entity.ToTable("douong");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ghichu)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("ghichu");

                entity.Property(e => e.Giatien).HasColumnName("giatien");

                entity.Property(e => e.Tendouong)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("tendouong");
            });

            modelBuilder.Entity<Hoadon>(entity =>
            {
                entity.ToTable("hoadon");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Soban).HasColumnName("soban");

                entity.HasOne(d => d.SobanNavigation)
                    .WithMany(p => p.Hoadons)
                    .HasForeignKey(d => d.Soban)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mas");
            });

            modelBuilder.Entity<Nhanvien>(entity =>
            {
                entity.HasKey(e => e.Manv)
                    .HasName("PK__nhanvien__603F5114DCB28C2F");

                entity.ToTable("nhanvien");

                entity.Property(e => e.Manv)
                    .ValueGeneratedNever()
                    .HasColumnName("MANV");

                entity.Property(e => e.Dienthoai)
                    .HasMaxLength(12)
                    .HasColumnName("DIENTHOAI");

                entity.Property(e => e.Gioitinh)
                    .HasMaxLength(10)
                    .HasColumnName("GIOITINH");

                entity.Property(e => e.Tenhanvien)
                    .HasMaxLength(50)
                    .HasColumnName("TENHANVIEN");
            });

            modelBuilder.Entity<Thongke>(entity =>
            {
                entity.ToTable("thongke");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Doanhthu).HasColumnName("doanhthu");

                entity.Property(e => e.Ngaylap)
                    .HasColumnType("date")
                    .HasColumnName("ngaylap");

                entity.Property(e => e.TenSanPham).HasMaxLength(30);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.UserName)
                    .HasName("PK__users__C9F2845716BDB2DB");

                entity.ToTable("users");

                entity.Property(e => e.UserName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Priority).HasColumnName("priority");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
