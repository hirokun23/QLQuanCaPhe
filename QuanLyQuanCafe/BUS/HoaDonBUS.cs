using QuanLyQuanCafe.DAO;
using System.Data;

namespace QuanLyQuanCafe.BUS
{
    public class HoaDonBUS
    {
        HoaDonDAO dao = new HoaDonDAO();

        public DataTable GetAllHoaDon()
        {
            return dao.GetAllHoaDon();
        }

        public DataTable GetChiTietHoaDon(int maHD)
        {
            return dao.GetChiTietHoaDon(maHD);
        }
    }
}