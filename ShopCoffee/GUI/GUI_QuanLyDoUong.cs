using BLL;
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
    public partial class GUI_QuanLyDoUong : UserControl
    {
        BLL_LoaiDoUong bllloaidouong = new BLL_LoaiDoUong();
        BLL_DoUong blldouong = new BLL_DoUong();

        public GUI_QuanLyDoUong()
        {
            InitializeComponent();

            loaddanhsachdouong();
            loaddanhsachloaidouong();

            loadcombobox();
        }

        private void loaddanhsachloaidouong()
        {
            dataGridView1.DataSource = bllloaidouong.GetAll();
        }

        private void loaddanhsachdouong()
        {
            dataGridView2.DataSource = blldouong.GetAll();
        }

        private void loadcombobox()
        {
            cboMaLoaiDoUong.DataSource = null;
            cboMaLoaiDoUong.DataSource = bllloaidouong.GetAll();
            cboMaLoaiDoUong.DisplayMember = "TenLoaiDoUong";
            cboMaLoaiDoUong.ValueMember = "MaLoaiDoUong";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaLoaiDoUong.Text.Trim().Equals("") || txtTenLoaiDoUong.Text.Trim().Equals(""))
            {
                MessageBox.Show("Nhập đầy đủ thông tin!");
            }
            else
            {
                if (bllloaidouong.GetByID(txtMaLoaiDoUong.Text.Trim()) != null)
                {
                    MessageBox.Show("Mã loại đồ uống đã tồn tại!");
                }
                else
                {
                    DTO_LoaiDoUong dto = new DTO_LoaiDoUong();
                    dto.MaLoaiDoUong = txtMaLoaiDoUong.Text.Trim();
                    dto.TenLoaiDoUong = txtTenLoaiDoUong.Text.Trim();
                    bllloaidouong.Add(dto);
                    loaddanhsachloaidouong();
                    loadcombobox();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaLoaiDoUong.Text.Trim().Equals("") || txtTenLoaiDoUong.Text.Trim().Equals(""))
            {
                MessageBox.Show("Nhập đầy đủ thông tin!");
            }
            else
            {
                if (bllloaidouong.GetByID(txtMaLoaiDoUong.Text.Trim()) != null)
                {
                    bllloaidouong.Delete(txtMaLoaiDoUong.Text.Trim());
                    loaddanhsachloaidouong();
                    loadcombobox();
                }
                else
                {
                    MessageBox.Show("Mã loại đồ uống không tồn tại!");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaLoaiDoUong.Text.Trim().Equals("") || txtTenLoaiDoUong.Text.Trim().Equals(""))
            {
                MessageBox.Show("Nhập đầy đủ thông tin!");
            }
            else
            {
                if (bllloaidouong.GetByID(txtMaLoaiDoUong.Text.Trim()) != null)
                {
                    DTO_LoaiDoUong dto = new DTO_LoaiDoUong();
                    dto.MaLoaiDoUong = txtMaLoaiDoUong.Text.Trim();
                    dto.TenLoaiDoUong = txtTenLoaiDoUong.Text.Trim();
                    bllloaidouong.Update(dto);
                    loaddanhsachloaidouong();
                    loadcombobox();
                }
                else
                {
                    MessageBox.Show("Mã loại đồ uống không tồn tại!");
                }
            }
        }

        private void btnThem1_Click(object sender, EventArgs e)
        {
            if (txtMaDoUong.Text.Trim().Equals("") || txtTenDoUong.Text.Trim().Equals("") || txtGiaTien.Text.Trim().Equals(""))
            {
                MessageBox.Show("Nhập đầy đủ thông tin!");
            }
            else
            {
                if (blldouong.GetByID(txtMaDoUong.Text.Trim()) != null)
                {
                    MessageBox.Show("Mã đồ uống đã tồn tại!");
                }
                else
                {
                    DTO_DoUong dto = new DTO_DoUong();
                    dto.MaDoUong = txtMaDoUong.Text.Trim();
                    dto.TenDoUong = txtTenDoUong.Text.Trim();
                    dto.GiaTien = int.Parse(txtGiaTien.Text.Trim());
                    dto.MaLoaiDoUong = (string)cboMaLoaiDoUong.SelectedValue;
                    blldouong.Add(dto);
                    loaddanhsachdouong();
                    loadcombobox();
                }
            }
        }

        private void btnXoa1_Click(object sender, EventArgs e)
        {
            if (txtMaDoUong.Text.Trim().Equals(""))
            {
                MessageBox.Show("Nhập đầy đủ thông tin!");
            }
            else
            {
                if (blldouong.GetByID(txtMaDoUong.Text.Trim()) != null)
                {
                    blldouong.Delete(txtMaDoUong.Text.Trim());
                    loaddanhsachdouong();
                }
                else
                {


                    MessageBox.Show("Mã đồ uống không tồn tại!");
                }
            }
        }

        private void btnSua1_Click(object sender, EventArgs e)
        {
            if (txtMaDoUong.Text.Trim().Equals("") || txtTenDoUong.Text.Trim().Equals("") || txtGiaTien.Text.Trim().Equals(""))
            {
                MessageBox.Show("Nhập đầy đủ thông tin!");
            }
            else
            {
                if (blldouong.GetByID(txtMaDoUong.Text.Trim()) != null)
                {
                    DTO_DoUong dto = new DTO_DoUong();
                    dto.MaDoUong = txtMaDoUong.Text.Trim();
                    dto.TenDoUong = txtTenDoUong.Text.Trim();
                    dto.GiaTien = int.Parse(txtGiaTien.Text.Trim());
                    dto.MaLoaiDoUong = (string)cboMaLoaiDoUong.SelectedValue;
                    blldouong.Update(dto);
                    loaddanhsachdouong();
                    loadcombobox();
                }
                else
                {
                    MessageBox.Show("Mã đồ uống không tồn tại!");
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                this.txtMaLoaiDoUong.Text = row.Cells["MaLoaiDoUong"].Value.ToString();
                this.txtTenLoaiDoUong.Text = row.Cells["TenLoaiDoUong"].Value.ToString();
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                this.txtMaDoUong.Text = row.Cells["MaDoUong"].Value.ToString();
                this.txtTenDoUong.Text = row.Cells["TenDoUong"].Value.ToString();
                this.txtGiaTien.Text = row.Cells["GiaTien"].Value.ToString();
                this.cboMaLoaiDoUong.Text = row.Cells["MaLoaiDoUong"].Value.ToString();
            }
        }
    }
}
