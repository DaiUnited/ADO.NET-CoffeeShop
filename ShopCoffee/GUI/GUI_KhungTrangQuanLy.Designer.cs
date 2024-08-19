namespace GUI
{
    partial class GUI_KhungTrangQuanLy
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
            menuStrip1 = new MenuStrip();
            goiMonToolStripMenuItem = new ToolStripMenuItem();
            nghiepVuToolStripMenuItem = new ToolStripMenuItem();
            quanLyDoUongToolStripMenuItem = new ToolStripMenuItem();
            quanLyBanToolStripMenuItem = new ToolStripMenuItem();
            quanLyHoaDonToolStripMenuItem = new ToolStripMenuItem();
            quanLyNhanVienToolStripMenuItem = new ToolStripMenuItem();
            thongKeToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { goiMonToolStripMenuItem, nghiepVuToolStripMenuItem, thongKeToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1160, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // goiMonToolStripMenuItem
            // 
            goiMonToolStripMenuItem.Name = "goiMonToolStripMenuItem";
            goiMonToolStripMenuItem.Size = new Size(62, 20);
            goiMonToolStripMenuItem.Text = "GoiMon";
            goiMonToolStripMenuItem.Click += goiMonToolStripMenuItem_Click;
            // 
            // nghiepVuToolStripMenuItem
            // 
            nghiepVuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { quanLyDoUongToolStripMenuItem, quanLyBanToolStripMenuItem, quanLyHoaDonToolStripMenuItem, quanLyNhanVienToolStripMenuItem });
            nghiepVuToolStripMenuItem.Name = "nghiepVuToolStripMenuItem";
            nghiepVuToolStripMenuItem.Size = new Size(72, 20);
            nghiepVuToolStripMenuItem.Text = "NghiepVu";
            // 
            // quanLyDoUongToolStripMenuItem
            // 
            quanLyDoUongToolStripMenuItem.Name = "quanLyDoUongToolStripMenuItem";
            quanLyDoUongToolStripMenuItem.Size = new Size(166, 22);
            quanLyDoUongToolStripMenuItem.Text = "QuanLyDoUong";
            quanLyDoUongToolStripMenuItem.Click += quanLyDoUongToolStripMenuItem_Click;
            // 
            // quanLyBanToolStripMenuItem
            // 
            quanLyBanToolStripMenuItem.Name = "quanLyBanToolStripMenuItem";
            quanLyBanToolStripMenuItem.Size = new Size(166, 22);
            quanLyBanToolStripMenuItem.Text = "QuanLyBan";
            quanLyBanToolStripMenuItem.Click += quanLyBanToolStripMenuItem_Click;
            // 
            // quanLyHoaDonToolStripMenuItem
            // 
            quanLyHoaDonToolStripMenuItem.Name = "quanLyHoaDonToolStripMenuItem";
            quanLyHoaDonToolStripMenuItem.Size = new Size(166, 22);
            quanLyHoaDonToolStripMenuItem.Text = "QuanLyHoaDon";
            quanLyHoaDonToolStripMenuItem.Click += quanLyHoaDonToolStripMenuItem_Click;
            // 
            // quanLyNhanVienToolStripMenuItem
            // 
            quanLyNhanVienToolStripMenuItem.Name = "quanLyNhanVienToolStripMenuItem";
            quanLyNhanVienToolStripMenuItem.Size = new Size(166, 22);
            quanLyNhanVienToolStripMenuItem.Text = "QuanLyNhanVien";
            quanLyNhanVienToolStripMenuItem.Click += quanLyNhanVienToolStripMenuItem_Click;
            // 
            // thongKeToolStripMenuItem
            // 
            thongKeToolStripMenuItem.Name = "thongKeToolStripMenuItem";
            thongKeToolStripMenuItem.Size = new Size(66, 20);
            thongKeToolStripMenuItem.Text = "ThongKe";
            thongKeToolStripMenuItem.Click += thongKeToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(0, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(1160, 608);
            panel1.TabIndex = 1;
            // 
            // GUI_KhungTrangQuanLy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1160, 634);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "GUI_KhungTrangQuanLy";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GUI_KhungTrangQuanLy";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem goiMonToolStripMenuItem;
        private ToolStripMenuItem nghiepVuToolStripMenuItem;
        private ToolStripMenuItem quanLyDoUongToolStripMenuItem;
        private ToolStripMenuItem quanLyBanToolStripMenuItem;
        private ToolStripMenuItem quanLyHoaDonToolStripMenuItem;
        private ToolStripMenuItem quanLyNhanVienToolStripMenuItem;
        private ToolStripMenuItem thongKeToolStripMenuItem;
        private Panel panel1;
    }
}