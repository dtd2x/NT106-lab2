using System.Globalization;
using System.Text.RegularExpressions;
using NT106_Lab2.Models;

namespace NT106_Lab2.Helpers
{
    /// <summary>
    /// Bài 04: các ràng buộc dữ liệu của sinh viên.
    /// </summary>
    public static class KiemTraSinhVien
    {
        public const float DiemToiThieu = 0;
        public const float DiemToiDa = 10;

        // MSSV là số có đúng 8 chữ số (chữ số đầu khác 0 để khi lưu kiểu int không bị mất số)
        public static bool KiemTraMSSV(string chuoi, out int mssv)
        {
            mssv = 0;
            return Regex.IsMatch(chuoi, "^[1-9][0-9]{7}$") && int.TryParse(chuoi, out mssv);
        }

        // Số điện thoại có 10 chữ số và bắt đầu bằng số 0
        public static bool KiemTraDienThoai(string chuoi)
        {
            return Regex.IsMatch(chuoi, "^0[0-9]{9}$");
        }

        // Điểm là số thực từ 0 đến 10, chấp nhận cả dấu chấm và dấu phẩy
        public static bool KiemTraDiem(string chuoi, out float diem)
        {
            string chuanHoa = chuoi.Trim().Replace(',', '.');
            if (!float.TryParse(chuanHoa, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out diem))
            {
                return false;
            }
            return diem >= DiemToiThieu && diem <= DiemToiDa;
        }

        // Kiểm tra lại một sinh viên đọc từ file (file có thể bị sửa tay)
        public static bool HopLe(SinhVien sv)
        {
            return !string.IsNullOrWhiteSpace(sv.HoTen)
                && sv.MSSV >= 10000000 && sv.MSSV <= 99999999
                && KiemTraDienThoai(sv.DienThoai)
                && LaDiemHopLe(sv.DiemMon1)
                && LaDiemHopLe(sv.DiemMon2)
                && LaDiemHopLe(sv.DiemMon3);
        }

        private static bool LaDiemHopLe(float diem)
        {
            return diem >= DiemToiThieu && diem <= DiemToiDa;
        }
    }
}
