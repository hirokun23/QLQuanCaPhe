using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.DTO;

namespace QuanLyQuanCafe.BUS
{
    public class LoginBUS
    {
        LoginDAO dao = new LoginDAO();

        public LoginDTO Login(string user, string pass)
        {
            return dao.Login(user, pass);
        }
    }
}