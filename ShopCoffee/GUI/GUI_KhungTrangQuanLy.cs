using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class GUI_KhungTrangQuanLy : Form
    {
        string manhanvien;
        public GUI_KhungTrangQuanLy()
        {
            InitializeComponent();
        }

        public GUI_KhungTrangQuanLy(string ma)
        {
            InitializeComponent();
            manhanvien = ma;
        }

        private void quanLyDoUongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            GUI_QuanLyDoUong gui = new GUI_QuanLyDoUong();
            panel1.Controls.Add(gui);
            gui.Show();
        }

        private void quanLyBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            GUI_QuanLyBan gui = new GUI_QuanLyBan();
            panel1.Controls.Add(gui);
            gui.Show();
        }

        private void quanLyHoaDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            GUI_QuanLyHoaDon gui = new GUI_QuanLyHoaDon();
            panel1.Controls.Add(gui);
            gui.Show();
        }

        private void quanLyNhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            GUI_QuanLyNhanVien gui = new GUI_QuanLyNhanVien();
            panel1.Controls.Add(gui);
            gui.Show();
        }

        private void goiMonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            GUI_GoiMon gui = new GUI_GoiMon(manhanvien);
            panel1.Controls.Add(gui);
            gui.Show();
        }

        private void thongKeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
