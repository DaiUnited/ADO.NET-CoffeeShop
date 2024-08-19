namespace GUI
{
    partial class GUI_QuanLyDoUong
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
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            groupBox3 = new GroupBox();
            txtTenLoaiDoUong = new TextBox();
            groupBox4 = new GroupBox();
            txtMaLoaiDoUong = new TextBox();
            groupBox2 = new GroupBox();
            groupBox7 = new GroupBox();
            cboMaLoaiDoUong = new ComboBox();
            groupBox8 = new GroupBox();
            txtGiaTien = new TextBox();
            btnSua1 = new Button();
            btnXoa1 = new Button();
            btnThem1 = new Button();
            groupBox5 = new GroupBox();
            txtTenDoUong = new TextBox();
            groupBox6 = new GroupBox();
            txtMaDoUong = new TextBox();
            dataGridView2 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox8.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Location = new Point(0, 4);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(506, 803);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Loại đồ uống";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(24, 460);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(451, 243);
            dataGridView1.TabIndex = 17;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(334, 245);
            btnSua.Margin = new Padding(3, 4, 3, 4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(86, 31);
            btnSua.TabIndex = 16;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(185, 245);
            btnXoa.Margin = new Padding(3, 4, 3, 4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(86, 31);
            btnXoa.TabIndex = 15;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(45, 245);
            btnThem.Margin = new Padding(3, 4, 3, 4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(86, 31);
            btnThem.TabIndex = 14;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtTenLoaiDoUong);
            groupBox3.Location = new Point(101, 115);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(246, 65);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tên loại đồ uống";
            // 
            // txtTenLoaiDoUong
            // 
            txtTenLoaiDoUong.Location = new Point(7, 25);
            txtTenLoaiDoUong.Margin = new Padding(3, 4, 3, 4);
            txtTenLoaiDoUong.Name = "txtTenLoaiDoUong";
            txtTenLoaiDoUong.Size = new Size(231, 27);
            txtTenLoaiDoUong.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtMaLoaiDoUong);
            groupBox4.Location = new Point(101, 41);
            groupBox4.Margin = new Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 4, 3, 4);
            groupBox4.Size = new Size(246, 65);
            groupBox4.TabIndex = 10;
            groupBox4.TabStop = false;
            groupBox4.Text = "Mã loại đồ uống";
            // 
            // txtMaLoaiDoUong
            // 
            txtMaLoaiDoUong.Location = new Point(7, 25);
            txtMaLoaiDoUong.Margin = new Padding(3, 4, 3, 4);
            txtMaLoaiDoUong.Name = "txtMaLoaiDoUong";
            txtMaLoaiDoUong.Size = new Size(231, 27);
            txtMaLoaiDoUong.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox7);
            groupBox2.Controls.Add(groupBox8);
            groupBox2.Controls.Add(btnSua1);
            groupBox2.Controls.Add(btnXoa1);
            groupBox2.Controls.Add(btnThem1);
            groupBox2.Controls.Add(groupBox5);
            groupBox2.Controls.Add(groupBox6);
            groupBox2.Controls.Add(dataGridView2);
            groupBox2.Location = new Point(513, 4);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(809, 803);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Đồ uống";
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(cboMaLoaiDoUong);
            groupBox7.Location = new Point(151, 300);
            groupBox7.Margin = new Padding(3, 4, 3, 4);
            groupBox7.Name = "groupBox7";
            groupBox7.Padding = new Padding(3, 4, 3, 4);
            groupBox7.Size = new Size(246, 65);
            groupBox7.TabIndex = 21;
            groupBox7.TabStop = false;
            groupBox7.Text = "Mã loại đồ uống";
            // 
            // cboMaLoaiDoUong
            // 
            cboMaLoaiDoUong.FormattingEnabled = true;
            cboMaLoaiDoUong.Location = new Point(7, 27);
            cboMaLoaiDoUong.Margin = new Padding(3, 4, 3, 4);
            cboMaLoaiDoUong.Name = "cboMaLoaiDoUong";
            cboMaLoaiDoUong.Size = new Size(231, 28);
            cboMaLoaiDoUong.TabIndex = 0;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(txtGiaTien);
            groupBox8.Location = new Point(151, 227);
            groupBox8.Margin = new Padding(3, 4, 3, 4);
            groupBox8.Name = "groupBox8";
            groupBox8.Padding = new Padding(3, 4, 3, 4);
            groupBox8.Size = new Size(246, 65);
            groupBox8.TabIndex = 20;
            groupBox8.TabStop = false;
            groupBox8.Text = "Giá tiền";
            // 
            // txtGiaTien
            // 
            txtGiaTien.Location = new Point(7, 25);
            txtGiaTien.Margin = new Padding(3, 4, 3, 4);
            txtGiaTien.Name = "txtGiaTien";
            txtGiaTien.Size = new Size(231, 27);
            txtGiaTien.TabIndex = 0;
            // 
            // btnSua1
            // 
            btnSua1.Location = new Point(519, 385);
            btnSua1.Margin = new Padding(3, 4, 3, 4);
            btnSua1.Name = "btnSua1";
            btnSua1.Size = new Size(86, 31);
            btnSua1.TabIndex = 19;
            btnSua1.Text = "Sửa";
            btnSua1.UseVisualStyleBackColor = true;
            btnSua1.Click += btnSua1_Click;
            // 
            // btnXoa1
            // 
            btnXoa1.Location = new Point(346, 385);
            btnXoa1.Margin = new Padding(3, 4, 3, 4);
            btnXoa1.Name = "btnXoa1";
            btnXoa1.Size = new Size(86, 31);
            btnXoa1.TabIndex = 18;
            btnXoa1.Text = "Xóa";
            btnXoa1.UseVisualStyleBackColor = true;
            btnXoa1.Click += btnXoa1_Click;
            // 
            // btnThem1
            // 
            btnThem1.Location = new Point(206, 387);
            btnThem1.Margin = new Padding(3, 4, 3, 4);
            btnThem1.Name = "btnThem1";
            btnThem1.Size = new Size(86, 31);
            btnThem1.TabIndex = 17;
            btnThem1.Text = "Thêm";
            btnThem1.UseVisualStyleBackColor = true;
            btnThem1.Click += btnThem1_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(txtTenDoUong);
            groupBox5.Location = new Point(151, 140);
            groupBox5.Margin = new Padding(3, 4, 3, 4);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(3, 4, 3, 4);
            groupBox5.Size = new Size(246, 65);
            groupBox5.TabIndex = 13;
            groupBox5.TabStop = false;
            groupBox5.Text = "Tên đồ uống";
            // 
            // txtTenDoUong
            // 
            txtTenDoUong.Location = new Point(7, 25);
            txtTenDoUong.Margin = new Padding(3, 4, 3, 4);
            txtTenDoUong.Name = "txtTenDoUong";
            txtTenDoUong.Size = new Size(231, 27);
            txtTenDoUong.TabIndex = 0;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(txtMaDoUong);
            groupBox6.Location = new Point(151, 67);
            groupBox6.Margin = new Padding(3, 4, 3, 4);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(3, 4, 3, 4);
            groupBox6.Size = new Size(246, 65);
            groupBox6.TabIndex = 12;
            groupBox6.TabStop = false;
            groupBox6.Text = "Mã đồ uống";
            // 
            // txtMaDoUong
            // 
            txtMaDoUong.Location = new Point(7, 25);
            txtMaDoUong.Margin = new Padding(3, 4, 3, 4);
            txtMaDoUong.Name = "txtMaDoUong";
            txtMaDoUong.Size = new Size(231, 27);
            txtMaDoUong.TabIndex = 0;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(7, 427);
            dataGridView2.Margin = new Padding(3, 4, 3, 4);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(795, 311);
            dataGridView2.TabIndex = 0;
            dataGridView2.CellClick += dataGridView2_CellClick;
            // 
            // GUI_QuanLyDoUong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "GUI_QuanLyDoUong";
            Size = new Size(1326, 811);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox7.ResumeLayout(false);
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox txtTenLoaiDoUong;
        private GroupBox groupBox4;
        private TextBox txtMaLoaiDoUong;
        private DataGridView dataGridView1;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private Button btnSua1;
        private Button btnXoa1;
        private Button btnThem1;
        private GroupBox groupBox5;
        private TextBox txtTenDoUong;
        private GroupBox groupBox6;
        private TextBox txtMaDoUong;
        private DataGridView dataGridView2;
        private GroupBox groupBox7;
        private ComboBox cboMaLoaiDoUong;
        private GroupBox groupBox8;
        private TextBox txtGiaTien;
    }
}
