namespace NT106_Lab2.Models
{
    /// <summary>
    /// Bài 06: bảng MonAn (IDMA, TenMonAn, HinhAnh, IDNCC).
    /// TenNguoiDongGop lấy thêm từ bảng NguoiDung khi JOIN.
    /// </summary>
    public class MonAn
    {
        public int IDMA { get; set; }
        public string TenMonAn { get; set; } = "";
        public byte[]? HinhAnh { get; set; }
        public int IDNCC { get; set; }
        public string TenNguoiDongGop { get; set; } = "";
    }

    /// <summary>
    /// Bài 06: bảng NguoiDung (IDNCC, HoVaTen, QuyenHan).
    /// </summary>
    public class NguoiDung
    {
        public int IDNCC { get; set; }
        public string HoVaTen { get; set; } = "";
        public string QuyenHan { get; set; } = "";

        // ComboBox hiển thị object bằng ToString()
        public override string ToString()
        {
            return $"{HoVaTen} ({QuyenHan})";
        }
    }
}
