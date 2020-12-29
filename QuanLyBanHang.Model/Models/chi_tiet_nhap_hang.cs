namespace QuanLyBanHang.Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("nhap_hang.chi_tiet_nhap_hang")]
    public partial class chi_tiet_nhap_hang
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(11)]
        public string id_hoa_don_nhap { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_muc { get; set; }

        [Required]
        [StringLength(12)]
        public string id_xe { get; set; }

        public decimal gia_nhap { get; set; }

        public byte so_luong { get; set; }

        public decimal chiet_khau { get; set; }

        public virtual don_nhap_hang don_nhap_hang { get; set; }

        public virtual xe xe { get; set; }
    }
}
