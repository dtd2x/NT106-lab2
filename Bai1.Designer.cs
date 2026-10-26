namespace NT106_Lab2
{
    partial class Bai1
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
            pnlFile = new Panel();
            lblTep = new Label();
            lblFileDoc = new Label();
            txtFileDoc = new TextBox();
            btnChonFileDoc = new Button();
            lblFileGhi = new Label();
            txtFileGhi = new TextBox();
            btnDocFile = new Button();
            btnGhiFile = new Button();
            lblTrangThai = new Label();
            pnlNoiDung = new Panel();
            lblNoiDungDoc = new Label();
            rtbNoiDungDoc = new RichTextBox();
            lblNoiDungGhi = new Label();
            rtbNoiDungGhi = new RichTextBox();
            btnThoat = new Button();
            pnlHeader.SuspendLayout();
            pnlFile.SuspendLayout();
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
            lblTieuDe.Text = "GHI VÀ ĐỌC FILE";
            lblTieuDe.TabIndex = 0;
            // 
            // pnlFile
            // 
            pnlFile.BackColor = Color.White;
            pnlFile.Location = new Point(20, 80);
            pnlFile.Name = "pnlFile";
            pnlFile.Size = new Size(300, 362);
            pnlFile.Controls.Add(lblTep);
            pnlFile.Controls.Add(lblFileDoc);
            pnlFile.Controls.Add(txtFileDoc);
            pnlFile.Controls.Add(btnChonFileDoc);
            pnlFile.Controls.Add(lblFileGhi);
            pnlFile.Controls.Add(txtFileGhi);
            pnlFile.Controls.Add(btnDocFile);
            pnlFile.Controls.Add(btnGhiFile);
            pnlFile.Controls.Add(lblTrangThai);
            pnlFile.TabIndex = 1;
            // 
            // lblTep
            // 
            lblTep.AutoSize = true;
            lblTep.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTep.ForeColor = Color.FromArgb(30, 64, 175);
            lblTep.Location = new Point(14, 12);
            lblTep.Name = "lblTep";
            lblTep.Text = "Tệp tin";
            lblTep.TabIndex = 0;
            // 
            // lblFileDoc
            // 
            lblFileDoc.AutoSize = true;
            lblFileDoc.ForeColor = Color.FromArgb(30, 41, 59);
            lblFileDoc.Location = new Point(14, 48);
            lblFileDoc.Name = "lblFileDoc";
            lblFileDoc.Text = "File đọc";
            lblFileDoc.TabIndex = 1;
            // 
            // txtFileDoc
            // 
            txtFileDoc.BackColor = Color.FromArgb(239, 246, 255);
            txtFileDoc.ForeColor = Color.FromArgb(30, 41, 59);
            txtFileDoc.Location = new Point(14, 74);
            txtFileDoc.Name = "txtFileDoc";
            txtFileDoc.ReadOnly = true;
            txtFileDoc.Size = new Size(228, 25);
            txtFileDoc.TabIndex = 2;
            // 
            // btnChonFileDoc
            // 
            btnChonFileDoc.BackColor = Color.FromArgb(226, 232, 240);
            btnChonFileDoc.Cursor = Cursors.Hand;
            btnChonFileDoc.FlatAppearance.BorderSize = 0;
            btnChonFileDoc.FlatAppearance.MouseOverBackColor = Color.FromArgb(203, 213, 225);
            btnChonFileDoc.FlatStyle = FlatStyle.Flat;
            btnChonFileDoc.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnChonFileDoc.ForeColor = Color.FromArgb(30, 41, 59);
            btnChonFileDoc.Location = new Point(248, 72);
            btnChonFileDoc.Name = "btnChonFileDoc";
            btnChonFileDoc.Size = new Size(38, 29);
            btnChonFileDoc.Text = "...";
            btnChonFileDoc.UseVisualStyleBackColor = false;
            btnChonFileDoc.TabIndex = 3;
            btnChonFileDoc.Click += btnChonFileDoc_Click;
            // 
            // lblFileGhi
            // 
            lblFileGhi.AutoSize = true;
            lblFileGhi.ForeColor = Color.FromArgb(30, 41, 59);
            lblFileGhi.Location = new Point(14, 112);
            lblFileGhi.Name = "lblFileGhi";
            lblFileGhi.Text = "File ghi";
            lblFileGhi.TabIndex = 4;
            // 
            // txtFileGhi
            // 
            txtFileGhi.BackColor = Color.FromArgb(239, 246, 255);
            txtFileGhi.ForeColor = Color.FromArgb(30, 41, 59);
            txtFileGhi.Location = new Point(14, 138);
            txtFileGhi.Name = "txtFileGhi";
            txtFileGhi.ReadOnly = true;
            txtFileGhi.Size = new Size(272, 25);
            txtFileGhi.TabIndex = 5;
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
            btnDocFile.Location = new Point(14, 190);
            btnDocFile.Name = "btnDocFile";
            btnDocFile.Size = new Size(272, 46);
            btnDocFile.Text = "ĐỌC FILE";
            btnDocFile.UseVisualStyleBackColor = false;
            btnDocFile.TabIndex = 6;
            btnDocFile.Click += btnDocFile_Click;
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
            btnGhiFile.Location = new Point(14, 246);
            btnGhiFile.Name = "btnGhiFile";
            btnGhiFile.Size = new Size(272, 46);
            btnGhiFile.Text = "GHI FILE";
            btnGhiFile.UseVisualStyleBackColor = false;
            btnGhiFile.TabIndex = 7;
            btnGhiFile.Click += btnGhiFile_Click;
            // 
            // lblTrangThai
            // 
            lblTrangThai.Font = new Font("Segoe UI", 9F);
            lblTrangThai.ForeColor = Color.FromArgb(100, 116, 139);
            lblTrangThai.Location = new Point(14, 304);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(272, 44);
            lblTrangThai.Text = "Bấm ĐỌC FILE để đọc input1.txt.";
            lblTrangThai.TabIndex = 8;
            // 
            // pnlNoiDung
            // 
            pnlNoiDung.BackColor = Color.White;
            pnlNoiDung.Location = new Point(340, 80);
            pnlNoiDung.Name = "pnlNoiDung";
            pnlNoiDung.Size = new Size(540, 362);
            pnlNoiDung.Controls.Add(lblNoiDungDoc);
            pnlNoiDung.Controls.Add(rtbNoiDungDoc);
            pnlNoiDung.Controls.Add(lblNoiDungGhi);
            pnlNoiDung.Controls.Add(rtbNoiDungGhi);
            pnlNoiDung.TabIndex = 2;
            // 
            // lblNoiDungDoc
            // 
            lblNoiDungDoc.AutoSize = true;
            lblNoiDungDoc.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNoiDungDoc.ForeColor = Color.FromArgb(30, 64, 175);
            lblNoiDungDoc.Location = new Point(14, 12);
            lblNoiDungDoc.Name = "lblNoiDungDoc";
            lblNoiDungDoc.Text = "Nội dung file đọc";
            lblNoiDungDoc.TabIndex = 0;
            // 
            // rtbNoiDungDoc
            // 
            rtbNoiDungDoc.BackColor = Color.FromArgb(239, 246, 255);
            rtbNoiDungDoc.ForeColor = Color.FromArgb(30, 41, 59);
            rtbNoiDungDoc.Location = new Point(14, 40);
            rtbNoiDungDoc.Name = "rtbNoiDungDoc";
            rtbNoiDungDoc.ReadOnly = true;
            rtbNoiDungDoc.Size = new Size(512, 140);
            rtbNoiDungDoc.Text = "";
            rtbNoiDungDoc.WordWrap = true;
            rtbNoiDungDoc.TabIndex = 1;
            // 
            // lblNoiDungGhi
            // 
            lblNoiDungGhi.AutoSize = true;
            lblNoiDungGhi.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNoiDungGhi.ForeColor = Color.FromArgb(30, 64, 175);
            lblNoiDungGhi.Location = new Point(14, 190);
            lblNoiDungGhi.Name = "lblNoiDungGhi";
            lblNoiDungGhi.Text = "Nội dung file ghi (in hoa)";
            lblNoiDungGhi.TabIndex = 2;
            // 
            // rtbNoiDungGhi
            // 
            rtbNoiDungGhi.BackColor = Color.FromArgb(239, 246, 255);
            rtbNoiDungGhi.ForeColor = Color.FromArgb(30, 41, 59);
            rtbNoiDungGhi.Location = new Point(14, 218);
            rtbNoiDungGhi.Name = "rtbNoiDungGhi";
            rtbNoiDungGhi.ReadOnly = true;
            rtbNoiDungGhi.Size = new Size(512, 130);
            rtbNoiDungGhi.Text = "";
            rtbNoiDungGhi.WordWrap = true;
            rtbNoiDungGhi.TabIndex = 3;
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
            btnThoat.TabIndex = 3;
            btnThoat.Click += btnThoat_Click;
            // 
            // Bai1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 246, 250);
            CancelButton = btnThoat;
            ClientSize = new Size(900, 514);
            Controls.Add(btnThoat);
            Controls.Add(pnlNoiDung);
            Controls.Add(pnlFile);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.FromArgb(30, 41, 59);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Bai1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Lab02-Bai01";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlFile.ResumeLayout(false);
            pnlFile.PerformLayout();
            pnlNoiDung.ResumeLayout(false);
            pnlNoiDung.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTieuDe;
        private Panel pnlFile;
        private Label lblTep;
        private Label lblFileDoc;
        private TextBox txtFileDoc;
        private Button btnChonFileDoc;
        private Label lblFileGhi;
        private TextBox txtFileGhi;
        private Button btnDocFile;
        private Button btnGhiFile;
        private Label lblTrangThai;
        private Panel pnlNoiDung;
        private Label lblNoiDungDoc;
        private RichTextBox rtbNoiDungDoc;
        private Label lblNoiDungGhi;
        private RichTextBox rtbNoiDungGhi;
        private Button btnThoat;
    }
}
