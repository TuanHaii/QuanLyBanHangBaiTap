namespace QuanLyBanHang.Forms
{
    partial class frmNhanVien
    {
        private System.ComponentModel.IContainer components = null;

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
            groupBoxThongTin = new GroupBox();
            labelHoVaTen = new Label();
            txtHoVaTen = new TextBox();
            labelDienThoai = new Label();
            txtDienThoai = new TextBox();
            labelDiaChi = new Label();
            txtDiaChi = new TextBox();
            labelTenDangNhap = new Label();
            txtTenDangNhap = new TextBox();
            labelMatKhau = new Label();
            txtMatKhau = new TextBox();
            labelQuyenHan = new Label();
            cboQuyenHan = new ComboBox();
            btnThem = new Button();
            btnLuu = new Button();
            btnTimKiem = new Button();
            btnSua = new Button();
            btnHuyBo = new Button();
            btnNhap = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            btnXuat = new Button();
            groupBoxDanhSach = new GroupBox();
            dataGridView = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colHoVaTen = new DataGridViewTextBoxColumn();
            colDienThoai = new DataGridViewTextBoxColumn();
            colDiaChi = new DataGridViewTextBoxColumn();
            colTenDangNhap = new DataGridViewTextBoxColumn();
            colQuyenHan = new DataGridViewCheckBoxColumn();
            groupBoxThongTin.SuspendLayout();
            groupBoxDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // groupBoxThongTin
            // 
            groupBoxThongTin.Controls.Add(labelHoVaTen);
            groupBoxThongTin.Controls.Add(txtHoVaTen);
            groupBoxThongTin.Controls.Add(labelDienThoai);
            groupBoxThongTin.Controls.Add(txtDienThoai);
            groupBoxThongTin.Controls.Add(labelDiaChi);
            groupBoxThongTin.Controls.Add(txtDiaChi);
            groupBoxThongTin.Controls.Add(labelTenDangNhap);
            groupBoxThongTin.Controls.Add(txtTenDangNhap);
            groupBoxThongTin.Controls.Add(labelMatKhau);
            groupBoxThongTin.Controls.Add(txtMatKhau);
            groupBoxThongTin.Controls.Add(labelQuyenHan);
            groupBoxThongTin.Controls.Add(cboQuyenHan);
            groupBoxThongTin.Controls.Add(btnThem);
            groupBoxThongTin.Controls.Add(btnLuu);
            groupBoxThongTin.Controls.Add(btnTimKiem);
            groupBoxThongTin.Controls.Add(btnSua);
            groupBoxThongTin.Controls.Add(btnHuyBo);
            groupBoxThongTin.Controls.Add(btnNhap);
            groupBoxThongTin.Controls.Add(btnXoa);
            groupBoxThongTin.Controls.Add(btnThoat);
            groupBoxThongTin.Controls.Add(btnXuat);
            groupBoxThongTin.Location = new Point(12, 12);
            groupBoxThongTin.Name = "groupBoxThongTin";
            groupBoxThongTin.Size = new Size(797, 140);
            groupBoxThongTin.TabIndex = 0;
            groupBoxThongTin.TabStop = false;
            groupBoxThongTin.Text = "Thông tin nhân viên";
            // 
            // labelHoVaTen
            // 
            labelHoVaTen.AutoSize = true;
            labelHoVaTen.Location = new Point(12, 28);
            labelHoVaTen.Name = "labelHoVaTen";
            labelHoVaTen.Size = new Size(77, 15);
            labelHoVaTen.TabIndex = 0;
            labelHoVaTen.Text = "Họ và tên (*):";
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.Location = new Point(90, 25);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new Size(220, 23);
            txtHoVaTen.TabIndex = 1;
            // 
            // labelDienThoai
            // 
            labelDienThoai.AutoSize = true;
            labelDienThoai.Location = new Point(330, 28);
            labelDienThoai.Name = "labelDienThoai";
            labelDienThoai.Size = new Size(64, 15);
            labelDienThoai.TabIndex = 2;
            labelDienThoai.Text = "Điện thoại:";
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(405, 25);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(120, 23);
            txtDienThoai.TabIndex = 3;
            // 
            // labelDiaChi
            // 
            labelDiaChi.AutoSize = true;
            labelDiaChi.Location = new Point(12, 64);
            labelDiaChi.Name = "labelDiaChi";
            labelDiaChi.Size = new Size(46, 15);
            labelDiaChi.TabIndex = 4;
            labelDiaChi.Text = "Địa chỉ:";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(90, 61);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(220, 23);
            txtDiaChi.TabIndex = 5;
            // 
            // labelTenDangNhap
            // 
            labelTenDangNhap.AutoSize = true;
            labelTenDangNhap.Location = new Point(330, 64);
            labelTenDangNhap.Name = "labelTenDangNhap";
            labelTenDangNhap.Size = new Size(105, 15);
            labelTenDangNhap.TabIndex = 6;
            labelTenDangNhap.Text = "Tên đăng nhập (*):";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(420, 61);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(150, 23);
            txtTenDangNhap.TabIndex = 7;
            // 
            // labelMatKhau
            // 
            labelMatKhau.AutoSize = true;
            labelMatKhau.Location = new Point(12, 100);
            labelMatKhau.Name = "labelMatKhau";
            labelMatKhau.Size = new Size(76, 15);
            labelMatKhau.TabIndex = 8;
            labelMatKhau.Text = "Mật khẩu (*):";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(90, 97);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(220, 23);
            txtMatKhau.TabIndex = 9;
            txtMatKhau.UseSystemPasswordChar = true;
            // 
            // labelQuyenHan
            // 
            labelQuyenHan.AutoSize = true;
            labelQuyenHan.Location = new Point(330, 100);
            labelQuyenHan.Name = "labelQuyenHan";
            labelQuyenHan.Size = new Size(84, 15);
            labelQuyenHan.TabIndex = 10;
            labelQuyenHan.Text = "Quyền hạn (*):";
            // 
            // cboQuyenHan
            // 
            cboQuyenHan.DropDownStyle = ComboBoxStyle.DropDownList;
            cboQuyenHan.FormattingEnabled = true;
            cboQuyenHan.Location = new Point(420, 97);
            cboQuyenHan.Name = "cboQuyenHan";
            cboQuyenHan.Size = new Size(150, 23);
            cboQuyenHan.TabIndex = 11;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(590, 24);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(60, 25);
            btnThem.TabIndex = 12;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(656, 24);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(60, 25);
            btnLuu.TabIndex = 13;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(722, 24);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(60, 25);
            btnTimKiem.TabIndex = 14;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(590, 55);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(60, 25);
            btnSua.TabIndex = 15;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(656, 55);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(60, 25);
            btnHuyBo.TabIndex = 16;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(722, 55);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(60, 25);
            btnNhap.TabIndex = 17;
            btnNhap.Text = "Nhập...";
            btnNhap.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(590, 86);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(60, 25);
            btnXoa.TabIndex = 18;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(656, 86);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(60, 25);
            btnThoat.TabIndex = 19;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(722, 86);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(60, 25);
            btnXuat.TabIndex = 20;
            btnXuat.Text = "Xuất...";
            btnXuat.UseVisualStyleBackColor = true;
            // 
            // groupBoxDanhSach
            // 
            groupBoxDanhSach.Controls.Add(dataGridView);
            groupBoxDanhSach.Location = new Point(12, 158);
            groupBoxDanhSach.Name = "groupBoxDanhSach";
            groupBoxDanhSach.Size = new Size(770, 310);
            groupBoxDanhSach.TabIndex = 1;
            groupBoxDanhSach.TabStop = false;
            groupBoxDanhSach.Text = "Danh sách nhân viên";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { colID, colHoVaTen, colDienThoai, colDiaChi, colTenDangNhap, colQuyenHan });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 19);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(764, 288);
            dataGridView.TabIndex = 0;
            // 
            // colID
            // 
            colID.DataPropertyName = "ID";
            colID.HeaderText = "ID";
            colID.Name = "colID";
            // 
            // colHoVaTen
            // 
            colHoVaTen.DataPropertyName = "HoVaTen";
            colHoVaTen.HeaderText = "Họ và tên";
            colHoVaTen.Name = "colHoVaTen";
            // 
            // colDienThoai
            // 
            colDienThoai.DataPropertyName = "DienThoai";
            colDienThoai.HeaderText = "Điện thoại";
            colDienThoai.Name = "colDienThoai";
            // 
            // colDiaChi
            // 
            colDiaChi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colDiaChi.DataPropertyName = "DiaChi";
            colDiaChi.HeaderText = "Địa chỉ";
            colDiaChi.Name = "colDiaChi";
            // 
            // colTenDangNhap
            // 
            colTenDangNhap.DataPropertyName = "TenDangNhap";
            colTenDangNhap.HeaderText = "Tên đăng nhập";
            colTenDangNhap.Name = "colTenDangNhap";
            // 
            // colQuyenHan
            // 
            colQuyenHan.DataPropertyName = "QuyenHan";
            colQuyenHan.HeaderText = "Quyền hạn";
            colQuyenHan.Name = "colQuyenHan";
            // 
            // frmNhanVien
            // 
            ClientSize = new Size(821, 481);
            Controls.Add(groupBoxDanhSach);
            Controls.Add(groupBoxThongTin);
            Name = "frmNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nhân viên";
            Load += frmNhanVien_Load;
            groupBoxThongTin.ResumeLayout(false);
            groupBoxThongTin.PerformLayout();
            groupBoxDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox groupBoxThongTin;
        private System.Windows.Forms.Label labelHoVaTen;
        private System.Windows.Forms.TextBox txtHoVaTen;
        private System.Windows.Forms.Label labelDienThoai;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.Label labelDiaChi;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label labelTenDangNhap;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Label labelMatKhau;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label labelQuyenHan;
        private System.Windows.Forms.ComboBox cboQuyenHan;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.GroupBox groupBoxDanhSach;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoVaTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenDangNhap;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colQuyenHan;
    }
}
