﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ApiQuanLyNhaThuoc.Models.Models.Entities
{
    public class ChiTietHoaDonNhapHang
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public double SoLuongNhap { get; set; }
        [Required]
        [ForeignKey("HoaDonNhapHang")]
        public string HoaDonNhapHangId { get; set; }
        [JsonIgnore]
        public HoaDonNhapHang? HoaDonNhapHang { get; private set; }
        [Required]
        [ForeignKey("PhienBanSanPham")]
        public string PhienBanSanPhamId { get; set; }
        [JsonIgnore]
        public PhienBanSanPham? PhienBanSanPham { get; private set; }

        [Required]
        [ForeignKey("LoHang")]
        public string LoHangId { get; set; }
        public LoHang? LoHang { get;  set; }

        [Required]
        public decimal Gia { get; set; }

     
    }
}