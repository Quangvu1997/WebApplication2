namespace QuanLyBanHang.Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ban_hang.gio_hang")]
    public partial class gio_hang
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string id_khach_hang { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(12)]
        public string id_xe { get; set; }

        public int? so_luong { get; set; }

        public virtual khach_hang khach_hang { get; set; }

        public virtual xe xe { get; set; }
    }
}
