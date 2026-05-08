using QuanLyQuanCafe.BUS;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class KhoForm : Form
    {
        NguyenLieuBUS bus = new NguyenLieuBUS();

        public KhoForm()
        {
            InitializeComponent();
        }

        private void KhoForm_Load(object sender, EventArgs e)
        {
            dgvKho.DataSource = bus.GetAll();
            dgvKho.DefaultCellStyle.ForeColor = Color.Black;
            dgvKho.DefaultCellStyle.BackColor = Color.White;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int sl;
            if (!int.TryParse(txtSoLuong.Text, out sl))
            {
                MessageBox.Show("Số lượng phải là số!");
                return;
            }

            bus.Insert(txtMaNL.Text, txtTenNL.Text, sl);
            dgvKho.DataSource = bus.GetAll();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int sl;
            if (!int.TryParse(txtSoLuong.Text, out sl))
                return;

            bus.Update(txtMaNL.Text, txtTenNL.Text, sl);
            dgvKho.DataSource = bus.GetAll();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            bus.Delete(txtMaNL.Text);
            dgvKho.DataSource = bus.GetAll();
        }
    }
}