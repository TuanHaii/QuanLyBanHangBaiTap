namespace QuanLyBanHang.Forms
{
    partial class frmSanPham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelTitle = new Label();
            groupBoxThongTin = new GroupBox();
            labelPhanLoai = new Label();
            cboLoaiSanPham = new ComboBox();
            labelHangSX = new Label();
            cboHangSanXuat = new ComboBox();
            labelTenSP = new Label();
            txtTenSanPham = new TextBox();
            labelMoTa = new Label();
            txtMoTa = new TextBox();
            labelSoLuong = new Label();
            numericSoLuong = new NumericUpDown();
            labelDonGia = new Label();
            txtDonGia = new TextBox();
            pbHinhAnh = new PictureBox();
            btnDoiAnh = new Button();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLuu = new Button();
            btnHuyBo = new Button();
            btnThoat = new Button();
            dataGridView = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            groupBoxThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericSoLuong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbHinhAnh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelTitle.Location = new Point(12, 9);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(61, 15);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Sản phẩm";
            // 
            // groupBoxThongTin
            // 
            groupBoxThongTin.Controls.Add(labelPhanLoai);
            groupBoxThongTin.Controls.Add(cboLoaiSanPham);
            groupBoxThongTin.Controls.Add(labelHangSX);
            groupBoxThongTin.Controls.Add(cboHangSanXuat);
            groupBoxThongTin.Controls.Add(labelTenSP);
            groupBoxThongTin.Controls.Add(txtTenSanPham);
            groupBoxThongTin.Controls.Add(labelMoTa);
            groupBoxThongTin.Controls.Add(txtMoTa);
            groupBoxThongTin.Controls.Add(labelSoLuong);
            groupBoxThongTin.Controls.Add(numericSoLuong);
            groupBoxThongTin.Controls.Add(labelDonGia);
            groupBoxThongTin.Controls.Add(txtDonGia);
            groupBoxThongTin.Controls.Add(pbHinhAnh);
            groupBoxThongTin.Controls.Add(btnDoiAnh);
            groupBoxThongTin.Location = new Point(12, 27);
            groupBoxThongTin.Name = "groupBoxThongTin";
            groupBoxThongTin.Size = new Size(820, 170);
            groupBoxThongTin.TabIndex = 1;
            groupBoxThongTin.TabStop = false;
            groupBoxThongTin.Text = "Thông tin sản phẩm";
            // 
            // labelPhanLoai
            // 
            labelPhanLoai.AutoSize = true;
            labelPhanLoai.Location = new Point(12, 28);
            labelPhanLoai.Name = "labelPhanLoai";
            labelPhanLoai.Size = new Size(56, 15);
            labelPhanLoai.TabIndex = 0;
            labelPhanLoai.Text = "Phân loại";
            // 
            // cboLoaiSanPham
            // 
            cboLoaiSanPham.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoaiSanPham.FormattingEnabled = true;
            cboLoaiSanPham.Location = new Point(120, 25);
            cboLoaiSanPham.Name = "cboLoaiSanPham";
            cboLoaiSanPham.Size = new Size(220, 23);
            cboLoaiSanPham.TabIndex = 1;
            // 
            // labelHangSX
            // 
            labelHangSX.AutoSize = true;
            labelHangSX.Location = new Point(12, 61);
            labelHangSX.Name = "labelHangSX";
            labelHangSX.Size = new Size(82, 15);
            labelHangSX.TabIndex = 2;
            labelHangSX.Text = "Hãng sản xuất";
            // 
            // cboHangSanXuat
            // 
            cboHangSanXuat.DropDownStyle = ComboBoxStyle.DropDownList;
            cboHangSanXuat.FormattingEnabled = true;
            cboHangSanXuat.Location = new Point(120, 58);
            cboHangSanXuat.Name = "cboHangSanXuat";
            cboHangSanXuat.Size = new Size(220, 23);
            cboHangSanXuat.TabIndex = 3;
            // 
            // labelTenSP
            // 
            labelTenSP.AutoSize = true;
            labelTenSP.Location = new Point(12, 95);
            labelTenSP.Name = "labelTenSP";
            labelTenSP.Size = new Size(81, 15);
            labelTenSP.TabIndex = 4;
            labelTenSP.Text = "Tên sản phẩm";
            // 
            // txtTenSanPham
            // 
            txtTenSanPham.Location = new Point(120, 92);
            txtTenSanPham.Name = "txtTenSanPham";
            txtTenSanPham.Size = new Size(220, 23);
            txtTenSanPham.TabIndex = 5;
            // 
            // labelMoTa
            // 
            labelMoTa.AutoSize = true;
            labelMoTa.Location = new Point(12, 128);
            labelMoTa.Name = "labelMoTa";
            labelMoTa.Size = new Size(38, 15);
            labelMoTa.TabIndex = 6;
            labelMoTa.Text = "Mô tả";
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(120, 125);
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(480, 23);
            txtMoTa.TabIndex = 7;
            // 
            // labelSoLuong
            // 
            labelSoLuong.AutoSize = true;
            labelSoLuong.Location = new Point(380, 28);
            labelSoLuong.Name = "labelSoLuong";
            labelSoLuong.Size = new Size(54, 15);
            labelSoLuong.TabIndex = 8;
            labelSoLuong.Text = "Số lượng";
            // 
            // numericSoLuong
            // 
            numericSoLuong.Location = new Point(460, 26);
            numericSoLuong.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numericSoLuong.Name = "numericSoLuong";
            numericSoLuong.Size = new Size(140, 23);
            numericSoLuong.TabIndex = 9;
            // 
            // labelDonGia
            // 
            labelDonGia.AutoSize = true;
            labelDonGia.Location = new Point(380, 61);
            labelDonGia.Name = "labelDonGia";
            labelDonGia.Size = new Size(48, 15);
            labelDonGia.TabIndex = 10;
            labelDonGia.Text = "Đơn giá";
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(460, 58);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(140, 23);
            txtDonGia.TabIndex = 11;
            // 
            // pbHinhAnh
            // 
            pbHinhAnh.BorderStyle = BorderStyle.FixedSingle;
            pbHinhAnh.Location = new Point(620, 20);
            pbHinhAnh.Name = "pbHinhAnh";
            pbHinhAnh.Size = new Size(160, 120);
            pbHinhAnh.SizeMode = PictureBoxSizeMode.Zoom;
            pbHinhAnh.TabIndex = 12;
            pbHinhAnh.TabStop = false;
            // 
            // btnDoiAnh
            // 
            btnDoiAnh.Location = new Point(620, 145);
            btnDoiAnh.Name = "btnDoiAnh";
            btnDoiAnh.Size = new Size(75, 23);
            btnDoiAnh.TabIndex = 13;
            btnDoiAnh.Text = "Đổi ảnh...";
            btnDoiAnh.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(12, 205);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 25);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(105, 205);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 25);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(198, 205);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 25);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(291, 205);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(75, 25);
            btnLuu.TabIndex = 5;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(384, 205);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(75, 25);
            btnHuyBo.TabIndex = 6;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(477, 205);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 25);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(12, 240);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 62;
            dataGridView.Size = new Size(820, 236);
            dataGridView.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(568, 205);
            button1.Name = "button1";
            button1.Size = new Size(75, 25);
            button1.TabIndex = 7;
            button1.Text = "Tìm kiếm";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(662, 205);
            button2.Name = "button2";
            button2.Size = new Size(75, 25);
            button2.TabIndex = 7;
            button2.Text = "Nhập..";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(757, 203);
            button3.Name = "button3";
            button3.Size = new Size(75, 25);
            button3.TabIndex = 9;
            button3.Text = "Xuất..";
            button3.UseVisualStyleBackColor = true;
            // 
            // frmSanPham
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(853, 583);
            Controls.Add(button3);
            Controls.Add(dataGridView);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnThoat);
            Controls.Add(btnHuyBo);
            Controls.Add(btnLuu);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(groupBoxThongTin);
            Controls.Add(labelTitle);
            Name = "frmSanPham";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sản phẩm";
            Load += frmSanPham_Load;
            groupBoxThongTin.ResumeLayout(false);
            groupBoxThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericSoLuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbHinhAnh).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.GroupBox groupBoxThongTin;
        private System.Windows.Forms.Label labelPhanLoai;
        private System.Windows.Forms.Label labelHangSX;
        private System.Windows.Forms.Label labelTenSP;
        private System.Windows.Forms.Label labelMoTa;
        private System.Windows.Forms.Label labelSoLuong;
        private System.Windows.Forms.Label labelDonGia;
        private System.Windows.Forms.ComboBox cboLoaiSanPham;
        private System.Windows.Forms.ComboBox cboHangSanXuat;
        private System.Windows.Forms.TextBox txtTenSanPham;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.NumericUpDown numericSoLuong;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.PictureBox pbHinhAnh;
        private System.Windows.Forms.Button btnDoiAnh;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dataGridView;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
