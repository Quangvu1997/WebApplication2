namespace QuanLyBanHang.Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ban_hang.cua_hang")]
    public partial class cua_hang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cua_hang()
        {
            dat_hang = new HashSet<dat_hang>();
            nhan_viens = new HashSet<nhan_viens>();
            khoes = new HashSet<kho>();
            don_nhap_hang = new HashSet<don_nhap_hang>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int stt { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(10)]
        public string id_cua_hang { get; set; }

        [Required]
        [StringLength(15)]
        public string ten_cua_hang { get; set; }

        [StringLength(10)]
        public string SDT { get; set; }

        [StringLength(40)]
        public string email { get; set; }

        [StringLength(100)]
        public string dia_chi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dat_hang> dat_hang { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<nhan_viens> nhan_viens { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<kho> khoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<don_nhap_hang> don_nhap_hang { get; set; }
    }
}
