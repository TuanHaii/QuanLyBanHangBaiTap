using System.Windows.Forms;

namespace QuanLyBanHang.Forms
{
    partial class frmHangSanXuat
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

        #region Windows Form Designer generated code

     private void InitializeComponent()
  {
      label1 = new Label();
            label2 = new Label();
   label3 = new Label();
     txtTenHangSanXuat = new TextBox();
btnThem = new Button();
          btnSua = new Button();
     btnXoa = new Button();
            btnLuu = new Button();
   btnHuyBo = new Button();
            btnThoat = new Button();
 dataGridView = new DataGridView();
     ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
   // label1
     label1.AutoSize = true;
label1.Location = new Point(41, 18);
label1.Margin = new Padding(2, 0, 2, 0);
      label1.Name = "label1";
  label1.Size = new Size(135, 15);
label1.TabIndex = 0;
            label1.Text = "Thong tin hang san xuat";
            // label2
            label2.AutoSize = true;
  label2.Location = new Point(41, 63);
            label2.Margin = new Padding(2, 0, 2, 0);
 label2.Name = "label2";
       label2.Size = new Size(102, 15);
         label2.TabIndex = 1;
   label2.Text = "Ten hang san xuat";
     // label3
            label3.AutoSize = true;
            label3.Location = new Point(41, 157);
    label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
    label3.Size = new Size(138, 15);
    label3.TabIndex = 2;
    label3.Text = "Danh sach hang san xuat";
  // txtTenHangSanXuat
            txtTenHangSanXuat.Location = new Point(326, 61);
          txtTenHangSanXuat.Margin = new Padding(2, 1, 2, 1);
      txtTenHangSanXuat.Name = "txtTenHangSanXuat";
    txtTenHangSanXuat.Size = new Size(756, 23);
    txtTenHangSanXuat.TabIndex = 3;
            // btnThem
       btnThem.Location = new Point(326, 103);
          btnThem.Margin = new Padding(2, 1, 2, 1);
        btnThem.Name = "btnThem";
btnThem.Size = new Size(81, 22);
            btnThem.TabIndex = 4;
            btnThem.Text = "Them";
   btnThem.UseVisualStyleBackColor = true;
     btnThem.Click += btnThem_Click;
            // btnSua
      btnSua.Location = new Point(459, 103);
            btnSua.Margin = new Padding(2, 1, 2, 1);
 btnSua.Name = "btnSua";
            btnSua.Size = new Size(81, 22);
         btnSua.TabIndex = 5;
  btnSua.Text = "Sua";
            btnSua.UseVisualStyleBackColor = true;
        btnSua.Click += btnSua_Click;
        // btnXoa
          btnXoa.Location = new Point(592, 103);
   btnXoa.Margin = new Padding(2, 1, 2, 1);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(81, 22);
 btnXoa.TabIndex = 6;
  btnXoa.Text = "Xoa";
            btnXoa.UseVisualStyleBackColor = true;
       btnXoa.Click += btnXoa_Click;
          // btnLuu
    btnLuu.Location = new Point(725, 103);
   btnLuu.Margin = new Padding(2, 1, 2, 1);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(81, 22);
            btnLuu.TabIndex = 7;
    btnLuu.Text = "Luu";
       btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
       // btnHuyBo
     btnHuyBo.Location = new Point(858, 103);
            btnHuyBo.Margin = new Padding(2, 1, 2, 1);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(81, 22);
   btnHuyBo.TabIndex = 8;
    btnHuyBo.Text = "Huy bo";
    btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
          // btnThoat
            btnThoat.Location = new Point(999, 103);
            btnThoat.Margin = new Padding(2, 1, 2, 1);
      btnThoat.Name = "btnThoat";
    btnThoat.Size = new Size(81, 22);
    btnThoat.TabIndex = 9;
         btnThoat.Text = "Thoat";
            btnThoat.UseVisualStyleBackColor = true;
  btnThoat.Click += btnThoat_Click;
      // dataGridView
     dataGridView.AllowUserToAddRows = false;
          dataGridView.AllowUserToDeleteRows = false;
   dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
          dataGridView.Location = new Point(41, 185);
            dataGridView.Margin = new Padding(2, 1, 2, 1);
     dataGridView.Name = "dataGridView";
     dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 82;
            dataGridView.Size = new Size(1039, 193);
     dataGridView.TabIndex = 10;
            // frmHangSanXuat
      AutoScaleDimensions = new SizeF(7F, 15F);
 AutoScaleMode = AutoScaleMode.Font;
       ClientSize = new Size(1130, 391);
        Controls.Add(dataGridView);
            Controls.Add(btnThoat);
     Controls.Add(btnHuyBo);
Controls.Add(btnLuu);
   Controls.Add(btnXoa);
            Controls.Add(btnSua);
          Controls.Add(btnThem);
        Controls.Add(txtTenHangSanXuat);
        Controls.Add(label3);
   Controls.Add(label2);
            Controls.Add(label1);
  Margin = new Padding(2, 1, 2, 1);
          Name = "frmHangSanXuat";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hang san xuat";
            Load += frmHangSanXuat_Load;
   ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
       PerformLayout();
        }

        #endregion

        private Label label1;
 private Label label2;
 private Label label3;
private TextBox txtTenHangSanXuat;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLuu;
        private Button btnHuyBo;
      private Button btnThoat;
        private DataGridView dataGridView;
    }
}
