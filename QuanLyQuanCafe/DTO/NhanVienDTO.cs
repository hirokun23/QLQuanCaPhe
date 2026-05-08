using System;

namespace QuanLyQuanCafe.DTO
{
    public class NhanVienDTO
    {
        public int MaNV { get; set; }
        public string TenNV { get; set; }
        public DateTime NgaySinh { get; set; }
        public string SDT { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string ChucVu { get; set; }
        public float Luong { get; set; }
    }
}