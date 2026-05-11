using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class BillItemDTO
    {
        public int MaMon { get; set; }
        public string TenMon { get; set; }
        public decimal Gia { get; set; }
        public int SoLuong { get; set; }
    }
}
