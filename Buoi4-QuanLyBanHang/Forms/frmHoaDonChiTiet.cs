using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using QuanLyBanHang.Data;

namespace QuanLyBanHang.Forms
{
    public partial class frmHoaDonChiTiet : Form
    {
        QLBHDbContext context = new QLBHDbContext();
        int hoaDonID = 0; // 0 = thêm mới, > 0 = sửa
        List<HoaDon_ChiTiet> danhSachChiTiet = new List<HoaDon_ChiTiet>();

        public frmHoaDonChiTiet()
        {
            InitializeComponent();
        }

        public frmHoaDonChiTiet(int id)
        {
            InitializeComponent();
            hoaDonID = id;
        }

        private void frmHoaDonChiTiet_Load(object sender, EventArgs e)
        {
            // Load danh sách nhân viên
            cboNhanVienLap.DataSource = context.NhanVien.ToList();
            cboNhanVienLap.DisplayMember = "HoVaTen";
            cboNhanVienLap.ValueMember = "ID";

            // Load danh sách khách hàng
            cboKhachHang.DataSource = context.KhachHang.ToList();
            cboKhachHang.DisplayMember = "HoVaTen";
            cboKhachHang.ValueMember = "ID";

            // Load danh sách sản phẩm
            cboSanPham.DataSource = context.SanPham.ToList();
            cboSanPham.DisplayMember = "TenSanPham";
            cboSanPham.ValueMember = "ID";

            // Nếu là sửa, load dữ liệu hóa đơn cũ
            if (hoaDonID > 0)
            {
                HoaDon hd = context.HoaDon.Find(hoaDonID);
                if (hd != null)
                {
                    cboNhanVienLap.SelectedValue = hd.NhanVienID;
                    cboKhachHang.SelectedValue = hd.KhachHangID;
                    txtGhiChuHoaDon.Text = hd.GhiChuHoaDon;

                    // Include SanPham để TenSanPham và ThanhTien [NotMapped] hoạt động
                    danhSachChiTiet = context.HoaDon_ChiTiet
                        .Include(ct => ct.SanPham)
                        .Where(ct => ct.HoaDonID == hoaDonID)
                        .ToList();
                }
            }

            TaiLaiGridView();
        }

        private void TaiLaiGridView()
        {
            dgvChiTietHoaDon.DataSource = null;
            dgvChiTietHoaDon.DataSource = danhSachChiTiet;
        }

        private void cboSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSanPham.SelectedItem is SanPham sp)
            {
                numDonGiaBan.Value = sp.DonGia;
            }
        }

        private void btnXacNhanBan_Click(object sender, EventArgs e)
        {
            if (cboSanPham.SelectedItem is not SanPham sp) return;
            if (numSoLuongBan.Value <= 0)
            {
                MessageBox.Show("Vui lòng nhập số lượng bán lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra sản phẩm đã có trong danh sách chưa
            HoaDon_ChiTiet existing = danhSachChiTiet.FirstOrDefault(ct => ct.SanPhamID == sp.ID);
            if (existing != null)
            {
                existing.SoLuongBan += (short)numSoLuongBan.Value;
                existing.DonGiaBan = (int)numDonGiaBan.Value;
            }
            else
            {
                danhSachChiTiet.Add(new HoaDon_ChiTiet
                {
                    SanPhamID = sp.ID,
                    SanPham = sp,   // gán navigation property -> TenSanPham, ThanhTien tự tính
                    DonGiaBan = (int)numDonGiaBan.Value,
                    SoLuongBan = (short)numSoLuongBan.Value
                });
            }

            TaiLaiGridView();
            numSoLuongBan.Value = 0;
        }

        private void btnXoaChiTiet_Click(object sender, EventArgs e)
        {
            if (dgvChiTietHoaDon.CurrentRow == null) return;
            int idx = dgvChiTietHoaDon.CurrentRow.Index;
            if (idx >= 0 && idx < danhSachChiTiet.Count)
            {
                danhSachChiTiet.RemoveAt(idx);
                TaiLaiGridView();
            }
        }

        private void dgvChiTietHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= danhSachChiTiet.Count) return;
            HoaDon_ChiTiet ct = danhSachChiTiet[e.RowIndex];
            cboSanPham.SelectedValue = ct.SanPhamID;
            numDonGiaBan.Value = ct.DonGiaBan;
            numSoLuongBan.Value = ct.SoLuongBan;
        }

        private void btnLuuHoaDon_Click(object sender, EventArgs e)
        {
            if (cboNhanVienLap.SelectedValue == null || cboKhachHang.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên và khách hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (danhSachChiTiet.Count == 0)
            {
                MessageBox.Show("Vui lòng thêm ít nhất một sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (hoaDonID == 0)
            {
                // Thêm mới hóa đơn
                HoaDon hd = new HoaDon
                {
                    NhanVienID = (int)cboNhanVienLap.SelectedValue,
                    KhachHangID = (int)cboKhachHang.SelectedValue,
                    NgayLap = DateTime.Now,
                    GhiChuHoaDon = txtGhiChuHoaDon.Text
                };
                context.HoaDon.Add(hd);
                context.SaveChanges();

                foreach (HoaDon_ChiTiet ct in danhSachChiTiet)
                {
                    context.HoaDon_ChiTiet.Add(new HoaDon_ChiTiet
                    {
                        HoaDonID = hd.ID,
                        SanPhamID = ct.SanPhamID,
                        DonGiaBan = ct.DonGiaBan,
                        SoLuongBan = ct.SoLuongBan
                    });
                }
                context.SaveChanges();
                MessageBox.Show("Lưu hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                // Sửa hóa đơn
                HoaDon hd = context.HoaDon.Find(hoaDonID);
                if (hd != null)
                {
                    hd.NhanVienID = (int)cboNhanVienLap.SelectedValue;
                    hd.KhachHangID = (int)cboKhachHang.SelectedValue;
                    hd.GhiChuHoaDon = txtGhiChuHoaDon.Text;
                    context.HoaDon.Update(hd);

                    // Xóa chi tiết cũ, thêm lại
                    List<HoaDon_ChiTiet> chiTietCu = context.HoaDon_ChiTiet
                        .Where(ct => ct.HoaDonID == hoaDonID).ToList();
                    context.HoaDon_ChiTiet.RemoveRange(chiTietCu);

                    foreach (HoaDon_ChiTiet ct in danhSachChiTiet)
                    {
                        context.HoaDon_ChiTiet.Add(new HoaDon_ChiTiet
                        {
                            HoaDonID = hoaDonID,
                            SanPhamID = ct.SanPhamID,
                            DonGiaBan = ct.DonGiaBan,
                            SoLuongBan = ct.SoLuongBan
                        });
                    }
                    context.SaveChanges();
                    MessageBox.Show("Cập nhật hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng in hóa đơn đang được phát triển.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
