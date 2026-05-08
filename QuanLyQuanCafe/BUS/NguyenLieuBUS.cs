using System.Data;
using QuanLyQuanCafe.DAO;

namespace QuanLyQuanCafe.BUS
{
    public class NguyenLieuBUS
    {
        NguyenLieuDAO dao = new NguyenLieuDAO();

        public DataTable GetAll()
        {
            return dao.GetAll();
        }

        public void Insert(string ma, string ten, int sl)
        {
            if (ma == "" || ten == "")
                return;

            dao.Insert(ma, ten, sl);
        }

        public void Update(string ma, string ten, int sl)
        {
            dao.Update(ma, ten, sl);
        }

        public void Delete(string ma)
        {
            dao.Delete(ma);
        }
    }
}