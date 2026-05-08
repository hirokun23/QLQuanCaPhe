using QuanLyQuanCafe.DAO;
using System.Data;

namespace QuanLyQuanCafe.BUS
{
    public class BanBUS
    {
        BanDAO dao = new BanDAO();

        public DataTable GetAll()
        {
            return dao.GetAll();
        }

        public void Insert(string ten, string trangThai)
        {
            if (ten == "") return;
            dao.Insert(ten, trangThai);
        }

        public void Update(int ma, string ten, string trangThai)
        {
            dao.Update(ma, ten, trangThai);
        }

        public void Delete(int ma)
        {
            dao.Delete(ma);
        }
    }
}