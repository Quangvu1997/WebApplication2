namespace QuanLyBanHang.Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("san_pham.xe")]
    public partial class xe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public xe()
        {
            chi_tiet_don_dat_hang = new HashSet<chi_tiet_don_dat_hang>();
            doi_tra = new HashSet<doi_tra>();
            gio_hang = new HashSet<gio_hang>();
            chi_tiet_nhap_hang = new HashSet<chi_tiet_nhap_hang>();
            khoes = new HashSet<kho>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int stt { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(12)]
        public string id_xe { get; set; }

        [Required]
        [StringLength(55)]
        public string ten_xe { get; set; }

        [Required]
        [StringLength(10)]
        public string id_hang_xe { get; set; }

        [Required]
        [StringLength(10)]
        public string id_loai_xe { get; set; }

        public short model_year { get; set; }

        public decimal gia_ban { get; set; }

        public byte bao_hanh { get; set; }

        [StringLength(1500)]
        public string mo_ta { get; set; }

        public decimal khuyen_mai { get; set; }

        [StringLength(11)]
        public string id_nsx { get; set; }

        public bool is_con_hang { get; set; }

        public bool is_het_hang { get; set; }

        public bool is_khong_kinh_doanh { get; set; }

        [StringLength(50)]
        public string anh_xe { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<chi_tiet_don_dat_hang> chi_tiet_don_dat_hang { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<doi_tra> doi_tra { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<gio_hang> gio_hang { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<chi_tiet_nhap_hang> chi_tiet_nhap_hang { get; set; }

        public virtual nsx nsx { get; set; }

        public virtual hang_xe hang_xe { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<kho> khoes { get; set; }

        public virtual loai_xe loai_xe { get; set; }
    }
}
