using System.Text;
using NT106_Lab2.Models;

namespace NT106_Lab2.Services
{
    /// <summary>
    /// Bài 05: đọc/ghi file input5.txt. Mỗi phim gồm 3 dòng liên tiếp:
    ///   &lt;tên phim&gt;
    ///   &lt;giá vé chuẩn&gt;
    ///   &lt;phòng chiếu&gt;   (nhiều phòng cách nhau dấu phẩy, ví dụ 1,2,3)
    /// Các dòng trống được bỏ qua.
    /// </summary>
    public static class PhimFile
    {
        public static List<Phim> Doc(string duongDan)
        {
            // Lấy các dòng có nội dung, kèm số thứ tự dòng thật trong file để báo lỗi chính xác
            List<(int SoDong, string NoiDung)> cacDong = new List<(int SoDong, string NoiDung)>();
            using (StreamReader sr = new StreamReader(duongDan, Encoding.UTF8))
            {
                string? dong;
                int soDong = 0;
                while ((dong = sr.ReadLine()) != null)
                {
                    soDong++;
                    if (dong.Trim() != "")
                    {
                        cacDong.Add((soDong, dong.Trim()));
                    }
                }
            }

            if (cacDong.Count % 3 != 0)
            {
                throw new FormatException(
                    $"File phải gồm các nhóm 3 dòng (tên phim, giá vé, phòng chiếu), hiện có {cacDong.Count} dòng có nội dung.");
            }

            List<Phim> danhSach = new List<Phim>();
            for (int i = 0; i < cacDong.Count; i += 3)
            {
                var dongTen = cacDong[i];
                var dongGia = cacDong[i + 1];
                var dongPhong = cacDong[i + 2];

                if (!int.TryParse(dongGia.NoiDung, out int giaVe) || giaVe <= 0)
                {
                    throw new FormatException($"Dòng {dongGia.SoDong}: giá vé \"{dongGia.NoiDung}\" không hợp lệ.");
                }

                List<int>? phongChieu = PhanTichPhongChieu(dongPhong.NoiDung);
                if (phongChieu == null)
                {
                    throw new FormatException($"Dòng {dongPhong.SoDong}: phòng chiếu \"{dongPhong.NoiDung}\" không hợp lệ.");
                }

                if (danhSach.Any(p => string.Equals(p.TenPhim, dongTen.NoiDung, StringComparison.CurrentCultureIgnoreCase)))
                {
                    throw new FormatException($"Dòng {dongTen.SoDong}: phim \"{dongTen.NoiDung}\" bị trùng.");
                }

                danhSach.Add(new Phim
                {
                    TenPhim = dongTen.NoiDung,
                    GiaVeChuan = giaVe,
                    PhongChieu = phongChieu
                });
            }
            return danhSach;
        }

        // "1, 2,3" -> [1, 2, 3]; trả về null nếu có phần không phải số nguyên dương
        public static List<int>? PhanTichPhongChieu(string chuoi)
        {
            List<int> danhSach = new List<int>();
            string[] cacPhan = chuoi.Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
            foreach (string phan in cacPhan)
            {
                if (!int.TryParse(phan, out int phong) || phong <= 0)
                {
                    return null;
                }
                if (!danhSach.Contains(phong))
                {
                    danhSach.Add(phong);
                }
            }
            return danhSach.Count == 0 ? null : danhSach;
        }

        // Ghi thêm một phim vào cuối file
        public static void GhiThem(string duongDan, Phim phim)
        {
            // Nếu file đang có dữ liệu mà byte cuối chưa phải '\n' thì cần xuống dòng trước khi ghi
            bool canXuongDong = false;
            if (File.Exists(duongDan))
            {
                using FileStream fsDoc = new FileStream(duongDan, FileMode.Open, FileAccess.Read);
                if (fsDoc.Length > 0)
                {
                    fsDoc.Seek(-1, SeekOrigin.End);
                    canXuongDong = fsDoc.ReadByte() != '\n';
                }
            }

            using FileStream fs = new FileStream(duongDan, FileMode.Append, FileAccess.Write);
            using StreamWriter sw = new StreamWriter(fs, new UTF8Encoding(false));
            if (canXuongDong)
            {
                sw.WriteLine();
            }
            sw.WriteLine(phim.TenPhim);
            sw.WriteLine(phim.GiaVeChuan);
            sw.WriteLine(string.Join(",", phim.PhongChieu));
        }
    }
}
