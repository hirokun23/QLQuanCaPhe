using QuanLyQuanCafe.Data;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyQuanCafe.DAO
{
    public class TaiKhoanDAO
    {
        DataProvider dp = new DataProvider();

        public DataTable GetAll()
        {
            string query = "SELECT TenDangNhap, MatKhau, ChucVu, Email FROM TaiKhoan";
            return dp.ExecuteQuery(query, null); // Truyền null vì không có tham số
        }

        public int Insert(string tenDN, string matKhau, string chucVu, string email)
        {
            string query = "INSERT INTO TaiKhoan(TenDangNhap, MatKhau, ChucVu, Email) VALUES(@p0, @p1, @p2, @p3)";
            return dp.ExecuteNonQuery(query, new object[] { tenDN, matKhau, chucVu, email });
        }

        public int Update(string tenDN, string matKhau, string chucVu, string email)
        {
            // Sửa mật khẩu, chức vụ và email dựa trên tên đăng nhập
            string query = "UPDATE TaiKhoan SET MatKhau=@p0, ChucVu=@p1, Email=@p2 WHERE TenDangNhap=@p3";
            return dp.ExecuteNonQuery(query, new object[] { matKhau, chucVu, email, tenDN });
        }

        public int Delete(string tenDN)
        {
            string query = "DELETE FROM TaiKhoan WHERE TenDangNhap=@p0";
            return dp.ExecuteNonQuery(query, new object[] { tenDN });
        }

        public bool UpdatePassword(string user, string pass)
        {
            string sql = $"UPDATE TaiKhoan SET MatKhau = N'{pass}' WHERE TenDangNhap = N'{user}'";
            return dp.ExecuteNonQuery(sql) > 0;
        }

        public string GetUserByEmail(string email)
        {
            string sql = "SELECT TenDangNhap FROM TaiKhoan WHERE Email = @p0";
            DataTable dt = dp.ExecuteQuery(sql, new object[] { email });

            if (dt.Rows.Count == 0) return null;

            return dt.Rows[0]["TenDangNhap"].ToString();
        }
    }
}