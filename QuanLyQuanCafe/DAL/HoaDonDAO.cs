using System;
using System.Data;
using QuanLyQuanCafe.Data;

namespace QuanLyQuanCafe.DAO
{
    public class HoaDonDAO
    {
        DataProvider dp = new DataProvider();

        public DataTable GetDoanhThu(DateTime tu, DateTime den)
        {
            string query = "SELECT * FROM HoaDon WHERE Ngay BETWEEN @p0 AND @p1";
            return dp.ExecuteQuery(query, new object[] { tu, den });
        }
    }
}