using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    partial class OrderForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.flowLayoutPanelTable = new System.Windows.Forms.FlowLayoutPanel();
            this.panelRight = new Guna.UI2.WinForms.Guna2Panel();
            this.txtTable = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpCreated = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtExtra = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDiscount = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cboStaff = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dgvBill = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTotal = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnPay = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.flowLayoutPanelMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.cboLoai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.btnMinus = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanelTable
            // 
            this.flowLayoutPanelTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanelTable.AutoScroll = true;
            this.flowLayoutPanelTable.Location = new System.Drawing.Point(10, 10);
            this.flowLayoutPanelTable.Name = "flowLayoutPanelTable";
            this.flowLayoutPanelTable.Size = new System.Drawing.Size(329, 651);
            this.flowLayoutPanelTable.TabIndex = 0;
            // 
            // panelRight
            // 
            this.panelRight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRight.AutoScroll = true;
            this.panelRight.BorderColor = System.Drawing.Color.LightGray;
            this.panelRight.BorderRadius = 10;
            this.panelRight.BorderThickness = 1;
            this.panelRight.Controls.Add(this.txtTable);
            this.panelRight.Controls.Add(this.label1);
            this.panelRight.Controls.Add(this.dtpCreated);
            this.panelRight.Controls.Add(this.txtExtra);
            this.panelRight.Controls.Add(this.txtDiscount);
            this.panelRight.Controls.Add(this.label6);
            this.panelRight.Controls.Add(this.label5);
            this.panelRight.Controls.Add(this.label4);
            this.panelRight.Controls.Add(this.label3);
            this.panelRight.Controls.Add(this.label2);
            this.panelRight.Controls.Add(this.lblTitle);
            this.panelRight.Controls.Add(this.cboStaff);
            this.panelRight.Controls.Add(this.dgvBill);
            this.panelRight.Controls.Add(this.txtTotal);
            this.panelRight.Controls.Add(this.btnPay);
            this.panelRight.Controls.Add(this.btnCancel);
            this.panelRight.FillColor = System.Drawing.Color.White;
            this.panelRight.Location = new System.Drawing.Point(684, 10);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(368, 637);
            this.panelRight.TabIndex = 1;
            // 
            // txtTable
            // 
            this.txtTable.BorderRadius = 6;
            this.txtTable.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTable.DefaultText = "";
            this.txtTable.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTable.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTable.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTable.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTable.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTable.Location = new System.Drawing.Point(97, 65);
            this.txtTable.Name = "txtTable";
            this.txtTable.PlaceholderText = "";
            this.txtTable.ReadOnly = true;
            this.txtTable.SelectedText = "";
            this.txtTable.Size = new System.Drawing.Size(246, 30);
            this.txtTable.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(24, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Thời gian :";
            // 
            // dtpCreated
            // 
            this.dtpCreated.BorderRadius = 6;
            this.dtpCreated.Checked = true;
            this.dtpCreated.Enabled = false;
            this.dtpCreated.FillColor = System.Drawing.Color.White;
            this.dtpCreated.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpCreated.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCreated.Location = new System.Drawing.Point(97, 101);
            this.dtpCreated.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpCreated.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpCreated.Name = "dtpCreated";
            this.dtpCreated.ShowUpDown = true;
            this.dtpCreated.Size = new System.Drawing.Size(246, 30);
            this.dtpCreated.TabIndex = 23;
            this.dtpCreated.Value = new System.DateTime(2026, 5, 13, 0, 0, 0, 0);
            // 
            // txtExtra
            // 
            this.txtExtra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtExtra.BorderRadius = 6;
            this.txtExtra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtExtra.DefaultText = "";
            this.txtExtra.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtExtra.Location = new System.Drawing.Point(247, 488);
            this.txtExtra.Name = "txtExtra";
            this.txtExtra.PlaceholderText = "";
            this.txtExtra.SelectedText = "";
            this.txtExtra.Size = new System.Drawing.Size(96, 30);
            this.txtExtra.TabIndex = 22;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDiscount.BorderRadius = 6;
            this.txtDiscount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiscount.DefaultText = "";
            this.txtDiscount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDiscount.Location = new System.Drawing.Point(115, 488);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.PlaceholderText = "";
            this.txtDiscount.SelectedText = "";
            this.txtDiscount.Size = new System.Drawing.Size(65, 30);
            this.txtDiscount.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(186, 498);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "Phụ thu :";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 537);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 18);
            this.label5.TabIndex = 18;
            this.label5.Text = "Tổng tiền : ";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 498);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Giảm giá (%) :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(24, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Số Bàn :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(24, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nhân viên :";
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(7, 3);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(150, 23);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Chi tiết hóa đơn";
            // 
            // cboStaff
            // 
            this.cboStaff.BackColor = System.Drawing.Color.Transparent;
            this.cboStaff.BorderRadius = 6;
            this.cboStaff.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboStaff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStaff.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboStaff.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboStaff.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboStaff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboStaff.ItemHeight = 24;
            this.cboStaff.Location = new System.Drawing.Point(97, 29);
            this.cboStaff.Name = "cboStaff";
            this.cboStaff.Size = new System.Drawing.Size(246, 30);
            this.cboStaff.TabIndex = 2;
            // 
            // dgvBill
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvBill.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBill.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBill.ColumnHeadersHeight = 30;
            this.dgvBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBill.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBill.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBill.Location = new System.Drawing.Point(10, 147);
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.RowHeadersVisible = false;
            this.dgvBill.Size = new System.Drawing.Size(346, 328);
            this.dgvBill.TabIndex = 6;
            this.dgvBill.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBill.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvBill.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvBill.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvBill.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvBill.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvBill.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBill.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgvBill.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvBill.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBill.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvBill.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBill.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvBill.ThemeStyle.ReadOnly = false;
            this.dgvBill.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBill.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBill.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBill.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvBill.ThemeStyle.RowsStyle.Height = 22;
            this.dgvBill.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBill.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvBill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBill_CellClick);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "STT";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Tên Món";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "SL";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Giá Tiền";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTotal.BorderRadius = 6;
            this.txtTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotal.DefaultText = "0";
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtTotal.ForeColor = System.Drawing.Color.Red;
            this.txtTotal.Location = new System.Drawing.Point(123, 524);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.PlaceholderText = "";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.SelectedText = "";
            this.txtTotal.Size = new System.Drawing.Size(220, 42);
            this.txtTotal.TabIndex = 9;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnPay
            // 
            this.btnPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPay.BorderRadius = 8;
            this.btnPay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Location = new System.Drawing.Point(10, 572);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(160, 38);
            this.btnPay.TabIndex = 10;
            this.btnPay.Text = "Thanh toán";
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.BorderRadius = 8;
            this.btnCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(183, 572);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(160, 38);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Hủy hóa đơn";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // flowLayoutPanelMenu
            // 
            this.flowLayoutPanelMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelMenu.AutoScroll = true;
            this.flowLayoutPanelMenu.Location = new System.Drawing.Point(358, 46);
            this.flowLayoutPanelMenu.Name = "flowLayoutPanelMenu";
            this.flowLayoutPanelMenu.Size = new System.Drawing.Size(296, 546);
            this.flowLayoutPanelMenu.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(355, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Danh mục :";
            // 
            // cboLoai
            // 
            this.cboLoai.BackColor = System.Drawing.Color.Transparent;
            this.cboLoai.BorderRadius = 6;
            this.cboLoai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoai.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboLoai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboLoai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboLoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboLoai.ItemHeight = 24;
            this.cboLoai.Location = new System.Drawing.Point(444, 10);
            this.cboLoai.Name = "cboLoai";
            this.cboLoai.Size = new System.Drawing.Size(210, 30);
            this.cboLoai.TabIndex = 2;
            this.cboLoai.SelectedIndexChanged += new System.EventHandler(this.cboLoai_SelectedIndexChanged);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThem.BorderRadius = 6;
            this.btnThem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(358, 608);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(90, 38);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMinus.BorderRadius = 6;
            this.btnMinus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btnMinus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnMinus.ForeColor = System.Drawing.Color.White;
            this.btnMinus.Location = new System.Drawing.Point(459, 608);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(90, 38);
            this.btnMinus.TabIndex = 4;
            this.btnMinus.Text = "Giảm";
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXoa.BorderRadius = 6;
            this.btnXoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(564, 608);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(90, 38);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // OrderForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1104, 661);
            this.Controls.Add(this.flowLayoutPanelMenu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cboLoai);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.flowLayoutPanelTable);
            this.Controls.Add(this.panelRight);
            this.MinimumSize = new System.Drawing.Size(900, 700);
            this.Name = "OrderForm";
            this.Text = "Quản lý quán cà phê ";
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTable;
        private Guna.UI2.WinForms.Guna2Panel panelRight;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2ComboBox cboStaff;
        private Guna.UI2.WinForms.Guna2DataGridView dgvBill;
        private Guna.UI2.WinForms.Guna2TextBox txtTotal;
        private Guna.UI2.WinForms.Guna2Button btnPay;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtDiscount;
        private Guna.UI2.WinForms.Guna2TextBox txtExtra;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMenu;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpCreated;
        private Guna.UI2.WinForms.Guna2TextBox txtTable;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2ComboBox cboLoai;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2Button btnMinus;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
    }
}