using System.Drawing;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    partial class BanForm
    {
        private DataGridView dgvBan;
        private TextBox txtMaBan;
        private TextBox txtTenBan;
        private ComboBox cboTrangThai;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Label lblMa, lblTen, lblTrangThai;

        private void InitializeComponent()
        {
            dgvBan = new DataGridView();
            txtMaBan = new TextBox();
            txtTenBan = new TextBox();
            cboTrangThai = new ComboBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            lblMa = new Label();
            lblTen = new Label();
            lblTrangThai = new Label();

            this.Text = "Quản Lý Bàn";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(600, 380);
            this.MinimumSize = new Size(600, 380); // Thêm giới hạn thu nhỏ để không vỡ form
            this.Load += new System.EventHandler(this.BanForm_Load);

            // Cấu hình DataGridView
            dgvBan.Location = new Point(20, 20);
            dgvBan.Size = new Size(550, 200);
            dgvBan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // Neo 4 góc để tự mở rộng khi kéo dãn form
            dgvBan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvBan.CellClick += new DataGridViewCellEventHandler(this.dgvBan_CellClick);

            // Cấu hình thông tin Mã bàn
            lblMa.Text = "Mã bàn";
            lblMa.Location = new Point(20, 240);
            lblMa.Anchor = AnchorStyles.Bottom | AnchorStyles.Left; // Neo dưới trái

            txtMaBan.Location = new Point(20, 265);
            txtMaBan.ReadOnly = true;
            txtMaBan.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;

            // Cấu hình thông tin Tên bàn
            lblTen.Text = "Tên bàn";
            lblTen.Location = new Point(150, 240);
            lblTen.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;

            txtTenBan.Location = new Point(150, 265);
            txtTenBan.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;

            // Cấu hình thông tin Trạng thái
            lblTrangThai.Text = "Trạng thái";
            lblTrangThai.Location = new Point(320, 240);
            lblTrangThai.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;

            cboTrangThai.Location = new Point(320, 265);
            cboTrangThai.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cboTrangThai.Items.AddRange(new object[] { "Trống", "Có khách" });
            cboTrangThai.SelectedIndex = 0;

            // Cấu hình các nút chức năng
            btnThem.Text = "Thêm";
            btnThem.Location = new Point(50, 310);
            btnThem.BackColor = Color.Green;
            btnThem.ForeColor = Color.White;
            btnThem.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnThem.Click += new System.EventHandler(this.btnThem_Click);

            btnSua.Text = "Sửa";
            btnSua.Location = new Point(200, 310);
            btnSua.BackColor = Color.Orange;
            btnSua.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSua.Click += new System.EventHandler(this.btnSua_Click);

            btnXoa.Text = "Xóa";
            btnXoa.Location = new Point(350, 310);
            btnXoa.BackColor = Color.Red;
            btnXoa.ForeColor = Color.White;
            btnXoa.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            this.Controls.AddRange(new Control[] {
                dgvBan, txtMaBan, txtTenBan, cboTrangThai,
                btnThem, btnSua, btnXoa,
                lblMa, lblTen, lblTrangThai
            });
        }
    }
}