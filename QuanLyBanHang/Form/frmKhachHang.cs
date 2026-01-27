using QuanLyBanHang.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyBanHang.Forms
{
    public partial class frmKhachHang : Form
    {
        QLBHDbContext context = new QLBHDbContext();
        bool xulyThem = false;
        int id;

        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            txtHoVaTen.Enabled = giaTri;
            txtDienThoai.Enabled = giaTri;
            txtDiaChi.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);

            List<KhachHang> list = context.KhachHang.ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = list;

            txtHoVaTen.DataBindings.Clear();
            txtHoVaTen.DataBindings.Add("Text", bindingSource, "HoVaTen", false, DataSourceUpdateMode.Never);

            txtDienThoai.DataBindings.Clear();
            txtDienThoai.DataBindings.Add("Text", bindingSource, "DienThoai", false, DataSourceUpdateMode.Never);

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", bindingSource, "DiaChi", false, DataSourceUpdateMode.Never);

            dataGridView.DataSource = list;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xulyThem = true;
            BatTatChucNang(true);
            txtHoVaTen.Clear();
            txtDienThoai.Clear();
            txtDiaChi.Clear();
            txtHoVaTen.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null) return;
            xulyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null) return;
            if (MessageBox.Show("Xác nhận xóa khách hàng?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value);
                KhachHang kh = context.KhachHang.Find(id);
                if (kh != null)
                {
                    context.KhachHang.Remove(kh);
                    context.SaveChanges();
                }
                frmKhachHang_Load(sender, e);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoVaTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ và tên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (xulyThem)
            {
                KhachHang kh = new KhachHang
                {
                    HoVaTen = txtHoVaTen.Text,
                    DienThoai = txtDienThoai.Text,
                    DiaChi = txtDiaChi.Text
                };
                context.KhachHang.Add(kh);
                context.SaveChanges();
            }
            else
            {
                KhachHang kh = context.KhachHang.Find(id);
                if (kh != null)
                {
                    kh.HoVaTen = txtHoVaTen.Text;
                    kh.DienThoai = txtDienThoai.Text;
                    kh.DiaChi = txtDiaChi.Text;
                    context.KhachHang.Update(kh);
                    context.SaveChanges();
                }
            }

            frmKhachHang_Load(sender, e);
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmKhachHang_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string key = txtHoVaTen.Text.Trim();
            var result = context.KhachHang.Where(k => k.HoVaTen.Contains(key) || (k.DienThoai != null && k.DienThoai.Contains(key))).ToList();
            dataGridView.DataSource = result;
        }

        
    }
}
