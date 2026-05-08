using System;

namespace QuanLyQuanCafe.DTO
{
    public class HoaDonDTO
    {
        public int Id { get; set; }
        public DateTime Ngay { get; set; }
        public decimal TongTien { get; set; }

        public HoaDonDTO() { }

        public HoaDonDTO(int id, DateTime ngay, decimal tongTien)
        {
            Id = id;
            Ngay = ngay;
            TongTien = tongTien;
        }
    }
}