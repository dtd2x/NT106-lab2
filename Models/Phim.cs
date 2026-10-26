namespace NT106_Lab2.Models
{
    /// <summary>
    /// Bài 05: một phim đọc từ input5.txt.
    /// </summary>
    public class Phim
    {
        public string TenPhim { get; set; } = "";
        public int GiaVeChuan { get; set; }
        public List<int> PhongChieu { get; set; } = new List<int>();

        public override string ToString()
        {
            return $"{TenPhim}  |  {GiaVeChuan:#,##0} đ  |  phòng {string.Join(", ", PhongChieu)}";
        }
    }

    /// <summary>
    /// Bài 05: một vé đã bán.
    /// </summary>
    public class VeDaBan
    {
        public string HoTen { get; set; } = "";
        public string TenPhim { get; set; } = "";
        public int Phong { get; set; }
        public string Ghe { get; set; } = "";
        public decimal GiaTien { get; set; }
    }

    /// <summary>
    /// Bài 05: số liệu thống kê của một phim, dùng để xuất output5.txt.
    /// </summary>
    public class ThongKePhim
    {
        public string TenPhim { get; set; } = "";
        public int SoVeBan { get; set; }
        public int SoVeTon { get; set; }
        // Tỉ lệ từ 0 đến 1
        public double TiLeBan { get; set; }
        public decimal DoanhThu { get; set; }
        public int XepHang { get; set; }
    }
}
