namespace NT106_Lab2
{
    partial class Bai2
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
            pnlThongTin = new Panel();
            btnDocFile = new Button();
            lblTenFile = new Label();
            txtTenFile = new TextBox();
            lblKichThuoc = new Label();
            txtKichThuoc = new TextBox();
            lblDuongDan = new Label();
            txtDuongDan = new TextBox();
            lblSoDong = new Label();
            txtSoDong = new TextBox();
            lblSoTu = new Label();
            txtSoTu = new TextBox();
            lblSoKyTu = new Label();
            txtSoKyTu = new TextBox();
            pnlNoiDung = new Panel();
            lblNoiDung = new Label();
            rtbNoiDung = new RichTextBox();
            btnXoa = new Button();
            btnThoat = new Button();
            pnlHeader.SuspendLayout();
            pnlThongTin.SuspendLayout();
            pnlNoiDung.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(30, 64, 175);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(900, 64);
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
            lblTieuDe.Text = "ĐỌC THÔNG TIN FILE .TXT";
            lblTieuDe.TabIndex = 0;
            // 
            // pnlThongTin
            // 
            pnlThongTin.BackColor = Color.White;
            pnlThongTin.Location = new Point(20, 80);
            pnlThongTin.Name = "pnlThongTin";
            pnlThongTin.Size = new Size(360, 362);
            pnlThongTin.Controls.Add(btnDocFile);
            pnlThongTin.Controls.Add(lblTenFile);
            pnlThongTin.Controls.Add(txtTenFile);
            pnlThongTin.Controls.Add(lblKichThuoc);
            pnlThongTin.Controls.Add(txtKichThuoc);
            pnlThongTin.Controls.Add(lblDuongDan);
            pnlThongTin.Controls.Add(txtDuongDan);
            pnlThongTin.Controls.Add(lblSoDong);
            pnlThongTin.Controls.Add(txtSoDong);
            pnlThongTin.Controls.Add(lblSoTu);
            pnlThongTin.Controls.Add(txtSoTu);
            pnlThongTin.Controls.Add(lblSoKyTu);
            pnlThongTin.Controls.Add(txtSoKyTu);
            pnlThongTin.TabIndex = 1;
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
            btnDocFile.Location = new Point(14, 14);
            btnDocFile.Name = "btnDocFile";
            btnDocFile.Size = new Size(332, 40);
            btnDocFile.Text = "Đọc file";
            btnDocFile.UseVisualStyleBackColor = false;
            btnDocFile.TabIndex = 0;
            btnDocFile.Click += btnDocFile_Click;
            // 
            // lblTenFile
            // 
            lblTenFile.AutoSize = true;
            lblTenFile.ForeColor = Color.FromArgb(30, 41, 59);
            lblTenFile.Location = new Point(14, 77);
            lblTenFile.Name = "lblTenFile";
            lblTenFile.Text = "Tên file";
            lblTenFile.TabIndex = 1;
            // 
            // txtTenFile
            // 
            txtTenFile.BackColor = Color.FromArgb(239, 246, 255);
            txtTenFile.ForeColor = Color.FromArgb(30, 41, 59);
            txtTenFile.Location = new Point(120, 74);
            txtTenFile.Name = "txtTenFile";
            txtTenFile.ReadOnly = true;
            txtTenFile.Size = new Size(226, 25);
            txtTenFile.TabIndex = 2;
            // 
            // lblKichThuoc
            // 
            lblKichThuoc.AutoSize = true;
            lblKichThuoc.ForeColor = Color.FromArgb(30, 41, 59);
            lblKichThuoc.Location = new Point(14, 121);
            lblKichThuoc.Name = "lblKichThuoc";
            lblKichThuoc.Text = "Kích thước";
            lblKichThuoc.TabIndex = 3;
            // 
            // txtKichThuoc
            // 
            txtKichThuoc.BackColor = Color.FromArgb(239, 246, 255);
            txtKichThuoc.ForeColor = Color.FromArgb(30, 41, 59);
            txtKichThuoc.Location = new Point(120, 118);
            txtKichThuoc.Name = "txtKichThuoc";
            txtKichThuoc.ReadOnly = true;
            txtKichThuoc.Size = new Size(226, 25);
            txtKichThuoc.TabIndex = 4;
            // 
            // lblDuongDan
            // 
            lblDuongDan.AutoSize = true;
            lblDuongDan.ForeColor = Color.FromArgb(30, 41, 59);
            lblDuongDan.Location = new Point(14, 165);
            lblDuongDan.Name = "lblDuongDan";
            lblDuongDan.Text = "Đường dẫn";
            lblDuongDan.TabIndex = 5;
            // 
            // txtDuongDan
            // 
            txtDuongDan.BackColor = Color.FromArgb(239, 246, 255);
            txtDuongDan.ForeColor = Color.FromArgb(30, 41, 59);
            txtDuongDan.Location = new Point(120, 162);
            txtDuongDan.Name = "txtDuongDan";
            txtDuongDan.ReadOnly = true;
            txtDuongDan.Size = new Size(226, 25);
            txtDuongDan.TabIndex = 6;
            // 
            // lblSoDong
            // 
            lblSoDong.AutoSize = true;
            lblSoDong.ForeColor = Color.FromArgb(30, 41, 59);
            lblSoDong.Location = new Point(14, 209);
            lblSoDong.Name = "lblSoDong";
            lblSoDong.Text = "Số dòng";
            lblSoDong.TabIndex = 7;
            // 
            // txtSoDong
            // 
            txtSoDong.BackColor = Color.FromArgb(239, 246, 255);
            txtSoDong.ForeColor = Color.FromArgb(30, 41, 59);
            txtSoDong.Location = new Point(120, 206);
            txtSoDong.Name = "txtSoDong";
            txtSoDong.ReadOnly = true;
            txtSoDong.Size = new Size(226, 25);
            txtSoDong.TabIndex = 8;
            // 
            // lblSoTu
            // 
            lblSoTu.AutoSize = true;
            lblSoTu.ForeColor = Color.FromArgb(30, 41, 59);
            lblSoTu.Location = new Point(14, 253);
            lblSoTu.Name = "lblSoTu";
            lblSoTu.Text = "Số từ";
            lblSoTu.TabIndex = 9;
            // 
            // txtSoTu
            // 
            txtSoTu.BackColor = Color.FromArgb(239, 246, 255);
            txtSoTu.ForeColor = Color.FromArgb(30, 41, 59);
            txtSoTu.Location = new Point(120, 250);
            txtSoTu.Name = "txtSoTu";
            txtSoTu.ReadOnly = true;
            txtSoTu.Size = new Size(226, 25);
            txtSoTu.TabIndex = 10;
            // 
            // lblSoKyTu
            // 
            lblSoKyTu.AutoSize = true;
            lblSoKyTu.ForeColor = Color.FromArgb(30, 41, 59);
            lblSoKyTu.Location = new Point(14, 297);
            lblSoKyTu.Name = "lblSoKyTu";
            lblSoKyTu.Text = "Số ký tự";
            lblSoKyTu.TabIndex = 11;
            // 
            // txtSoKyTu
            // 
            txtSoKyTu.BackColor = Color.FromArgb(239, 246, 255);
            txtSoKyTu.ForeColor = Color.FromArgb(30, 41, 59);
            txtSoKyTu.Location = new Point(120, 294);
            txtSoKyTu.Name = "txtSoKyTu";
            txtSoKyTu.ReadOnly = true;
            txtSoKyTu.Size = new Size(226, 25);
            txtSoKyTu.TabIndex = 12;
            // 
            // pnlNoiDung
            // 
            pnlNoiDung.BackColor = Color.White;
            pnlNoiDung.Location = new Point(396, 80);
            pnlNoiDung.Name = "pnlNoiDung";
            pnlNoiDung.Size = new Size(484, 362);
            pnlNoiDung.Controls.Add(lblNoiDung);
            pnlNoiDung.Controls.Add(rtbNoiDung);
            pnlNoiDung.TabIndex = 2;
            // 
            // lblNoiDung
            // 
            lblNoiDung.AutoSize = true;
            lblNoiDung.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNoiDung.ForeColor = Color.FromArgb(30, 64, 175);
            lblNoiDung.Location = new Point(14, 12);
            lblNoiDung.Name = "lblNoiDung";
            lblNoiDung.Text = "Nội dung file";
            lblNoiDung.TabIndex = 0;
            // 
            // rtbNoiDung
            // 
            rtbNoiDung.BackColor = Color.FromArgb(239, 246, 255);
            rtbNoiDung.ForeColor = Color.FromArgb(30, 41, 59);
            rtbNoiDung.Location = new Point(14, 40);
            rtbNoiDung.Name = "rtbNoiDung";
            rtbNoiDung.ReadOnly = true;
            rtbNoiDung.Size = new Size(456, 308);
            rtbNoiDung.Text = "";
            rtbNoiDung.WordWrap = true;
            rtbNoiDung.TabIndex = 1;
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
            btnXoa.Location = new Point(638, 458);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(116, 38);
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.TabIndex = 3;
            btnXoa.Click += btnXoa_Click;
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
            btnThoat.Location = new Point(764, 458);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(116, 38);
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.TabIndex = 4;
            btnThoat.Click += btnThoat_Click;
            // 
            // Bai2
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 246, 250);
            CancelButton = btnThoat;
            ClientSize = new Size(900, 514);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(pnlNoiDung);
            Controls.Add(pnlThongTin);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.FromArgb(30, 41, 59);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Bai2";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Lab02-Bai02";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlThongTin.ResumeLayout(false);
            pnlThongTin.PerformLayout();
            pnlNoiDung.ResumeLayout(false);
            pnlNoiDung.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTieuDe;
        private Panel pnlThongTin;
        private Button btnDocFile;
        private Label lblTenFile;
        private TextBox txtTenFile;
        private Label lblKichThuoc;
        private TextBox txtKichThuoc;
        private Label lblDuongDan;
        private TextBox txtDuongDan;
        private Label lblSoDong;
        private TextBox txtSoDong;
        private Label lblSoTu;
        private TextBox txtSoTu;
        private Label lblSoKyTu;
        private TextBox txtSoKyTu;
        private Panel pnlNoiDung;
        private Label lblNoiDung;
        private RichTextBox rtbNoiDung;
        private Button btnXoa;
        private Button btnThoat;
    }
}
