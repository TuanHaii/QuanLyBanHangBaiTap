namespace QuanLyBanHang.Forms
{
    partial class frmKhachHang
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
            ID = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            HoVaTan = new DataGridViewTextBoxColumn();
            DienThoai = new DataGridViewTextBoxColumn();
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
            groupBoxThongTin.Size = new Size(760, 120);
            groupBoxThongTin.TabIndex = 0;
            groupBoxThongTin.TabStop = false;
            groupBoxThongTin.Text = "Thông tin khách hàng";
            // 
            // labelHoVaTen
            // 
            labelHoVaTen.AutoSize = true;
            labelHoVaTen.Location = new Point(12, 28);
            labelHoVaTen.Name = "labelHoVaTen";
            labelHoVaTen.Size = new Size(61, 15);
            labelHoVaTen.TabIndex = 0;
            labelHoVaTen.Text = "Họ và tên:";
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
            labelDienThoai.Text = "Ðiện thoại:";
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
            labelDiaChi.Text = "Ðịa chỉ:";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(90, 61);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(435, 23);
            txtDiaChi.TabIndex = 5;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(540, 20);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(60, 25);
            btnThem.TabIndex = 6;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(606, 20);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(60, 25);
            btnLuu.TabIndex = 7;
            btnLuu.Text = "Luu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(672, 20);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(60, 25);
            btnTimKiem.TabIndex = 8;
            btnTimKiem.Text = "Tìm ki?m";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(540, 51);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(60, 25);
            btnSua.TabIndex = 9;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(606, 51);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(60, 25);
            btnHuyBo.TabIndex = 10;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(672, 51);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(60, 25);
            btnNhap.TabIndex = 11;
            btnNhap.Text = "Nhập..";
            btnNhap.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(540, 82);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(60, 25);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(606, 82);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(60, 25);
            btnThoat.TabIndex = 13;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(672, 82);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(60, 25);
            btnXuat.TabIndex = 14;
            btnXuat.Text = "Xuất..";
            btnXuat.UseVisualStyleBackColor = true;
            // 
            // groupBoxDanhSach
            // 
            groupBoxDanhSach.Controls.Add(dataGridView);
            groupBoxDanhSach.Location = new Point(12, 138);
            groupBoxDanhSach.Name = "groupBoxDanhSach";
            groupBoxDanhSach.Size = new Size(760, 310);
            groupBoxDanhSach.TabIndex = 1;
            groupBoxDanhSach.TabStop = false;
            groupBoxDanhSach.Text = "Danh sách khách hàng";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, DiaChi, HoVaTan, DienThoai });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 19);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(754, 288);
            dataGridView.TabIndex = 0;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // DiaChi
            // 
            DiaChi.DataPropertyName = "DiaChi";
            DiaChi.HeaderText = "Ðịa chỉ";
            DiaChi.Name = "DiaChi";
            // 
            // HoVaTan
            // 
            HoVaTan.DataPropertyName = "HoVaTen";
            HoVaTan.HeaderText = "Họ Và Tên";
            HoVaTan.Name = "HoVaTan";
            // 
            // DienThoai
            // 
            DienThoai.DataPropertyName = "DienThoai";
            DienThoai.HeaderText = "Ðiện thoại";
            DienThoai.Name = "DienThoai";
            // 
            // frmKhachHang
            // 
            ClientSize = new Size(784, 461);
            Controls.Add(groupBoxDanhSach);
            Controls.Add(groupBoxThongTin);
            Name = "frmKhachHang";
            Text = "Khách hàng";
            Load += frmKhachHang_Load;
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
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn HoVaTan;
        private DataGridViewTextBoxColumn DienThoai;
    }
}
