using System;
using System.Data;
using System.Windows.Forms;
using QuanLyQuanCafe.BUS;

namespace QuanLyQuanCafe
{
    public partial class DoanhThuForm : Form
    {
        HoaDonBUS bus = new HoaDonBUS();

        public DoanhThuForm()
        {
            InitializeComponent();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            DataTable dt = bus.GetDoanhThu(dtTuNgay.Value, dtDenNgay.Value);
            dgvDoanhThu.DataSource = dt;

            decimal tong = 0;
            foreach (DataRow row in dt.Rows)
            {
                tong += Convert.ToDecimal(row["TongTien"]);
            }

            lblTongTien.Text = "Tổng tiền: " + tong.ToString("N0") + " VND";
        }
    }
}