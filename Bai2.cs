using System.Text;
using NT106_Lab2.Helpers;

namespace NT106_Lab2
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void btnDocFile_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Chọn file .txt";
            ofd.Filter = "Text files (*.txt)|*.txt";
            ofd.InitialDirectory = ThuMucDuLieu.DuongDanThuMuc;
            if (ofd.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            string noiDung;
            string duongDan;
            long kichThuoc;
            try
            {
                using FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                // fs.Name là đường dẫn đầy đủ, fs.Length là kích thước file tính bằng byte
                duongDan = fs.Name;
                kichThuoc = fs.Length;
                using StreamReader sr = new StreamReader(fs, Encoding.UTF8);
                noiDung = sr.ReadToEnd();
            }
            catch (Exception ex) when (ex is IOException || ex is UnauthorizedAccessException)
            {
                MessageBox.Show("Không đọc được file:\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtTenFile.Text = ofd.SafeFileName;
            txtKichThuoc.Text = kichThuoc.ToString("N0") + " bytes";
            txtDuongDan.Text = duongDan;
            txtSoDong.Text = ThongKeVanBan.DemSoDong(noiDung).ToString();
            txtSoTu.Text = ThongKeVanBan.DemSoTu(noiDung).ToString();
            txtSoKyTu.Text = ThongKeVanBan.DemSoKyTu(noiDung).ToString();
            rtbNoiDung.Text = noiDung;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtTenFile.Clear();
            txtKichThuoc.Clear();
            txtDuongDan.Clear();
            txtSoDong.Clear();
            txtSoTu.Clear();
            txtSoKyTu.Clear();
            rtbNoiDung.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
