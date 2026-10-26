using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;

namespace NT106_Lab2.Helpers
{
    /// <summary>
    /// Bài 06, 07: các thao tác với ảnh (đọc file, chuyển byte[] &lt;-&gt; Image, tạo ảnh minh hoạ).
    /// </summary>
    public static class XuLyAnh
    {
        private const int CanhToiDa = 800;

        // Đọc file ảnh bằng FileStream, thu nhỏ nếu cạnh dài hơn 800px rồi trả về byte[] JPEG để lưu BLOB
        public static byte[] DocVaThuNho(string duongDan)
        {
            using FileStream fs = new FileStream(duongDan, FileMode.Open, FileAccess.Read);
            using Image anhGoc = Image.FromStream(fs);

            double tiLe = Math.Min(1.0, (double)CanhToiDa / Math.Max(anhGoc.Width, anhGoc.Height));
            int rong = Math.Max(1, (int)(anhGoc.Width * tiLe));
            int cao = Math.Max(1, (int)(anhGoc.Height * tiLe));

            using Bitmap anhMoi = new Bitmap(anhGoc, rong, cao);
            using MemoryStream ms = new MemoryStream();
            anhMoi.Save(ms, ImageFormat.Jpeg);
            return ms.ToArray();
        }

        // Tạo bản sao Image từ byte[] để ảnh không phụ thuộc vào stream đã đóng
        public static Image TuMangByte(byte[] duLieu)
        {
            using MemoryStream ms = new MemoryStream(duLieu);
            using Image anh = Image.FromStream(ms);
            return new Bitmap(anh);
        }

        // Đọc file ảnh trên đĩa (Bài 07), cho phép file đang được chương trình khác mở
        public static Image DocFile(string duongDan)
        {
            using FileStream fs = new FileStream(duongDan, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            using Image anh = Image.FromStream(fs);
            return new Bitmap(anh);
        }

        // Ảnh vuông cỡ nhỏ cho ListView, giữ đúng tỉ lệ ảnh gốc
        public static Image TaoAnhThuNho(Image anh, int canh)
        {
            Bitmap anhNho = new Bitmap(canh, canh);
            using Graphics g = Graphics.FromImage(anhNho);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.Clear(Color.White);

            double tiLe = Math.Min((double)canh / anh.Width, (double)canh / anh.Height);
            int rong = (int)(anh.Width * tiLe);
            int cao = (int)(anh.Height * tiLe);
            g.DrawImage(anh, (canh - rong) / 2, (canh - cao) / 2, rong, cao);
            return anhNho;
        }

        // Ảnh minh hoạ cho dữ liệu mẫu: nền màu, một cái đĩa và tên món
        public static byte[] TaoAnhMinhHoa(string tenMon, Color mauNen)
        {
            const int rong = 480;
            const int cao = 320;
            using Bitmap anh = new Bitmap(rong, cao);
            using Graphics g = Graphics.FromImage(anh);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;

            Rectangle khung = new Rectangle(0, 0, rong, cao);
            using (LinearGradientBrush nen = new LinearGradientBrush(khung, mauNen, ControlPaint.Dark(mauNen), 45f))
            {
                g.FillRectangle(nen, khung);
            }
            using (SolidBrush dia = new SolidBrush(Color.FromArgb(235, 255, 255, 255)))
            {
                g.FillEllipse(dia, 150, 40, 180, 180);
            }
            using (SolidBrush lonDia = new SolidBrush(Color.FromArgb(60, mauNen)))
            {
                g.FillEllipse(lonDia, 180, 70, 120, 120);
            }
            using (Font chu = new Font("Segoe UI", 26F, FontStyle.Bold))
            using (StringFormat canGiua = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
            {
                g.DrawString(tenMon, chu, Brushes.White, new RectangleF(0, 228, rong, 80), canGiua);
            }

            using MemoryStream ms = new MemoryStream();
            anh.Save(ms, ImageFormat.Png);
            return ms.ToArray();
        }
    }
}
