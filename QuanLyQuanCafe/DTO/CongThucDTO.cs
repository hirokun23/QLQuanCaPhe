using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class CongThucDTO
    {
        public int MaMon { get; set; }
        public string MaNL { get; set; }
        public double SoLuong { get; set; }

        public CongThucDTO() { }
        public CongThucDTO(int maMon, string maNL, double soLuong)
        {
            this.MaMon = maMon;
            this.MaNL = maNL;
            this.SoLuong = soLuong;
        }
    }
}
