using System.Data;
using QuanLyQuanCafe.DAO;

namespace QuanLyQuanCafe.BUS
{
    public class TaiKhoanBUS
    {
        TaiKhoanDAO dao = new TaiKhoanDAO();

        public DataTable GetAll()
        {
            return dao.GetAll();
        }

        public bool Insert(string tenDN, string matKhau, string chucVu, string email)
        {
            // Trả về true nếu số dòng ảnh hưởng > 0
            return dao.Insert(tenDN, matKhau, chucVu, email) > 0;
        }

        public bool Update(string tenDN, string matKhau, string chucVu, string email)
        {
            return dao.Update(tenDN, matKhau, chucVu, email) > 0;
        }

        public bool Delete(string tenDN)
        {
            return dao.Delete(tenDN) > 0;
        }

        public bool UpdatePassword(string user, string pass)
        {
            return dao.UpdatePassword(user, pass);
        }

        public string GetUserByEmail(string email)
        {
            return dao.GetUserByEmail(email);
        }
    }
}