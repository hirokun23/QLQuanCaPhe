using QuanLyQuanCafe.DAO;
using System;
using System.Data;

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
        public string CanhBaoNguyenLieu()
        {
            DataTable dt = dao.GetAll();

            string msg = "";

            foreach (DataRow row in dt.Rows)
            {
                int sl = Convert.ToInt32(row["SoLuong"]);

                if (sl <= 0)
                {
                    msg += row["TenNL"].ToString() + " đã hết!\n";
                }
                else if (sl < 5)
                {
                    msg += row["TenNL"].ToString() + " sắp hết!\n";
                }
            }

            return msg;


        }

    }
}