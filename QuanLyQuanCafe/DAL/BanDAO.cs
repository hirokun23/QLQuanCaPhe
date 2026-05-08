using QuanLyQuanCafe.Data;
using System.Data;

namespace QuanLyQuanCafe.DAO
{
    public class BanDAO
    {
        DataProvider dp = new DataProvider();

        public DataTable GetAll()
        {
            string query = "SELECT MaBan, TenBan, TrangThai FROM Ban";
            return dp.ExecuteQuery(query, null);
        }

        public int Insert(string ten, string trangThai)
        {
            string query = "INSERT INTO Ban(TenBan, TrangThai) VALUES(@p0,@p1)";
            return dp.ExecuteNonQuery(query, new object[] { ten, trangThai });
        }

        public int Update(int ma, string ten, string trangThai)
        {
            string query = "UPDATE Ban SET TenBan=@p0, TrangThai=@p1 WHERE MaBan=@p2";
            return dp.ExecuteNonQuery(query, new object[] { ten, trangThai, ma });
        }

        public int Delete(int ma)
        {
            string query = "DELETE FROM Ban WHERE MaBan=@p0";
            return dp.ExecuteNonQuery(query, new object[] { ma });
        }
    }
}