namespace NT106_Lab2
{
    partial class Bai7
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
            tvThuMuc = new TreeView();
            grpNoiDung = new GroupBox();
            lblDuongDan = new Label();
            rtbNoiDung = new RichTextBox();
            picNoiDung = new PictureBox();
            btnThoat = new Button();
            imlBieuTuong = new ImageList(components);
            pnlHeader.SuspendLayout();
            grpNoiDung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picNoiDung).BeginInit();
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
            lblTieuDe.Text = "DUYỆT THƯ MỤC";
            lblTieuDe.TabIndex = 0;
            // 
            // tvThuMuc
            // 
            tvThuMuc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tvThuMuc.ForeColor = Color.FromArgb(30, 41, 59);
            tvThuMuc.HideSelection = false;
            tvThuMuc.ImageIndex = 0;
            tvThuMuc.ImageList = imlBieuTuong;
            tvThuMuc.Location = new Point(20, 80);
            tvThuMuc.Name = "tvThuMuc";
            tvThuMuc.SelectedImageIndex = 0;
            tvThuMuc.Size = new Size(320, 480);
            tvThuMuc.TabIndex = 1;
            tvThuMuc.BeforeExpand += tvThuMuc_BeforeExpand;
            tvThuMuc.AfterSelect += tvThuMuc_AfterSelect;
            // 
            // grpNoiDung
            // 
            grpNoiDung.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpNoiDung.BackColor = Color.White;
            grpNoiDung.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpNoiDung.ForeColor = Color.FromArgb(30, 64, 175);
            grpNoiDung.Location = new Point(356, 74);
            grpNoiDung.Name = "grpNoiDung";
            grpNoiDung.Size = new Size(624, 486);
            grpNoiDung.TabStop = false;
            grpNoiDung.Text = "Nội dung file";
            grpNoiDung.Controls.Add(lblDuongDan);
            grpNoiDung.Controls.Add(rtbNoiDung);
            grpNoiDung.Controls.Add(picNoiDung);
            grpNoiDung.TabIndex = 2;
            // 
            // lblDuongDan
            // 
            lblDuongDan.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblDuongDan.AutoEllipsis = true;
            lblDuongDan.Font = new Font("Segoe UI", 9F);
            lblDuongDan.ForeColor = Color.FromArgb(100, 116, 139);
            lblDuongDan.Location = new Point(12, 26);
            lblDuongDan.Name = "lblDuongDan";
            lblDuongDan.Size = new Size(600, 22);
            lblDuongDan.Text = "Chọn một file bên trái để xem nội dung.";
            lblDuongDan.TabIndex = 0;
            // 
            // rtbNoiDung
            // 
            rtbNoiDung.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtbNoiDung.BackColor = Color.FromArgb(239, 246, 255);
            rtbNoiDung.Font = new Font("Consolas", 11F);
            rtbNoiDung.ForeColor = Color.FromArgb(30, 41, 59);
            rtbNoiDung.Location = new Point(12, 52);
            rtbNoiDung.Name = "rtbNoiDung";
            rtbNoiDung.ReadOnly = true;
            rtbNoiDung.Size = new Size(600, 422);
            rtbNoiDung.Text = "";
            rtbNoiDung.WordWrap = false;
            rtbNoiDung.TabIndex = 1;
            // 
            // picNoiDung
            // 
            picNoiDung.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picNoiDung.BackColor = Color.FromArgb(239, 246, 255);
            picNoiDung.Location = new Point(12, 52);
            picNoiDung.Name = "picNoiDung";
            picNoiDung.Size = new Size(600, 422);
            picNoiDung.SizeMode = PictureBoxSizeMode.Zoom;
            picNoiDung.Visible = false;
            picNoiDung.TabStop = false;
            picNoiDung.TabIndex = 2;
            // 
            // btnThoat
            // 
            btnThoat.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnThoat.BackColor = Color.FromArgb(220, 38, 38);
            btnThoat.Cursor = Cursors.Hand;
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.FlatAppearance.MouseOverBackColor = Color.FromArgb(185, 28, 28);
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(864, 572);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(116, 38);
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.TabIndex = 3;
            btnThoat.Click += btnThoat_Click;
            // 
            // imlBieuTuong
            // 
            imlBieuTuong.ColorDepth = ColorDepth.Depth32Bit;
            imlBieuTuong.ImageSize = new Size(16, 16);
            imlBieuTuong.TransparentColor = Color.Transparent;
            // 
            // Bai7
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 246, 250);
            CancelButton = btnThoat;
            ClientSize = new Size(1000, 620);
            Controls.Add(btnThoat);
            Controls.Add(grpNoiDung);
            Controls.Add(tvThuMuc);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.FromArgb(30, 41, 59);
            MinimumSize = new Size(760, 480);
            Name = "Bai7";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Lab02-Bai07";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            grpNoiDung.ResumeLayout(false);
            grpNoiDung.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picNoiDung).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTieuDe;
        private TreeView tvThuMuc;
        private GroupBox grpNoiDung;
        private Label lblDuongDan;
        private RichTextBox rtbNoiDung;
        private PictureBox picNoiDung;
        private Button btnThoat;
        private ImageList imlBieuTuong;
    }
}
