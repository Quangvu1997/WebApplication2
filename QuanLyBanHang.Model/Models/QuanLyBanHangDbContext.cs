using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QuanLyBanHang.Model.Models
{
    public partial class QuanLyBanHangDbContext : DbContext
    {
        public QuanLyBanHangDbContext()
            : base("name=QuanLyBanHangDbContext")
        {
        }

        public virtual DbSet<chi_tiet_don_dat_hang> chi_tiet_don_dat_hang { get; set; }
        public virtual DbSet<cua_hang> cua_hang { get; set; }
        public virtual DbSet<dat_hang> dat_hang { get; set; }
        public virtual DbSet<doi_tra> doi_tra { get; set; }
        public virtual DbSet<gio_hang> gio_hang { get; set; }
        public virtual DbSet<khach_hang> khach_hang { get; set; }
        public virtual DbSet<Credential> Credentials { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<UserGroup> UserGroups { get; set; }
        public virtual DbSet<chuc_vu> chuc_vu { get; set; }
        public virtual DbSet<nhan_viens> nhan_viens { get; set; }
        public virtual DbSet<chi_tiet_nhap_hang> chi_tiet_nhap_hang { get; set; }
        public virtual DbSet<don_nhap_hang> don_nhap_hang { get; set; }
        public virtual DbSet<nsx> nsxes { get; set; }
        public virtual DbSet<hang_xe> hang_xe { get; set; }
        public virtual DbSet<kho> khoes { get; set; }
        public virtual DbSet<loai_xe> loai_xe { get; set; }
        public virtual DbSet<xe> xes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<chi_tiet_don_dat_hang>()
                .Property(e => e.gia_ban)
                .HasPrecision(6, 0);

            modelBuilder.Entity<chi_tiet_don_dat_hang>()
                .Property(e => e.giam_gia)
                .HasPrecision(3, 2);

            modelBuilder.Entity<cua_hang>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<cua_hang>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<cua_hang>()
                .HasMany(e => e.don_nhap_hang)
                .WithRequired(e => e.cua_hang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<dat_hang>()
                .Property(e => e.tien_ship)
                .HasPrecision(3, 0);

            modelBuilder.Entity<dat_hang>()
                .Property(e => e.so_tien_khach_duoc_giam)
                .HasPrecision(5, 0);

            modelBuilder.Entity<dat_hang>()
                .Property(e => e.tong_tien)
                .HasPrecision(8, 0);

            modelBuilder.Entity<khach_hang>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<khach_hang>()
                .Property(e => e.so_tien_duoc_giam)
                .HasPrecision(5, 0);

            modelBuilder.Entity<khach_hang>()
                .Property(e => e.GroupId)
                .IsUnicode(false);

            modelBuilder.Entity<Credential>()
                .Property(e => e.UserGroupId)
                .IsUnicode(false);

            modelBuilder.Entity<Credential>()
                .Property(e => e.RoleID)
                .IsUnicode(false);

            modelBuilder.Entity<Role>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<UserGroup>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<chuc_vu>()
                .Property(e => e.luong)
                .HasPrecision(5, 0);

            modelBuilder.Entity<nhan_viens>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<nhan_viens>()
                .HasMany(e => e.dat_hang)
                .WithOptional(e => e.nhan_viens)
                .HasForeignKey(e => e.id_nhan_vien_ban_hang)
                .WillCascadeOnDelete();

            modelBuilder.Entity<nhan_viens>()
                .HasMany(e => e.dat_hang1)
                .WithOptional(e => e.nhan_viens1)
                .HasForeignKey(e => e.id_nhan_vien_giao_hang);

            modelBuilder.Entity<nhan_viens>()
                .HasMany(e => e.don_nhap_hang)
                .WithRequired(e => e.nhan_viens)
                .HasForeignKey(e => e.id_chu_kho);

            modelBuilder.Entity<nhan_viens>()
                .HasMany(e => e.nhan_viens1)
                .WithOptional(e => e.nhan_viens2)
                .HasForeignKey(e => e.id_nguoi_quan_li);

            modelBuilder.Entity<chi_tiet_nhap_hang>()
                .Property(e => e.gia_nhap)
                .HasPrecision(6, 0);

            modelBuilder.Entity<chi_tiet_nhap_hang>()
                .Property(e => e.chiet_khau)
                .HasPrecision(3, 2);

            modelBuilder.Entity<don_nhap_hang>()
                .Property(e => e.tong_tien)
                .HasPrecision(7, 0);

            modelBuilder.Entity<nsx>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<nsx>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<xe>()
                .Property(e => e.gia_ban)
                .HasPrecision(6, 0);

            modelBuilder.Entity<xe>()
                .Property(e => e.khuyen_mai)
                .HasPrecision(3, 2);
        }
    }
}
