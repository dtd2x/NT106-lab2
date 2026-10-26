namespace NT106_Lab2
{
    partial class Bai3
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
            lblFileDoc = new Label();
            txtFileDoc = new TextBox();
            btnChonFileDoc = new Button();
            pnlInput = new Panel();
            lblInput = new Label();
            rtbInput = new RichTextBox();
            pnlOutput = new Panel();
            lblOutput = new Label();
            rtbOutput = new RichTextBox();
            lblTrangThai = new Label();
            btnDocFile = new Button();
            btnTinh = new Button();
            btnThoat = new Button();
            pnlHeader.SuspendLayout();
            pnlFile.SuspendLayout();
            pnlInput.SuspendLayout();
            pnlOutput.SuspendLayout();
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
            lblTieuDe.Text = "ĐỌC FILE VÀ TÍNH TOÁN";
            lblTieuDe.TabIndex = 0;
            // 
            // pnlFile
            // 
            pnlFile.BackColor = Color.White;
            pnlFile.Location = new Point(20, 80);
            pnlFile.Name = "pnlFile";
            pnlFile.Size = new Size(860, 58);
            pnlFile.Controls.Add(lblFileDoc);
            pnlFile.Controls.Add(txtFileDoc);
            pnlFile.Controls.Add(btnChonFileDoc);
            pnlFile.TabIndex = 1;
            // 
            // lblFileDoc
            // 
            lblFileDoc.AutoSize = true;
            lblFileDoc.ForeColor = Color.FromArgb(30, 41, 59);
            lblFileDoc.Location = new Point(14, 17);
            lblFileDoc.Name = "lblFileDoc";
            lblFileDoc.Text = "File đọc";
            lblFileDoc.TabIndex = 0;
            // 
            // txtFileDoc
            // 
            txtFileDoc.BackColor = Color.FromArgb(239, 246, 255);
            txtFileDoc.ForeColor = Color.FromArgb(30, 41, 59);
            txtFileDoc.Location = new Point(90, 14);
            txtFileDoc.Name = "txtFileDoc";
            txtFileDoc.ReadOnly = true;
            txtFileDoc.Size = new Size(712, 25);
            txtFileDoc.TabIndex = 1;
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
            btnChonFileDoc.Location = new Point(808, 12);
            btnChonFileDoc.Name = "btnChonFileDoc";
            btnChonFileDoc.Size = new Size(38, 29);
            btnChonFileDoc.Text = "...";
            btnChonFileDoc.UseVisualStyleBackColor = false;
            btnChonFileDoc.TabIndex = 2;
            btnChonFileDoc.Click += btnChonFileDoc_Click;
            // 
            // pnlInput
            // 
            pnlInput.BackColor = Color.White;
            pnlInput.Location = new Point(20, 152);
            pnlInput.Name = "pnlInput";
            pnlInput.Size = new Size(422, 300);
            pnlInput.Controls.Add(lblInput);
            pnlInput.Controls.Add(rtbInput);
            pnlInput.TabIndex = 2;
            // 
            // lblInput
            // 
            lblInput.AutoSize = true;
            lblInput.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblInput.ForeColor = Color.FromArgb(30, 64, 175);
            lblInput.Location = new Point(14, 12);
            lblInput.Name = "lblInput";
            lblInput.Text = "Nội dung file đọc (input3.txt)";
            lblInput.TabIndex = 0;
            // 
            // rtbInput
            // 
            rtbInput.BackColor = Color.FromArgb(239, 246, 255);
            rtbInput.Font = new Font("Consolas", 11F);
            rtbInput.ForeColor = Color.FromArgb(30, 41, 59);
            rtbInput.Location = new Point(14, 40);
            rtbInput.Name = "rtbInput";
            rtbInput.ReadOnly = true;
            rtbInput.Size = new Size(394, 246);
            rtbInput.Text = "";
            rtbInput.WordWrap = false;
            rtbInput.TabIndex = 1;
            // 
            // pnlOutput
            // 
            pnlOutput.BackColor = Color.White;
            pnlOutput.Location = new Point(458, 152);
            pnlOutput.Name = "pnlOutput";
            pnlOutput.Size = new Size(422, 300);
            pnlOutput.Controls.Add(lblOutput);
            pnlOutput.Controls.Add(rtbOutput);
            pnlOutput.TabIndex = 3;
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblOutput.ForeColor = Color.FromArgb(30, 64, 175);
            lblOutput.Location = new Point(14, 12);
            lblOutput.Name = "lblOutput";
            lblOutput.Text = "Kết quả (output3.txt)";
            lblOutput.TabIndex = 0;
            // 
            // rtbOutput
            // 
            rtbOutput.BackColor = Color.FromArgb(239, 246, 255);
            rtbOutput.Font = new Font("Consolas", 11F);
            rtbOutput.ForeColor = Color.FromArgb(30, 41, 59);
            rtbOutput.Location = new Point(14, 40);
            rtbOutput.Name = "rtbOutput";
            rtbOutput.ReadOnly = true;
            rtbOutput.Size = new Size(394, 246);
            rtbOutput.Text = "";
            rtbOutput.WordWrap = false;
            rtbOutput.TabIndex = 1;
            // 
            // lblTrangThai
            // 
            lblTrangThai.Font = new Font("Segoe UI", 9F);
            lblTrangThai.ForeColor = Color.FromArgb(100, 116, 139);
            lblTrangThai.Location = new Point(20, 470);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(480, 40);
            lblTrangThai.Text = "Phép tính hỗ trợ: + - * /, ngoặc đơn, số thập phân.";
            lblTrangThai.TabIndex = 4;
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
            btnDocFile.Location = new Point(512, 472);
            btnDocFile.Name = "btnDocFile";
            btnDocFile.Size = new Size(116, 38);
            btnDocFile.Text = "Đọc file";
            btnDocFile.UseVisualStyleBackColor = false;
            btnDocFile.TabIndex = 5;
            btnDocFile.Click += btnDocFile_Click;
            // 
            // btnTinh
            // 
            btnTinh.BackColor = Color.FromArgb(37, 99, 235);
            btnTinh.Cursor = Cursors.Hand;
            btnTinh.FlatAppearance.BorderSize = 0;
            btnTinh.FlatAppearance.MouseOverBackColor = Color.FromArgb(29, 78, 216);
            btnTinh.FlatStyle = FlatStyle.Flat;
            btnTinh.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnTinh.ForeColor = Color.White;
            btnTinh.Location = new Point(638, 472);
            btnTinh.Name = "btnTinh";
            btnTinh.Size = new Size(116, 38);
            btnTinh.Text = "Tính và ghi";
            btnTinh.UseVisualStyleBackColor = false;
            btnTinh.TabIndex = 6;
            btnTinh.Click += btnTinh_Click;
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
            btnThoat.Location = new Point(764, 472);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(116, 38);
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.TabIndex = 7;
            btnThoat.Click += btnThoat_Click;
            // 
            // Bai3
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 246, 250);
            CancelButton = btnThoat;
            ClientSize = new Size(900, 534);
            Controls.Add(btnThoat);
            Controls.Add(btnTinh);
            Controls.Add(btnDocFile);
            Controls.Add(lblTrangThai);
            Controls.Add(pnlOutput);
            Controls.Add(pnlInput);
            Controls.Add(pnlFile);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.FromArgb(30, 41, 59);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Bai3";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Lab02-Bai03";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlFile.ResumeLayout(false);
            pnlFile.PerformLayout();
            pnlInput.ResumeLayout(false);
            pnlInput.PerformLayout();
            pnlOutput.ResumeLayout(false);
            pnlOutput.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTieuDe;
        private Panel pnlFile;
        private Label lblFileDoc;
        private TextBox txtFileDoc;
        private Button btnChonFileDoc;
        private Panel pnlInput;
        private Label lblInput;
        private RichTextBox rtbInput;
        private Panel pnlOutput;
        private Label lblOutput;
        private RichTextBox rtbOutput;
        private Label lblTrangThai;
        private Button btnDocFile;
        private Button btnTinh;
        private Button btnThoat;
    }
}
