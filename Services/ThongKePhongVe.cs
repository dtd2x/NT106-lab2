using System.Text;
using NT106_Lab2.Helpers;
using NT106_Lab2.Models;

namespace NT106_Lab2.Services
{
    /// <summary>
    /// Bài 05: tính thống kê theo phim và tạo nội dung cho output5.txt.
    /// </summary>
    public static class ThongKePhongVe
    {
        public static List<ThongKePhim> Tinh(IEnumerable<Phim> danhSachPhim, IEnumerable<VeDaBan> danhSachVe)
        {
            List<ThongKePhim> ketQua = new List<ThongKePhim>();
            foreach (Phim phim in danhSachPhim)
            {
                List<VeDaBan> veCuaPhim = danhSachVe.Where(ve => ve.TenPhim == phim.TenPhim).ToList();
                // Mỗi phòng chiếu có 15 ghế
                int tongSoVe = phim.PhongChieu.Count * SoDoGhe.DanhSachGhe.Count;
                int soVeBan = veCuaPhim.Count;

                ketQua.Add(new ThongKePhim
                {
                    TenPhim = phim.TenPhim,
                    SoVeBan = soVeBan,
                    SoVeTon = tongSoVe - soVeBan,
                    TiLeBan = tongSoVe == 0 ? 0 : (double)soVeBan / tongSoVe,
                    DoanhThu = veCuaPhim.Sum(ve => ve.GiaTien)
                });
            }

            // Xếp hạng theo doanh thu từ cao đến thấp; các phim bằng doanh thu thì đồng hạng
            ketQua = ketQua.OrderByDescending(t => t.DoanhThu).ThenBy(t => t.TenPhim).ToList();
            for (int i = 0; i < ketQua.Count; i++)
            {
                bool bangPhimTruoc = i > 0 && ketQua[i].DoanhThu == ketQua[i - 1].DoanhThu;
                ketQua[i].XepHang = bangPhimTruoc ? ketQua[i - 1].XepHang : i + 1;
            }
            return ketQua;
        }

        public static string DinhDangTiLe(double tiLe)
        {
            return (tiLe * 100).ToString("0.00") + "%";
        }

        public static string DinhDangTien(decimal soTien)
        {
            return soTien.ToString("#,##0") + " đ";
        }

        // Khối nội dung của một phim trong output5.txt
        public static string TaoNoiDung(ThongKePhim thongKe)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Tên phim: " + thongKe.TenPhim);
            sb.AppendLine("Số lượng vé bán ra: " + thongKe.SoVeBan);
            sb.AppendLine("Số lượng vé tồn: " + thongKe.SoVeTon);
            sb.AppendLine("Tỉ lệ vé bán ra: " + DinhDangTiLe(thongKe.TiLeBan));
            sb.AppendLine("Doanh thu: " + DinhDangTien(thongKe.DoanhThu));
            sb.AppendLine("Xếp hạng doanh thu: " + thongKe.XepHang);
            sb.AppendLine("----------------------------------------");
            return sb.ToString();
        }
    }
}
