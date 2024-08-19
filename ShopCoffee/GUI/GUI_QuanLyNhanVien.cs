using BLL;
using DAL;
using DTO;
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
    public partial class GUI_QuanLyNhanVien : UserControl
    {
        BLL_NhanVien bll = new BLL_NhanVien();

        public GUI_QuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void loaddanhsach()
        {
            dataGridView1.DataSource = bll.GetAll();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaNhanVien.Text.Trim().Equals("") || txtMatKhau.Text.Trim().Equals("") || txtTenNhanVien.Text.Trim().Equals("") || txtSoDienThoai.Text.Trim().Equals("") || txtNamSinh.Text.Trim().Equals("") || txtGioiTinh.Text.Trim().Equals(""))
            {
                MessageBox.Show("Nhập đầy đủ thông tin!");
            }
            else
            {
                if (bll.GetByID(txtMaNhanVien.Text.Trim()) != null)
                {
                    MessageBox.Show("Mã nhân viên đã tồn tại!");
                }
                else
                {
                    DTO_NhanVien dto = new DTO_NhanVien();
                    dto.MaNhanVien = txtMaNhanVien.Text.Trim();
                    dto.MatKhau = txtMatKhau.Text.Trim();
                    dto.TenNhanVien = txtTenNhanVien.Text.Trim();
                    dto.SoDienThoai = txtSoDienThoai.Text.Trim();
                    dto.NamSinh = int.Parse(txtNamSinh.Text.Trim());
                    dto.GioiTinh = txtGioiTinh.Text.Trim();
                    bll.Add(dto);
                    loaddanhsach();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaNhanVien.Text.Trim().Equals(""))
            {
                MessageBox.Show("Nhập đầy đủ thông tin!");
            }
            else
            {
                if (bll.GetByID(txtMaNhanVien.Text.Trim()) != null)
                {
                    bll.Delete(txtMaNhanVien.Text.Trim());
                    loaddanhsach();
                }
                else
                {
                    MessageBox.Show("Mã nhân viên không tồn tại!");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaNhanVien.Text.Trim().Equals("") || txtMatKhau.Text.Trim().Equals("") || txtTenNhanVien.Text.Trim().Equals("") || txtSoDienThoai.Text.Trim().Equals("") || txtNamSinh.Text.Trim().Equals("") || txtGioiTinh.Text.Trim().Equals(""))
            {
                MessageBox.Show("Nhập đầy đủ thông tin!");
            }
            else
            {
                if (bll.GetByID(txtMaNhanVien.Text.Trim()) != null)
                {
                    DTO_NhanVien dto = new DTO_NhanVien();
                    dto.MaNhanVien = txtMaNhanVien.Text.Trim();
                    dto.MatKhau = txtMatKhau.Text.Trim();
                    dto.TenNhanVien = txtTenNhanVien.Text.Trim();
                    dto.SoDienThoai = txtSoDienThoai.Text.Trim();
                    dto.NamSinh = int.Parse(txtNamSinh.Text.Trim());
                    dto.GioiTinh = txtGioiTinh.Text.Trim();
                    bll.Update(dto);
                    loaddanhsach();
                }
                else
                {
                    MessageBox.Show("Mã nhân viên không tồn tại!");
                }
            }
        }

        private void GUI_QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            loaddanhsach();
        }

        private void txtNamSinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Không cho phép ký tự nhập vào
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                this.txtMaNhanVien.Text = row.Cells["MaNhanVien"].Value.ToString();
                this.txtMatKhau.Text = row.Cells["MatKhau"].Value.ToString();
                this.txtTenNhanVien.Text = row.Cells["TenNhanVien"].Value.ToString();
                this.txtSoDienThoai.Text = row.Cells["SoDienThoai"].Value.ToString();
                this.txtNamSinh.Text = row.Cells["NamSinh"].Value.ToString();
                this.txtGioiTinh.Text = row.Cells["GioiTinh"].Value.ToString();
            }
        }
    }
}
