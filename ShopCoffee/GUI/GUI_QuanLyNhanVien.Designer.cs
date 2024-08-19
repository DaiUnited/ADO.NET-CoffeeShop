namespace GUI
{
    partial class GUI_QuanLyNhanVien
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            groupBox2 = new GroupBox();
            txtMatKhau = new TextBox();
            groupBox1 = new GroupBox();
            txtMaNhanVien = new TextBox();
            dataGridView1 = new DataGridView();
            groupBox3 = new GroupBox();
            txtSoDienThoai = new TextBox();
            groupBox4 = new GroupBox();
            txtTenNhanVien = new TextBox();
            groupBox5 = new GroupBox();
            txtGioiTinh = new TextBox();
            groupBox6 = new GroupBox();
            txtNamSinh = new TextBox();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // btnSua
            // 
            btnSua.Location = new Point(717, 321);
            btnSua.Margin = new Padding(3, 4, 3, 4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(86, 31);
            btnSua.TabIndex = 13;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(544, 321);
            btnXoa.Margin = new Padding(3, 4, 3, 4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(86, 31);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(403, 323);
            btnThem.Margin = new Padding(3, 4, 3, 4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(86, 31);
            btnThem.TabIndex = 11;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtMatKhau);
            groupBox2.Location = new Point(321, 112);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(246, 65);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Mật khẩu";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(7, 25);
            txtMatKhau.Margin = new Padding(3, 4, 3, 4);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(231, 27);
            txtMatKhau.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtMaNhanVien);
            groupBox1.Location = new Point(321, 39);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(246, 65);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Mã nhân viên";
            // 
            // txtMaNhanVien
            // 
            txtMaNhanVien.Location = new Point(7, 25);
            txtMaNhanVien.Margin = new Padding(3, 4, 3, 4);
            txtMaNhanVien.Name = "txtMaNhanVien";
            txtMaNhanVien.Size = new Size(231, 27);
            txtMaNhanVien.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(272, 404);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(830, 347);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtSoDienThoai);
            groupBox3.Location = new Point(592, 112);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(246, 65);
            groupBox3.TabIndex = 15;
            groupBox3.TabStop = false;
            groupBox3.Text = "Số điện thoại";
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(7, 25);
            txtSoDienThoai.Margin = new Padding(3, 4, 3, 4);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(231, 27);
            txtSoDienThoai.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtTenNhanVien);
            groupBox4.Location = new Point(592, 39);
            groupBox4.Margin = new Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 4, 3, 4);
            groupBox4.Size = new Size(246, 65);
            groupBox4.TabIndex = 14;
            groupBox4.TabStop = false;
            groupBox4.Text = "Tên nhân viên";
            // 
            // txtTenNhanVien
            // 
            txtTenNhanVien.Location = new Point(7, 25);
            txtTenNhanVien.Margin = new Padding(3, 4, 3, 4);
            txtTenNhanVien.Name = "txtTenNhanVien";
            txtTenNhanVien.Size = new Size(231, 27);
            txtTenNhanVien.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(txtGioiTinh);
            groupBox5.Location = new Point(863, 112);
            groupBox5.Margin = new Padding(3, 4, 3, 4);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(3, 4, 3, 4);
            groupBox5.Size = new Size(246, 65);
            groupBox5.TabIndex = 17;
            groupBox5.TabStop = false;
            groupBox5.Text = "Giới tính";
            // 
            // txtGioiTinh
            // 
            txtGioiTinh.Location = new Point(7, 25);
            txtGioiTinh.Margin = new Padding(3, 4, 3, 4);
            txtGioiTinh.Name = "txtGioiTinh";
            txtGioiTinh.Size = new Size(231, 27);
            txtGioiTinh.TabIndex = 0;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(txtNamSinh);
            groupBox6.Location = new Point(863, 39);
            groupBox6.Margin = new Padding(3, 4, 3, 4);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(3, 4, 3, 4);
            groupBox6.Size = new Size(246, 65);
            groupBox6.TabIndex = 16;
            groupBox6.TabStop = false;
            groupBox6.Text = "Năm sinh";
            // 
            // txtNamSinh
            // 
            txtNamSinh.Location = new Point(7, 25);
            txtNamSinh.Margin = new Padding(3, 4, 3, 4);
            txtNamSinh.Name = "txtNamSinh";
            txtNamSinh.Size = new Size(231, 27);
            txtNamSinh.TabIndex = 0;
            txtNamSinh.KeyPress += txtNamSinh_KeyPress;
            // 
            // GUI_QuanLyNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox5);
            Controls.Add(groupBox6);
            Controls.Add(groupBox3);
            Controls.Add(groupBox4);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "GUI_QuanLyNhanVien";
            Size = new Size(1326, 811);
            Load += GUI_QuanLyNhanVien_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private GroupBox groupBox2;
        private TextBox txtMatKhau;
        private GroupBox groupBox1;
        private TextBox txtMaNhanVien;
        private DataGridView dataGridView1;
        private GroupBox groupBox3;
        private TextBox txtSoDienThoai;
        private GroupBox groupBox4;
        private TextBox txtTenNhanVien;
        private GroupBox groupBox5;
        private TextBox txtGioiTinh;
        private GroupBox groupBox6;
        private TextBox txtNamSinh;
    }
}
