namespace TimDuongDiNguoiGiaoHang
{
    partial class Main
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnChonDuong = new System.Windows.Forms.Button();
            this.btnTimDuong = new System.Windows.Forms.Button();
            this.btnSapXepCanh = new System.Windows.Forms.Button();
            this.btnTaoDsCanh = new System.Windows.Forms.Button();
            this.btnLoadDiem = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Stt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TenCanh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DoDai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.a = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1033, 1053);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnChonDuong);
            this.panel2.Controls.Add(this.btnTimDuong);
            this.panel2.Controls.Add(this.btnSapXepCanh);
            this.panel2.Controls.Add(this.btnTaoDsCanh);
            this.panel2.Controls.Add(this.btnLoadDiem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(1033, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(662, 148);
            this.panel2.TabIndex = 1;
            // 
            // btnChonDuong
            // 
            this.btnChonDuong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChonDuong.Enabled = false;
            this.btnChonDuong.Location = new System.Drawing.Point(222, 12);
            this.btnChonDuong.Name = "btnChonDuong";
            this.btnChonDuong.Size = new System.Drawing.Size(390, 34);
            this.btnChonDuong.TabIndex = 4;
            this.btnChonDuong.Text = "Chọn đường theo giải thuật tham lam";
            this.btnChonDuong.UseVisualStyleBackColor = true;
            this.btnChonDuong.Click += new System.EventHandler(this.btnChonDuong_Click);
            // 
            // btnTimDuong
            // 
            this.btnTimDuong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimDuong.Enabled = false;
            this.btnTimDuong.Location = new System.Drawing.Point(432, 69);
            this.btnTimDuong.Name = "btnTimDuong";
            this.btnTimDuong.Size = new System.Drawing.Size(180, 32);
            this.btnTimDuong.TabIndex = 3;
            this.btnTimDuong.Text = "Tìm đường";
            this.btnTimDuong.UseVisualStyleBackColor = true;
            this.btnTimDuong.Click += new System.EventHandler(this.btnTimDuong_Click);
            // 
            // btnSapXepCanh
            // 
            this.btnSapXepCanh.Enabled = false;
            this.btnSapXepCanh.Location = new System.Drawing.Point(222, 69);
            this.btnSapXepCanh.Name = "btnSapXepCanh";
            this.btnSapXepCanh.Size = new System.Drawing.Size(180, 34);
            this.btnSapXepCanh.TabIndex = 2;
            this.btnSapXepCanh.Text = "Sắp xếp cạnh";
            this.btnSapXepCanh.UseVisualStyleBackColor = true;
            this.btnSapXepCanh.Click += new System.EventHandler(this.btnSapXepCanh_Click);
            // 
            // btnTaoDsCanh
            // 
            this.btnTaoDsCanh.Enabled = false;
            this.btnTaoDsCanh.Location = new System.Drawing.Point(6, 71);
            this.btnTaoDsCanh.Name = "btnTaoDsCanh";
            this.btnTaoDsCanh.Size = new System.Drawing.Size(180, 32);
            this.btnTaoDsCanh.TabIndex = 1;
            this.btnTaoDsCanh.Text = "Tao danh sách cạnh";
            this.btnTaoDsCanh.UseVisualStyleBackColor = true;
            this.btnTaoDsCanh.Click += new System.EventHandler(this.btnTaoDsCanh_Click);
            // 
            // btnLoadDiem
            // 
            this.btnLoadDiem.Location = new System.Drawing.Point(6, 12);
            this.btnLoadDiem.Name = "btnLoadDiem";
            this.btnLoadDiem.Size = new System.Drawing.Size(180, 34);
            this.btnLoadDiem.TabIndex = 0;
            this.btnLoadDiem.Text = "Tạo điểm ngẫu nhiên";
            this.btnLoadDiem.UseVisualStyleBackColor = true;
            this.btnLoadDiem.Click += new System.EventHandler(this.btnLoadDiem_Click);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Stt,
            this.TenCanh,
            this.DoDai});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(1033, 148);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(659, 364);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Stt
            // 
            this.Stt.Text = "STT";
            this.Stt.Width = 100;
            // 
            // TenCanh
            // 
            this.TenCanh.Text = "Tên cạnh";
            this.TenCanh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TenCanh.Width = 200;
            // 
            // DoDai
            // 
            this.DoDai.Text = "Độ dài";
            this.DoDai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DoDai.Width = 250;
            // 
            // listView2
            // 
            this.listView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.a,
            this.columnHeader1,
            this.columnHeader2});
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.Location = new System.Drawing.Point(1036, 546);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(650, 495);
            this.listView2.TabIndex = 7;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // a
            // 
            this.a.Text = "STT";
            this.a.Width = 100;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên cạnh";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Độ dài";
            this.columnHeader2.Width = 250;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1695, 1053);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TÌM ĐƯỜNG ĐI CHO NGƯỜI GIAO HÀNG - GIẢI THUẬT THAM LAM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader TenCanh;
        private System.Windows.Forms.ColumnHeader DoDai;
        private System.Windows.Forms.ColumnHeader Stt;
        private System.Windows.Forms.Button btnLoadDiem;
        private System.Windows.Forms.Button btnTimDuong;
        private System.Windows.Forms.Button btnSapXepCanh;
        private System.Windows.Forms.Button btnTaoDsCanh;
        private System.Windows.Forms.Button btnChonDuong;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader a;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;

    }
}

