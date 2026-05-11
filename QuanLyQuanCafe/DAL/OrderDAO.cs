using QuanLyQuanCafe.Data;
using System;
using System.Data;

namespace QuanLyQuanCafe.DAO
{
    public class OrderDAO
    {
        DataProvider dp = new DataProvider();

        // ================= LẤY HOÁ ĐƠN CHƯA THANH TOÁN =================
        public int GetOrCreateHoaDon(int maBan)
        {
            string sqlGet = @"
                SELECT TOP 1 MaHD
                FROM HoaDon
                WHERE MaBan = @p0 AND TrangThai = N'ChuaThanhToan'
                ORDER BY MaHD DESC";

            object result = dp.ExecuteScalar(sqlGet, new object[] { maBan });

            if (result != null)
                return Convert.ToInt32(result);

            string sqlInsert = @"
                INSERT INTO HoaDon(MaBan, MaNV, TongTien, GiamGia, PhuThu, TrangThai)
                VALUES(@p0, 1, 0, 0, 0, N'ChuaThanhToan');
                SELECT SCOPE_IDENTITY();";

            return Convert.ToInt32(dp.ExecuteScalar(sqlInsert, new object[] { maBan }));
        }

        // ================= THÊM MÓN =================
        public void AddMon(int maBan, int maMon, decimal gia)
        {
            int maHD = GetOrCreateHoaDon(maBan);

            string sql = @"
                IF EXISTS (SELECT 1 FROM ChiTietHoaDon WHERE MaHD=@p0 AND MaMon=@p1)
                    UPDATE ChiTietHoaDon
                    SET SoLuong = SoLuong + 1
                    WHERE MaHD=@p0 AND MaMon=@p1
                ELSE
                    INSERT INTO ChiTietHoaDon(MaHD, MaMon, SoLuong, DonGia)
                    VALUES(@p0, @p1, 1, @p2)";

            dp.ExecuteNonQuery(sql, new object[] { maHD, maMon, gia });
        }

        // ================= LẤY BILL =================
        public DataTable GetBill(int maBan)
        {
            string sql = @"
                SELECT 
                    m.MaMon,
                    m.TenMon,
                    c.DonGia,
                    c.SoLuong
                FROM ChiTietHoaDon c
                JOIN HoaDon h ON c.MaHD = h.MaHD
                JOIN Mon m ON m.MaMon = c.MaMon
                WHERE h.MaBan = @p0 AND h.TrangThai = N'ChuaThanhToan'";

            return dp.ExecuteQuery(sql, new object[] { maBan });
        }

        // ================= XÓA BILL =================
        public void ClearBill(int maBan)
        {
            string sql = @"
                DELETE c
                FROM ChiTietHoaDon c
                JOIN HoaDon h ON c.MaHD = h.MaHD
                WHERE h.MaBan = @p0 AND h.TrangThai = N'ChuaThanhToan'";

            dp.ExecuteNonQuery(sql, new object[] { maBan });
        }

        // ================= XÓA / GIẢM MÓN =================
        public void RemoveMon(int maBan, int maMon)
        {
            string sql = @"
                UPDATE ChiTietHoaDon
                SET SoLuong = SoLuong - 1
                WHERE MaHD = (
                    SELECT TOP 1 MaHD FROM HoaDon
                    WHERE MaBan = @p0 AND TrangThai = N'ChuaThanhToan'
                    ORDER BY MaHD DESC
                )
                AND MaMon = @p1;

                DELETE FROM ChiTietHoaDon
                WHERE SoLuong <= 0";

            dp.ExecuteNonQuery(sql, new object[] { maBan, maMon });
        }

        // ================= THANH TOÁN =================
        public void ThanhToan(int maHD, decimal tongTien, decimal giam, decimal phuThu)
        {
            string sql = @"
                UPDATE HoaDon
                SET TongTien = @p1,
                    GiamGia = @p2,
                    PhuThu = @p3,
                    TrangThai = N'DaThanhToan'
                WHERE MaHD = @p0";

            dp.ExecuteNonQuery(sql, new object[] { maHD, tongTien, giam, phuThu });
        }

        public void TangSoLuong(int maBan, int maMon)
        {
            string sql = @"
    UPDATE ChiTietHoaDon
    SET SoLuong = SoLuong + 1
    WHERE MaHD = (
        SELECT TOP 1 MaHD FROM HoaDon
        WHERE MaBan = @p0 AND TrangThai = N'ChuaThanhToan'
        ORDER BY MaHD DESC
    ) AND MaMon = @p1";

            dp.ExecuteNonQuery(sql, new object[] { maBan, maMon });
        }

        public void GiamSoLuong(int maBan, int maMon)
        {
            string sql = @"
    UPDATE ChiTietHoaDon
    SET SoLuong = SoLuong - 1
    WHERE MaHD = (
        SELECT TOP 1 MaHD FROM HoaDon
        WHERE MaBan = @p0 AND TrangThai = N'ChuaThanhToan'
        ORDER BY MaHD DESC
    ) AND MaMon = @p1;

    DELETE FROM ChiTietHoaDon
    WHERE SoLuong <= 0";

            dp.ExecuteNonQuery(sql, new object[] { maBan, maMon });
        }
    }
}