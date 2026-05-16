using QuanLyQuanCafe.Data;
using System.Data;

namespace QuanLyQuanCafe.DAO
{
    public class CongThucDAO
    {
        DataProvider dp = new DataProvider();

        public DataTable GetAll()
        {
            // Query này lấy đầy đủ tên món và tên nguyên liệu để hiển thị cho đẹp
            string query = @"SELECT ct.MaMon, m.TenMon, ct.MaNL, nl.TenNL, ct.SoLuong 
                     FROM CongThuc ct 
                     JOIN Mon m ON ct.MaMon = m.MaMon 
                     JOIN NguyenLieu nl ON ct.MaNL = nl.MaNL";
            return dp.ExecuteQuery(query);
        }

        // Lấy danh sách nguyên liệu theo mã món
        public DataTable GetByMaMon(int maMon)
        {
            string query = "SELECT ct.MaNL, nl.TenNL, ct.SoLuong FROM CongThuc ct " +
                           "JOIN NguyenLieu nl ON ct.MaNL = nl.MaNL WHERE ct.MaMon = @p0";
            return dp.ExecuteQuery(query, new object[] { maMon });
        }

        public int Insert(int maMon, string maNL, double soLuong)
        {
            string query = "INSERT INTO CongThuc(MaMon, MaNL, SoLuong) VALUES(@p0, @p1, @p2)";
            return dp.ExecuteNonQuery(query, new object[] { maMon, maNL, soLuong });
        }

        public int Update(int maMon, string maNL, double soLuong)
        {
            string query = "UPDATE CongThuc SET SoLuong = @p0 WHERE MaMon = @p1 AND MaNL = @p2";
            return dp.ExecuteNonQuery(query, new object[] { soLuong, maMon, maNL });
        }

        public int Delete(int maMon, string maNL)
        {
            string query = "DELETE FROM CongThuc WHERE MaMon = @p0 AND MaNL = @p1";
            return dp.ExecuteNonQuery(query, new object[] { maMon, maNL });
        }
    }
}