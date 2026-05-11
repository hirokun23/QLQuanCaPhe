using QuanLyQuanCafe.Data;
using System.Data;

namespace QuanLyQuanCafe.DAO
{
    public class BanDAO
    {
        DataProvider dp = new DataProvider();

        // LẤY TẤT CẢ BÀN
        public DataTable GetAll()
        {
            return dp.ExecuteQuery("SELECT * FROM Ban");
        }

        // THÊM BÀN
        public void Insert(string tenBan, string trangThai)
        {
            string sql = "INSERT INTO Ban(TenBan, TrangThai) VALUES(@p0, @p1)";
            dp.ExecuteNonQuery(sql, new object[] { tenBan, trangThai });
        }

        // CẬP NHẬT BÀN
        public void Update(int maBan, string tenBan, string trangThai)
        {
            string sql = "UPDATE Ban SET TenBan=@p0, TrangThai=@p1 WHERE MaBan=@p2";
            dp.ExecuteNonQuery(sql, new object[] { tenBan, trangThai, maBan });
        }

        // XÓA BÀN
        public void Delete(int maBan)
        {
            string sql = "DELETE FROM Ban WHERE MaBan=@p0";
            dp.ExecuteNonQuery(sql, new object[] { maBan });
        }

        // CẬP NHẬT TRẠNG THÁI
        public void UpdateTrangThai(int maBan, string trangThai)
        {
            string sql = "UPDATE Ban SET TrangThai=@p0 WHERE MaBan=@p1";
            dp.ExecuteNonQuery(sql, new object[] { trangThai, maBan });
        }
    }
}