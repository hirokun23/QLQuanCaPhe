using QuanLyQuanCafe.Data;
using System;
using System.Data;

public class DoanhThuDAO
{
    DataProvider dp = new DataProvider();

    public DataTable GetDoanhThu(DateTime from, DateTime to)
    {
        string sql = @"
            SELECT 
                NgayLap,
                TongTien,
                GiamGia,
                PhuThu,
                (TongTien - GiamGia + PhuThu) AS ThanhTien
            FROM HoaDon
            WHERE NgayLap BETWEEN @p0 AND @p1
        ";

        return dp.ExecuteQuery(sql, new object[] { from, to });
    }
}