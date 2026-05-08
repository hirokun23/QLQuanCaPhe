using QuanLyQuanCafe.Data;
using System.Data;

namespace QuanLyQuanCafe.DAO
{
    public class MonDAO
    {
        DataProvider dp = new DataProvider();

        public DataTable GetAll()
        {
            string query = "SELECT MaMon, TenMon, Gia, Loai FROM Mon";
            return dp.ExecuteQuery(query, null);
        }

        public int Insert(string ten, float gia, string loai)
        {
            string query = "INSERT INTO Mon(TenMon, Gia, Loai) VALUES(@p0,@p1,@p2)";
            return dp.ExecuteNonQuery(query, new object[] { ten, gia, loai });
        }

        public int Update(int ma, string ten, float gia, string loai)
        {
            string query = "UPDATE Mon SET TenMon=@p0, Gia=@p1, Loai=@p2 WHERE MaMon=@p3";
            return dp.ExecuteNonQuery(query, new object[] { ten, gia, loai, ma });
        }

        public int Delete(int ma)
        {
            string query = "DELETE FROM Mon WHERE MaMon=@p0";
            return dp.ExecuteNonQuery(query, new object[] { ma });
        }
    }
}