using QuanLyQuanCafe.Data;
using System.Data;

namespace QuanLyQuanCafe.DAO
{
    public class MonDAO
    {
        DataProvider dp = new DataProvider();

        public DataTable GetAll()
        {
            string query = "SELECT MaMon, TenMon, Gia, Loai, HinhAnh FROM Mon";
            return dp.ExecuteQuery(query, null);
        }

        public int Insert(string ten, float gia, string loai, string hinhAnh)
        {
            string query = "INSERT INTO Mon(TenMon, Gia, Loai, HinhAnh) VALUES(@p0,@p1,@p2,@p3)";
            return dp.ExecuteNonQuery(query, new object[] { ten, gia, loai, hinhAnh });
        }

        public int Update(int ma, string ten, float gia, string loai, string hinhAnh)
        {
            string query = "UPDATE Mon SET TenMon=@p0, Gia=@p1, Loai=@p2, HinhAnh=@p3 WHERE MaMon=@p4";

            return dp.ExecuteNonQuery(query,
                new object[] { ten, gia, loai, hinhAnh, ma });
        }

        public int Delete(int ma)
        {
            string query = "DELETE FROM Mon WHERE MaMon=@p0";
            return dp.ExecuteNonQuery(query, new object[] { ma });
        }
    }
}