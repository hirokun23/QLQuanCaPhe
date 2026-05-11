using System;
using System.Data;
using System.Windows.Forms;
using QuanLyQuanCafe.BUS;

namespace QuanLyQuanCafe
{
    public partial class DoanhThuForm : Form
    {
        DoanhThuBUS bus = new DoanhThuBUS();

        public DoanhThuForm()
        {
            InitializeComponent();
            LoadDoanhThu();
        }

        DoanhThuBUS doanhthuBUS = new DoanhThuBUS();

        void LoadDoanhThu()
        {
            DateTime from = dtpFrom.Value;
            DateTime to = dtpTo.Value;

            DataTable dt = bus.LayDoanhThu(from, to);

            dgvDoanhThu.DataSource = dt;

            lblSoHD.Text = dt.Rows.Count.ToString();
            lblTongTien.Text = bus.TongDoanhThu(dt).ToString("N0");
            lblTrungBinh.Text = bus.TrungBinhHoaDon(dt).ToString("N0");
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            LoadDoanhThu();
        }
    }
}