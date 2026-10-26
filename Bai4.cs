using System.Text.Json;
using NT106_Lab2.Helpers;
using NT106_Lab2.Models;
using NT106_Lab2.Services;

namespace NT106_Lab2
{
    public partial class Bai4 : Form
    {
        private const string TenFileInput = "input4.txt";
        private const string TenFileOutput = "output4.txt";

        // Danh sách đang nhập (bên trái), sẽ ghi xuống input4.txt
        private readonly List<SinhVien> danhSachNhap = new List<SinhVien>();
        // Danh sách đọc từ input4.txt và đã tính ĐTB (bên phải)
        private List<SinhVien> danhSachKetQua = new List<SinhVien>();
        private int trangHienTai = 0;

        public Bai4()
        {
            InitializeComponent();
            TaiDanhSachDaCo();
            CapNhatTrang();
        }

        // Nếu input4.txt đã có từ lần chạy trước thì nạp lại để nhập tiếp
        private void TaiDanhSachDaCo()
        {
            string duongDan = ThuMucDuLieu.LayDuongDan(TenFileInput);
            if (!File.Exists(duongDan))
            {
                return;
            }

            try
            {
                danhSachNhap.AddRange(SinhVienJson.Doc(duongDan));
                HienThiDanhSachNhap();
                lblTrangThai.Text = $"Đã nạp {danhSachNhap.Count} sinh viên có sẵn trong {TenFileInput}.";
            }
            catch (Exception ex) when (ex is IOException || ex is JsonException || ex is UnauthorizedAccessException)
            {
                lblTrangThai.Text = $"Không nạp được {TenFileInput} cũ: {ex.Message}";
            }
        }

