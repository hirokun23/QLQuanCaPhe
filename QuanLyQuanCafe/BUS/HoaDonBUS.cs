using System;
using System.Data;
using QuanLyQuanCafe.DAO;

namespace QuanLyQuanCafe.BUS
{
    public class HoaDonBUS
    {
        HoaDonDAO dao = new HoaDonDAO();

        public DataTable GetDoanhThu(DateTime tu, DateTime den)
        {
            return dao.GetDoanhThu(tu, den);
        }
    }
}