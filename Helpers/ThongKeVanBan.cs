namespace NT106_Lab2.Helpers
{
    /// <summary>
    /// Bài 02: đếm số dòng, số từ, số ký tự của một chuỗi văn bản.
    /// </summary>
    public static class ThongKeVanBan
    {
        // Đếm dòng giống cách StreamReader.ReadLine tách dòng (\n, \r\n hoặc \r)
        public static int DemSoDong(string noiDung)
        {
            int soDong = 0;
            using StringReader reader = new StringReader(noiDung);
            while (reader.ReadLine() != null)
            {
                soDong++;
            }
            return soDong;
        }

        // Từ là chuỗi ký tự liên tiếp không chứa khoảng trắng (space, tab, xuống dòng...)
        public static int DemSoTu(string noiDung)
        {
            return noiDung.Split((char[]?)null, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        // Số ký tự tính cả khoảng trắng và ký tự xuống dòng
        public static int DemSoKyTu(string noiDung)
        {
            return noiDung.Length;
        }
    }
}
