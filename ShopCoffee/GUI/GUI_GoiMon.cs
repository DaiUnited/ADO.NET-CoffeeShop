using BLL;
using DAL;
using DTO;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class GUI_GoiMon : UserControl
    {
        BLL_Ban bllban = new BLL_Ban();

        BLL_HoaDon bllhoadon = new BLL_HoaDon();

        BLL_LoaiDoUong bllloaidouong = new BLL_LoaiDoUong();

        BLL_DoUong blldouong = new BLL_DoUong();

        BLL_ChiTietHoaDon bllchitiethoadon = new BLL_ChiTietHoaDon();

        string manhanvien;

        public GUI_GoiMon()
        {
            InitializeComponent();
        }

        public GUI_GoiMon(string ma)
        {
            InitializeComponent();
            manhanvien = ma;
        }

        private void loadcomboboxloaidouong()
        {
            cboLoaiDoUong.DataSource = null;
            cboLoaiDoUong.DataSource = bllloaidouong.GetAll();
            cboLoaiDoUong.DisplayMember = "TenLoaiDoUong";
            cboLoaiDoUong.ValueMember = "MaLoaiDoUong";
        }

        private void loadchitiethoadon(int mahoadon)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = bllchitiethoadon.GetAll(mahoadon);

            float totalTongTien = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["TongTien"].Value != null)
                {
                    float tongTien = Convert.ToSingle(row.Cells["TongTien"].Value);
                    totalTongTien += tongTien;
                }
            }

            lblThanhTien.Text = totalTongTien.ToString();
        }


        private void loadban()
        {
            this.flowLayoutPanel1.Controls.Clear();

            this.flowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight;

            this.flowLayoutPanel1.WrapContents = true;

            this.flowLayoutPanel1.AutoScroll = true;

            List<DTO_Ban> ds = bllban.GetAll();

            foreach (DTO_Ban dto in ds)
            {
                Button btn = new Button();
                btn.Text = dto.MaBan;
                btn.Size = new Size(100, 100);
                if (dto.TrangThai == "Sẵn Sàng")
                {
                    btn.BackColor = Color.Green;
                }
                if (dto.TrangThai == "Đang Sử Dụng")
                {
                    btn.BackColor = Color.Yellow;
                }

                btn.Click += Btn_Click;

                this.flowLayoutPanel1.Controls.Add(btn);
            }
        }

        private void GUI_GoiMon_Load(object sender, EventArgs e)
        {
            loadban();
            btnThanhToan.Enabled = true;
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.Name = "DeleteButtonColumn";
            deleteButtonColumn.HeaderText = "Delete";
            deleteButtonColumn.Text = "Delete";
            deleteButtonColumn.UseColumnTextForButtonValue = true;

            // Thêm cột nút "Delete" vào DataGridView
            dataGridView1.Columns.Add(deleteButtonColumn);

            // Gắn sự kiện Click cho nút "Delete"
            dataGridView1.CellClick += DataGridView1_CellClick;

            // Tải dữ liệu vào DataGridView

            loadcomboboxloaidouong();
        }

        private void Btn_Click(object? sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            string maBan = clickedButton.Text;
            if (clickedButton.BackColor == Color.Green)
            {
                btnTaoHoaDon.Enabled = true;
                btnThanhToan.Enabled = false;
                lblMaHoaDon.Text = "";
                lblNgayLap.Text = "";
                lblMaBan.Text = maBan;
                lblMaNhanVien.Text = manhanvien;
                lblTrangThai.Text = "";
                dataGridView1.DataSource = null;
            }
            else
            {
                btnTaoHoaDon.Enabled = false;
                btnThanhToan.Enabled = true;
                DTO_HoaDon dto = new DTO_HoaDon();
                dto = bllhoadon.GetByMaBanAndTrangThai(maBan, "Chưa Thanh Toán");

                if (dto != null)
                {
                    lblMaHoaDon.Text = dto.MaHoaDon.ToString();
                    lblNgayLap.Text = dto.NgayLap.ToString();
                    lblMaBan.Text = dto.MaBan;
                    lblMaNhanVien.Text = dto.MaNhanVien;
                    lblTrangThai.Text = dto.TrangThai;
                    lblThanhTien.Text = dto.ThanhTien.ToString();
                    loadchitiethoadon(dto.MaHoaDon);
                }
            }
        }

        private void DataGridView1_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["DeleteButtonColumn"].Index && e.RowIndex >= 0)
            {
                int selectedRowIndex = e.RowIndex;

                int maHoaDon = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells["MaHoaDon"].Value);

                string maDoUong = dataGridView1.Rows[selectedRowIndex].Cells["MaDoUong"].Value.ToString();

                bllchitiethoadon.Delete(maHoaDon, maDoUong);



                loadchitiethoadon(maHoaDon);
            }
        }

        private void btnTaoHoaDon_Click(object sender, EventArgs e)
        {
            DTO_HoaDon dto = new DTO_HoaDon();

            dto.NgayLap = DateTime.Now;
            dto.MaBan = lblMaBan.Text;
            dto.MaNhanVien = manhanvien;
            dto.ThanhTien = 0;
            dto.TrangThai = "Chưa Thanh Toán";

            bllhoadon.Add(dto);
            DTO_Ban dto_ban = bllban.GetByID(lblMaBan.Text);
            dto_ban.TrangThai = "Đang Sử Dụng";
            bllban.Update(dto_ban);
            loadban();

            DTO_HoaDon dto2 = new DTO_HoaDon();
            dto = bllhoadon.GetByMaBanAndTrangThai(lblMaBan.Text, "Chưa Thanh Toán");

            if (dto != null)
            {
                lblMaHoaDon.Text = dto.MaHoaDon.ToString();
                lblNgayLap.Text = dto.NgayLap.ToString();
                lblMaBan.Text = dto.MaBan;
                lblMaNhanVien.Text = dto.MaNhanVien;
                lblTrangThai.Text = dto.TrangThai;
                lblThanhTien.Text = dto.ThanhTien.ToString();
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            DTO_HoaDon dto = new DTO_HoaDon();
            dto.MaHoaDon = int.Parse(lblMaHoaDon.Text);
            dto.NgayLap = DateTime.Parse(lblNgayLap.Text);
            dto.MaBan = lblMaBan.Text;
            dto.MaNhanVien = lblMaNhanVien.Text;
            dto.TrangThai = "Đã Thanh Toán";
            dto.ThanhTien = float.Parse(lblThanhTien.Text);

            DTO_Ban dtoban = bllban.GetByID(lblMaBan.Text);
            dtoban.TrangThai = "Sẵn Sàng";

            bllhoadon.Update(dto);

            bllban.Update(dtoban);

            loadban();
            lblMaHoaDon.Text = "";
            lblNgayLap.Text = "";
            lblMaBan.Text = "";
            lblMaNhanVien.Text = "";
            lblTrangThai.Text = "";
            lblThanhTien.Text = "";
            dataGridView1.DataSource = null;
        }

        private void cboLoaiDoUong_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboDoUong.DataSource = null;
            cboDoUong.DataSource = blldouong.GetAllByMaLoai(cboLoaiDoUong.SelectedValue.ToString());

            cboDoUong.DisplayMember = "TenDoUong";
            cboDoUong.ValueMember = "MaDoUong";
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            if (lblMaHoaDon.Text.Equals("") == false && cboDoUong.SelectedIndex != -1)
            {
                DTO_ChiTietHoaDon dto = new DTO_ChiTietHoaDon();
                dto.MaHoaDon = int.Parse(lblMaHoaDon.Text);
                dto.MaDoUong = cboDoUong.SelectedValue.ToString();
                dto.SoLuong = (int)numericUpDownSoLuong.Value;

                if (bllchitiethoadon.GetByID(dto.MaHoaDon, dto.MaDoUong) == null)
                {
                    bllchitiethoadon.Add(dto);
                }
                else
                {
                    bllchitiethoadon.Update(dto);
                }
                loadchitiethoadon(dto.MaHoaDon);
            }
        }
    }
}
