namespace QuanLyBanHang.Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("san_pham.kho")]
    public partial class kho
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string id_cua_hang { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(12)]
        public string id_xe { get; set; }

        public short so_luong_khong_loi { get; set; }

        public byte so_luong_bi_loi { get; set; }

        public virtual cua_hang cua_hang { get; set; }

        public virtual xe xe { get; set; }
    }
}
