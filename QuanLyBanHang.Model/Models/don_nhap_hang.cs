namespace QuanLyBanHang.Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("nhap_hang.don_nhap_hang")]
    public partial class don_nhap_hang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public don_nhap_hang()
        {
            chi_tiet_nhap_hang = new HashSet<chi_tiet_nhap_hang>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int stt { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(11)]
        public string id_hoa_don_nhap { get; set; }

        [Required]
        [StringLength(11)]
        public string id_nsx { get; set; }

        [Required]
        [StringLength(10)]
        public string id_chu_kho { get; set; }

        [Column(TypeName = "date")]
        public DateTime ngay_nhap_hang { get; set; }

        [Required]
        [StringLength(10)]
        public string id_cua_hang { get; set; }

        public decimal tong_tien { get; set; }

        public virtual cua_hang cua_hang { get; set; }

        public virtual nhan_viens nhan_viens { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<chi_tiet_nhap_hang> chi_tiet_nhap_hang { get; set; }

        public virtual nsx nsx { get; set; }
    }
}
