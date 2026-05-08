using QuanLyQuanCafe.DAO;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyQuanCafe.BUS
{
    public class GoiMonBUS
    {
        GoiMonDAO dao = new GoiMonDAO();

        public DataTable GetMenu()
        {
            return dao.GetMenu();
        }

        public void ThanhToan(
            int maBan,
            DataGridView dgv,
            float tongTien)
        {
            // thêm hóa đơn
            dao.InsertHoaDon(maBan, tongTien);

            // lấy mã hóa đơn mới nhất
            DataTable dt = dao.GetLastHoaDon();

            int maHD =
                int.Parse(dt.Rows[0]["MaHD"].ToString());

            // thêm chi tiết
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    int maMon =
                        Convert.ToInt32(row.Cells[0].Value);

                    int soLuong =
                        Convert.ToInt32(row.Cells[3].Value);

                    float gia =
                        Convert.ToSingle(row.Cells[2].Value);

                    dao.InsertChiTiet(
                        maHD,
                        maMon,
                        soLuong,
                        gia
                    );
                }
            }
        }
    }
}