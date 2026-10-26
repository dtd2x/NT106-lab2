namespace NT106_Lab2
{
    partial class Bai4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            lblTieuDe = new Label();
            pnlNhap = new Panel();
            lblNhap = new Label();
            lblHoTen = new Label();
            txtHoTen = new TextBox();
            lblMSSV = new Label();
            txtMSSV = new TextBox();
            lblDienThoai = new Label();
            txtDienThoai = new TextBox();
            lblDiem1 = new Label();
            txtDiem1 = new TextBox();
            lblDiem2 = new Label();
            txtDiem2 = new TextBox();
            lblDiem3 = new Label();
            txtDiem3 = new TextBox();
            lblRangBuoc = new Label();
            btnThem = new Button();
            btnGhiFile = new Button();
            pnlDanhSach = new Panel();
            lblDanhSach = new Label();
            lstSinhVien = new ListBox();
            btnXoaSinhVien = new Button();
            pnlKetQua = new Panel();
            lblKetQua = new Label();
            btnDocFile = new Button();
            lblKqHoTen = new Label();
            txtKqHoTen = new TextBox();
            lblKqMSSV = new Label();
            txtKqMSSV = new TextBox();
            lblKqDienThoai = new Label();
            txtKqDienThoai = new TextBox();
            lblKqDiem1 = new Label();
            txtKqDiem1 = new TextBox();
            lblKqDiem2 = new Label();
            txtKqDiem2 = new TextBox();
            lblKqDiem3 = new Label();
            txtKqDiem3 = new TextBox();
            lblKqDiemTB = new Label();
            txtKqDiemTB = new TextBox();
            btnTruoc = new Button();
            lblTrang = new Label();
            btnSau = new Button();
            lblTrangThai = new Label();
            btnThoat = new Button();
            pnlHeader.SuspendLayout();
            pnlNhap.SuspendLayout();
            pnlDanhSach.SuspendLayout();
            pnlKetQua.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(30, 64, 175);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1000, 64);
            pnlHeader.Controls.Add(lblTieuDe);
            pnlHeader.TabIndex = 0;
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.White;
            lblTieuDe.Location = new Point(18, 14);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Text = "QUẢN LÝ SINH VIÊN (JSON)";
            lblTieuDe.TabIndex = 0;
            // 
            // pnlNhap
            // 
            pnlNhap.BackColor = Color.White;
            pnlNhap.Location = new Point(20, 80);
            pnlNhap.Name = "pnlNhap";
            pnlNhap.Size = new Size(310, 400);
            pnlNhap.Controls.Add(lblNhap);
            pnlNhap.Controls.Add(lblHoTen);
            pnlNhap.Controls.Add(txtHoTen);
            pnlNhap.Controls.Add(lblMSSV);
            pnlNhap.Controls.Add(txtMSSV);
            pnlNhap.Controls.Add(lblDienThoai);
            pnlNhap.Controls.Add(txtDienThoai);
            pnlNhap.Controls.Add(lblDiem1);
            pnlNhap.Controls.Add(txtDiem1);
            pnlNhap.Controls.Add(lblDiem2);
            pnlNhap.Controls.Add(txtDiem2);
            pnlNhap.Controls.Add(lblDiem3);
            pnlNhap.Controls.Add(txtDiem3);
            pnlNhap.Controls.Add(lblRangBuoc);
            pnlNhap.Controls.Add(btnThem);
            pnlNhap.Controls.Add(btnGhiFile);
            pnlNhap.TabIndex = 1;
            // 
            // lblNhap
            // 
            lblNhap.AutoSize = true;
            lblNhap.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNhap.ForeColor = Color.FromArgb(30, 64, 175);
            lblNhap.Location = new Point(14, 12);
            lblNhap.Name = "lblNhap";
            lblNhap.Text = "Nhập sinh viên";
            lblNhap.TabIndex = 0;
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.ForeColor = Color.FromArgb(30, 41, 59);
            lblHoTen.Location = new Point(14, 49);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Text = "Họ và tên";
            lblHoTen.TabIndex = 1;
            // 
            // txtHoTen
            // 
            txtHoTen.ForeColor = Color.FromArgb(30, 41, 59);
            txtHoTen.Location = new Point(116, 46);
            txtHoTen.MaxLength = 100;
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(180, 25);
            txtHoTen.TabIndex = 2;
            // 
            // lblMSSV
            // 
            lblMSSV.AutoSize = true;
            lblMSSV.ForeColor = Color.FromArgb(30, 41, 59);
            lblMSSV.Location = new Point(14, 89);
            lblMSSV.Name = "lblMSSV";
            lblMSSV.Text = "MSSV";
            lblMSSV.TabIndex = 3;
            // 
            // txtMSSV
            // 
            txtMSSV.ForeColor = Color.FromArgb(30, 41, 59);
            txtMSSV.Location = new Point(116, 86);
            txtMSSV.MaxLength = 8;
            txtMSSV.Name = "txtMSSV";
            txtMSSV.Size = new Size(180, 25);
            txtMSSV.TabIndex = 4;
            // 
            // lblDienThoai
            // 
            lblDienThoai.AutoSize = true;
            lblDienThoai.ForeColor = Color.FromArgb(30, 41, 59);
            lblDienThoai.Location = new Point(14, 129);
            lblDienThoai.Name = "lblDienThoai";
            lblDienThoai.Text = "Điện thoại";
            lblDienThoai.TabIndex = 5;
            // 
            // txtDienThoai
            // 
            txtDienThoai.ForeColor = Color.FromArgb(30, 41, 59);
            txtDienThoai.Location = new Point(116, 126);
            txtDienThoai.MaxLength = 10;
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(180, 25);
            txtDienThoai.TabIndex = 6;
            // 
            // lblDiem1
            // 
            lblDiem1.AutoSize = true;
            lblDiem1.ForeColor = Color.FromArgb(30, 41, 59);
            lblDiem1.Location = new Point(14, 169);
            lblDiem1.Name = "lblDiem1";
            lblDiem1.Text = "Điểm môn 1";
            lblDiem1.TabIndex = 7;
            // 
            // txtDiem1
            // 
            txtDiem1.ForeColor = Color.FromArgb(30, 41, 59);
            txtDiem1.Location = new Point(116, 166);
            txtDiem1.MaxLength = 5;
            txtDiem1.Name = "txtDiem1";
            txtDiem1.Size = new Size(180, 25);
            txtDiem1.TabIndex = 8;
            // 
            // lblDiem2
            // 
            lblDiem2.AutoSize = true;
            lblDiem2.ForeColor = Color.FromArgb(30, 41, 59);
            lblDiem2.Location = new Point(14, 209);
            lblDiem2.Name = "lblDiem2";
            lblDiem2.Text = "Điểm môn 2";
            lblDiem2.TabIndex = 9;
            // 
            // txtDiem2
            // 
            txtDiem2.ForeColor = Color.FromArgb(30, 41, 59);
            txtDiem2.Location = new Point(116, 206);
            txtDiem2.MaxLength = 5;
            txtDiem2.Name = "txtDiem2";
            txtDiem2.Size = new Size(180, 25);
            txtDiem2.TabIndex = 10;
            // 
            // lblDiem3
            // 
            lblDiem3.AutoSize = true;
            lblDiem3.ForeColor = Color.FromArgb(30, 41, 59);
            lblDiem3.Location = new Point(14, 249);
            lblDiem3.Name = "lblDiem3";
            lblDiem3.Text = "Điểm môn 3";
            lblDiem3.TabIndex = 11;
            // 
            // txtDiem3
            // 
            txtDiem3.ForeColor = Color.FromArgb(30, 41, 59);
            txtDiem3.Location = new Point(116, 246);
            txtDiem3.MaxLength = 5;
            txtDiem3.Name = "txtDiem3";
            txtDiem3.Size = new Size(180, 25);
            txtDiem3.TabIndex = 12;
            // 
            // lblRangBuoc
            // 
            lblRangBuoc.Font = new Font("Segoe UI", 9F);
            lblRangBuoc.ForeColor = Color.FromArgb(100, 116, 139);
            lblRangBuoc.Location = new Point(14, 290);
            lblRangBuoc.Name = "lblRangBuoc";
            lblRangBuoc.Size = new Size(282, 40);
            lblRangBuoc.Text = "MSSV: 8 chữ số. SĐT: 10 chữ số, bắt đầu bằng 0.\r\nĐiểm từ 0 đến 10. Không nhập ĐTB.";
            lblRangBuoc.TabIndex = 13;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(37, 99, 235);
            btnThem.Cursor = Cursors.Hand;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatAppearance.MouseOverBackColor = Color.FromArgb(29, 78, 216);
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(14, 344);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(134, 40);
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.TabIndex = 14;
            btnThem.Click += btnThem_Click;
            // 
            // btnGhiFile
            // 
            btnGhiFile.BackColor = Color.FromArgb(37, 99, 235);
            btnGhiFile.Cursor = Cursors.Hand;
            btnGhiFile.FlatAppearance.BorderSize = 0;
            btnGhiFile.FlatAppearance.MouseOverBackColor = Color.FromArgb(29, 78, 216);
            btnGhiFile.FlatStyle = FlatStyle.Flat;
            btnGhiFile.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGhiFile.ForeColor = Color.White;
            btnGhiFile.Location = new Point(162, 344);
            btnGhiFile.Name = "btnGhiFile";
            btnGhiFile.Size = new Size(134, 40);
            btnGhiFile.Text = "Ghi input4.txt";
            btnGhiFile.UseVisualStyleBackColor = false;
            btnGhiFile.TabIndex = 15;
            btnGhiFile.Click += btnGhiFile_Click;
            // 
            // pnlDanhSach
            // 
            pnlDanhSach.BackColor = Color.White;
            pnlDanhSach.Location = new Point(346, 80);
            pnlDanhSach.Name = "pnlDanhSach";
            pnlDanhSach.Size = new Size(300, 400);
            pnlDanhSach.Controls.Add(lblDanhSach);
            pnlDanhSach.Controls.Add(lstSinhVien);
            pnlDanhSach.Controls.Add(btnXoaSinhVien);
            pnlDanhSach.TabIndex = 2;
            // 
            // lblDanhSach
            // 
            lblDanhSach.AutoSize = true;
            lblDanhSach.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDanhSach.ForeColor = Color.FromArgb(30, 64, 175);
            lblDanhSach.Location = new Point(14, 12);
            lblDanhSach.Name = "lblDanhSach";
            lblDanhSach.Text = "Danh sách chờ ghi file";
            lblDanhSach.TabIndex = 0;
            // 
            // lstSinhVien
            // 
            lstSinhVien.ForeColor = Color.FromArgb(30, 41, 59);
            lstSinhVien.FormattingEnabled = true;
            lstSinhVien.HorizontalScrollbar = true;
            lstSinhVien.Location = new Point(14, 40);
            lstSinhVien.Name = "lstSinhVien";
            lstSinhVien.Size = new Size(272, 304);
            lstSinhVien.TabIndex = 1;
            // 
            // btnXoaSinhVien
            // 
            btnXoaSinhVien.BackColor = Color.FromArgb(226, 232, 240);
            btnXoaSinhVien.Cursor = Cursors.Hand;
            btnXoaSinhVien.FlatAppearance.BorderSize = 0;
            btnXoaSinhVien.FlatAppearance.MouseOverBackColor = Color.FromArgb(203, 213, 225);
            btnXoaSinhVien.FlatStyle = FlatStyle.Flat;
            btnXoaSinhVien.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnXoaSinhVien.ForeColor = Color.FromArgb(30, 41, 59);
            btnXoaSinhVien.Location = new Point(14, 350);
            btnXoaSinhVien.Name = "btnXoaSinhVien";
            btnXoaSinhVien.Size = new Size(272, 34);
            btnXoaSinhVien.Text = "Xoá dòng đã chọn";
            btnXoaSinhVien.UseVisualStyleBackColor = false;
            btnXoaSinhVien.TabIndex = 2;
            btnXoaSinhVien.Click += btnXoaSinhVien_Click;
            // 
            // pnlKetQua
            // 
            pnlKetQua.BackColor = Color.White;
            pnlKetQua.Location = new Point(662, 80);
            pnlKetQua.Name = "pnlKetQua";
            pnlKetQua.Size = new Size(322, 400);
            pnlKetQua.Controls.Add(lblKetQua);
            pnlKetQua.Controls.Add(btnDocFile);
            pnlKetQua.Controls.Add(lblKqHoTen);
            pnlKetQua.Controls.Add(txtKqHoTen);
            pnlKetQua.Controls.Add(lblKqMSSV);
            pnlKetQua.Controls.Add(txtKqMSSV);
            pnlKetQua.Controls.Add(lblKqDienThoai);
            pnlKetQua.Controls.Add(txtKqDienThoai);
            pnlKetQua.Controls.Add(lblKqDiem1);
            pnlKetQua.Controls.Add(txtKqDiem1);
            pnlKetQua.Controls.Add(lblKqDiem2);
            pnlKetQua.Controls.Add(txtKqDiem2);
            pnlKetQua.Controls.Add(lblKqDiem3);
            pnlKetQua.Controls.Add(txtKqDiem3);
            pnlKetQua.Controls.Add(lblKqDiemTB);
            pnlKetQua.Controls.Add(txtKqDiemTB);
            pnlKetQua.Controls.Add(btnTruoc);
            pnlKetQua.Controls.Add(lblTrang);
            pnlKetQua.Controls.Add(btnSau);
            pnlKetQua.TabIndex = 3;
            // 
            // lblKetQua
            // 
            lblKetQua.AutoSize = true;
            lblKetQua.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblKetQua.ForeColor = Color.FromArgb(30, 64, 175);
            lblKetQua.Location = new Point(14, 12);
            lblKetQua.Name = "lblKetQua";
            lblKetQua.Text = "Đọc input4.txt, tính ĐTB";
            lblKetQua.TabIndex = 0;
            // 
            // btnDocFile
            // 
            btnDocFile.BackColor = Color.FromArgb(37, 99, 235);
            btnDocFile.Cursor = Cursors.Hand;
            btnDocFile.FlatAppearance.BorderSize = 0;
            btnDocFile.FlatAppearance.MouseOverBackColor = Color.FromArgb(29, 78, 216);
            btnDocFile.FlatStyle = FlatStyle.Flat;
            btnDocFile.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDocFile.ForeColor = Color.White;
            btnDocFile.Location = new Point(14, 40);
            btnDocFile.Name = "btnDocFile";
            btnDocFile.Size = new Size(294, 36);
            btnDocFile.Text = "Đọc file";
            btnDocFile.UseVisualStyleBackColor = false;
            btnDocFile.TabIndex = 1;
            btnDocFile.Click += btnDocFile_Click;
            // 
            // lblKqHoTen
            // 
            lblKqHoTen.AutoSize = true;
            lblKqHoTen.ForeColor = Color.FromArgb(30, 41, 59);
            lblKqHoTen.Location = new Point(14, 89);
            lblKqHoTen.Name = "lblKqHoTen";
            lblKqHoTen.Text = "Họ và tên";
            lblKqHoTen.TabIndex = 2;
            // 
            // txtKqHoTen
            // 
            txtKqHoTen.BackColor = Color.FromArgb(239, 246, 255);
            txtKqHoTen.ForeColor = Color.FromArgb(30, 41, 59);
            txtKqHoTen.Location = new Point(116, 86);
            txtKqHoTen.Name = "txtKqHoTen";
            txtKqHoTen.ReadOnly = true;
            txtKqHoTen.Size = new Size(192, 25);
            txtKqHoTen.TabIndex = 3;
            // 
            // lblKqMSSV
            // 
            lblKqMSSV.AutoSize = true;
            lblKqMSSV.ForeColor = Color.FromArgb(30, 41, 59);
            lblKqMSSV.Location = new Point(14, 125);
            lblKqMSSV.Name = "lblKqMSSV";
            lblKqMSSV.Text = "MSSV";
            lblKqMSSV.TabIndex = 4;
            // 
            // txtKqMSSV
            // 
            txtKqMSSV.BackColor = Color.FromArgb(239, 246, 255);
            txtKqMSSV.ForeColor = Color.FromArgb(30, 41, 59);
            txtKqMSSV.Location = new Point(116, 122);
            txtKqMSSV.Name = "txtKqMSSV";
            txtKqMSSV.ReadOnly = true;
            txtKqMSSV.Size = new Size(192, 25);
            txtKqMSSV.TabIndex = 5;
            // 
            // lblKqDienThoai
            // 
            lblKqDienThoai.AutoSize = true;
            lblKqDienThoai.ForeColor = Color.FromArgb(30, 41, 59);
            lblKqDienThoai.Location = new Point(14, 161);
            lblKqDienThoai.Name = "lblKqDienThoai";
            lblKqDienThoai.Text = "Điện thoại";
            lblKqDienThoai.TabIndex = 6;
            // 
            // txtKqDienThoai
            // 
            txtKqDienThoai.BackColor = Color.FromArgb(239, 246, 255);
            txtKqDienThoai.ForeColor = Color.FromArgb(30, 41, 59);
            txtKqDienThoai.Location = new Point(116, 158);
            txtKqDienThoai.Name = "txtKqDienThoai";
            txtKqDienThoai.ReadOnly = true;
            txtKqDienThoai.Size = new Size(192, 25);
            txtKqDienThoai.TabIndex = 7;
            // 
            // lblKqDiem1
            // 
            lblKqDiem1.AutoSize = true;
            lblKqDiem1.ForeColor = Color.FromArgb(30, 41, 59);
            lblKqDiem1.Location = new Point(14, 197);
            lblKqDiem1.Name = "lblKqDiem1";
            lblKqDiem1.Text = "Điểm môn 1";
            lblKqDiem1.TabIndex = 8;
            // 
            // txtKqDiem1
            // 
            txtKqDiem1.BackColor = Color.FromArgb(239, 246, 255);
            txtKqDiem1.ForeColor = Color.FromArgb(30, 41, 59);
            txtKqDiem1.Location = new Point(116, 194);
            txtKqDiem1.Name = "txtKqDiem1";
            txtKqDiem1.ReadOnly = true;
            txtKqDiem1.Size = new Size(192, 25);
            txtKqDiem1.TabIndex = 9;
            // 
            // lblKqDiem2
            // 
            lblKqDiem2.AutoSize = true;
            lblKqDiem2.ForeColor = Color.FromArgb(30, 41, 59);
            lblKqDiem2.Location = new Point(14, 233);
            lblKqDiem2.Name = "lblKqDiem2";
            lblKqDiem2.Text = "Điểm môn 2";
            lblKqDiem2.TabIndex = 10;
            // 
            // txtKqDiem2
            // 
            txtKqDiem2.BackColor = Color.FromArgb(239, 246, 255);
            txtKqDiem2.ForeColor = Color.FromArgb(30, 41, 59);
            txtKqDiem2.Location = new Point(116, 230);
            txtKqDiem2.Name = "txtKqDiem2";
            txtKqDiem2.ReadOnly = true;
            txtKqDiem2.Size = new Size(192, 25);
            txtKqDiem2.TabIndex = 11;
            // 
            // lblKqDiem3
            // 
            lblKqDiem3.AutoSize = true;
            lblKqDiem3.ForeColor = Color.FromArgb(30, 41, 59);
            lblKqDiem3.Location = new Point(14, 269);
            lblKqDiem3.Name = "lblKqDiem3";
            lblKqDiem3.Text = "Điểm môn 3";
            lblKqDiem3.TabIndex = 12;
            // 
            // txtKqDiem3
            // 
            txtKqDiem3.BackColor = Color.FromArgb(239, 246, 255);
            txtKqDiem3.ForeColor = Color.FromArgb(30, 41, 59);
            txtKqDiem3.Location = new Point(116, 266);
            txtKqDiem3.Name = "txtKqDiem3";
            txtKqDiem3.ReadOnly = true;
            txtKqDiem3.Size = new Size(192, 25);
            txtKqDiem3.TabIndex = 13;
            // 
            // lblKqDiemTB
            // 
            lblKqDiemTB.AutoSize = true;
            lblKqDiemTB.ForeColor = Color.FromArgb(30, 41, 59);
            lblKqDiemTB.Location = new Point(14, 305);
            lblKqDiemTB.Name = "lblKqDiemTB";
            lblKqDiemTB.Text = "Điểm TB";
            lblKqDiemTB.TabIndex = 14;
            // 
            // txtKqDiemTB
            // 
            txtKqDiemTB.BackColor = Color.FromArgb(239, 246, 255);
            txtKqDiemTB.ForeColor = Color.FromArgb(30, 41, 59);
            txtKqDiemTB.Location = new Point(116, 302);
            txtKqDiemTB.Name = "txtKqDiemTB";
            txtKqDiemTB.ReadOnly = true;
            txtKqDiemTB.Size = new Size(192, 25);
            txtKqDiemTB.TabIndex = 15;
            // 
            // btnTruoc
            // 
            btnTruoc.BackColor = Color.FromArgb(226, 232, 240);
            btnTruoc.Cursor = Cursors.Hand;
            btnTruoc.Enabled = false;
            btnTruoc.FlatAppearance.BorderSize = 0;
            btnTruoc.FlatAppearance.MouseOverBackColor = Color.FromArgb(203, 213, 225);
            btnTruoc.FlatStyle = FlatStyle.Flat;
            btnTruoc.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnTruoc.ForeColor = Color.FromArgb(30, 41, 59);
            btnTruoc.Location = new Point(14, 348);
            btnTruoc.Name = "btnTruoc";
            btnTruoc.Size = new Size(90, 36);
            btnTruoc.Text = "< Back";
            btnTruoc.UseVisualStyleBackColor = false;
            btnTruoc.TabIndex = 16;
            btnTruoc.Click += btnTruoc_Click;
            // 
            // lblTrang
            // 
            lblTrang.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTrang.ForeColor = Color.FromArgb(30, 64, 175);
            lblTrang.Location = new Point(110, 348);
            lblTrang.Name = "lblTrang";
            lblTrang.Size = new Size(102, 36);
            lblTrang.TextAlign = ContentAlignment.MiddleCenter;
            lblTrang.Text = "0 / 0";
            lblTrang.TabIndex = 17;
            // 
            // btnSau
            // 
            btnSau.BackColor = Color.FromArgb(226, 232, 240);
            btnSau.Cursor = Cursors.Hand;
            btnSau.Enabled = false;
            btnSau.FlatAppearance.BorderSize = 0;
            btnSau.FlatAppearance.MouseOverBackColor = Color.FromArgb(203, 213, 225);
            btnSau.FlatStyle = FlatStyle.Flat;
            btnSau.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSau.ForeColor = Color.FromArgb(30, 41, 59);
            btnSau.Location = new Point(218, 348);
            btnSau.Name = "btnSau";
            btnSau.Size = new Size(90, 36);
            btnSau.Text = "Next >";
            btnSau.UseVisualStyleBackColor = false;
            btnSau.TabIndex = 18;
            btnSau.Click += btnSau_Click;
            // 
            // lblTrangThai
            // 
            lblTrangThai.Font = new Font("Segoe UI", 9F);
            lblTrangThai.ForeColor = Color.FromArgb(100, 116, 139);
            lblTrangThai.Location = new Point(20, 498);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(820, 36);
            lblTrangThai.Text = "";
            lblTrangThai.TabIndex = 4;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(220, 38, 38);
            btnThoat.Cursor = Cursors.Hand;
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.FlatAppearance.MouseOverBackColor = Color.FromArgb(185, 28, 28);
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(868, 494);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(116, 38);
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.TabIndex = 5;
            btnThoat.Click += btnThoat_Click;
            // 
            // Bai4
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 246, 250);
            CancelButton = btnThoat;
            ClientSize = new Size(1000, 548);
            Controls.Add(btnThoat);
            Controls.Add(lblTrangThai);
            Controls.Add(pnlKetQua);
            Controls.Add(pnlDanhSach);
            Controls.Add(pnlNhap);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.FromArgb(30, 41, 59);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Bai4";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Lab02-Bai04";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlNhap.ResumeLayout(false);
            pnlNhap.PerformLayout();
            pnlDanhSach.ResumeLayout(false);
            pnlDanhSach.PerformLayout();
            pnlKetQua.ResumeLayout(false);
            pnlKetQua.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTieuDe;
        private Panel pnlNhap;
        private Label lblNhap;
        private Label lblHoTen;
        private TextBox txtHoTen;
        private Label lblMSSV;
        private TextBox txtMSSV;
        private Label lblDienThoai;
        private TextBox txtDienThoai;
        private Label lblDiem1;
        private TextBox txtDiem1;
        private Label lblDiem2;
        private TextBox txtDiem2;
        private Label lblDiem3;
        private TextBox txtDiem3;
        private Label lblRangBuoc;
        private Button btnThem;
        private Button btnGhiFile;
        private Panel pnlDanhSach;
        private Label lblDanhSach;
        private ListBox lstSinhVien;
        private Button btnXoaSinhVien;
        private Panel pnlKetQua;
        private Label lblKetQua;
        private Button btnDocFile;
        private Label lblKqHoTen;
        private TextBox txtKqHoTen;
        private Label lblKqMSSV;
        private TextBox txtKqMSSV;
        private Label lblKqDienThoai;
        private TextBox txtKqDienThoai;
        private Label lblKqDiem1;
        private TextBox txtKqDiem1;
        private Label lblKqDiem2;
        private TextBox txtKqDiem2;
        private Label lblKqDiem3;
        private TextBox txtKqDiem3;
        private Label lblKqDiemTB;
        private TextBox txtKqDiemTB;
        private Button btnTruoc;
        private Label lblTrang;
        private Button btnSau;
        private Label lblTrangThai;
        private Button btnThoat;
    }
}
