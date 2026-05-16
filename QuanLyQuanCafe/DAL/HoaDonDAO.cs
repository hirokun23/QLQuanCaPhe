using QuanLyQuanCafe.Data;
using System.Data;

namespace QuanLyQuanCafe.DAO
{
    public class HoaDonDAO
    {
        DataProvider dp = new DataProvider();

        // LOAD HÓA ĐƠN
        public DataTable GetAllHoaDon()
        {
            string sql = @"
            SELECT 
                hd.MaHD,
                b.TenBan,
                nv.TenNV,
                hd.NgayLap,
                ISNULL(hd.GiamGia,0) AS GiamGia,
                ISNULL(hd.PhuThu,0) AS PhuThu,
                hd.TongTien
            FROM HoaDon hd
            JOIN Ban b ON hd.MaBan = b.MaBan
            JOIN NhanVien nv ON hd.MaNV = nv.MaNV
            ORDER BY hd.MaHD DESC";

            return dp.ExecuteQuery(sql);
        }

        // LOAD CHI TIẾT
        public DataTable GetChiTietHoaDon(int maHD)
        {
            string sql = $@"
    SELECT
        ct.MaHD,
        ISNULL(m.TenMon, N'Không tìm thấy món') AS TenMon,
        ct.DonGia,
        ct.SoLuong,
        (ct.SoLuong * ct.DonGia) AS ThanhTien,
        ct.GhiChu
    FROM ChiTietHoaDon ct
    LEFT JOIN Mon m ON ct.MaMon = m.MaMon
    WHERE ct.MaHD = {maHD}";

            return dp.ExecuteQuery(sql);
        }
    }
}