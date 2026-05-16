using QuanLyQuanCafe.Data;
using QuanLyQuanCafe.DTO;
using System.Data;

namespace QuanLyQuanCafe.DAO
{
    public class LoginDAO
    {
        DataProvider dp = new DataProvider();

        public LoginDTO Login(string user, string pass)
        {
            string query =
            @"SELECT 
                nv.TenNV,
                tk.ChucVu
            FROM TaiKhoan tk
            LEFT JOIN NhanVien nv
            ON tk.TenDangNhap = nv.TenDangNhap
            WHERE tk.TenDangNhap = @p0
            AND tk.MatKhau = @p1";

            DataTable dt =
                dp.ExecuteQuery(
                    query,
                    new object[]
                    {
                        user,
                        pass
                    });

            if (dt.Rows.Count > 0)
            {
                LoginDTO dto = new LoginDTO();

                dto.TenNV =
                    dt.Rows[0]["TenNV"].ToString();

                dto.ChucVu =
                    dt.Rows[0]["ChucVu"].ToString();

                return dto;
            }

            return null;
        }
    }
}