using QuanLyQuanCafe.Data;
using System.Data;

namespace QuanLyQuanCafe.DAO
{
    public class GoiMonDAO
    {
        DataProvider dp = new DataProvider();

        // load món
        public DataTable GetMenu()
        {
            string sql =
                "SELECT MaMon, TenMon, Gia, Loai FROM Mon";

            return dp.ExecuteQuery(sql, null);
        }

        // lưu hóa đơn
        public int InsertHoaDon(int maBan, float tongTien)
        {
            string sql =
                "INSERT INTO HoaDon(MaBan, NgayLap, TongTien) " +
                "VALUES(@p0, GETDATE(), @p1)";

            return dp.ExecuteNonQuery(sql,
                new object[]
                {
                    maBan,
                    tongTien
                });
        }

        // lấy mã hóa đơn mới nhất
        public DataTable GetLastHoaDon()
        {
            string sql =
                "SELECT TOP 1 MaHD FROM HoaDon ORDER BY MaHD DESC";

            return dp.ExecuteQuery(sql, null);
        }

        // lưu chi tiết hóa đơn
        public int InsertChiTiet(
            int maHD,
            int maMon,
            int soLuong,
            float donGia)
        {
            string sql =
                "INSERT INTO ChiTietHoaDon " +
                "VALUES(@p0,@p1,@p2,@p3)";

            return dp.ExecuteNonQuery(sql,
                new object[]
                {
                    maHD,
                    maMon,
                    soLuong,
                    donGia
                });
        }
    }
}