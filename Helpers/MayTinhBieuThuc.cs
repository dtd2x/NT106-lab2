using System.Globalization;
using System.Text;

namespace NT106_Lab2.Helpers
{
    /// <summary>
    /// Bài 03: tính giá trị biểu thức gồm + - * /, ngoặc đơn và số thập phân,
    /// không dùng DataTable.Compute.
    ///
    /// Dùng phương pháp đệ quy xuống (recursive descent) theo văn phạm:
    ///   BieuThuc := Hang   (('+' | '-') Hang)*
    ///   Hang     := ThuaSo (('*' | '/') ThuaSo)*
    ///   ThuaSo   := ('+' | '-') ThuaSo | So | '(' BieuThuc ')'
    /// Mỗi tầng ứng với một mức ưu tiên nên nhân chia luôn được tính trước cộng trừ.
    /// </summary>
    public class MayTinhBieuThuc
    {
        private readonly string bieuThuc;
        private int viTri;

        private MayTinhBieuThuc(string bieuThuc)
        {
            this.bieuThuc = ChuanHoaKyHieu(bieuThuc);
            viTri = 0;
        }

        /// <summary>
        /// Tính giá trị biểu thức. Ném FormatException nếu sai cú pháp,
        /// DivideByZeroException nếu chia cho 0, OverflowException nếu số quá lớn.
        /// </summary>
        public static decimal Tinh(string bieuThuc)
        {
            if (string.IsNullOrWhiteSpace(bieuThuc))
            {
                throw new FormatException("Biểu thức rỗng");
            }

            MayTinhBieuThuc mayTinh = new MayTinhBieuThuc(bieuThuc);
            decimal ketQua = mayTinh.DocBieuThuc();

            // Đọc xong mà vẫn còn ký tự thừa, ví dụ "1 + 2 )"
            char? kyTuThua = mayTinh.XemKyTu();
            if (kyTuThua != null)
            {
                throw new FormatException($"Ký tự '{kyTuThua}' không hợp lệ ở vị trí {mayTinh.viTri + 1}");
            }
            return ketQua;
        }

        /// <summary>
        /// Tạo một dòng kết quả cho output3.txt, dạng "biểu thức = kết quả".
        /// Biểu thức lỗi vẫn có một dòng, phần kết quả ghi rõ lỗi.
        /// </summary>
        public static string TaoDongKetQua(string bieuThuc, out bool coLoi)
        {
            coLoi = true;
            try
            {
                string ketQua = DinhDang(Tinh(bieuThuc));
                coLoi = false;
                return bieuThuc + " = " + ketQua;
            }
            catch (DivideByZeroException)
            {
                return bieuThuc + " = Lỗi: chia cho 0";
            }
            catch (OverflowException)
            {
                return bieuThuc + " = Lỗi: kết quả vượt quá giới hạn";
            }
            catch (FormatException ex)
            {
                return bieuThuc + " = Lỗi: " + ex.Message;
            }
        }

        // Bỏ số 0 thừa ở phần thập phân: 10.000 -> 10, 111.80 -> 111.8
        public static string DinhDang(decimal so)
        {
            return so.ToString("0.##########", CultureInfo.InvariantCulture);
        }

        // Đề bài dùng dấu gạch ngang dài (–) thay cho dấu trừ, nên đổi về ký hiệu chuẩn
        private static string ChuanHoaKyHieu(string s)
        {
            StringBuilder sb = new StringBuilder(s.Length);
            foreach (char c in s)
            {
                switch (c)
                {
                    case '–': // en dash
                    case '—': // em dash
                    case '−': // dấu trừ toán học
                        sb.Append('-');
                        break;
                    case '×':
                        sb.Append('*');
                        break;
                    case '÷':
                        sb.Append('/');
                        break;
                    default:
                        sb.Append(c);
                        break;
                }
            }
            return sb.ToString();
        }

        // BieuThuc := Hang (('+' | '-') Hang)*
        private decimal DocBieuThuc()
        {
            decimal ketQua = DocHang();
            while (true)
            {
                char? toanTu = XemKyTu();
                if (toanTu == '+')
                {
                    viTri++;
                    ketQua += DocHang();
                }
                else if (toanTu == '-')
                {
                    viTri++;
                    ketQua -= DocHang();
                }
                else
                {
                    return ketQua;
                }
            }
        }

        // Hang := ThuaSo (('*' | '/') ThuaSo)*
        private decimal DocHang()
        {
            decimal ketQua = DocThuaSo();
            while (true)
            {
                char? toanTu = XemKyTu();
                if (toanTu == '*')
                {
                    viTri++;
                    ketQua *= DocThuaSo();
                }
                else if (toanTu == '/')
                {
                    viTri++;
                    decimal soChia = DocThuaSo();
                    if (soChia == 0)
                    {
                        throw new DivideByZeroException();
                    }
                    ketQua /= soChia;
                }
                else
                {
                    return ketQua;
                }
            }
        }

        // ThuaSo := ('+' | '-') ThuaSo | So | '(' BieuThuc ')'
        private decimal DocThuaSo()
        {
            char? kyTu = XemKyTu();
            if (kyTu == null)
            {
                throw new FormatException("Biểu thức bị thiếu toán hạng ở cuối");
            }

            if (kyTu == '+')
            {
                viTri++;
                return DocThuaSo();
            }
            if (kyTu == '-')
            {
                viTri++;
                return -DocThuaSo();
            }
            if (kyTu == '(')
            {
                viTri++;
                decimal giaTri = DocBieuThuc();
                if (XemKyTu() != ')')
                {
                    throw new FormatException("Thiếu dấu ngoặc đóng ')'");
                }
                viTri++;
                return giaTri;
            }
            if (char.IsDigit(kyTu.Value) || kyTu == '.' || kyTu == ',')
            {
                return DocSo();
            }
            throw new FormatException($"Ký tự '{kyTu}' không hợp lệ ở vị trí {viTri + 1}");
        }

        // Đọc một số thực; chấp nhận cả dấu chấm và dấu phẩy làm dấu thập phân
        private decimal DocSo()
        {
            int batDau = viTri;
            bool daCoDauThapPhan = false;
            while (viTri < bieuThuc.Length)
            {
                char c = bieuThuc[viTri];
                if (char.IsDigit(c))
                {
                    viTri++;
                }
                else if ((c == '.' || c == ',') && !daCoDauThapPhan)
                {
                    daCoDauThapPhan = true;
                    viTri++;
                }
                else
                {
                    break;
                }
            }

            string chuoiSo = bieuThuc.Substring(batDau, viTri - batDau).Replace(',', '.');
            if (!decimal.TryParse(chuoiSo, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out decimal so))
            {
                throw new FormatException($"Số '{chuoiSo}' không hợp lệ");
            }
            return so;
        }

        // Trả về ký tự tiếp theo (đã bỏ khoảng trắng) mà không di chuyển vị trí; null nếu hết chuỗi
        private char? XemKyTu()
        {
            while (viTri < bieuThuc.Length && char.IsWhiteSpace(bieuThuc[viTri]))
            {
                viTri++;
            }
            if (viTri < bieuThuc.Length)
            {
                return bieuThuc[viTri];
            }
            return null;
        }
    }
}
