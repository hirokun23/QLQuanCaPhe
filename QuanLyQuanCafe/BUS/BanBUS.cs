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

            // INSERT
            public void Insert(string tenBan, string trangThai)
            {
                dao.Insert(tenBan, trangThai);
            }

            // UPDATE
            public void Update(int maBan, string tenBan, string trangThai)
            {
                dao.Update(maBan, tenBan, trangThai);
            }

            // DELETE
            public void Delete(int maBan)
            {
                dao.Delete(maBan);
            }

            // UPDATE TRẠNG THÁI
            public void UpdateTrangThai(int maBan, string trangThai)
            {
                dao.UpdateTrangThai(maBan, trangThai);
            }
        }
    }