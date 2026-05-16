using System.Data;
using QuanLyQuanCafe.DAO;

namespace QuanLyQuanCafe.BUS
{
    public class CongThucBUS
    {
        CongThucDAO dao = new CongThucDAO();

        public DataTable GetAll()
        {
            return dao.GetAll();
        }

        public DataTable GetByMaMon(int maMon) => dao.GetByMaMon(maMon);

        public bool Insert(int maMon, string maNL, double soLuong) => dao.Insert(maMon, maNL, soLuong) > 0;

        public bool Update(int maMon, string maNL, double soLuong) => dao.Update(maMon, maNL, soLuong) > 0;

        public bool Delete(int maMon, string maNL) => dao.Delete(maMon, maNL) > 0;
    }
}