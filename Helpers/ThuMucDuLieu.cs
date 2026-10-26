namespace NT106_Lab2.Helpers
{
    /// <summary>
    /// Quản lý thư mục Data nằm cạnh file .exe, nơi chứa các file input/output của các bài.
    /// </summary>
    public static class ThuMucDuLieu
    {
        public static string DuongDanThuMuc
        {
            get
            {
                string thuMuc = Path.Combine(AppContext.BaseDirectory, "Data");
                Directory.CreateDirectory(thuMuc);
                return thuMuc;
            }
        }

        public static string LayDuongDan(string tenFile)
        {
            return Path.Combine(DuongDanThuMuc, tenFile);
        }
    }
}
