using System.Windows.Forms;

namespace QuanLyBanHang.Forms
{
    partial class frmHoaDonChiTiet
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            grpThongTinHoaDon = new GroupBox();
            lblNhanVienLap = new Label();
            cboNhanVienLap = new ComboBox();
            lblKhachHang = new Label();
            cboKhachHang = new ComboBox();
            lblGhiChu = new Label();
            txtGhiChuHoaDon = new TextBox();
            grpChiTietHoaDon = new GroupBox();
            lblSanPham = new Label();
            cboSanPham = new ComboBox();
            lblDonGiaBan = new Label();
            numDonGiaBan = new NumericUpDown();
            lblSoLuongBan = new Label();
            numSoLuongBan = new NumericUpDown();
            btnXacNhanBan = new Button();
            btnXoaChiTiet = new Button();
            dgvChiTietHoaDon = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colTenSanPham = new DataGridViewTextBoxColumn();
            colDonGiaBan = new DataGridViewTextBoxColumn();
            colSoLuongBan = new DataGridViewTextBoxColumn();
            colThanhTien = new DataGridViewTextBoxColumn();
            btnLuuHoaDon = new Button();
            btnInHoaDon = new Button();
            btnThoat = new Button();

            grpThongTinHoaDon.SuspendLayout();
            grpChiTietHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDonGiaBan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuongBan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietHoaDon).BeginInit();
            SuspendLayout();

            // grpThongTinHoaDon
            grpThongTinHoaDon.Controls.Add(lblNhanVienLap);
            grpThongTinHoaDon.Controls.Add(cboNhanVienLap);
            grpThongTinHoaDon.Controls.Add(lblKhachHang);
            grpThongTinHoaDon.Controls.Add(cboKhachHang);
            grpThongTinHoaDon.Controls.Add(lblGhiChu);
            grpThongTinHoaDon.Controls.Add(txtGhiChuHoaDon);
            grpThongTinHoaDon.Location = new Point(12, 12);
            grpThongTinHoaDon.Name = "grpThongTinHoaDon";
            grpThongTinHoaDon.Size = new Size(760, 85);
            grpThongTinHoaDon.TabIndex = 0;
            grpThongTinHoaDon.TabStop = false;
            grpThongTinHoaDon.Text = "Thông tin hóa đơn";

            // lblNhanVienLap
            lblNhanVienLap.AutoSize = true;
            lblNhanVienLap.Location = new Point(12, 28);
            lblNhanVienLap.Name = "lblNhanVienLap";
            lblNhanVienLap.Size = new Size(90, 15);
            lblNhanVienLap.TabIndex = 0;
            lblNhanVienLap.Text = "Nhân viên lập (*):";

            // cboNhanVienLap
            cboNhanVienLap.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNhanVienLap.FormattingEnabled = true;
            cboNhanVienLap.Location = new Point(110, 25);
            cboNhanVienLap.Name = "cboNhanVienLap";
            cboNhanVienLap.Size = new Size(200, 23);
            cboNhanVienLap.TabIndex = 1;

            // lblKhachHang
            lblKhachHang.AutoSize = true;
            lblKhachHang.Location = new Point(360, 28);
            lblKhachHang.Name = "lblKhachHang";
            lblKhachHang.Size = new Size(80, 15);
            lblKhachHang.TabIndex = 2;
            lblKhachHang.Text = "Khách hàng (*):";

            // cboKhachHang
            cboKhachHang.DropDownStyle = ComboBoxStyle.DropDownList;
            cboKhachHang.FormattingEnabled = true;
            cboKhachHang.Location = new Point(448, 25);
            cboKhachHang.Name = "cboKhachHang";
            cboKhachHang.Size = new Size(300, 23);
            cboKhachHang.TabIndex = 3;

            // lblGhiChu
            lblGhiChu.AutoSize = true;
            lblGhiChu.Location = new Point(12, 58);
            lblGhiChu.Name = "lblGhiChu";
            lblGhiChu.Size = new Size(80, 15);
            lblGhiChu.TabIndex = 4;
            lblGhiChu.Text = "Ghi chú hóa đơn:";

            // txtGhiChuHoaDon
            txtGhiChuHoaDon.Location = new Point(110, 55);
            txtGhiChuHoaDon.Name = "txtGhiChuHoaDon";
            txtGhiChuHoaDon.Size = new Size(638, 23);
            txtGhiChuHoaDon.TabIndex = 5;

            // grpChiTietHoaDon
            grpChiTietHoaDon.Controls.Add(lblSanPham);
            grpChiTietHoaDon.Controls.Add(cboSanPham);
            grpChiTietHoaDon.Controls.Add(lblDonGiaBan);
            grpChiTietHoaDon.Controls.Add(numDonGiaBan);
            grpChiTietHoaDon.Controls.Add(lblSoLuongBan);
            grpChiTietHoaDon.Controls.Add(numSoLuongBan);
            grpChiTietHoaDon.Controls.Add(btnXacNhanBan);
            grpChiTietHoaDon.Controls.Add(btnXoaChiTiet);
            grpChiTietHoaDon.Controls.Add(dgvChiTietHoaDon);
            grpChiTietHoaDon.Location = new Point(12, 105);
            grpChiTietHoaDon.Name = "grpChiTietHoaDon";
            grpChiTietHoaDon.Size = new Size(760, 310);
            grpChiTietHoaDon.TabIndex = 1;
            grpChiTietHoaDon.TabStop = false;
            grpChiTietHoaDon.Text = "Thông tin chi tiết hóa đơn";

            // lblSanPham
            lblSanPham.AutoSize = true;
            lblSanPham.Location = new Point(12, 28);
            lblSanPham.Name = "lblSanPham";
            lblSanPham.Size = new Size(74, 15);
            lblSanPham.TabIndex = 0;
            lblSanPham.Text = "Sản phẩm (*):";

            // cboSanPham
            cboSanPham.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSanPham.FormattingEnabled = true;
            cboSanPham.Location = new Point(12, 50);
            cboSanPham.Name = "cboSanPham";
            cboSanPham.Size = new Size(200, 23);
            cboSanPham.TabIndex = 1;
            cboSanPham.SelectedIndexChanged += cboSanPham_SelectedIndexChanged;

            // lblDonGiaBan
            lblDonGiaBan.AutoSize = true;
            lblDonGiaBan.Location = new Point(230, 28);
            lblDonGiaBan.Name = "lblDonGiaBan";
            lblDonGiaBan.Size = new Size(83, 15);
            lblDonGiaBan.TabIndex = 2;
            lblDonGiaBan.Text = "Đơn giá bán (*):";

            // numDonGiaBan
            numDonGiaBan.Location = new Point(230, 50);
            numDonGiaBan.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numDonGiaBan.Name = "numDonGiaBan";
            numDonGiaBan.Size = new Size(140, 23);
            numDonGiaBan.TabIndex = 3;
            numDonGiaBan.ThousandsSeparator = true;

            // lblSoLuongBan
            lblSoLuongBan.AutoSize = true;
            lblSoLuongBan.Location = new Point(390, 28);
            lblSoLuongBan.Name = "lblSoLuongBan";
            lblSoLuongBan.Size = new Size(89, 15);
            lblSoLuongBan.TabIndex = 4;
            lblSoLuongBan.Text = "Số lượng bán (*):";

            // numSoLuongBan
            numSoLuongBan.Location = new Point(390, 50);
            numSoLuongBan.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numSoLuongBan.Name = "numSoLuongBan";
            numSoLuongBan.Size = new Size(100, 23);
            numSoLuongBan.TabIndex = 5;

            // btnXacNhanBan
            btnXacNhanBan.Location = new Point(510, 48);
            btnXacNhanBan.Name = "btnXacNhanBan";
            btnXacNhanBan.Size = new Size(100, 25);
            btnXacNhanBan.TabIndex = 6;
            btnXacNhanBan.Text = "Xác nhận bán";
            btnXacNhanBan.UseVisualStyleBackColor = true;
            btnXacNhanBan.Click += btnXacNhanBan_Click;

            // btnXoaChiTiet
            btnXoaChiTiet.Location = new Point(620, 48);
            btnXoaChiTiet.Name = "btnXoaChiTiet";
            btnXoaChiTiet.Size = new Size(60, 25);
            btnXoaChiTiet.TabIndex = 7;
            btnXoaChiTiet.Text = "Xóa";
            btnXoaChiTiet.UseVisualStyleBackColor = true;
            btnXoaChiTiet.Click += btnXoaChiTiet_Click;

            // dgvChiTietHoaDon
            dgvChiTietHoaDon.AllowUserToAddRows = false;
            dgvChiTietHoaDon.AllowUserToDeleteRows = false;
            dgvChiTietHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChiTietHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTietHoaDon.Columns.AddRange(new DataGridViewColumn[] { colID, colTenSanPham, colDonGiaBan, colSoLuongBan, colThanhTien });
            dgvChiTietHoaDon.Location = new Point(12, 82);
            dgvChiTietHoaDon.MultiSelect = false;
            dgvChiTietHoaDon.Name = "dgvChiTietHoaDon";
            dgvChiTietHoaDon.ReadOnly = true;
            dgvChiTietHoaDon.RowHeadersWidth = 40;
            dgvChiTietHoaDon.Size = new Size(736, 215);
            dgvChiTietHoaDon.TabIndex = 8;
            dgvChiTietHoaDon.CellClick += dgvChiTietHoaDon_CellClick;

            // colID
            colID.DataPropertyName = "ID";
            colID.HeaderText = "ID";
            colID.Name = "colID";
            colID.FillWeight = 5;

            // colTenSanPham
            colTenSanPham.DataPropertyName = "TenSanPham";
            colTenSanPham.HeaderText = "Tên sản phẩm";
            colTenSanPham.Name = "colTenSanPham";
            colTenSanPham.FillWeight = 30;

            // colDonGiaBan
            colDonGiaBan.DataPropertyName = "DonGiaBan";
            colDonGiaBan.HeaderText = "Đơn giá bán";
            colDonGiaBan.Name = "colDonGiaBan";
            colDonGiaBan.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            colDonGiaBan.DefaultCellStyle.Format = "N0";
            colDonGiaBan.FillWeight = 25;

            // colSoLuongBan
            colSoLuongBan.DataPropertyName = "SoLuongBan";
            colSoLuongBan.HeaderText = "Số lượng bán";
            colSoLuongBan.Name = "colSoLuongBan";
            colSoLuongBan.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colSoLuongBan.FillWeight = 20;

            // colThanhTien
            colThanhTien.DataPropertyName = "ThanhTien";
            colThanhTien.HeaderText = "Thành tiền";
            colThanhTien.Name = "colThanhTien";
            colThanhTien.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            colThanhTien.DefaultCellStyle.Format = "N0";
            colThanhTien.DefaultCellStyle.ForeColor = System.Drawing.Color.Blue;
            colThanhTien.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            colThanhTien.FillWeight = 20;

            // btnLuuHoaDon
            btnLuuHoaDon.Location = new Point(268, 428);
            btnLuuHoaDon.Name = "btnLuuHoaDon";
            btnLuuHoaDon.Size = new Size(100, 28);
            btnLuuHoaDon.TabIndex = 2;
            btnLuuHoaDon.Text = "Lưu hóa đơn";
            btnLuuHoaDon.UseVisualStyleBackColor = true;
            btnLuuHoaDon.Click += btnLuuHoaDon_Click;

            // btnInHoaDon
            btnInHoaDon.Location = new Point(386, 428);
            btnInHoaDon.Name = "btnInHoaDon";
            btnInHoaDon.Size = new Size(100, 28);
            btnInHoaDon.TabIndex = 3;
            btnInHoaDon.Text = "In hóa đơn...";
            btnInHoaDon.UseVisualStyleBackColor = true;
            btnInHoaDon.Click += btnInHoaDon_Click;

            // btnThoat
            btnThoat.ForeColor = System.Drawing.Color.Red;
            btnThoat.Location = new Point(504, 428);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(100, 28);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;

            // frmHoaDonChiTiet
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 470);
            Controls.Add(grpThongTinHoaDon);
            Controls.Add(grpChiTietHoaDon);
            Controls.Add(btnLuuHoaDon);
            Controls.Add(btnInHoaDon);
            Controls.Add(btnThoat);
            Name = "frmHoaDonChiTiet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hóa đơn chi tiết";
            Load += frmHoaDonChiTiet_Load;

            grpThongTinHoaDon.ResumeLayout(false);
            grpThongTinHoaDon.PerformLayout();
            grpChiTietHoaDon.ResumeLayout(false);
            grpChiTietHoaDon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDonGiaBan).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuongBan).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietHoaDon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpThongTinHoaDon;
        private Label lblNhanVienLap;
        private ComboBox cboNhanVienLap;
        private Label lblKhachHang;
        private ComboBox cboKhachHang;
        private Label lblGhiChu;
        private TextBox txtGhiChuHoaDon;
        private GroupBox grpChiTietHoaDon;
        private Label lblSanPham;
        private ComboBox cboSanPham;
        private Label lblDonGiaBan;
        private NumericUpDown numDonGiaBan;
        private Label lblSoLuongBan;
        private NumericUpDown numSoLuongBan;
        private Button btnXacNhanBan;
        private Button btnXoaChiTiet;
        private DataGridView dgvChiTietHoaDon;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colTenSanPham;
        private DataGridViewTextBoxColumn colDonGiaBan;
        private DataGridViewTextBoxColumn colSoLuongBan;
        private DataGridViewTextBoxColumn colThanhTien;
        private Button btnLuuHoaDon;
        private Button btnInHoaDon;
        private Button btnThoat;
    }
}