using System.Text;
using NT106_Lab2.Helpers;

namespace NT106_Lab2
{
    public partial class Bai7 : Form
    {
        // Chỉ hiển thị tối đa 1 MB đầu của file văn bản để giao diện không bị treo
        private const int GioiHanDocVanBan = 1024 * 1024;
        private static readonly string[] DuoiFileAnh = { ".jpg", ".jpeg", ".png", ".bmp", ".gif", ".ico", ".tif", ".tiff" };

        private const string KhoaODia = "odia";
        private const string KhoaThuMuc = "thumuc";
        private const string KhoaFile = "file";

        // Thông tin gắn vào Tag của mỗi nút trên cây; nút tạm (chưa tải) có Tag = null
        private sealed class MucDuyet
        {
            public MucDuyet(string duongDan, bool laThuMuc)
            {
                DuongDan = duongDan;
                LaThuMuc = laThuMuc;
            }

            public string DuongDan { get; }
            public bool LaThuMuc { get; }
        }

        public Bai7()
        {
            InitializeComponent();
            TaoBieuTuong();
            TaiODia();
        }

        private void TaiODia()
        {
            tvThuMuc.BeginUpdate();
            tvThuMuc.Nodes.Clear();
            foreach (DriveInfo oDia in DriveInfo.GetDrives())
            {
                if (!oDia.IsReady)
                {
                    continue;
                }
                string nhan = string.IsNullOrWhiteSpace(oDia.VolumeLabel) ? "Local Disk" : oDia.VolumeLabel;
                TreeNode nut = TaoNut($"{nhan} ({oDia.Name})", new MucDuyet(oDia.RootDirectory.FullName, true), KhoaODia);
                tvThuMuc.Nodes.Add(nut);
            }
            tvThuMuc.EndUpdate();
        }

        private static TreeNode TaoNut(string ten, MucDuyet muc, string khoaBieuTuong)
        {
            TreeNode nut = new TreeNode(ten);
            nut.Tag = muc;
            nut.ImageKey = khoaBieuTuong;
            nut.SelectedImageKey = khoaBieuTuong;
            if (muc.LaThuMuc)
            {
                // Thêm một nút tạm để hiện dấu [+]; nội dung thật chỉ tải khi mở ra
                nut.Nodes.Add(new TreeNode("Đang tải..."));
            }
            return nut;
        }

        // Nhấp đúp hoặc bấm [+] đều gọi sự kiện này trước khi mở thư mục
        private void tvThuMuc_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode? nut = e.Node;
            if (nut == null || nut.Tag is not MucDuyet muc)
            {
                return;
            }
            bool chuaTai = nut.Nodes.Count == 1 && nut.Nodes[0].Tag == null;
            if (chuaTai)
            {
                TaiNoiDungThuMuc(nut, muc.DuongDan);
            }
        }

        private void TaiNoiDungThuMuc(TreeNode nut, string duongDan)
        {
            tvThuMuc.BeginUpdate();
            nut.Nodes.Clear();
            try
            {
                DirectoryInfo thuMuc = new DirectoryInfo(duongDan);
                foreach (DirectoryInfo con in thuMuc.GetDirectories().OrderBy(d => d.Name, StringComparer.CurrentCultureIgnoreCase))
                {
                    nut.Nodes.Add(TaoNut(con.Name, new MucDuyet(con.FullName, true), KhoaThuMuc));
                }
                foreach (FileInfo file in thuMuc.GetFiles().OrderBy(f => f.Name, StringComparer.CurrentCultureIgnoreCase))
                {
                    nut.Nodes.Add(TaoNut(file.Name, new MucDuyet(file.FullName, false), KhoaFile));
                }
            }
            catch (Exception ex) when (ex is UnauthorizedAccessException || ex is IOException || ex is System.Security.SecurityException)
            {
                // Thư mục hệ thống không có quyền đọc: báo ngay trên cây, không làm dừng chương trình
                TreeNode nutLoi = new TreeNode("(Không có quyền truy cập)");
                nutLoi.ForeColor = Color.Gray;
                nutLoi.Tag = new MucDuyet(duongDan, false);
                nut.Nodes.Add(nutLoi);
            }
            finally
            {
                tvThuMuc.EndUpdate();
            }
        }

