namespace QuanLyBanHang.Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("nhap_hang.nsx")]
    public partial class nsx
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public nsx()
        {
            don_nhap_hang = new HashSet<don_nhap_hang>();
            xes = new HashSet<xe>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int stt { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(11)]
        public string id_nsx { get; set; }

        [Required]
        [StringLength(30)]
        public string ten_nsx { get; set; }

        [StringLength(10)]
        public string SDT { get; set; }

        [StringLength(40)]
        public string email { get; set; }

        [StringLength(200)]
        public string dia_chi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<don_nhap_hang> don_nhap_hang { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<xe> xes { get; set; }
    }
}
