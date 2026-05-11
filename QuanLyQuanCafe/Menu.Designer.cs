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
            this.dgvMon = new System.Windows.Forms.DataGridView();
            this.txtMaMon = new System.Windows.Forms.TextBox();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.cboLoai = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lblMa = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblGia = new System.Windows.Forms.Label();
            this.lblLoai = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMon
            // 
            this.dgvMon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMon.Location = new System.Drawing.Point(20, 20);
            this.dgvMon.Name = "dgvMon";
            this.dgvMon.Size = new System.Drawing.Size(600, 200);
            this.dgvMon.TabIndex = 0;
            this.dgvMon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMon_CellClick);
            // 
            // txtMaMon
            // 
            this.txtMaMon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMaMon.Location = new System.Drawing.Point(20, 265);
            this.txtMaMon.Name = "txtMaMon";
            this.txtMaMon.ReadOnly = true;
            this.txtMaMon.Size = new System.Drawing.Size(100, 20);
            this.txtMaMon.TabIndex = 1;
            // 
            // txtTenMon
            // 
            this.txtTenMon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTenMon.Location = new System.Drawing.Point(151, 265);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(100, 20);
            this.txtTenMon.TabIndex = 2;
            // 
            // txtGia
            // 
            this.txtGia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtGia.Location = new System.Drawing.Point(280, 265);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(100, 20);
            this.txtGia.TabIndex = 3;
            // 
            // cboLoai
            // 
            this.cboLoai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cboLoai.Items.AddRange(new object[] {
            "Cafe",
            "Trà",
            "Nước",
            "Khác"});
            this.cboLoai.Location = new System.Drawing.Point(420, 265);
            this.cboLoai.Name = "cboLoai";
            this.cboLoai.Size = new System.Drawing.Size(121, 21);
            this.cboLoai.TabIndex = 4;
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThem.BackColor = System.Drawing.Color.Green;
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(80, 320);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSua.BackColor = System.Drawing.Color.Orange;
            this.btnSua.Location = new System.Drawing.Point(230, 320);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(380, 320);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lblMa
            // 
            this.lblMa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMa.Location = new System.Drawing.Point(20, 240);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(100, 23);
            this.lblMa.TabIndex = 8;
            this.lblMa.Text = "Mã";
            // 
            // lblTen
            // 
            this.lblTen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTen.Location = new System.Drawing.Point(148, 240);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(100, 23);
            this.lblTen.TabIndex = 9;
            this.lblTen.Text = "Tên món";
            // 
            // lblGia
            // 
            this.lblGia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblGia.Location = new System.Drawing.Point(280, 240);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(100, 23);
            this.lblGia.TabIndex = 10;
            this.lblGia.Text = "Giá";
            // 
            // lblLoai
            // 
            this.lblLoai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLoai.Location = new System.Drawing.Point(420, 240);
            this.lblLoai.Name = "lblLoai";
            this.lblLoai.Size = new System.Drawing.Size(100, 23);
            this.lblLoai.TabIndex = 11;
            this.lblLoai.Text = "Loại";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 361);
            this.MinimumSize = new System.Drawing.Size(650, 400); // Thêm MinimumSize để form không bị vỡ layout
            this.Controls.Add(this.dgvMon);
            this.Controls.Add(this.txtMaMon);
            this.Controls.Add(this.txtTenMon);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.cboLoai);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.lblMa);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.lblGia);
            this.Controls.Add(this.lblLoai);
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Menu";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}