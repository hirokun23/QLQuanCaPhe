using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class NguyenLieuDTO
    {
        public string MaNL { get; set; }
        public string TenNL { get; set; }
        public int SoLuong { get; set; }

        public NguyenLieuDTO() { }

        public NguyenLieuDTO(string ma, string ten, int sl)
        {
            MaNL = ma;
            TenNL = ten;
            SoLuong = sl;
        }
    }
}