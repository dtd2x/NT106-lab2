namespace NT106_Lab2
{
    partial class Dashboard
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
            btnBai01 = new Button();
            btnBai02 = new Button();
            btnBai03 = new Button();
            btnBai04 = new Button();
            btnBai05 = new Button();
            btnBai06 = new Button();
            btnBai07 = new Button();
            btnThoat = new Button();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(30, 64, 175);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(600, 64);
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
            lblTieuDe.Text = "LAB 2 - NT106";
            lblTieuDe.TabIndex = 0;
            // 
            // btnBai01
            // 
            btnBai01.BackColor = Color.White;
            btnBai01.Cursor = Cursors.Hand;
            btnBai01.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnBai01.FlatAppearance.MouseOverBackColor = Color.FromArgb(219, 234, 254);
            btnBai01.FlatStyle = FlatStyle.Flat;
            btnBai01.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBai01.ForeColor = Color.FromArgb(30, 64, 175);
            btnBai01.Location = new Point(20, 84);
            btnBai01.Name = "btnBai01";
            btnBai01.Size = new Size(176, 64);
            btnBai01.Text = "Bài 01\r\nGhi và đọc file";
            btnBai01.UseVisualStyleBackColor = false;
            btnBai01.TabIndex = 1;
            btnBai01.Click += btnBai01_Click;
            // 
            // btnBai02
            // 
            btnBai02.BackColor = Color.White;
            btnBai02.Cursor = Cursors.Hand;
            btnBai02.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnBai02.FlatAppearance.MouseOverBackColor = Color.FromArgb(219, 234, 254);
            btnBai02.FlatStyle = FlatStyle.Flat;
            btnBai02.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBai02.ForeColor = Color.FromArgb(30, 64, 175);
            btnBai02.Location = new Point(212, 84);
            btnBai02.Name = "btnBai02";
            btnBai02.Size = new Size(176, 64);
            btnBai02.Text = "Bài 02\r\nThông tin file .txt";
            btnBai02.UseVisualStyleBackColor = false;
            btnBai02.TabIndex = 2;
            btnBai02.Click += btnBai02_Click;
            // 
            // btnBai03
            // 
            btnBai03.BackColor = Color.White;
            btnBai03.Cursor = Cursors.Hand;
            btnBai03.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnBai03.FlatAppearance.MouseOverBackColor = Color.FromArgb(219, 234, 254);
            btnBai03.FlatStyle = FlatStyle.Flat;
            btnBai03.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBai03.ForeColor = Color.FromArgb(30, 64, 175);
            btnBai03.Location = new Point(404, 84);
            btnBai03.Name = "btnBai03";
            btnBai03.Size = new Size(176, 64);
            btnBai03.Text = "Bài 03\r\nTính biểu thức từ file";
            btnBai03.UseVisualStyleBackColor = false;
            btnBai03.TabIndex = 3;
            btnBai03.Click += btnBai03_Click;
            // 
            // btnBai04
            // 
            btnBai04.BackColor = Color.White;
            btnBai04.Cursor = Cursors.Hand;
            btnBai04.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnBai04.FlatAppearance.MouseOverBackColor = Color.FromArgb(219, 234, 254);
            btnBai04.FlatStyle = FlatStyle.Flat;
            btnBai04.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBai04.ForeColor = Color.FromArgb(30, 64, 175);
            btnBai04.Location = new Point(20, 164);
            btnBai04.Name = "btnBai04";
            btnBai04.Size = new Size(176, 64);
            btnBai04.Text = "Bài 04\r\nSinh viên (JSON)";
            btnBai04.UseVisualStyleBackColor = false;
            btnBai04.TabIndex = 4;
            btnBai04.Click += btnBai04_Click;
            // 
            // btnBai05
            // 
            btnBai05.BackColor = Color.White;
            btnBai05.Cursor = Cursors.Hand;
            btnBai05.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnBai05.FlatAppearance.MouseOverBackColor = Color.FromArgb(219, 234, 254);
            btnBai05.FlatStyle = FlatStyle.Flat;
            btnBai05.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBai05.ForeColor = Color.FromArgb(30, 64, 175);
            btnBai05.Location = new Point(212, 164);
            btnBai05.Name = "btnBai05";
            btnBai05.Size = new Size(176, 64);
            btnBai05.Text = "Bài 05\r\nQuản lý phòng vé";
            btnBai05.UseVisualStyleBackColor = false;
            btnBai05.TabIndex = 5;
            btnBai05.Click += btnBai05_Click;
            // 
            // btnBai06
            // 
            btnBai06.BackColor = Color.White;
            btnBai06.Cursor = Cursors.Hand;
            btnBai06.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnBai06.FlatAppearance.MouseOverBackColor = Color.FromArgb(219, 234, 254);
            btnBai06.FlatStyle = FlatStyle.Flat;
            btnBai06.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBai06.ForeColor = Color.FromArgb(30, 64, 175);
            btnBai06.Location = new Point(404, 164);
            btnBai06.Name = "btnBai06";
            btnBai06.Size = new Size(176, 64);
            btnBai06.Text = "Bài 06\r\nHôm nay ăn gì? (SQLite)";
            btnBai06.UseVisualStyleBackColor = false;
            btnBai06.TabIndex = 6;
            btnBai06.Click += btnBai06_Click;
            // 
            // btnBai07
            // 
            btnBai07.BackColor = Color.White;
            btnBai07.Cursor = Cursors.Hand;
            btnBai07.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnBai07.FlatAppearance.MouseOverBackColor = Color.FromArgb(219, 234, 254);
            btnBai07.FlatStyle = FlatStyle.Flat;
            btnBai07.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBai07.ForeColor = Color.FromArgb(30, 64, 175);
            btnBai07.Location = new Point(20, 244);
            btnBai07.Name = "btnBai07";
            btnBai07.Size = new Size(176, 64);
            btnBai07.Text = "Bài 07\r\nDuyệt thư mục";
            btnBai07.UseVisualStyleBackColor = false;
            btnBai07.TabIndex = 7;
            btnBai07.Click += btnBai07_Click;
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
            btnThoat.Location = new Point(464, 330);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(116, 40);
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.TabIndex = 8;
            btnThoat.Click += btnThoat_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 246, 250);
            CancelButton = btnThoat;
            ClientSize = new Size(600, 390);
            Controls.Add(btnThoat);
            Controls.Add(btnBai07);
            Controls.Add(btnBai06);
            Controls.Add(btnBai05);
            Controls.Add(btnBai04);
            Controls.Add(btnBai03);
            Controls.Add(btnBai02);
            Controls.Add(btnBai01);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.FromArgb(30, 41, 59);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lab02-Dashboard";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTieuDe;
        private Button btnBai01;
        private Button btnBai02;
        private Button btnBai03;
        private Button btnBai04;
        private Button btnBai05;
        private Button btnBai06;
        private Button btnBai07;
        private Button btnThoat;
    }
}