        private void tvThuMuc_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node?.Tag is not MucDuyet muc)
            {
                return;
            }

            lblDuongDan.Text = muc.DuongDan;
            if (muc.LaThuMuc)
            {
                HienThiThongBao("Nhấp đúp vào thư mục để mở, chọn một file để xem nội dung.");
                return;
            }
            if (!File.Exists(muc.DuongDan))
            {
                HienThiThongBao("Không có quyền truy cập thư mục này.");
                return;
            }
            HienThiFile(muc.DuongDan);
        }

        private void HienThiFile(string duongDan)
        {
            try
            {
                string duoi = Path.GetExtension(duongDan).ToLowerInvariant();
                if (DuoiFileAnh.Contains(duoi))
                {
                    HienThiAnh(XuLyAnh.DocFile(duongDan));
                }
                else
                {
                    HienThiVanBan(duongDan);
                }
            }
            catch (Exception ex) when (ex is IOException || ex is UnauthorizedAccessException || ex is ArgumentException || ex is OutOfMemoryException)
            {
                HienThiThongBao("Không mở được file: " + ex.Message);
            }
        }

        private void HienThiVanBan(string duongDan)
        {
            using FileStream fs = new FileStream(duongDan, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            long kichThuoc = fs.Length;
            int soByteCanDoc = (int)Math.Min(kichThuoc, GioiHanDocVanBan);

            // Đọc tối đa 1 MB đầu tiên vào bộ đệm
            byte[] boDem = new byte[soByteCanDoc];
            int daDoc = 0;
            while (daDoc < soByteCanDoc)
            {
                int soByte = fs.Read(boDem, daDoc, soByteCanDoc - daDoc);
                if (soByte == 0)
                {
                    break;
                }
                daDoc += soByte;
            }

            if (LaFileNhiPhan(boDem, daDoc))
            {
                HienThiThongBao($"File nhị phân ({kichThuoc:N0} bytes), không hiển thị được dưới dạng văn bản.");
                return;
            }

            // StreamReader tự nhận dạng BOM (UTF-8, UTF-16...), mặc định là UTF-8
            string noiDung;
            using (MemoryStream ms = new MemoryStream(boDem, 0, daDoc))
            using (StreamReader sr = new StreamReader(ms, Encoding.UTF8, true))
            {
                noiDung = sr.ReadToEnd();
            }
            if (kichThuoc > GioiHanDocVanBan)
            {
                noiDung += $"\n\n... (chỉ hiển thị 1 MB đầu tiên, file có {kichThuoc:N0} bytes)";
            }

            DatAnh(null);
            picNoiDung.Visible = false;
            rtbNoiDung.Visible = true;
            rtbNoiDung.Text = noiDung;
        }

        // File có byte 0 trong 8 KB đầu (và không phải UTF-16 có BOM) thì coi là file nhị phân
        private static bool LaFileNhiPhan(byte[] duLieu, int soByte)
        {
            bool laUtf16 = soByte >= 2
                && ((duLieu[0] == 0xFF && duLieu[1] == 0xFE) || (duLieu[0] == 0xFE && duLieu[1] == 0xFF));
            if (laUtf16)
            {
                return false;
            }
            int soByteKiemTra = Math.Min(soByte, 8000);
            for (int i = 0; i < soByteKiemTra; i++)
            {
                if (duLieu[i] == 0)
                {
                    return true;
                }
            }
            return false;
        }

        private void HienThiAnh(Image anh)
        {
            rtbNoiDung.Visible = false;
            DatAnh(anh);
            picNoiDung.Visible = true;
        }

        private void HienThiThongBao(string thongBao)
        {
            DatAnh(null);
            picNoiDung.Visible = false;
            rtbNoiDung.Visible = true;
            rtbNoiDung.Text = thongBao;
        }

        // Gán ảnh mới cho PictureBox và giải phóng ảnh cũ
        private void DatAnh(Image? anhMoi)
        {
            Image? anhCu = picNoiDung.Image;
            picNoiDung.Image = anhMoi;
            anhCu?.Dispose();
        }

        // ===== Vẽ biểu tượng 16x16 cho ổ đĩa, thư mục, file =====

        private void TaoBieuTuong()
        {
            imlBieuTuong.Images.Add(KhoaODia, VeBieuTuongODia());
            imlBieuTuong.Images.Add(KhoaThuMuc, VeBieuTuongThuMuc());
            imlBieuTuong.Images.Add(KhoaFile, VeBieuTuongFile());
        }

        private static Bitmap VeBieuTuongODia()
        {
            Bitmap anh = new Bitmap(16, 16);
            using Graphics g = Graphics.FromImage(anh);
            using SolidBrush than = new SolidBrush(Color.FromArgb(100, 116, 139));
            using SolidBrush den = new SolidBrush(Color.FromArgb(34, 197, 94));
            g.FillRectangle(than, 1, 5, 14, 7);
            g.FillRectangle(den, 11, 9, 2, 2);
            return anh;
        }

        private static Bitmap VeBieuTuongThuMuc()
        {
            Bitmap anh = new Bitmap(16, 16);
            using Graphics g = Graphics.FromImage(anh);
            using SolidBrush tai = new SolidBrush(Color.FromArgb(217, 119, 6));
            using SolidBrush than = new SolidBrush(Color.FromArgb(251, 191, 36));
            g.FillRectangle(tai, 1, 3, 6, 3);
            g.FillRectangle(than, 1, 5, 14, 9);
            return anh;
        }

        private static Bitmap VeBieuTuongFile()
        {
            Bitmap anh = new Bitmap(16, 16);
            using Graphics g = Graphics.FromImage(anh);
            using Pen vien = new Pen(Color.FromArgb(100, 116, 139));
            using Pen dong = new Pen(Color.FromArgb(148, 163, 184));
            g.FillRectangle(Brushes.White, 3, 1, 10, 14);
            g.DrawRectangle(vien, 3, 1, 10, 14);
            g.DrawLine(dong, 5, 5, 11, 5);
            g.DrawLine(dong, 5, 8, 11, 8);
            g.DrawLine(dong, 5, 11, 9, 11);
            return anh;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
