namespace QuanLyBanHang.Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ban_hang.chi_tiet_don_dat_hang")]
    public partial class chi_tiet_don_dat_hang
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(13)]
        public string id_don_dat_hang { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_muc { get; set; }

        [Required]
        [StringLength(12)]
        public string id_xe { get; set; }

        public byte so_luong { get; set; }

        public decimal gia_ban { get; set; }

        public decimal giam_gia { get; set; }

        public virtual dat_hang dat_hang { get; set; }

        public virtual xe xe { get; set; }
    }
}
