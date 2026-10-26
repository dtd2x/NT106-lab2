namespace NT106_Lab2
{
    partial class Bai6
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
            components = new System.ComponentModel.Container();
            pnlHeader = new Panel();
            lblTieuDe = new Label();
            pnlNhap = new Panel();
            lblThemNguoiDung = new Label();
            lblHoTen = new Label();
            txtHoTen = new TextBox();
            lblQuyenHan = new Label();
            cboQuyenHan = new ComboBox();
            btnThemNguoiDung = new Button();
            lblThemMon = new Label();
            lblTenMon = new Label();
            txtTenMon = new TextBox();
            lblNguoiDongGop = new Label();
            cboNguoiDongGop = new ComboBox();
            lblHinhAnh = new Label();
            btnChonAnh = new Button();
            picXemTruoc = new PictureBox();
            btnThemMon = new Button();
            pnlDanhSach = new Panel();
            lblDanhSach = new Label();
            lvwMonAn = new ListView();
            btnXoaMon = new Button();
            pnlChonMon = new Panel();
            lblHomNay = new Label();
            btnChonNgauNhien = new Button();
            picMonAn = new PictureBox();
            lblTenMonChon = new Label();
            lblNguoiGop = new Label();
            btnThoat = new Button();
            imlMonAn = new ImageList(components);
            colTenMon = new ColumnHeader();
            colNguoiDongGop = new ColumnHeader();
            pnlHeader.SuspendLayout();
            pnlNhap.SuspendLayout();
            pnlDanhSach.SuspendLayout();
            pnlChonMon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picXemTruoc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMonAn).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(30, 64, 175);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1020, 64);
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
            lblTieuDe.Text = "HÔM NAY ĂN GÌ? (SQLITE)";
            lblTieuDe.TabIndex = 0;
            // 
            // pnlNhap
            // 
            pnlNhap.BackColor = Color.White;
            pnlNhap.Location = new Point(20, 80);
            pnlNhap.Name = "pnlNhap";
            pnlNhap.Size = new Size(330, 480);
            pnlNhap.Controls.Add(lblThemNguoiDung);
            pnlNhap.Controls.Add(lblHoTen);
            pnlNhap.Controls.Add(txtHoTen);
            pnlNhap.Controls.Add(lblQuyenHan);
            pnlNhap.Controls.Add(cboQuyenHan);
            pnlNhap.Controls.Add(btnThemNguoiDung);
            pnlNhap.Controls.Add(lblThemMon);
            pnlNhap.Controls.Add(lblTenMon);
            pnlNhap.Controls.Add(txtTenMon);
            pnlNhap.Controls.Add(lblNguoiDongGop);
            pnlNhap.Controls.Add(cboNguoiDongGop);
            pnlNhap.Controls.Add(lblHinhAnh);
            pnlNhap.Controls.Add(btnChonAnh);
            pnlNhap.Controls.Add(picXemTruoc);
            pnlNhap.Controls.Add(btnThemMon);
            pnlNhap.TabIndex = 1;
            // 
            // lblThemNguoiDung
            // 
            lblThemNguoiDung.AutoSize = true;
            lblThemNguoiDung.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblThemNguoiDung.ForeColor = Color.FromArgb(30, 64, 175);
            lblThemNguoiDung.Location = new Point(14, 12);
            lblThemNguoiDung.Name = "lblThemNguoiDung";
            lblThemNguoiDung.Text = "Thêm người dùng";
            lblThemNguoiDung.TabIndex = 0;
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
            txtHoTen.Size = new Size(206, 25);
            txtHoTen.TabIndex = 2;
            // 
            // lblQuyenHan
            // 
            lblQuyenHan.AutoSize = true;
            lblQuyenHan.ForeColor = Color.FromArgb(30, 41, 59);
            lblQuyenHan.Location = new Point(14, 83);
            lblQuyenHan.Name = "lblQuyenHan";
            lblQuyenHan.Text = "Quyền hạn";
            lblQuyenHan.TabIndex = 3;
            // 
            // cboQuyenHan
            // 
            cboQuyenHan.DropDownStyle = ComboBoxStyle.DropDownList;
            cboQuyenHan.ForeColor = Color.FromArgb(30, 41, 59);
            cboQuyenHan.FormattingEnabled = true;
            cboQuyenHan.Location = new Point(110, 80);
            cboQuyenHan.Name = "cboQuyenHan";
            cboQuyenHan.Size = new Size(206, 25);
            cboQuyenHan.TabIndex = 4;
            cboQuyenHan.Items.AddRange(new object[] { "Admin", "Người dùng" });
            // 
            // btnThemNguoiDung
            // 
            btnThemNguoiDung.BackColor = Color.FromArgb(37, 99, 235);
            btnThemNguoiDung.Cursor = Cursors.Hand;
            btnThemNguoiDung.FlatAppearance.BorderSize = 0;
            btnThemNguoiDung.FlatAppearance.MouseOverBackColor = Color.FromArgb(29, 78, 216);
            btnThemNguoiDung.FlatStyle = FlatStyle.Flat;
            btnThemNguoiDung.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnThemNguoiDung.ForeColor = Color.White;
            btnThemNguoiDung.Location = new Point(110, 116);
            btnThemNguoiDung.Name = "btnThemNguoiDung";
            btnThemNguoiDung.Size = new Size(206, 34);
            btnThemNguoiDung.Text = "Thêm người dùng";
            btnThemNguoiDung.UseVisualStyleBackColor = false;
            btnThemNguoiDung.TabIndex = 5;
            btnThemNguoiDung.Click += btnThemNguoiDung_Click;
            // 
            // lblThemMon
            // 
            lblThemMon.AutoSize = true;
            lblThemMon.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblThemMon.ForeColor = Color.FromArgb(30, 64, 175);
            lblThemMon.Location = new Point(14, 172);
            lblThemMon.Name = "lblThemMon";
            lblThemMon.Text = "Thêm món ăn";
            lblThemMon.TabIndex = 6;
            // 
            // lblTenMon
            // 
            lblTenMon.AutoSize = true;
            lblTenMon.ForeColor = Color.FromArgb(30, 41, 59);
            lblTenMon.Location = new Point(14, 207);
            lblTenMon.Name = "lblTenMon";
            lblTenMon.Text = "Tên món";
            lblTenMon.TabIndex = 7;
            // 
            // txtTenMon
            // 
            txtTenMon.ForeColor = Color.FromArgb(30, 41, 59);
            txtTenMon.Location = new Point(110, 204);
            txtTenMon.Name = "txtTenMon";
            txtTenMon.Size = new Size(206, 25);
            txtTenMon.TabIndex = 8;
            // 
            // lblNguoiDongGop
            // 
            lblNguoiDongGop.AutoSize = true;
            lblNguoiDongGop.ForeColor = Color.FromArgb(30, 41, 59);
            lblNguoiDongGop.Location = new Point(14, 243);
            lblNguoiDongGop.Name = "lblNguoiDongGop";
            lblNguoiDongGop.Text = "Người góp";
            lblNguoiDongGop.TabIndex = 9;
            // 
            // cboNguoiDongGop
            // 
            cboNguoiDongGop.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNguoiDongGop.ForeColor = Color.FromArgb(30, 41, 59);
            cboNguoiDongGop.FormattingEnabled = true;
            cboNguoiDongGop.Location = new Point(110, 240);
            cboNguoiDongGop.Name = "cboNguoiDongGop";
            cboNguoiDongGop.Size = new Size(206, 25);
            cboNguoiDongGop.TabIndex = 10;
            // 
            // lblHinhAnh
            // 
            lblHinhAnh.AutoSize = true;
            lblHinhAnh.ForeColor = Color.FromArgb(30, 41, 59);
            lblHinhAnh.Location = new Point(14, 281);
            lblHinhAnh.Name = "lblHinhAnh";
            lblHinhAnh.Text = "Hình ảnh";
            lblHinhAnh.TabIndex = 11;
            // 
            // btnChonAnh
            // 
            btnChonAnh.BackColor = Color.FromArgb(226, 232, 240);
            btnChonAnh.Cursor = Cursors.Hand;
            btnChonAnh.FlatAppearance.BorderSize = 0;
            btnChonAnh.FlatAppearance.MouseOverBackColor = Color.FromArgb(203, 213, 225);
            btnChonAnh.FlatStyle = FlatStyle.Flat;
            btnChonAnh.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnChonAnh.ForeColor = Color.FromArgb(30, 41, 59);
            btnChonAnh.Location = new Point(110, 276);
            btnChonAnh.Name = "btnChonAnh";
            btnChonAnh.Size = new Size(206, 32);
            btnChonAnh.Text = "Chọn ảnh...";
            btnChonAnh.UseVisualStyleBackColor = false;
            btnChonAnh.TabIndex = 12;
            btnChonAnh.Click += btnChonAnh_Click;
            // 
            // picXemTruoc
            // 
            picXemTruoc.BackColor = Color.FromArgb(239, 246, 255);
            picXemTruoc.BorderStyle = BorderStyle.FixedSingle;
            picXemTruoc.Location = new Point(110, 314);
            picXemTruoc.Name = "picXemTruoc";
            picXemTruoc.Size = new Size(206, 112);
            picXemTruoc.SizeMode = PictureBoxSizeMode.Zoom;
            picXemTruoc.TabStop = false;
            picXemTruoc.TabIndex = 13;
            // 
            // btnThemMon
            // 
            btnThemMon.BackColor = Color.FromArgb(37, 99, 235);
            btnThemMon.Cursor = Cursors.Hand;
            btnThemMon.FlatAppearance.BorderSize = 0;
            btnThemMon.FlatAppearance.MouseOverBackColor = Color.FromArgb(29, 78, 216);
            btnThemMon.FlatStyle = FlatStyle.Flat;
            btnThemMon.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnThemMon.ForeColor = Color.White;
            btnThemMon.Location = new Point(110, 434);
            btnThemMon.Name = "btnThemMon";
            btnThemMon.Size = new Size(206, 34);
            btnThemMon.Text = "Thêm món ăn";
            btnThemMon.UseVisualStyleBackColor = false;
            btnThemMon.TabIndex = 14;
            btnThemMon.Click += btnThemMon_Click;
            // 
            // pnlDanhSach
            // 
            pnlDanhSach.BackColor = Color.White;
            pnlDanhSach.Location = new Point(366, 80);
            pnlDanhSach.Name = "pnlDanhSach";
            pnlDanhSach.Size = new Size(370, 480);
            pnlDanhSach.Controls.Add(lblDanhSach);
            pnlDanhSach.Controls.Add(lvwMonAn);
            pnlDanhSach.Controls.Add(btnXoaMon);
            pnlDanhSach.TabIndex = 2;
            // 
            // lblDanhSach
            // 
            lblDanhSach.AutoSize = true;
            lblDanhSach.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDanhSach.ForeColor = Color.FromArgb(30, 64, 175);
            lblDanhSach.Location = new Point(14, 12);
            lblDanhSach.Name = "lblDanhSach";
            lblDanhSach.Text = "Danh sách món ăn";
            lblDanhSach.TabIndex = 0;
            // 
            // lvwMonAn
            // 
            lvwMonAn.ForeColor = Color.FromArgb(30, 41, 59);
            lvwMonAn.FullRowSelect = true;
            lvwMonAn.Location = new Point(14, 40);
            lvwMonAn.MultiSelect = false;
            lvwMonAn.Name = "lvwMonAn";
            lvwMonAn.Size = new Size(342, 384);
            lvwMonAn.SmallImageList = imlMonAn;
            lvwMonAn.UseCompatibleStateImageBehavior = false;
            lvwMonAn.View = View.Details;
            lvwMonAn.Columns.AddRange(new ColumnHeader[] { colTenMon, colNguoiDongGop });
            lvwMonAn.TabIndex = 1;
            // 
            // colTenMon
            // 
            colTenMon.Text = "Món ăn";
            colTenMon.Width = 180;
            // 
            // colNguoiDongGop
            // 
            colNguoiDongGop.Text = "Người đóng góp";
            colNguoiDongGop.Width = 140;
            // 
            // btnXoaMon
            // 
            btnXoaMon.BackColor = Color.FromArgb(226, 232, 240);
            btnXoaMon.Cursor = Cursors.Hand;
            btnXoaMon.FlatAppearance.BorderSize = 0;
            btnXoaMon.FlatAppearance.MouseOverBackColor = Color.FromArgb(203, 213, 225);
            btnXoaMon.FlatStyle = FlatStyle.Flat;
            btnXoaMon.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnXoaMon.ForeColor = Color.FromArgb(30, 41, 59);
            btnXoaMon.Location = new Point(14, 432);
            btnXoaMon.Name = "btnXoaMon";
            btnXoaMon.Size = new Size(342, 34);
            btnXoaMon.Text = "Xoá món đã chọn";
            btnXoaMon.UseVisualStyleBackColor = false;
            btnXoaMon.TabIndex = 2;
            btnXoaMon.Click += btnXoaMon_Click;
            // 
            // pnlChonMon
            // 
            pnlChonMon.BackColor = Color.White;
            pnlChonMon.Location = new Point(752, 80);
            pnlChonMon.Name = "pnlChonMon";
            pnlChonMon.Size = new Size(248, 480);
            pnlChonMon.Controls.Add(lblHomNay);
            pnlChonMon.Controls.Add(btnChonNgauNhien);
            pnlChonMon.Controls.Add(picMonAn);
            pnlChonMon.Controls.Add(lblTenMonChon);
            pnlChonMon.Controls.Add(lblNguoiGop);
            pnlChonMon.TabIndex = 3;
            // 
            // lblHomNay
            // 
            lblHomNay.AutoSize = true;
            lblHomNay.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblHomNay.ForeColor = Color.FromArgb(30, 64, 175);
            lblHomNay.Location = new Point(14, 12);
            lblHomNay.Name = "lblHomNay";
            lblHomNay.Text = "Hôm nay ăn gì?";
            lblHomNay.TabIndex = 0;
            // 
            // btnChonNgauNhien
            // 
            btnChonNgauNhien.BackColor = Color.FromArgb(37, 99, 235);
            btnChonNgauNhien.Cursor = Cursors.Hand;
            btnChonNgauNhien.FlatAppearance.BorderSize = 0;
            btnChonNgauNhien.FlatAppearance.MouseOverBackColor = Color.FromArgb(29, 78, 216);
            btnChonNgauNhien.FlatStyle = FlatStyle.Flat;
            btnChonNgauNhien.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnChonNgauNhien.ForeColor = Color.White;
            btnChonNgauNhien.Location = new Point(14, 40);
            btnChonNgauNhien.Name = "btnChonNgauNhien";
            btnChonNgauNhien.Size = new Size(220, 40);
            btnChonNgauNhien.Text = "Chọn ngẫu nhiên";
            btnChonNgauNhien.UseVisualStyleBackColor = false;
            btnChonNgauNhien.TabIndex = 1;
            btnChonNgauNhien.Click += btnChonNgauNhien_Click;
            // 
            // picMonAn
            // 
            picMonAn.BackColor = Color.FromArgb(239, 246, 255);
            picMonAn.BorderStyle = BorderStyle.FixedSingle;
            picMonAn.Location = new Point(14, 94);
            picMonAn.Name = "picMonAn";
            picMonAn.Size = new Size(220, 190);
            picMonAn.SizeMode = PictureBoxSizeMode.Zoom;
            picMonAn.TabStop = false;
            picMonAn.TabIndex = 2;
            // 
            // lblTenMonChon
            // 
            lblTenMonChon.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTenMonChon.ForeColor = Color.FromArgb(30, 64, 175);
            lblTenMonChon.Location = new Point(14, 294);
            lblTenMonChon.Name = "lblTenMonChon";
            lblTenMonChon.Size = new Size(220, 64);
            lblTenMonChon.TextAlign = ContentAlignment.MiddleCenter;
            lblTenMonChon.Text = "???";
            lblTenMonChon.TabIndex = 3;
            // 
            // lblNguoiGop
            // 
            lblNguoiGop.Font = new Font("Segoe UI", 9F);
            lblNguoiGop.ForeColor = Color.FromArgb(100, 116, 139);
            lblNguoiGop.Location = new Point(14, 362);
            lblNguoiGop.Name = "lblNguoiGop";
            lblNguoiGop.Size = new Size(220, 44);
            lblNguoiGop.TextAlign = ContentAlignment.TopCenter;
            lblNguoiGop.Text = "";
            lblNguoiGop.TabIndex = 4;
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
            btnThoat.Location = new Point(884, 574);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(116, 38);
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.TabIndex = 4;
            btnThoat.Click += btnThoat_Click;
            // 
            // imlMonAn
            // 
            imlMonAn.ColorDepth = ColorDepth.Depth32Bit;
            imlMonAn.ImageSize = new Size(40, 40);
            imlMonAn.TransparentColor = Color.Transparent;
            // 
            // Bai6
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 246, 250);
            CancelButton = btnThoat;
            ClientSize = new Size(1020, 626);
            Controls.Add(btnThoat);
            Controls.Add(pnlChonMon);
            Controls.Add(pnlDanhSach);
            Controls.Add(pnlNhap);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.FromArgb(30, 41, 59);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Bai6";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Lab02-Bai06";
            Load += Bai6_Load;
            FormClosed += Bai6_FormClosed;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlNhap.ResumeLayout(false);
            pnlNhap.PerformLayout();
            pnlDanhSach.ResumeLayout(false);
            pnlDanhSach.PerformLayout();
            pnlChonMon.ResumeLayout(false);
            pnlChonMon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picXemTruoc).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMonAn).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTieuDe;
        private Panel pnlNhap;
        private Label lblThemNguoiDung;
        private Label lblHoTen;
        private TextBox txtHoTen;
        private Label lblQuyenHan;
        private ComboBox cboQuyenHan;
        private Button btnThemNguoiDung;
        private Label lblThemMon;
        private Label lblTenMon;
        private TextBox txtTenMon;
        private Label lblNguoiDongGop;
        private ComboBox cboNguoiDongGop;
        private Label lblHinhAnh;
        private Button btnChonAnh;
        private PictureBox picXemTruoc;
        private Button btnThemMon;
        private Panel pnlDanhSach;
        private Label lblDanhSach;
        private ListView lvwMonAn;
        private Button btnXoaMon;
        private Panel pnlChonMon;
        private Label lblHomNay;
        private Button btnChonNgauNhien;
        private PictureBox picMonAn;
        private Label lblTenMonChon;
        private Label lblNguoiGop;
        private Button btnThoat;
        private ImageList imlMonAn;
        private ColumnHeader colTenMon;
        private ColumnHeader colNguoiDongGop;
    }
}
