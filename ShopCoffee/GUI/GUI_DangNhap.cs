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
    public partial class GUI_DangNhap : Form
    {
        public GUI_DangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (this.txtMaNhanVien.Text.Trim().Equals("") || this.txtMatKhau.Text.Trim().Equals(""))
            {
                MessageBox.Show("Tài khoản và mật khẩu không được để trống!");
            }
            else
            {
                BLL_NhanVien bll = new BLL_NhanVien();

                if (bll.GetByID(txtMaNhanVien.Text.Trim(), txtMatKhau.Text.Trim()) != null)
                {
                    string s = "Chào Mừng Nhân Vien " + txtMaNhanVien.Text;
                    MessageBox.Show(s);

                    GUI_KhungTrangQuanLy gui = new GUI_KhungTrangQuanLy(this.txtMaNhanVien.Text.Trim());
                    gui.FormClosed += Gui_FormClosed; ;
                    this.Hide();
                    gui.Show();
                }
                else
                {
                    MessageBox.Show("Tài Khoản Không Tồn Tại !");
                }
            }
        }

        private void Gui_FormClosed(object? sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
