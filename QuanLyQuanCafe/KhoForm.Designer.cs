using System.Drawing;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    partial class KhoForm
    {
        private System.ComponentModel.IContainer components = null;

        private DataGridView dgvKho;
        private TextBox txtMaNL;
        private TextBox txtTenNL;
        private TextBox txtSoLuong;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvKho = new DataGridView();
            this.txtMaNL = new TextBox();
            this.txtTenNL = new TextBox();
            this.txtSoLuong = new TextBox();
            this.btnThem = new Button();
            this.btnSua = new Button();
            this.btnXoa = new Button();

            this.SuspendLayout();

            // FORM
            this.Text = "Quản lý Kho";
            this.Size = new Size(600, 400);
            this.BackColor = Color.White;

            // dgvKho
            dgvKho.Location = new Point(20, 20);
            dgvKho.Size = new Size(540, 200);
            dgvKho.BackgroundColor = Color.White;
            dgvKho.ForeColor = Color.Black;

            // txtMaNL
            txtMaNL.Location = new Point(20, 240);
            txtMaNL.Size = new Size(150, 25);
            txtMaNL.Text = "Mã nguyên liệu";

            // txtTenNL
            txtTenNL.Location = new Point(200, 240);
            txtTenNL.Size = new Size(150, 25);
            txtTenNL.Text = "Tên nguyên liệu";

            // txtSoLuong
            txtSoLuong.Location = new Point(380, 240);
            txtSoLuong.Size = new Size(100, 25);
            txtSoLuong.Text = "Số lượng";

            // btnThem
            btnThem.Text = "Thêm";
            btnThem.Location = new Point(20, 280);
            btnThem.BackColor = Color.Green;
            btnThem.ForeColor = Color.White;
            btnThem.Click += new System.EventHandler(this.btnThem_Click);

            // btnSua
            btnSua.Text = "Sửa";
            btnSua.Location = new Point(120, 280);
            btnSua.BackColor = Color.Orange;
            btnSua.ForeColor = Color.White;
            btnSua.Click += new System.EventHandler(this.btnSua_Click);

            // btnXoa
            btnXoa.Text = "Xóa";
            btnXoa.Location = new Point(220, 280);
            btnXoa.BackColor = Color.Red;
            btnXoa.ForeColor = Color.White;
            btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            // ADD CONTROL
            this.Controls.Add(dgvKho);
            this.Controls.Add(txtMaNL);
            this.Controls.Add(txtTenNL);
            this.Controls.Add(txtSoLuong);
            this.Controls.Add(btnThem);
            this.Controls.Add(btnSua);
            this.Controls.Add(btnXoa);

            this.Load += new System.EventHandler(this.KhoForm_Load);
            this.ResumeLayout(false);
        }
    }
}