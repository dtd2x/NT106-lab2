using System.Text;
using NT106_Lab2.Helpers;

namespace NT106_Lab2
{
    public partial class Bai3 : Form
    {
        private const string TenFileDoc = "input3.txt";
        private const string TenFileGhi = "output3.txt";

        // Các dòng biểu thức đọc được từ file
        private List<string> cacDongBieuThuc = new List<string>();

        public Bai3()
        {
            InitializeComponent();
            txtFileDoc.Text = ThuMucDuLieu.LayDuongDan(TenFileDoc);
        }

        private void btnChonFileDoc_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Chọn file biểu thức";
            ofd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            ofd.InitialDirectory = ThuMucDuLieu.DuongDanThuMuc;
            if (ofd.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            txtFileDoc.Text = ofd.FileName;
            cacDongBieuThuc.Clear();
            rtbInput.Clear();
            rtbOutput.Clear();
            lblTrangThai.Text = "Đã chọn file, bấm Đọc file.";
        }

        private void btnDocFile_Click(object sender, EventArgs e)
        {
            string duongDan = txtFileDoc.Text;
            if (!File.Exists(duongDan))
            {
                MessageBox.Show("Không tìm thấy file:\n" + duongDan, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<string> cacDong = new List<string>();
            try
            {
                using StreamReader sr = new StreamReader(duongDan, Encoding.UTF8);
                string? dong;
                while ((dong = sr.ReadLine()) != null)
                {
                    cacDong.Add(dong);
                }
            }
            catch (Exception ex) when (ex is IOException || ex is UnauthorizedAccessException)
            {
                MessageBox.Show("Không đọc được file:\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            cacDongBieuThuc = cacDong;
            rtbInput.Lines = cacDongBieuThuc.ToArray();
            rtbOutput.Clear();
            lblTrangThai.Text = $"Đã đọc {cacDongBieuThuc.Count} dòng. Bấm \"Tính và ghi\" để tính kết quả.";
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            if (cacDongBieuThuc.Count == 0)
            {
                MessageBox.Show("Vui lòng đọc file trước (hoặc file đang rỗng).", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<string> ketQua = new List<string>();
            List<int> dongLoi = new List<int>();
            foreach (string dong in cacDongBieuThuc)
            {
                string bieuThuc = dong.Trim();
                if (bieuThuc == "")
                {
                    // Giữ dòng trống để output thẳng hàng với input
                    ketQua.Add("");
                    continue;
                }

                ketQua.Add(MayTinhBieuThuc.TaoDongKetQua(bieuThuc, out bool coLoi));
                if (coLoi)
                {
                    dongLoi.Add(ketQua.Count - 1);
                }
            }

            string duongDanGhi = ThuMucDuLieu.LayDuongDan(TenFileGhi);
            try
            {
                using FileStream fs = new FileStream(duongDanGhi, FileMode.Create, FileAccess.Write);
                using StreamWriter sw = new StreamWriter(fs, new UTF8Encoding(false));
                foreach (string dong in ketQua)
                {
                    sw.WriteLine(dong);
                }
            }
            catch (Exception ex) when (ex is IOException || ex is UnauthorizedAccessException)
            {
                MessageBox.Show("Không ghi được file:\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            HienThiKetQua(ketQua, dongLoi);
            lblTrangThai.Text = $"Đã ghi {TenFileGhi}: {ketQua.Count(d => d != "") - dongLoi.Count} biểu thức đúng, {dongLoi.Count} biểu thức lỗi.";
        }

        // Hiển thị output, tô đỏ các dòng biểu thức bị lỗi
        private void HienThiKetQua(List<string> ketQua, List<int> dongLoi)
        {
            rtbOutput.Lines = ketQua.ToArray();
            foreach (int chiSo in dongLoi)
            {
                int viTriDau = rtbOutput.GetFirstCharIndexFromLine(chiSo);
                rtbOutput.Select(viTriDau, ketQua[chiSo].Length);
                rtbOutput.SelectionColor = Color.FromArgb(220, 38, 38);
            }
            rtbOutput.Select(0, 0);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
