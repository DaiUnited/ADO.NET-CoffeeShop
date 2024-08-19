using BLL;
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
    public partial class GUI_QuanLyHoaDon : UserControl
    {
        BLL_HoaDon bllhoadon = new BLL_HoaDon();
        public GUI_QuanLyHoaDon()
        {
            InitializeComponent();
        }

        private void loaddanhsach()
        {
            dataGridView1.DataSource = bllhoadon.GetAll();
        }

        private void GUI_QuanLyHoaDon_Load(object sender, EventArgs e)
        {
            loaddanhsach();
        }
    }
}
