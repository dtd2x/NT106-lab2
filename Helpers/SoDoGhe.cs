namespace NT106_Lab2.Helpers
{
    /// <summary>
    /// Bài 05: sơ đồ 15 ghế của mỗi phòng chiếu, giữ nguyên như Bài 4 - Lab 1.
    /// Vé vớt = 1/4 giá chuẩn, vé thường = giá chuẩn, vé VIP = 2 lần giá chuẩn.
    /// </summary>
    public static class SoDoGhe
    {
        public static readonly IReadOnlyList<string> DanhSachGhe = new List<string>
        {
            "A1", "A2", "A3", "A4", "A5",
            "B1", "B2", "B3", "B4", "B5",
            "C1", "C2", "C3", "C4", "C5"
        };

        private static readonly Dictionary<string, decimal> heSoGhe = new Dictionary<string, decimal>
        {
            { "A1", 0.25m }, { "A2", 1 }, { "A3", 1 }, { "A4", 1 }, { "A5", 0.25m },
            { "B1", 1 },     { "B2", 2 }, { "B3", 2 }, { "B4", 2 }, { "B5", 1 },
            { "C1", 0.25m }, { "C2", 1 }, { "C3", 1 }, { "C4", 1 }, { "C5", 0.25m }
        };

        public static decimal LayHeSo(string ghe)
        {
            return heSoGhe[ghe];
        }

        public static string MoTaLoaiVe()
        {
            return "Vé vớt (1/4 giá): A1, A5, C1, C5\r\n"
                 + "Vé thường: A2, A3, A4, B1, B5, C2, C3, C4\r\n"
                 + "Vé VIP (2 lần giá): B2, B3, B4";
        }
    }
}
