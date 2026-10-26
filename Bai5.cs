using System.Text;
using NT106_Lab2.Helpers;
using NT106_Lab2.Models;
using NT106_Lab2.Services;

namespace NT106_Lab2
{
    public partial class Bai5 : Form
    {
        private const string TenFileInput = "input5.txt";
        private const string TenFileOutput = "output5.txt";

        private List<Phim> danhSachPhim = new List<Phim>();
        private readonly List<VeDaBan> danhSachVe = new List<VeDaBan>();
        // Giữ quy tắc của Lab 1: một khách chỉ mua vé ở một phòng chiếu
        private readonly Dictionary<string, int> phongCuaKhach = new Dictionary<string, int>();
        private bool dangXuatFile = false;

        public Bai5()
        {
            InitializeComponent();
            lblLoaiVe.Text = SoDoGhe.MoTaLoaiVe();
            DocFilePhim(false);
        }

        // ===== Đọc file và thêm phim =====

        private void btnDocFile_Click(object sender, EventArgs e)
        {
            DocFilePhim(true);
        }

        private void DocFilePhim(bool baoKhiThieuFile)
        {
            string duongDan = ThuMucDuLieu.LayDuongDan(TenFileInput);
            if (!File.Exists(duongDan))
            {
                if (baoKhiThieuFile)
                {
                    MessageBox.Show("Không tìm thấy file:\n" + duongDan, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }

            try
            {
                danhSachPhim = PhimFile.Doc(duongDan);
            }
            catch (Exception ex) when (ex is IOException || ex is FormatException || ex is UnauthorizedAccessException)
            {
                MessageBox.Show($"Không đọc được {TenFileInput}:\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lstPhim.Items.Clear();
            cboPhim.Items.Clear();
            foreach (Phim phim in danhSachPhim)
            {
                lstPhim.Items.Add(phim);
                cboPhim.Items.Add(phim.TenPhim);
            }
            cboPhongChieu.Items.Clear();
            clbGhe.Items.Clear();
            CapNhatThongKe();
            lblTienDo.Text = $"Đã đọc {danhSachPhim.Count} phim từ {TenFileInput}.";
        }

        private void btnThemPhim_Click(object sender, EventArgs e)
        {
            string tenPhim = txtTenPhimMoi.Text.Trim();
            if (tenPhim == "")
            {
                BaoLoi("Vui lòng nhập tên phim.", txtTenPhimMoi);
                return;
            }
            if (danhSachPhim.Any(p => string.Equals(p.TenPhim, tenPhim, StringComparison.CurrentCultureIgnoreCase)))
            {
                BaoLoi("Phim này đã có trong danh sách.", txtTenPhimMoi);
                return;
            }
            if (!int.TryParse(txtGiaVeMoi.Text.Trim(), out int giaVe) || giaVe <= 0)
            {
                BaoLoi("Giá vé chuẩn phải là số nguyên dương.", txtGiaVeMoi);
                return;
            }
            List<int>? phongChieu = PhimFile.PhanTichPhongChieu(txtPhongMoi.Text);
            if (phongChieu == null)
            {
                BaoLoi("Phòng chiếu là các số nguyên dương cách nhau dấu phẩy, ví dụ: 1,2,3", txtPhongMoi);
                return;
            }

            Phim phimMoi = new Phim { TenPhim = tenPhim, GiaVeChuan = giaVe, PhongChieu = phongChieu };
            try
            {
                PhimFile.GhiThem(ThuMucDuLieu.LayDuongDan(TenFileInput), phimMoi);
            }
            catch (Exception ex) when (ex is IOException || ex is UnauthorizedAccessException)
            {
                MessageBox.Show("Không ghi được file:\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtTenPhimMoi.Clear();
            txtGiaVeMoi.Clear();
            txtPhongMoi.Clear();
            DocFilePhim(true);
            MessageBox.Show($"Đã thêm phim \"{tenPhim}\" vào {TenFileInput}.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BaoLoi(string thongBao, Control oBiLoi)
        {
            MessageBox.Show(thongBao, "Dữ liệu không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            oBiLoi.Focus();
        }

        // ===== Đặt vé (giống Bài 4 - Lab 1) =====

        private Phim? LayPhimDangChon()
        {
            // Thứ tự trong ComboBox trùng với thứ tự trong danhSachPhim
            if (cboPhim.SelectedIndex < 0 || cboPhim.SelectedIndex >= danhSachPhim.Count)
            {
                return null;
            }
            return danhSachPhim[cboPhim.SelectedIndex];
        }

        private void cboPhim_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboPhongChieu.Items.Clear();
            clbGhe.Items.Clear();
            Phim? phim = LayPhimDangChon();
            if (phim == null)
            {
                return;
            }
            foreach (int phong in phim.PhongChieu)
            {
                cboPhongChieu.Items.Add(phong);
            }
        }

        private void cboPhongChieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadGhe();
        }

        // Chỉ hiện các ghế chưa bán của phim và phòng đang chọn
        private void LoadGhe()
        {
            clbGhe.Items.Clear();
            Phim? phim = LayPhimDangChon();
            if (phim == null || cboPhongChieu.SelectedItem is not int phong)
            {
                return;
            }
            foreach (string ghe in SoDoGhe.DanhSachGhe)
            {
                bool daBan = danhSachVe.Any(ve => ve.TenPhim == phim.TenPhim && ve.Phong == phong && ve.Ghe == ghe);
                if (!daBan)
                {
                    clbGhe.Items.Add(ghe);
                }
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text.Trim();
            if (hoTen == "")
            {
                BaoLoi("Vui lòng nhập họ và tên.", txtHoTen);
                return;
            }
            Phim? phim = LayPhimDangChon();
            if (phim == null)
            {
                BaoLoi("Vui lòng chọn phim.", cboPhim);
                return;
            }
            if (cboPhongChieu.SelectedItem is not int phong)
            {
                BaoLoi("Vui lòng chọn phòng chiếu.", cboPhongChieu);
                return;
            }
            if (clbGhe.CheckedItems.Count == 0)
            {
                BaoLoi("Vui lòng chọn ít nhất 1 ghế.", clbGhe);
                return;
            }
            if (phongCuaKhach.TryGetValue(hoTen, out int phongDaMua) && phongDaMua != phong)
            {
                MessageBox.Show($"Khách hàng {hoTen} đã mua vé ở phòng {phongDaMua}, không thể mua vé ở phòng chiếu khác.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal tongTien = 0;
            List<string> gheDaChon = new List<string>();
            foreach (object item in clbGhe.CheckedItems)
            {
                string ghe = item.ToString() ?? "";
                decimal giaTien = phim.GiaVeChuan * SoDoGhe.LayHeSo(ghe);
                danhSachVe.Add(new VeDaBan { HoTen = hoTen, TenPhim = phim.TenPhim, Phong = phong, Ghe = ghe, GiaTien = giaTien });
                tongTien += giaTien;
                gheDaChon.Add(ghe);
            }
            phongCuaKhach[hoTen] = phong;

            txtThongTinVe.Text = "Họ và tên: " + hoTen + "\r\n"
                + "Vé đã chọn: " + string.Join(", ", gheDaChon) + "\r\n"
                + "Tên phim: " + phim.TenPhim + "\r\n"
                + "Phòng chiếu: " + phong + "\r\n"
                + "Số tiền cần thanh toán: " + ThongKePhongVe.DinhDangTien(tongTien);
            MessageBox.Show("Thanh toán thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadGhe();
            CapNhatThongKe();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtHoTen.Clear();
            txtThongTinVe.Clear();
            cboPhim.SelectedIndex = -1;
            cboPhongChieu.Items.Clear();
            clbGhe.Items.Clear();
        }

        // ===== Thống kê và xuất output5.txt =====

        private void CapNhatThongKe()
        {
            List<ThongKePhim> thongKe = ThongKePhongVe.Tinh(danhSachPhim, danhSachVe);
            lvwThongKe.BeginUpdate();
            lvwThongKe.Items.Clear();
            foreach (ThongKePhim t in thongKe)
            {
                ListViewItem dong = new ListViewItem(t.XepHang.ToString());
                dong.SubItems.Add(t.TenPhim);
                dong.SubItems.Add(t.SoVeBan.ToString());
                dong.SubItems.Add(t.SoVeTon.ToString());
                dong.SubItems.Add(ThongKePhongVe.DinhDangTiLe(t.TiLeBan));
                dong.SubItems.Add(ThongKePhongVe.DinhDangTien(t.DoanhThu));
                lvwThongKe.Items.Add(dong);
            }
            lvwThongKe.EndUpdate();
        }

        private async void btnXuatFile_Click(object sender, EventArgs e)
        {
            if (danhSachPhim.Count == 0)
            {
                MessageBox.Show($"Chưa có phim nào, hãy đọc {TenFileInput} trước.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<ThongKePhim> thongKe = ThongKePhongVe.Tinh(danhSachPhim, danhSachVe);
            string duongDan = ThuMucDuLieu.LayDuongDan(TenFileOutput);

            dangXuatFile = true;
            btnXuatFile.Enabled = false;
            pgbXuatFile.Minimum = 0;
            pgbXuatFile.Maximum = thongKe.Count;
            pgbXuatFile.Value = 0;
            try
            {
                using (StreamWriter sw = new StreamWriter(duongDan, false, new UTF8Encoding(false)))
                {
                    await sw.WriteLineAsync("THỐNG KÊ DOANH THU PHÒNG VÉ");
                    await sw.WriteLineAsync("Thời điểm xuất: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                    await sw.WriteLineAsync("========================================");

                    for (int i = 0; i < thongKe.Count; i++)
                    {
                        lblTienDo.Text = $"Đang ghi {i + 1}/{thongKe.Count}: {thongKe[i].TenPhim}";
                        await sw.WriteAsync(ThongKePhongVe.TaoNoiDung(thongKe[i]));
                        pgbXuatFile.Value = i + 1;
                        // Dữ liệu ít nên ghi rất nhanh; chờ một chút để thấy được thanh tiến trình chạy
                        await Task.Delay(400);
                    }
                }
                lblTienDo.Text = $"Đã xuất {TenFileOutput} ({thongKe.Count} phim).";
                MessageBox.Show("Xuất file thành công!\n" + duongDan, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) when (ex is IOException || ex is UnauthorizedAccessException)
            {
                lblTienDo.Text = "Xuất file thất bại.";
                MessageBox.Show("Không ghi được file:\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dangXuatFile = false;
                btnXuatFile.Enabled = true;
            }
        }

        // Không cho đóng form khi đang xuất file dở dang
        private void Bai5_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dangXuatFile)
            {
                e.Cancel = true;
                MessageBox.Show("Đang xuất file, vui lòng đợi hoàn tất.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
