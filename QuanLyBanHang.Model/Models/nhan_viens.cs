namespace QuanLyBanHang.Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("nhan_vien.nhan_viens")]
    public partial class nhan_viens
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public nhan_viens()
        {
            dat_hang = new HashSet<dat_hang>();
            dat_hang1 = new HashSet<dat_hang>();
            don_nhap_hang = new HashSet<don_nhap_hang>();
            nhan_viens1 = new HashSet<nhan_viens>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int stt { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(10)]
        public string id_nhan_vien { get; set; }

        [Required]
        [StringLength(30)]
        public string ten_nhan_vien { get; set; }

        [StringLength(10)]
        public string SDT { get; set; }

        [StringLength(100)]
        public string dia_chi { get; set; }

        [Column(TypeName = "date")]
        public DateTime ngay_vao_lam_viec { get; set; }

        [Required]
        [StringLength(10)]
        public string id_chuc_vu { get; set; }

        [Required]
        [StringLength(10)]
        public string id_cua_hang { get; set; }

        [StringLength(10)]
        public string id_nguoi_quan_li { get; set; }

        public bool is_dang_lam_viec { get; set; }

        public bool is_nghi_viec { get; set; }

        public virtual cua_hang cua_hang { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dat_hang> dat_hang { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dat_hang> dat_hang1 { get; set; }

        public virtual chuc_vu chuc_vu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<don_nhap_hang> don_nhap_hang { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<nhan_viens> nhan_viens1 { get; set; }

        public virtual nhan_viens nhan_viens2 { get; set; }
    }
}
