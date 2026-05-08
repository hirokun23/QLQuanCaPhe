using QuanLyQuanCafe.DAO;
using System.Data;

namespace QuanLyQuanCafe.BUS
{
    public class MonBUS
    {
        MonDAO dao = new MonDAO();

        public DataTable GetAll()
        {
            return dao.GetAll();
        }

        public void Insert(string ten, float gia, string loai)
        {
            if (string.IsNullOrWhiteSpace(ten) || gia <= 0) return;
            dao.Insert(ten, gia, loai);
        }

        public void Update(int ma, string ten, float gia, string loai)
        {
            dao.Update(ma, ten, gia, loai);
        }

        public void Delete(int ma)
        {
            dao.Delete(ma);
        }
    }
}