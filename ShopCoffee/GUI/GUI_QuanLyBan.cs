using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class GUI_QuanLyBan : UserControl
    {
        BLL_Ban bllban = new BLL_Ban();

        public GUI_QuanLyBan()
        {
            InitializeComponent();
        }

        private void loaddanhsach()
        {
            dataGridView1.DataSource = bllban.GetAll();
        }

        private void GUI_QuanLyBan_Load(object sender, EventArgs e)
        {
            loaddanhsach();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaBan.Text.Trim().Equals("") || txtTenBan.Text.Trim().Equals(""))
            {
                MessageBox.Show("Nhập đầy đủ thông tin!");
            }
            else
            {
                if (bllban.GetByID(txtMaBan.Text.Trim()) != null)
                {
                    MessageBox.Show("Mã bàn đã tồn tại!");
                }
                else
                {
                    DTO_Ban dto = new DTO_Ban();
                    dto.MaBan = txtMaBan.Text.Trim();
                    dto.TenBan = txtTenBan.Text.Trim();
                    dto.TrangThai = cboTrangThai.Text;
                    bllban.Add(dto);
                    loaddanhsach();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaBan.Text.Trim().Equals(""))
            {
                MessageBox.Show("Nhập đầy đủ thông tin!");
            }
            else
            {
                if (bllban.GetByID(txtMaBan.Text.Trim()) != null)
                {
                    bllban.Delete(txtMaBan.Text.Trim());
                    loaddanhsach();
                }
                else
                {
                    MessageBox.Show("Mã bàn không tồn tại!");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaBan.Text.Trim().Equals("") || txtTenBan.Text.Trim().Equals(""))
            {
                MessageBox.Show("Nhập đầy đủ thông tin!");
            }
            else
            {
                if (bllban.GetByID(txtMaBan.Text.Trim()) != null)
                {
                    DTO_Ban dto = new DTO_Ban();
                    dto.MaBan = txtMaBan.Text.Trim();
                    dto.TenBan = txtTenBan.Text.Trim();
                    dto.TrangThai = cboTrangThai.Text;
                    bllban.Update(dto);
                    loaddanhsach();
                }
                else
                {
                    MessageBox.Show("Mã bàn không tồn tại!");
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                this.txtMaBan.Text = row.Cells["MaBan"].Value.ToString();
                this.txtTenBan.Text = row.Cells["TenBan"].Value.ToString();
                this.cboTrangThai.Text = row.Cells["TrangThai"].Value.ToString();
            }
        }
    }
}