        private void HienThiDanhSachNhap()
        {
            lstSinhVien.Items.Clear();
            for (int i = 0; i < danhSachNhap.Count; i++)
            {
                SinhVien sv = danhSachNhap[i];
                lstSinhVien.Items.Add($"{i + 1}. {sv.HoTen} - {sv.MSSV}");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text.Trim();
            if (hoTen == "")
            {
                BaoLoi("Vui lòng nhập họ và tên.", txtHoTen);
                return;
            }
            if (!KiemTraSinhVien.KiemTraMSSV(txtMSSV.Text.Trim(), out int mssv))
            {
                BaoLoi("MSSV phải là số có đúng 8 chữ số.", txtMSSV);
                return;
            }
            if (danhSachNhap.Any(sv => sv.MSSV == mssv))
            {
                BaoLoi("MSSV này đã có trong danh sách.", txtMSSV);
                return;
            }
            string dienThoai = txtDienThoai.Text.Trim();
            if (!KiemTraSinhVien.KiemTraDienThoai(dienThoai))
            {
                BaoLoi("Số điện thoại phải có 10 chữ số và bắt đầu bằng số 0.", txtDienThoai);
                return;
            }
            if (!KiemTraSinhVien.KiemTraDiem(txtDiem1.Text, out float diem1))
            {
                BaoLoi("Điểm môn 1 phải là số từ 0 đến 10.", txtDiem1);
                return;
            }
            if (!KiemTraSinhVien.KiemTraDiem(txtDiem2.Text, out float diem2))
            {
                BaoLoi("Điểm môn 2 phải là số từ 0 đến 10.", txtDiem2);
                return;
            }
            if (!KiemTraSinhVien.KiemTraDiem(txtDiem3.Text, out float diem3))
            {
                BaoLoi("Điểm môn 3 phải là số từ 0 đến 10.", txtDiem3);
                return;
            }

            // Không nhập điểm trung bình, ĐTB chỉ được tính sau khi đọc file
            danhSachNhap.Add(new SinhVien
            {
                HoTen = hoTen,
                MSSV = mssv,
                DienThoai = dienThoai,
                DiemMon1 = diem1,
                DiemMon2 = diem2,
                DiemMon3 = diem3
            });

            HienThiDanhSachNhap();
            XoaONhap();
            lblTrangThai.Text = $"Đã thêm {hoTen}. Bấm \"Ghi input4.txt\" để lưu xuống file.";
        }

        private void BaoLoi(string thongBao, TextBox oBiLoi)
        {
            MessageBox.Show(thongBao, "Dữ liệu không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            oBiLoi.Focus();
            oBiLoi.SelectAll();
        }

        private void XoaONhap()
        {
            txtHoTen.Clear();
            txtMSSV.Clear();
            txtDienThoai.Clear();
            txtDiem1.Clear();
            txtDiem2.Clear();
            txtDiem3.Clear();
            txtHoTen.Focus();
        }

        private void btnXoaSinhVien_Click(object sender, EventArgs e)
        {
            int chiSo = lstSinhVien.SelectedIndex;
            if (chiSo == -1)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xoá trong danh sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            danhSachNhap.RemoveAt(chiSo);
            HienThiDanhSachNhap();
        }

        private void btnGhiFile_Click(object sender, EventArgs e)
        {
            if (danhSachNhap.Count == 0)
            {
                MessageBox.Show("Danh sách đang trống, vui lòng thêm sinh viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string duongDan = ThuMucDuLieu.LayDuongDan(TenFileInput);
            try
            {
                SinhVienJson.Ghi(duongDan, danhSachNhap);
            }
            catch (Exception ex) when (ex is IOException || ex is UnauthorizedAccessException)
            {
                MessageBox.Show("Không ghi được file:\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblTrangThai.Text = $"Đã ghi {danhSachNhap.Count} sinh viên vào {TenFileInput}.";
            MessageBox.Show($"Đã ghi {danhSachNhap.Count} sinh viên vào\n{duongDan}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDocFile_Click(object sender, EventArgs e)
        {
            string duongDanInput = ThuMucDuLieu.LayDuongDan(TenFileInput);
            if (!File.Exists(duongDanInput))
            {
                MessageBox.Show($"Chưa có {TenFileInput}, hãy nhập sinh viên và ghi file trước.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int soKhongHopLe;
            try
            {
                danhSachKetQua = SinhVienJson.Doc(duongDanInput);
                // Bỏ các sinh viên sai ràng buộc (trường hợp file bị sửa tay)
                soKhongHopLe = danhSachKetQua.RemoveAll(sv => !KiemTraSinhVien.HopLe(sv));
                foreach (SinhVien sv in danhSachKetQua)
                {
                    sv.TinhDiemTrungBinh();
                }
                SinhVienJson.Ghi(ThuMucDuLieu.LayDuongDan(TenFileOutput), danhSachKetQua);
            }
            catch (Exception ex) when (ex is IOException || ex is JsonException || ex is UnauthorizedAccessException)
            {
                MessageBox.Show("Không xử lý được file:\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            trangHienTai = 0;
            CapNhatTrang();
            lblTrangThai.Text = $"Đã đọc {danhSachKetQua.Count} sinh viên, tính ĐTB và ghi {TenFileOutput}.";
            if (soKhongHopLe > 0)
            {
                MessageBox.Show($"Đã bỏ qua {soKhongHopLe} sinh viên có dữ liệu không hợp lệ trong {TenFileInput}.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Hiển thị sinh viên ở trang hiện tại và bật/tắt nút Back, Next
        private void CapNhatTrang()
        {
            if (danhSachKetQua.Count == 0)
            {
                txtKqHoTen.Clear();
                txtKqMSSV.Clear();
                txtKqDienThoai.Clear();
                txtKqDiem1.Clear();
                txtKqDiem2.Clear();
                txtKqDiem3.Clear();
                txtKqDiemTB.Clear();
                lblTrang.Text = "0 / 0";
                btnTruoc.Enabled = false;
                btnSau.Enabled = false;
                return;
            }

            SinhVien sv = danhSachKetQua[trangHienTai];
            txtKqHoTen.Text = sv.HoTen;
            txtKqMSSV.Text = sv.MSSV.ToString();
            txtKqDienThoai.Text = sv.DienThoai;
            txtKqDiem1.Text = sv.DiemMon1.ToString("0.##");
            txtKqDiem2.Text = sv.DiemMon2.ToString("0.##");
            txtKqDiem3.Text = sv.DiemMon3.ToString("0.##");
            txtKqDiemTB.Text = sv.DiemTrungBinh.ToString("0.00");
            lblTrang.Text = $"{trangHienTai + 1} / {danhSachKetQua.Count}";
            btnTruoc.Enabled = trangHienTai > 0;
            btnSau.Enabled = trangHienTai < danhSachKetQua.Count - 1;
        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            if (trangHienTai > 0)
            {
                trangHienTai--;
                CapNhatTrang();
            }
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            if (trangHienTai < danhSachKetQua.Count - 1)
            {
                trangHienTai++;
                CapNhatTrang();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
