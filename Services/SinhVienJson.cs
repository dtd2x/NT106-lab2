using System.Text.Encodings.Web;
using System.Text.Json;
using NT106_Lab2.Models;

namespace NT106_Lab2.Services
{
    /// <summary>
    /// Bài 04: ghi/đọc danh sách sinh viên bằng JsonSerializer
    /// (thay cho BinaryFormatter đã bị loại bỏ từ .NET 9 vì lý do bảo mật).
    /// </summary>
    public static class SinhVienJson
    {
        private static readonly JsonSerializerOptions TuyChon = new JsonSerializerOptions
        {
            WriteIndented = true,
            // Giữ nguyên tiếng Việt có dấu trong file thay vì đổi thành ạ...
            Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
        };

        public static void Ghi(string duongDan, List<SinhVien> danhSach)
        {
            using FileStream fs = new FileStream(duongDan, FileMode.Create, FileAccess.Write);
            JsonSerializer.Serialize(fs, danhSach, TuyChon);
        }

        public static List<SinhVien> Doc(string duongDan)
        {
            using FileStream fs = new FileStream(duongDan, FileMode.Open, FileAccess.Read);
            List<SinhVien>? danhSach = JsonSerializer.Deserialize<List<SinhVien>>(fs, TuyChon);
            return danhSach ?? new List<SinhVien>();
        }
    }
}
