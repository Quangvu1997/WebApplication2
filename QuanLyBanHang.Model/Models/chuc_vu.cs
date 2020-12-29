namespace QuanLyBanHang.Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("nhan_vien.chuc_vu")]
    public partial class chuc_vu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public chuc_vu()
        {
            nhan_viens = new HashSet<nhan_viens>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int stt { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(10)]
        public string id_chuc_vu { get; set; }

        [Required]
        [StringLength(20)]
        public string ten_chuc_vu { get; set; }

        public decimal luong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<nhan_viens> nhan_viens { get; set; }
    }
}
