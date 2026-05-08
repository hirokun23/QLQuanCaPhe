using QuanLyQuanCafe.Data;
using System.Data;

namespace QuanLyQuanCafe.DAO
{
    public class NguyenLieuDAO
    {
        DataProvider dp = new DataProvider();

        public DataTable GetAll()
        {
            string query = "SELECT MaNL, TenNL, SoLuong FROM NguyenLieu";
            return dp.ExecuteQuery(query, null); // ✅ thêm null
        }

        public int Insert(string ma, string ten, int sl)
        {
            string query = "INSERT INTO NguyenLieu(MaNL, TenNL, SoLuong) VALUES(@p0,@p1,@p2)";
            return dp.ExecuteNonQuery(query, new object[] { ma, ten, sl });
        }

        public int Update(string ma, string ten, int sl)
        {
            string query = "UPDATE NguyenLieu SET TenNL=@p0, SoLuong=@p1 WHERE MaNL=@p2";
            return dp.ExecuteNonQuery(query, new object[] { ten, sl, ma });
        }

        public int Delete(string ma)
        {
            string query = "DELETE FROM NguyenLieu WHERE MaNL=@p0";
            return dp.ExecuteNonQuery(query, new object[] { ma });
        }
    }
}