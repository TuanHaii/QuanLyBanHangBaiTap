using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Data
{
    public class HoaDon_ChiTiet
    {
        public int ID { get; set; }
        public int HoaDonID { get; set; }
        public int SanPhamID { get; set; }
        public short SoLuongBan {  get; set; }
        public int DonGiaBan { get; set; }
        public virtual HoaDon HoaDon { get; set; } = null;
        public virtual SanPham SanPham { get; set; } = null;

        [NotMapped]
        public string TenSanPham => SanPham?.TenSanPham ?? string.Empty;

        [NotMapped]
        public long ThanhTien => (long)DonGiaBan * SoLuongBan;
    }
}
