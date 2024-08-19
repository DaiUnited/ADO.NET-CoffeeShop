namespace GUI
{
    partial class GUI_GoiMon
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox2 = new GroupBox();
            btnTaoHoaDon = new Button();
            groupBox11 = new GroupBox();
            lblTrangThai = new Label();
            groupBox10 = new GroupBox();
            lblMaNhanVien = new Label();
            groupBox8 = new GroupBox();
            lblMaBan = new Label();
            groupBox5 = new GroupBox();
            lblNgayLap = new Label();
            groupBox6 = new GroupBox();
            lblMaHoaDon = new Label();
            groupBox3 = new GroupBox();
            btnThemMon = new Button();
            groupBox9 = new GroupBox();
            numericUpDownSoLuong = new NumericUpDown();
            groupBox7 = new GroupBox();
            cboDoUong = new ComboBox();
            groupBox4 = new GroupBox();
            cboLoaiDoUong = new ComboBox();
            label1 = new Label();
            lblThanhTien = new Label();
            btnThanhToan = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox11.SuspendLayout();
            groupBox10.SuspendLayout();
            groupBox8.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSoLuong).BeginInit();
            groupBox7.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.ActiveCaption;
            flowLayoutPanel1.Location = new Point(3, 4);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(557, 803);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(567, 389);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(755, 343);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sach do uong";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 29);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(735, 297);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnTaoHoaDon);
            groupBox2.Controls.Add(groupBox11);
            groupBox2.Controls.Add(groupBox10);
            groupBox2.Controls.Add(groupBox8);
            groupBox2.Controls.Add(groupBox5);
            groupBox2.Controls.Add(groupBox6);
            groupBox2.Location = new Point(567, 4);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(401, 377);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin hóa đơn";
            // 
            // btnTaoHoaDon
            // 
            btnTaoHoaDon.Location = new Point(275, 317);
            btnTaoHoaDon.Margin = new Padding(3, 4, 3, 4);
            btnTaoHoaDon.Name = "btnTaoHoaDon";
            btnTaoHoaDon.Size = new Size(114, 38);
            btnTaoHoaDon.TabIndex = 26;
            btnTaoHoaDon.Text = "Tạo Hóa Đơn";
            btnTaoHoaDon.UseVisualStyleBackColor = true;
            btnTaoHoaDon.Click += btnTaoHoaDon_Click;
            // 
            // groupBox11
            // 
            groupBox11.Controls.Add(lblTrangThai);
            groupBox11.Location = new Point(7, 292);
            groupBox11.Margin = new Padding(3, 4, 3, 4);
            groupBox11.Name = "groupBox11";
            groupBox11.Padding = new Padding(3, 4, 3, 4);
            groupBox11.Size = new Size(246, 65);
            groupBox11.TabIndex = 25;
            groupBox11.TabStop = false;
            groupBox11.Text = "Trạng thái";
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Location = new Point(7, 25);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(0, 20);
            lblTrangThai.TabIndex = 0;
            // 
            // groupBox10
            // 
            groupBox10.Controls.Add(lblMaNhanVien);
            groupBox10.Location = new Point(7, 227);
            groupBox10.Margin = new Padding(3, 4, 3, 4);
            groupBox10.Name = "groupBox10";
            groupBox10.Padding = new Padding(3, 4, 3, 4);
            groupBox10.Size = new Size(246, 65);
            groupBox10.TabIndex = 24;
            groupBox10.TabStop = false;
            groupBox10.Text = "Mã nhân viên";
            // 
            // lblMaNhanVien
            // 
            lblMaNhanVien.AutoSize = true;
            lblMaNhanVien.Location = new Point(7, 25);
            lblMaNhanVien.Name = "lblMaNhanVien";
            lblMaNhanVien.Size = new Size(0, 20);
            lblMaNhanVien.TabIndex = 0;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(lblMaBan);
            groupBox8.Location = new Point(7, 161);
            groupBox8.Margin = new Padding(3, 4, 3, 4);
            groupBox8.Name = "groupBox8";
            groupBox8.Padding = new Padding(3, 4, 3, 4);
            groupBox8.Size = new Size(246, 65);
            groupBox8.TabIndex = 23;
            groupBox8.TabStop = false;
            groupBox8.Text = "Mã bàn";
            // 
            // lblMaBan
            // 
            lblMaBan.AutoSize = true;
            lblMaBan.Location = new Point(7, 25);
            lblMaBan.Name = "lblMaBan";
            lblMaBan.Size = new Size(0, 20);
            lblMaBan.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(lblNgayLap);
            groupBox5.Location = new Point(7, 96);
            groupBox5.Margin = new Padding(3, 4, 3, 4);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(3, 4, 3, 4);
            groupBox5.Size = new Size(246, 65);
            groupBox5.TabIndex = 22;
            groupBox5.TabStop = false;
            groupBox5.Text = "Ngày lập";
            // 
            // lblNgayLap
            // 
            lblNgayLap.AutoSize = true;
            lblNgayLap.Location = new Point(7, 25);
            lblNgayLap.Name = "lblNgayLap";
            lblNgayLap.Size = new Size(0, 20);
            lblNgayLap.TabIndex = 0;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(lblMaHoaDon);
            groupBox6.Location = new Point(7, 29);
            groupBox6.Margin = new Padding(3, 4, 3, 4);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(3, 4, 3, 4);
            groupBox6.Size = new Size(246, 65);
            groupBox6.TabIndex = 21;
            groupBox6.TabStop = false;
            groupBox6.Text = "Mã hóa đơn";
            // 
            // lblMaHoaDon
            // 
            lblMaHoaDon.AutoSize = true;
            lblMaHoaDon.Location = new Point(7, 29);
            lblMaHoaDon.Name = "lblMaHoaDon";
            lblMaHoaDon.Size = new Size(0, 20);
            lblMaHoaDon.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnThemMon);
            groupBox3.Controls.Add(groupBox9);
            groupBox3.Controls.Add(groupBox7);
            groupBox3.Controls.Add(groupBox4);
            groupBox3.Location = new Point(1002, 71);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(263, 243);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thêm món";
            // 
            // btnThemMon
            // 
            btnThemMon.Location = new Point(150, 185);
            btnThemMon.Margin = new Padding(3, 4, 3, 4);
            btnThemMon.Name = "btnThemMon";
            btnThemMon.Size = new Size(102, 40);
            btnThemMon.TabIndex = 25;
            btnThemMon.Text = "Thêm món";
            btnThemMon.UseVisualStyleBackColor = true;
            btnThemMon.Click += btnThemMon_Click;
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(numericUpDownSoLuong);
            groupBox9.Location = new Point(7, 160);
            groupBox9.Margin = new Padding(3, 4, 3, 4);
            groupBox9.Name = "groupBox9";
            groupBox9.Padding = new Padding(3, 4, 3, 4);
            groupBox9.Size = new Size(137, 65);
            groupBox9.TabIndex = 24;
            groupBox9.TabStop = false;
            groupBox9.Text = "Số lượng";
            // 
            // numericUpDownSoLuong
            // 
            numericUpDownSoLuong.Location = new Point(7, 27);
            numericUpDownSoLuong.Margin = new Padding(3, 4, 3, 4);
            numericUpDownSoLuong.Name = "numericUpDownSoLuong";
            numericUpDownSoLuong.Size = new Size(123, 27);
            numericUpDownSoLuong.TabIndex = 25;
            numericUpDownSoLuong.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(cboDoUong);
            groupBox7.Location = new Point(7, 95);
            groupBox7.Margin = new Padding(3, 4, 3, 4);
            groupBox7.Name = "groupBox7";
            groupBox7.Padding = new Padding(3, 4, 3, 4);
            groupBox7.Size = new Size(246, 65);
            groupBox7.TabIndex = 5;
            groupBox7.TabStop = false;
            groupBox7.Text = "Đồ uống";
            // 
            // cboDoUong
            // 
            cboDoUong.FormattingEnabled = true;
            cboDoUong.Location = new Point(7, 27);
            cboDoUong.Margin = new Padding(3, 4, 3, 4);
            cboDoUong.Name = "cboDoUong";
            cboDoUong.Size = new Size(231, 28);
            cboDoUong.TabIndex = 4;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(cboLoaiDoUong);
            groupBox4.Location = new Point(7, 29);
            groupBox4.Margin = new Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 4, 3, 4);
            groupBox4.Size = new Size(246, 65);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Loại đồ uống";
            // 
            // cboLoaiDoUong
            // 
            cboLoaiDoUong.FormattingEnabled = true;
            cboLoaiDoUong.Location = new Point(7, 27);
            cboLoaiDoUong.Margin = new Padding(3, 4, 3, 4);
            cboLoaiDoUong.Name = "cboLoaiDoUong";
            cboLoaiDoUong.Size = new Size(231, 28);
            cboLoaiDoUong.TabIndex = 4;
            cboLoaiDoUong.SelectedIndexChanged += cboLoaiDoUong_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(881, 760);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 4;
            label1.Text = "Tổng tiền:";
            // 
            // lblThanhTien
            // 
            lblThanhTien.AutoSize = true;
            lblThanhTien.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblThanhTien.ForeColor = Color.Red;
            lblThanhTien.Location = new Point(957, 760);
            lblThanhTien.Name = "lblThanhTien";
            lblThanhTien.Size = new Size(0, 20);
            lblThanhTien.TabIndex = 5;
            // 
            // btnThanhToan
            // 
            btnThanhToan.Location = new Point(1201, 755);
            btnThanhToan.Margin = new Padding(3, 4, 3, 4);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(98, 31);
            btnThanhToan.TabIndex = 6;
            btnThanhToan.Text = "Thanh toán";
            btnThanhToan.UseVisualStyleBackColor = true;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // GUI_GoiMon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnThanhToan);
            Controls.Add(lblThanhTien);
            Controls.Add(label1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(flowLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "GUI_GoiMon";
            Size = new Size(1326, 811);
            Load += GUI_GoiMon_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox11.ResumeLayout(false);
            groupBox11.PerformLayout();
            groupBox10.ResumeLayout(false);
            groupBox10.PerformLayout();
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDownSoLuong).EndInit();
            groupBox7.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox8;
        private GroupBox groupBox5;
        private GroupBox groupBox6;
        private GroupBox groupBox9;
        private NumericUpDown numericUpDownSoLuong;
        private GroupBox groupBox7;
        private ComboBox cboDoUong;
        private GroupBox groupBox4;
        private ComboBox cboLoaiDoUong;
        private GroupBox groupBox11;
        private Label lblTrangThai;
        private GroupBox groupBox10;
        private Label lblMaNhanVien;
        private Label lblMaBan;
        private Label lblNgayLap;
        private Label lblMaHoaDon;
        private Button btnThemMon;
        private Button btnTaoHoaDon;
        private DataGridView dataGridView1;
        private Label label1;
        private Label lblThanhTien;
        private Button btnThanhToan;
    }
}
