using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class OrderDTO
    {
        public int MaBan { get; set; }
        public int MaNV { get; set; }
        public decimal TongTien { get; set; }
        public decimal GiamGia { get; set; }
        public decimal PhuThu { get; set; }
    }
}
