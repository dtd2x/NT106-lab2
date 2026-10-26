using Microsoft.Data.Sqlite;
using NT106_Lab2.Helpers;
using NT106_Lab2.Models;
using NT106_Lab2.Services;

namespace NT106_Lab2
{
    public partial class Bai6 : Form
    {
        private const string TenFileCSDL = "monan.db";
        private const int CanhAnhNho = 40;

        private readonly MonAnDatabase csdl = new MonAnDatabase(ThuMucDuLieu.LayDuongDan(TenFileCSDL));
        private List<MonAn> danhSachMonAn = new List<MonAn>();
        // Ảnh đã chọn cho món sắp thêm (đã thu nhỏ, dạng byte[] để lưu BLOB)
        private byte[]? anhDaChon;

        public Bai6()
        {
            InitializeComponent();
            cboQuyenHan.SelectedIndex = 1;
        }

        private void Bai6_Load(object sender, EventArgs e)
        {
            try
            {
                csdl.KhoiTao();
                if (!csdl.CoDuLieu())
                {
                    TaoDuLieuMau();
                }
                TaiNguoiDung();
                TaiMonAn();
            }
            catch (SqliteException ex)
            {
                MessageBox.Show("Lỗi cơ sở dữ liệu:\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Lần chạy đầu: thêm 3 người dùng và 7 món ăn của Bài 8 - Lab 1.
        // Ảnh lấy từ thư mục Data\MonAn; món nào thiếu ảnh thì dùng ảnh minh hoạ tự vẽ.
        private void TaoDuLieuMau()
        {
            int idAn = csdl.ThemNguoiDung("Nguyễn Văn An", "Admin");
            int idBinh = csdl.ThemNguoiDung("Trần Thị Bình", "Người dùng");
            int idCuong = csdl.ThemNguoiDung("Lê Hoàng Cường", "Người dùng");

            var monMau = new (string Ten, string TenFileAnh, Color Mau, int IdNguoiGop)[]
            {
                ("Phở", "pho", Color.FromArgb(194, 65, 12), idAn),
                ("Bún bò Huế", "bun-bo-hue", Color.FromArgb(185, 28, 28), idBinh),
                ("Cơm tấm", "com-tam", Color.FromArgb(180, 83, 9), idCuong),
                ("Bánh mì", "banh-mi", Color.FromArgb(161, 98, 7), idAn),
                ("Hủ tiếu", "hu-tieu", Color.FromArgb(21, 128, 61), idBinh),
                ("Bánh xèo", "banh-xeo", Color.FromArgb(202, 138, 4), idCuong),
                ("Gỏi cuốn", "goi-cuon", Color.FromArgb(13, 148, 136), idAn)
            };
            foreach (var mon in monMau)
            {
                byte[] hinhAnh = DocAnhMau(mon.TenFileAnh) ?? XuLyAnh.TaoAnhMinhHoa(mon.Ten, mon.Mau);
                csdl.ThemMonAn(mon.Ten, hinhAnh, mon.IdNguoiGop);
            }
        }

        // Tìm ảnh <tên file>.jpg/.jpeg/.png trong Data\MonAn; trả về null nếu không có hoặc ảnh hỏng
        private static byte[]? DocAnhMau(string tenFile)
        {
            string thuMucAnh = Path.Combine(ThuMucDuLieu.DuongDanThuMuc, "MonAn");
            foreach (string duoi in new[] { ".jpg", ".jpeg", ".png" })
            {
                string duongDan = Path.Combine(thuMucAnh, tenFile + duoi);
                if (!File.Exists(duongDan))
                {
                    continue;
                }
                try
                {
                    return XuLyAnh.DocVaThuNho(duongDan);
                }
                catch (Exception ex) when (ex is IOException || ex is ArgumentException || ex is UnauthorizedAccessException)
                {
                    return null;
                }
            }
            return null;
        }

        private void TaiNguoiDung()
        {
            cboNguoiDongGop.Items.Clear();
            foreach (NguoiDung nguoiDung in csdl.LayDanhSachNguoiDung())
            {
                cboNguoiDongGop.Items.Add(nguoiDung);
            }
            if (cboNguoiDongGop.Items.Count > 0)
            {
                cboNguoiDongGop.SelectedIndex = 0;
            }
        }

        // Đọc bảng MonAn (JOIN NguoiDung) và hiển thị lên ListView kèm ảnh nhỏ
        private void TaiMonAn()
        {
            danhSachMonAn = csdl.LayDanhSachMonAn();

            lvwMonAn.BeginUpdate();
            lvwMonAn.Items.Clear();
            imlMonAn.Images.Clear();
            foreach (MonAn mon in danhSachMonAn)
            {
                string khoaAnh = mon.IDMA.ToString();
                if (mon.HinhAnh != null)
                {
                    using Image anh = XuLyAnh.TuMangByte(mon.HinhAnh);
                    imlMonAn.Images.Add(khoaAnh, XuLyAnh.TaoAnhThuNho(anh, CanhAnhNho));
                }

                ListViewItem dong = new ListViewItem(mon.TenMonAn);
                dong.ImageKey = khoaAnh;
                dong.SubItems.Add(mon.TenNguoiDongGop);
                dong.Tag = mon;
                lvwMonAn.Items.Add(dong);
            }
            lvwMonAn.EndUpdate();
            lblDanhSach.Text = $"Danh sách món ăn ({danhSachMonAn.Count} món)";
        }

        private void btnThemNguoiDung_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text.Trim();
            if (hoTen == "")
            {
                BaoLoi("Vui lòng nhập họ và tên người dùng.", txtHoTen);
                return;
            }
            string quyenHan = cboQuyenHan.Text;

            try
            {
                int idMoi = csdl.ThemNguoiDung(hoTen, quyenHan);
                TaiNguoiDung();
                // Chọn sẵn người vừa thêm để thêm món cho tiện
                foreach (NguoiDung nguoiDung in cboNguoiDongGop.Items)
                {
                    if (nguoiDung.IDNCC == idMoi)
                    {
                        cboNguoiDongGop.SelectedItem = nguoiDung;
                        break;
                    }
                }
            }
            catch (SqliteException ex)
            {
                MessageBox.Show("Không thêm được người dùng:\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtHoTen.Clear();
            MessageBox.Show($"Đã thêm người dùng {hoTen}.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Chọn hình món ăn";
            ofd.Filter = "Hình ảnh|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            if (ofd.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            try
            {
                anhDaChon = XuLyAnh.DocVaThuNho(ofd.FileName);
                DatAnh(picXemTruoc, XuLyAnh.TuMangByte(anhDaChon));
            }
            catch (Exception ex) when (ex is IOException || ex is ArgumentException || ex is UnauthorizedAccessException)
            {
                // Image.FromStream ném ArgumentException khi file không phải ảnh hợp lệ
                anhDaChon = null;
                DatAnh(picXemTruoc, null);
                MessageBox.Show("Không đọc được ảnh:\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            string tenMon = txtTenMon.Text.Trim();
            if (tenMon == "")
            {
                BaoLoi("Vui lòng nhập tên món ăn.", txtTenMon);
                return;
            }
            if (danhSachMonAn.Any(m => string.Equals(m.TenMonAn, tenMon, StringComparison.CurrentCultureIgnoreCase)))
            {
                BaoLoi("Món này đã có trong danh sách.", txtTenMon);
                return;
            }
            if (cboNguoiDongGop.SelectedItem is not NguoiDung nguoiDongGop)
            {
                BaoLoi("Vui lòng chọn người đóng góp.", cboNguoiDongGop);
                return;
            }
            if (anhDaChon == null)
            {
                BaoLoi("Vui lòng chọn hình ảnh cho món ăn.", btnChonAnh);
                return;
            }

            try
            {
                csdl.ThemMonAn(tenMon, anhDaChon, nguoiDongGop.IDNCC);
            }
            catch (SqliteException ex)
            {
                MessageBox.Show("Không thêm được món ăn:\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtTenMon.Clear();
            anhDaChon = null;
            DatAnh(picXemTruoc, null);
            TaiMonAn();
            MessageBox.Show($"Đã thêm món {tenMon}.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoaMon_Click(object sender, EventArgs e)
        {
            if (lvwMonAn.SelectedItems.Count == 0 || lvwMonAn.SelectedItems[0].Tag is not MonAn mon)
            {
                MessageBox.Show("Vui lòng chọn món cần xoá.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult xacNhan = MessageBox.Show($"Xoá món \"{mon.TenMonAn}\"?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (xacNhan != DialogResult.Yes)
            {
                return;
            }

            try
            {
                csdl.XoaMonAn(mon.IDMA);
            }
            catch (SqliteException ex)
            {
                MessageBox.Show("Không xoá được món ăn:\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            TaiMonAn();
        }

        private void btnChonNgauNhien_Click(object sender, EventArgs e)
        {
            MonAn? mon;
            try
            {
                mon = csdl.LayMonAnNgauNhien();
            }
            catch (SqliteException ex)
            {
                MessageBox.Show("Lỗi truy vấn:\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (mon == null)
            {
                MessageBox.Show("Chưa có món ăn nào trong cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            lblTenMonChon.Text = mon.TenMonAn;
            lblNguoiGop.Text = "Người đóng góp: " + mon.TenNguoiDongGop;
            DatAnh(picMonAn, mon.HinhAnh != null ? XuLyAnh.TuMangByte(mon.HinhAnh) : null);

            // Đánh dấu món được chọn trong danh sách
            foreach (ListViewItem dong in lvwMonAn.Items)
            {
                dong.Selected = dong.Tag is MonAn m && m.IDMA == mon.IDMA;
                if (dong.Selected)
                {
                    dong.EnsureVisible();
                }
            }
        }

        // Gán ảnh mới cho PictureBox và giải phóng ảnh cũ
        private static void DatAnh(PictureBox khungAnh, Image? anhMoi)
        {
            Image? anhCu = khungAnh.Image;
            khungAnh.Image = anhMoi;
            anhCu?.Dispose();
        }

        private void BaoLoi(string thongBao, Control oBiLoi)
        {
            MessageBox.Show(thongBao, "Dữ liệu không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            oBiLoi.Focus();
        }

        // Đóng hết kết nối trong pool để file monan.db không bị khoá sau khi đóng form
        private void Bai6_FormClosed(object sender, FormClosedEventArgs e)
        {
            SqliteConnection.ClearAllPools();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
