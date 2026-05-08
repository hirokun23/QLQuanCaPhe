using QuanLyQuanCafe.DTO;
using QuanLyQuanCafe.Data;
using System.Data;

namespace QuanLyQuanCafe.BUS
{
    public class NhanVienBUS
    {
        NhanVienDAO dao = new NhanVienDAO();
        public NhanVienDTO info;

        public DataTable getDSNhanVien()
        {
            return dao.getAll();
        }

        public bool insert()
        {
            return dao.insert(info) > 0;
        }

        public bool update()
        {
            return dao.update(info) > 0;
        }

        public bool delete()
        {
            return dao.delete(info.MaNV) > 0;
        }
    }
}