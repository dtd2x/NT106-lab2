namespace NT106_Lab2.Models
{
    /// <summary>
    /// Bài 04: thông tin một sinh viên, được serialize sang JSON để lưu file.
    /// </summary>
    public class SinhVien
    {
        public string HoTen { get; set; } = "";
        public int MSSV { get; set; }
        public string DienThoai { get; set; } = "";
        public float DiemMon1 { get; set; }
        public float DiemMon2 { get; set; }
        public float DiemMon3 { get; set; }
        public float DiemTrungBinh { get; set; }

        // Điểm trung bình 3 môn, làm tròn 2 chữ số thập phân
        public void TinhDiemTrungBinh()
        {
            DiemTrungBinh = (float)Math.Round((DiemMon1 + DiemMon2 + DiemMon3) / 3.0, 2);
        }
    }
}
