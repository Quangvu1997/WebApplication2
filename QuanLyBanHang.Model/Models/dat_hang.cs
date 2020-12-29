namespace QuanLyBanHang.Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ban_hang.dat_hang")]
    public partial class dat_hang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public dat_hang()
        {
            chi_tiet_don_dat_hang = new HashSet<chi_tiet_don_dat_hang>();
            doi_tra = new HashSet<doi_tra>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int stt { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(13)]
        public string id_don_dat_hang { get; set; }

        [Required]
        [StringLength(10)]
        public string id_khach_hang { get; set; }

        public DateTime ngay_dat_hang { get; set; }

        public DateTime? ngay_giao_hang { get; set; }

        public decimal tien_ship { get; set; }

        public decimal so_tien_khach_duoc_giam { get; set; }

        [StringLength(10)]
        public string id_nhan_vien_ban_hang { get; set; }

        [StringLength(10)]
        public string id_nhan_vien_giao_hang { get; set; }

        [StringLength(10)]
        public string id_cua_hang { get; set; }

        public decimal tong_tien { get; set; }

        public bool is_dang_giao_hang { get; set; }

        public bool is_da_giao_hang { get; set; }

        public bool is_huy_don_hang { get; set; }

        [StringLength(200)]
        public string dia_chi_giao_hang { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<chi_tiet_don_dat_hang> chi_tiet_don_dat_hang { get; set; }

        public virtual cua_hang cua_hang { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<doi_tra> doi_tra { get; set; }

        public virtual khach_hang khach_hang { get; set; }

        public virtual nhan_viens nhan_viens { get; set; }

        public virtual nhan_viens nhan_viens1 { get; set; }
    }
}
