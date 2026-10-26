namespace NT106_Lab2
{
    partial class Bai5
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
            pnlPhim = new Panel();
            lblPhim = new Label();
            btnDocFile = new Button();
            lstPhim = new ListBox();
            lblThemPhim = new Label();
            lblTenPhimMoi = new Label();
            txtTenPhimMoi = new TextBox();
            lblGiaVeMoi = new Label();
            txtGiaVeMoi = new TextBox();
            lblPhongMoi = new Label();
            txtPhongMoi = new TextBox();
            btnThemPhim = new Button();
            pnlDatVe = new Panel();
            lblDatVe = new Label();
            lblHoTen = new Label();
            txtHoTen = new TextBox();
            lblChonPhim = new Label();
            cboPhim = new ComboBox();
            lblPhongChieu = new Label();
            cboPhongChieu = new ComboBox();
            lblChonGhe = new Label();
            clbGhe = new CheckedListBox();
            lblLoaiVe = new Label();
            pnlThongTinVe = new Panel();
            lblThongTinVe = new Label();
            txtThongTinVe = new TextBox();
            btnThanhToan = new Button();
            btnXoa = new Button();
            pnlThongKe = new Panel();
            lblThongKe = new Label();
            lvwThongKe = new ListView();
            btnXuatFile = new Button();
            pgbXuatFile = new ProgressBar();
            lblTienDo = new Label();
            btnThoat = new Button();
            colHang = new ColumnHeader();
            colTenPhim = new ColumnHeader();
            colVeBan = new ColumnHeader();
            colVeTon = new ColumnHeader();
            colTiLe = new ColumnHeader();
            colDoanhThu = new ColumnHeader();
            pnlHeader.SuspendLayout();
            pnlPhim.SuspendLayout();
            pnlDatVe.SuspendLayout();
            pnlThongTinVe.SuspendLayout();
            pnlThongKe.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(30, 64, 175);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1180, 64);
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
            lblTieuDe.Text = "QUẢN LÝ PHÒNG VÉ (ĐỌC TỪ FILE)";
            lblTieuDe.TabIndex = 0;
            // 
            // pnlPhim
            // 
            pnlPhim.BackColor = Color.White;
            pnlPhim.Location = new Point(20, 80);
            pnlPhim.Name = "pnlPhim";
            pnlPhim.Size = new Size(360, 316);
            pnlPhim.Controls.Add(lblPhim);
            pnlPhim.Controls.Add(btnDocFile);
            pnlPhim.Controls.Add(lstPhim);
            pnlPhim.Controls.Add(lblThemPhim);
            pnlPhim.Controls.Add(lblTenPhimMoi);
            pnlPhim.Controls.Add(txtTenPhimMoi);
            pnlPhim.Controls.Add(lblGiaVeMoi);
            pnlPhim.Controls.Add(txtGiaVeMoi);
            pnlPhim.Controls.Add(lblPhongMoi);
            pnlPhim.Controls.Add(txtPhongMoi);
            pnlPhim.Controls.Add(btnThemPhim);
            pnlPhim.TabIndex = 1;
            // 
            // lblPhim
            // 
            lblPhim.AutoSize = true;
            lblPhim.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPhim.ForeColor = Color.FromArgb(30, 64, 175);
            lblPhim.Location = new Point(14, 12);
            lblPhim.Name = "lblPhim";
            lblPhim.Text = "Danh sách phim (input5.txt)";
            lblPhim.TabIndex = 0;
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
            btnDocFile.Location = new Point(246, 8);
            btnDocFile.Name = "btnDocFile";
            btnDocFile.Size = new Size(100, 30);
            btnDocFile.Text = "Đọc file";
            btnDocFile.UseVisualStyleBackColor = false;
            btnDocFile.TabIndex = 1;
            btnDocFile.Click += btnDocFile_Click;
            // 
            // lstPhim
            // 
            lstPhim.ForeColor = Color.FromArgb(30, 41, 59);
            lstPhim.FormattingEnabled = true;
            lstPhim.HorizontalScrollbar = true;
            lstPhim.Location = new Point(14, 44);
            lstPhim.Name = "lstPhim";
            lstPhim.Size = new Size(332, 104);
            lstPhim.TabIndex = 2;
            // 
            // lblThemPhim
            // 
            lblThemPhim.AutoSize = true;
            lblThemPhim.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblThemPhim.ForeColor = Color.FromArgb(30, 64, 175);
            lblThemPhim.Location = new Point(14, 158);
            lblThemPhim.Name = "lblThemPhim";
            lblThemPhim.Text = "Thêm phim và ghi vào file";
            lblThemPhim.TabIndex = 3;
            // 
            // lblTenPhimMoi
            // 
            lblTenPhimMoi.AutoSize = true;
            lblTenPhimMoi.ForeColor = Color.FromArgb(30, 41, 59);
            lblTenPhimMoi.Location = new Point(14, 191);
            lblTenPhimMoi.Name = "lblTenPhimMoi";
            lblTenPhimMoi.Text = "Tên phim";
            lblTenPhimMoi.TabIndex = 4;
            // 
            // txtTenPhimMoi
            // 
            txtTenPhimMoi.ForeColor = Color.FromArgb(30, 41, 59);
            txtTenPhimMoi.Location = new Point(114, 188);
            txtTenPhimMoi.Name = "txtTenPhimMoi";
            txtTenPhimMoi.Size = new Size(232, 25);
            txtTenPhimMoi.TabIndex = 5;
            // 
            // lblGiaVeMoi
            // 
            lblGiaVeMoi.AutoSize = true;
            lblGiaVeMoi.ForeColor = Color.FromArgb(30, 41, 59);
            lblGiaVeMoi.Location = new Point(14, 227);
            lblGiaVeMoi.Name = "lblGiaVeMoi";
            lblGiaVeMoi.Text = "Giá vé chuẩn";
            lblGiaVeMoi.TabIndex = 6;
            // 
            // txtGiaVeMoi
            // 
            txtGiaVeMoi.ForeColor = Color.FromArgb(30, 41, 59);
            txtGiaVeMoi.Location = new Point(114, 224);
            txtGiaVeMoi.MaxLength = 9;
            txtGiaVeMoi.Name = "txtGiaVeMoi";
            txtGiaVeMoi.PlaceholderText = "VD: 90000";
            txtGiaVeMoi.Size = new Size(232, 25);
            txtGiaVeMoi.TabIndex = 7;
            // 
            // lblPhongMoi
            // 
            lblPhongMoi.AutoSize = true;
            lblPhongMoi.ForeColor = Color.FromArgb(30, 41, 59);
            lblPhongMoi.Location = new Point(14, 263);
            lblPhongMoi.Name = "lblPhongMoi";
            lblPhongMoi.Text = "Phòng chiếu";
            lblPhongMoi.TabIndex = 8;
            // 
            // txtPhongMoi
            // 
            txtPhongMoi.ForeColor = Color.FromArgb(30, 41, 59);
            txtPhongMoi.Location = new Point(114, 260);
            txtPhongMoi.Name = "txtPhongMoi";
            txtPhongMoi.PlaceholderText = "VD: 1,2,3";
            txtPhongMoi.Size = new Size(120, 25);
            txtPhongMoi.TabIndex = 9;
            // 
            // btnThemPhim
            // 
            btnThemPhim.BackColor = Color.FromArgb(37, 99, 235);
            btnThemPhim.Cursor = Cursors.Hand;
            btnThemPhim.FlatAppearance.BorderSize = 0;
            btnThemPhim.FlatAppearance.MouseOverBackColor = Color.FromArgb(29, 78, 216);
            btnThemPhim.FlatStyle = FlatStyle.Flat;
            btnThemPhim.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnThemPhim.ForeColor = Color.White;
            btnThemPhim.Location = new Point(242, 258);
            btnThemPhim.Name = "btnThemPhim";
            btnThemPhim.Size = new Size(104, 30);
            btnThemPhim.Text = "Thêm";
            btnThemPhim.UseVisualStyleBackColor = false;
            btnThemPhim.TabIndex = 10;
            btnThemPhim.Click += btnThemPhim_Click;
            // 
            // pnlDatVe
            // 
            pnlDatVe.BackColor = Color.White;
            pnlDatVe.Location = new Point(396, 80);
            pnlDatVe.Name = "pnlDatVe";
            pnlDatVe.Size = new Size(380, 316);
            pnlDatVe.Controls.Add(lblDatVe);
            pnlDatVe.Controls.Add(lblHoTen);
            pnlDatVe.Controls.Add(txtHoTen);
            pnlDatVe.Controls.Add(lblChonPhim);
            pnlDatVe.Controls.Add(cboPhim);
            pnlDatVe.Controls.Add(lblPhongChieu);
            pnlDatVe.Controls.Add(cboPhongChieu);
            pnlDatVe.Controls.Add(lblChonGhe);
            pnlDatVe.Controls.Add(clbGhe);
            pnlDatVe.Controls.Add(lblLoaiVe);
            pnlDatVe.TabIndex = 2;
            // 
            // lblDatVe
            // 
            lblDatVe.AutoSize = true;
            lblDatVe.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDatVe.ForeColor = Color.FromArgb(30, 64, 175);
            lblDatVe.Location = new Point(14, 12);
            lblDatVe.Name = "lblDatVe";
            lblDatVe.Text = "Thông tin đặt vé";
            lblDatVe.TabIndex = 0;
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.ForeColor = Color.FromArgb(30, 41, 59);
            lblHoTen.Location = new Point(14, 47);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Text = "Họ và tên";
            lblHoTen.TabIndex = 1;
            // 
            // txtHoTen
            // 
            txtHoTen.ForeColor = Color.FromArgb(30, 41, 59);
            txtHoTen.Location = new Point(110, 44);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(256, 25);
            txtHoTen.TabIndex = 2;
            // 
            // lblChonPhim
            // 
            lblChonPhim.AutoSize = true;
            lblChonPhim.ForeColor = Color.FromArgb(30, 41, 59);
            lblChonPhim.Location = new Point(14, 85);
            lblChonPhim.Name = "lblChonPhim";
            lblChonPhim.Text = "Phim";
            lblChonPhim.TabIndex = 3;
            // 
            // cboPhim
            // 
            cboPhim.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPhim.ForeColor = Color.FromArgb(30, 41, 59);
            cboPhim.FormattingEnabled = true;
            cboPhim.Location = new Point(110, 82);
            cboPhim.Name = "cboPhim";
            cboPhim.Size = new Size(256, 25);
            cboPhim.TabIndex = 4;
            cboPhim.SelectedIndexChanged += cboPhim_SelectedIndexChanged;
            // 
            // lblPhongChieu
            // 
            lblPhongChieu.AutoSize = true;
            lblPhongChieu.ForeColor = Color.FromArgb(30, 41, 59);
            lblPhongChieu.Location = new Point(14, 123);
            lblPhongChieu.Name = "lblPhongChieu";
            lblPhongChieu.Text = "Phòng chiếu";
            lblPhongChieu.TabIndex = 5;
            // 
            // cboPhongChieu
            // 
            cboPhongChieu.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPhongChieu.ForeColor = Color.FromArgb(30, 41, 59);
            cboPhongChieu.FormattingEnabled = true;
            cboPhongChieu.Location = new Point(110, 120);
            cboPhongChieu.Name = "cboPhongChieu";
            cboPhongChieu.Size = new Size(256, 25);
            cboPhongChieu.TabIndex = 6;
            cboPhongChieu.SelectedIndexChanged += cboPhongChieu_SelectedIndexChanged;
            // 
            // lblChonGhe
            // 
            lblChonGhe.AutoSize = true;
            lblChonGhe.ForeColor = Color.FromArgb(30, 41, 59);
            lblChonGhe.Location = new Point(14, 160);
            lblChonGhe.Name = "lblChonGhe";
            lblChonGhe.Text = "Chọn ghế";
            lblChonGhe.TabIndex = 7;
            // 
            // clbGhe
            // 
            clbGhe.CheckOnClick = true;
            clbGhe.ColumnWidth = 84;
            clbGhe.ForeColor = Color.FromArgb(30, 41, 59);
            clbGhe.FormattingEnabled = true;
            clbGhe.Location = new Point(110, 158);
            clbGhe.MultiColumn = true;
            clbGhe.Name = "clbGhe";
            clbGhe.Size = new Size(256, 92);
            clbGhe.TabIndex = 8;
            // 
            // lblLoaiVe
            // 
            lblLoaiVe.Font = new Font("Segoe UI", 9F);
            lblLoaiVe.ForeColor = Color.FromArgb(100, 116, 139);
            lblLoaiVe.Location = new Point(14, 258);
            lblLoaiVe.Name = "lblLoaiVe";
            lblLoaiVe.Size = new Size(352, 50);
            lblLoaiVe.Text = "";
            lblLoaiVe.TabIndex = 9;
            // 
            // pnlThongTinVe
            // 
            pnlThongTinVe.BackColor = Color.White;
            pnlThongTinVe.Location = new Point(792, 80);
            pnlThongTinVe.Name = "pnlThongTinVe";
            pnlThongTinVe.Size = new Size(368, 316);
            pnlThongTinVe.Controls.Add(lblThongTinVe);
            pnlThongTinVe.Controls.Add(txtThongTinVe);
            pnlThongTinVe.Controls.Add(btnThanhToan);
            pnlThongTinVe.Controls.Add(btnXoa);
            pnlThongTinVe.TabIndex = 3;
            // 
            // lblThongTinVe
            // 
            lblThongTinVe.AutoSize = true;
            lblThongTinVe.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblThongTinVe.ForeColor = Color.FromArgb(30, 64, 175);
            lblThongTinVe.Location = new Point(14, 12);
            lblThongTinVe.Name = "lblThongTinVe";
            lblThongTinVe.Text = "Thông tin vé";
            lblThongTinVe.TabIndex = 0;
            // 
            // txtThongTinVe
            // 
            txtThongTinVe.BackColor = Color.FromArgb(239, 246, 255);
            txtThongTinVe.ForeColor = Color.FromArgb(30, 41, 59);
            txtThongTinVe.Location = new Point(14, 40);
            txtThongTinVe.Multiline = true;
            txtThongTinVe.Name = "txtThongTinVe";
            txtThongTinVe.ReadOnly = true;
            txtThongTinVe.ScrollBars = ScrollBars.Vertical;
            txtThongTinVe.Size = new Size(340, 220);
            txtThongTinVe.TabIndex = 1;
            // 
            // btnThanhToan
            // 
            btnThanhToan.BackColor = Color.FromArgb(37, 99, 235);
            btnThanhToan.Cursor = Cursors.Hand;
            btnThanhToan.FlatAppearance.BorderSize = 0;
            btnThanhToan.FlatAppearance.MouseOverBackColor = Color.FromArgb(29, 78, 216);
            btnThanhToan.FlatStyle = FlatStyle.Flat;
            btnThanhToan.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnThanhToan.ForeColor = Color.White;
            btnThanhToan.Location = new Point(14, 268);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(164, 36);
            btnThanhToan.Text = "Thanh toán";
            btnThanhToan.UseVisualStyleBackColor = false;
            btnThanhToan.TabIndex = 2;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(226, 232, 240);
            btnXoa.Cursor = Cursors.Hand;
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatAppearance.MouseOverBackColor = Color.FromArgb(203, 213, 225);
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnXoa.ForeColor = Color.FromArgb(30, 41, 59);
            btnXoa.Location = new Point(190, 268);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(164, 36);
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.TabIndex = 3;
            btnXoa.Click += btnXoa_Click;
            // 
            // pnlThongKe
            // 
            pnlThongKe.BackColor = Color.White;
            pnlThongKe.Location = new Point(20, 410);
            pnlThongKe.Name = "pnlThongKe";
            pnlThongKe.Size = new Size(1140, 178);
            pnlThongKe.Controls.Add(lblThongKe);
            pnlThongKe.Controls.Add(lvwThongKe);
            pnlThongKe.Controls.Add(btnXuatFile);
            pnlThongKe.Controls.Add(pgbXuatFile);
            pnlThongKe.Controls.Add(lblTienDo);
            pnlThongKe.TabIndex = 4;
            // 
            // lblThongKe
            // 
            lblThongKe.AutoSize = true;
            lblThongKe.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblThongKe.ForeColor = Color.FromArgb(30, 64, 175);
            lblThongKe.Location = new Point(14, 12);
            lblThongKe.Name = "lblThongKe";
            lblThongKe.Text = "Thống kê theo phim";
            lblThongKe.TabIndex = 0;
            // 
            // lvwThongKe
            // 
            lvwThongKe.ForeColor = Color.FromArgb(30, 41, 59);
            lvwThongKe.FullRowSelect = true;
            lvwThongKe.GridLines = true;
            lvwThongKe.Location = new Point(14, 40);
            lvwThongKe.MultiSelect = false;
            lvwThongKe.Name = "lvwThongKe";
            lvwThongKe.Size = new Size(870, 126);
            lvwThongKe.UseCompatibleStateImageBehavior = false;
            lvwThongKe.View = View.Details;
            lvwThongKe.Columns.AddRange(new ColumnHeader[] { colHang, colTenPhim, colVeBan, colVeTon, colTiLe, colDoanhThu });
            lvwThongKe.TabIndex = 1;
            // 
            // colHang
            // 
            colHang.TextAlign = HorizontalAlignment.Center;
            colHang.Text = "Hạng";
            colHang.Width = 60;
            // 
            // colTenPhim
            // 
            colTenPhim.Text = "Tên phim";
            colTenPhim.Width = 250;
            // 
            // colVeBan
            // 
            colVeBan.TextAlign = HorizontalAlignment.Right;
            colVeBan.Text = "Vé bán ra";
            colVeBan.Width = 100;
            // 
            // colVeTon
            // 
            colVeTon.TextAlign = HorizontalAlignment.Right;
            colVeTon.Text = "Vé tồn";
            colVeTon.Width = 100;
            // 
            // colTiLe
            // 
            colTiLe.TextAlign = HorizontalAlignment.Right;
            colTiLe.Text = "Tỉ lệ bán";
            colTiLe.Width = 110;
            // 
            // colDoanhThu
            // 
            colDoanhThu.TextAlign = HorizontalAlignment.Right;
            colDoanhThu.Text = "Doanh thu";
            colDoanhThu.Width = 200;
            // 
            // btnXuatFile
            // 
            btnXuatFile.BackColor = Color.FromArgb(37, 99, 235);
            btnXuatFile.Cursor = Cursors.Hand;
            btnXuatFile.FlatAppearance.BorderSize = 0;
            btnXuatFile.FlatAppearance.MouseOverBackColor = Color.FromArgb(29, 78, 216);
            btnXuatFile.FlatStyle = FlatStyle.Flat;
            btnXuatFile.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnXuatFile.ForeColor = Color.White;
            btnXuatFile.Location = new Point(898, 40);
            btnXuatFile.Name = "btnXuatFile";
            btnXuatFile.Size = new Size(228, 38);
            btnXuatFile.Text = "Xuất output5.txt";
            btnXuatFile.UseVisualStyleBackColor = false;
            btnXuatFile.TabIndex = 2;
            btnXuatFile.Click += btnXuatFile_Click;
            // 
            // pgbXuatFile
            // 
            pgbXuatFile.Location = new Point(898, 88);
            pgbXuatFile.Name = "pgbXuatFile";
            pgbXuatFile.Size = new Size(228, 24);
            pgbXuatFile.TabIndex = 3;
            // 
            // lblTienDo
            // 
            lblTienDo.Font = new Font("Segoe UI", 9F);
            lblTienDo.ForeColor = Color.FromArgb(100, 116, 139);
            lblTienDo.Location = new Point(898, 118);
            lblTienDo.Name = "lblTienDo";
            lblTienDo.Size = new Size(228, 50);
            lblTienDo.Text = "";
            lblTienDo.TabIndex = 4;
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
            btnThoat.Location = new Point(1044, 600);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(116, 38);
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.TabIndex = 5;
            btnThoat.Click += btnThoat_Click;
            // 
            // Bai5
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 246, 250);
            CancelButton = btnThoat;
            ClientSize = new Size(1180, 648);
            Controls.Add(btnThoat);
            Controls.Add(pnlThongKe);
            Controls.Add(pnlThongTinVe);
            Controls.Add(pnlDatVe);
            Controls.Add(pnlPhim);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.FromArgb(30, 41, 59);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Bai5";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Lab02-Bai05";
            FormClosing += Bai5_FormClosing;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlPhim.ResumeLayout(false);
            pnlPhim.PerformLayout();
            pnlDatVe.ResumeLayout(false);
            pnlDatVe.PerformLayout();
            pnlThongTinVe.ResumeLayout(false);
            pnlThongTinVe.PerformLayout();
            pnlThongKe.ResumeLayout(false);
            pnlThongKe.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTieuDe;
        private Panel pnlPhim;
        private Label lblPhim;
        private Button btnDocFile;
        private ListBox lstPhim;
        private Label lblThemPhim;
        private Label lblTenPhimMoi;
        private TextBox txtTenPhimMoi;
        private Label lblGiaVeMoi;
        private TextBox txtGiaVeMoi;
        private Label lblPhongMoi;
        private TextBox txtPhongMoi;
        private Button btnThemPhim;
        private Panel pnlDatVe;
        private Label lblDatVe;
        private Label lblHoTen;
        private TextBox txtHoTen;
        private Label lblChonPhim;
        private ComboBox cboPhim;
        private Label lblPhongChieu;
        private ComboBox cboPhongChieu;
        private Label lblChonGhe;
        private CheckedListBox clbGhe;
        private Label lblLoaiVe;
        private Panel pnlThongTinVe;
        private Label lblThongTinVe;
        private TextBox txtThongTinVe;
        private Button btnThanhToan;
        private Button btnXoa;
        private Panel pnlThongKe;
        private Label lblThongKe;
        private ListView lvwThongKe;
        private Button btnXuatFile;
        private ProgressBar pgbXuatFile;
        private Label lblTienDo;
        private Button btnThoat;
        private ColumnHeader colHang;
        private ColumnHeader colTenPhim;
        private ColumnHeader colVeBan;
        private ColumnHeader colVeTon;
        private ColumnHeader colTiLe;
        private ColumnHeader colDoanhThu;
    }
}
