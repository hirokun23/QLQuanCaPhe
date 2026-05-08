using System;
using System.Data;
using System.Windows.Forms;
using QuanLyQuanCafe.BUS;

namespace QuanLyQuanCafe
{
    public partial class MenuForm : Form
    {
        MonBUS bus = new MonBUS();

        public MenuForm()
        {
            InitializeComponent();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            LoadMon();
        }

        void LoadMon()
        {
            dgvMon.DataSource = bus.GetAll();

            txtMaMon.Clear();
            txtTenMon.Clear();
            txtGia.Clear();
            cboLoai.SelectedIndex = 0;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenMon.Text == "" || txtGia.Text == "")
            {
                MessageBox.Show("Nhập đầy đủ thông tin 😏");
                return;
            }

            float gia = float.Parse(txtGia.Text);
            bus.Insert(txtTenMon.Text, gia, cboLoai.Text);

            MessageBox.Show("Thêm thành công");
            LoadMon();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int ma = int.Parse(txtMaMon.Text);
            float gia = float.Parse(txtGia.Text);

            bus.Update(ma, txtTenMon.Text, gia, cboLoai.Text);

            MessageBox.Show("Sửa thành công");
            LoadMon();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int ma = int.Parse(txtMaMon.Text);
            bus.Delete(ma);

            MessageBox.Show("Xóa thành công");
            LoadMon();
        }

        private void dgvMon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMaMon.Text = dgvMon.Rows[e.RowIndex].Cells["MaMon"].Value.ToString();
                txtTenMon.Text = dgvMon.Rows[e.RowIndex].Cells["TenMon"].Value.ToString();
                txtGia.Text = dgvMon.Rows[e.RowIndex].Cells["Gia"].Value.ToString();
                cboLoai.Text = dgvMon.Rows[e.RowIndex].Cells["Loai"].Value.ToString();
            }
        }
    }
}