using System.Drawing;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    partial class MenuForm
    {
        private DataGridView dgvMon;
        private TextBox txtMaMon, txtTenMon, txtGia;
        private ComboBox cboLoai;
        private Button btnThem, btnSua, btnXoa;
        private Label lblMa, lblTen, lblGia, lblLoai;

        private void InitializeComponent()
        {
            dgvMon = new DataGridView();
            txtMaMon = new TextBox();
            txtTenMon = new TextBox();
            txtGia = new TextBox();
            cboLoai = new ComboBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            lblMa = new Label();
            lblTen = new Label();
            lblGia = new Label();
            lblLoai = new Label();

            this.Text = "Quản Lý Menu";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(650, 400);
            this.Load += new System.EventHandler(this.MenuForm_Load);

            dgvMon.Location = new Point(20, 20);
            dgvMon.Size = new Size(600, 200);
            dgvMon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMon.CellClick += new DataGridViewCellEventHandler(this.dgvMon_CellClick);

            lblMa.Text = "Mã"; lblMa.Location = new Point(20, 240);
            txtMaMon.Location = new Point(20, 265); txtMaMon.ReadOnly = true;

            lblTen.Text = "Tên món"; lblTen.Location = new Point(120, 240);
            txtTenMon.Location = new Point(120, 265);

            lblGia.Text = "Giá"; lblGia.Location = new Point(280, 240);
            txtGia.Location = new Point(280, 265);

            lblLoai.Text = "Loại"; lblLoai.Location = new Point(420, 240);
            cboLoai.Location = new Point(420, 265);
            cboLoai.Items.AddRange(new object[] { "Cafe", "Trà", "Nước", "Khác" });
            cboLoai.SelectedIndex = 0;

            btnThem.Text = "Thêm"; btnThem.Location = new Point(80, 320);
            btnThem.BackColor = Color.Green; btnThem.ForeColor = Color.White;
            btnThem.Click += new System.EventHandler(this.btnThem_Click);

            btnSua.Text = "Sửa"; btnSua.Location = new Point(230, 320);
            btnSua.BackColor = Color.Orange;
            btnSua.Click += new System.EventHandler(this.btnSua_Click);

            btnXoa.Text = "Xóa"; btnXoa.Location = new Point(380, 320);
            btnXoa.BackColor = Color.Red; btnXoa.ForeColor = Color.White;
            btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            this.Controls.AddRange(new Control[] {
                dgvMon, txtMaMon, txtTenMon, txtGia, cboLoai,
                btnThem, btnSua, btnXoa,
                lblMa, lblTen, lblGia, lblLoai
            });
        }
    }
}