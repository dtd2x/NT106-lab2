using System.Text;
using NT106_Lab2.Helpers;

namespace NT106_Lab2
{
    public partial class Bai1 : Form
    {
        private const string TenFileDoc = "input1.txt";
        private const string TenFileGhi = "output1.txt";

        // Nội dung của lần đọc gần nhất; null nghĩa là chưa đọc file
        private string? noiDungDaDoc;

        public Bai1()
        {
            InitializeComponent();
            txtFileDoc.Text = ThuMucDuLieu.LayDuongDan(TenFileDoc);
            txtFileGhi.Text = ThuMucDuLieu.LayDuongDan(TenFileGhi);
        }

        private void btnChonFileDoc_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Chọn file cần đọc";
            ofd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            ofd.InitialDirectory = ThuMucDuLieu.DuongDanThuMuc;
            if (ofd.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            txtFileDoc.Text = ofd.FileName;
            noiDungDaDoc = null;
            rtbNoiDungDoc.Clear();
            rtbNoiDungGhi.Clear();
            lblTrangThai.Text = "Đã chọn file, bấm ĐỌC FILE để đọc.";
        }

        private void btnDocFile_Click(object sender, EventArgs e)
        {
            string duongDan = txtFileDoc.Text;
            if (!File.Exists(duongDan))
            {
                MessageBox.Show("Không tìm thấy file:\n" + duongDan, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // ReadToEnd đọc toàn bộ nội dung file một lần
                using FileStream fs = new FileStream(duongDan, FileMode.Open, FileAccess.Read);
                using StreamReader sr = new StreamReader(fs, Encoding.UTF8);
                noiDungDaDoc = sr.ReadToEnd();
            }
            catch (Exception ex) when (ex is IOException || ex is UnauthorizedAccessException)
            {
                MessageBox.Show("Không đọc được file:\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            rtbNoiDungDoc.Text = noiDungDaDoc;
            rtbNoiDungGhi.Clear();
            lblTrangThai.Text = $"Đã đọc {noiDungDaDoc.Length} ký tự từ {Path.GetFileName(duongDan)}.";
        }

        private void btnGhiFile_Click(object sender, EventArgs e)
        {
            if (noiDungDaDoc == null)
            {
                MessageBox.Show("Vui lòng đọc file trước khi ghi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string duongDanGhi = txtFileGhi.Text;
            string noiDungInHoa = noiDungDaDoc.ToUpper();

            try
            {
                // FileMode.Create: tạo mới hoặc ghi đè nếu file đã tồn tại
                using (FileStream fs = new FileStream(duongDanGhi, FileMode.Create, FileAccess.Write))
                using (StreamWriter sw = new StreamWriter(fs, new UTF8Encoding(false)))
                {
                    sw.Write(noiDungInHoa);
                }

                // Đọc lại file vừa ghi để hiển thị đúng nội dung đang nằm trên đĩa
                using StreamReader sr = new StreamReader(duongDanGhi, Encoding.UTF8);
                rtbNoiDungGhi.Text = sr.ReadToEnd();
            }
            catch (Exception ex) when (ex is IOException || ex is UnauthorizedAccessException)
            {
                MessageBox.Show("Không ghi được file:\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblTrangThai.Text = "Đã ghi nội dung in hoa vào " + Path.GetFileName(duongDanGhi) + ".";
            MessageBox.Show("Ghi file thành công!\n" + duongDanGhi, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
