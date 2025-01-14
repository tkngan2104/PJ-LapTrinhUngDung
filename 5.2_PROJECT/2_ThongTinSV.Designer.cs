namespace WindowsFormsApp1
{
    partial class THONGTINSV
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(THONGTINSV));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvSV = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.dtpNgSinh = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblQueQuan = new System.Windows.Forms.Label();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblLop = new System.Windows.Forms.Label();
            this.cboNienKhoa = new System.Windows.Forms.ComboBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.lblCMND = new System.Windows.Forms.Label();
            this.lblNienKhoa = new System.Windows.Forms.Label();
            this.txtTenSV = new System.Windows.Forms.TextBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.lblTenSV = new System.Windows.Forms.Label();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblTTSV = new System.Windows.Forms.Label();
            this.errorMaSV = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorTenSV = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDiaChi = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorQueQuan = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCCCD = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSV)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorMaSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTenSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDiaChi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorQueQuan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCCCD)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvSV);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(48, 691);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1953, 252);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách sinh viên đã thêm";
            // 
            // dgvSV
            // 
            this.dgvSV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSV.Location = new System.Drawing.Point(4, 32);
            this.dgvSV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvSV.Name = "dgvSV";
            this.dgvSV.RowHeadersWidth = 62;
            this.dgvSV.Size = new System.Drawing.Size(1945, 215);
            this.dgvSV.TabIndex = 33;
            this.dgvSV.Click += new System.EventHandler(this.dgvSV_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboLop);
            this.groupBox2.Controls.Add(this.dtpNgSinh);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtDiaChi);
            this.groupBox2.Controls.Add(this.lblDiaChi);
            this.groupBox2.Controls.Add(this.lblQueQuan);
            this.groupBox2.Controls.Add(this.txtQueQuan);
            this.groupBox2.Controls.Add(this.radNu);
            this.groupBox2.Controls.Add(this.radNam);
            this.groupBox2.Controls.Add(this.lblGioiTinh);
            this.groupBox2.Controls.Add(this.lblLop);
            this.groupBox2.Controls.Add(this.cboNienKhoa);
            this.groupBox2.Controls.Add(this.txtCMND);
            this.groupBox2.Controls.Add(this.lblCMND);
            this.groupBox2.Controls.Add(this.lblNienKhoa);
            this.groupBox2.Controls.Add(this.txtTenSV);
            this.groupBox2.Controls.Add(this.txtMaSV);
            this.groupBox2.Controls.Add(this.lblTenSV);
            this.groupBox2.Controls.Add(this.lblMaSV);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(48, 89);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(1504, 592);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết";
            // 
            // cboLop
            // 
            this.cboLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(551, 128);
            this.cboLop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(393, 37);
            this.cboLop.TabIndex = 31;
            // 
            // dtpNgSinh
            // 
            this.dtpNgSinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgSinh.Location = new System.Drawing.Point(1046, 480);
            this.dtpNgSinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgSinh.Name = "dtpNgSinh";
            this.dtpNgSinh.Size = new System.Drawing.Size(390, 35);
            this.dtpNgSinh.TabIndex = 30;
            this.dtpNgSinh.ValueChanged += new System.EventHandler(this.dtpNgSinh_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1059, 376);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 29);
            this.label1.TabIndex = 29;
            this.label1.Text = "Ngày sinh";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(1046, 129);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(391, 48);
            this.txtDiaChi.TabIndex = 28;
            this.txtDiaChi.Click += new System.EventHandler(this.txtDiaChi_Click);
            this.txtDiaChi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiaChi_KeyPress);
            this.txtDiaChi.Leave += new System.EventHandler(this.txtDiaChi_Leave);
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(1040, 72);
            this.lblDiaChi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(198, 29);
            this.lblDiaChi.TabIndex = 27;
            this.lblDiaChi.Text = "Địa chỉ thường trú";
            // 
            // lblQueQuan
            // 
            this.lblQueQuan.AutoSize = true;
            this.lblQueQuan.Location = new System.Drawing.Point(1059, 248);
            this.lblQueQuan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQueQuan.Name = "lblQueQuan";
            this.lblQueQuan.Size = new System.Drawing.Size(118, 29);
            this.lblQueQuan.TabIndex = 23;
            this.lblQueQuan.Text = "Quê quán";
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Location = new System.Drawing.Point(1045, 302);
            this.txtQueQuan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtQueQuan.Multiline = true;
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Size = new System.Drawing.Size(391, 44);
            this.txtQueQuan.TabIndex = 24;
            this.txtQueQuan.Click += new System.EventHandler(this.txtQueQuan_Click);
            this.txtQueQuan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQueQuan_KeyPress);
            this.txtQueQuan.Leave += new System.EventHandler(this.txtQueQuan_Leave);
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNu.Location = new System.Drawing.Point(328, 478);
            this.radNu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(69, 33);
            this.radNu.TabIndex = 26;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Checked = true;
            this.radNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNam.Location = new System.Drawing.Point(112, 478);
            this.radNam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(89, 33);
            this.radNam.TabIndex = 25;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(50, 418);
            this.lblGioiTinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(101, 29);
            this.lblGioiTinh.TabIndex = 20;
            this.lblGioiTinh.Text = "Giới tính";
            // 
            // lblLop
            // 
            this.lblLop.AutoSize = true;
            this.lblLop.Location = new System.Drawing.Point(546, 72);
            this.lblLop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(54, 29);
            this.lblLop.TabIndex = 19;
            this.lblLop.Text = "Lớp";
            // 
            // cboNienKhoa
            // 
            this.cboNienKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNienKhoa.FormattingEnabled = true;
            this.cboNienKhoa.Items.AddRange(new object[] {
            "2021-2024",
            "2022-2025"});
            this.cboNienKhoa.Location = new System.Drawing.Point(56, 128);
            this.cboNienKhoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboNienKhoa.Name = "cboNienKhoa";
            this.cboNienKhoa.Size = new System.Drawing.Size(402, 37);
            this.cboNienKhoa.TabIndex = 18;
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(552, 474);
            this.txtCMND.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCMND.Multiline = true;
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(402, 42);
            this.txtCMND.TabIndex = 17;
            this.txtCMND.Click += new System.EventHandler(this.txtCMND_Click);
            this.txtCMND.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCMND_KeyPress);
            this.txtCMND.Leave += new System.EventHandler(this.txtCMND_Leave);
            // 
            // lblCMND
            // 
            this.lblCMND.AutoSize = true;
            this.lblCMND.Location = new System.Drawing.Point(546, 418);
            this.lblCMND.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCMND.Name = "lblCMND";
            this.lblCMND.Size = new System.Drawing.Size(172, 29);
            this.lblCMND.TabIndex = 16;
            this.lblCMND.Text = "CMND / CCCD";
            // 
            // lblNienKhoa
            // 
            this.lblNienKhoa.AutoSize = true;
            this.lblNienKhoa.Location = new System.Drawing.Point(50, 72);
            this.lblNienKhoa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNienKhoa.Name = "lblNienKhoa";
            this.lblNienKhoa.Size = new System.Drawing.Size(122, 29);
            this.lblNienKhoa.TabIndex = 15;
            this.lblNienKhoa.Text = "Niên khóa";
            // 
            // txtTenSV
            // 
            this.txtTenSV.Location = new System.Drawing.Point(552, 302);
            this.txtTenSV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenSV.Multiline = true;
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.Size = new System.Drawing.Size(402, 42);
            this.txtTenSV.TabIndex = 14;
            this.txtTenSV.Click += new System.EventHandler(this.txtTenSV_Click);
            this.txtTenSV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenSV_KeyPress);
            this.txtTenSV.Leave += new System.EventHandler(this.txtTenSV_Leave);
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(56, 302);
            this.txtMaSV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaSV.MaxLength = 11;
            this.txtMaSV.Multiline = true;
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(402, 42);
            this.txtMaSV.TabIndex = 13;
            this.txtMaSV.Click += new System.EventHandler(this.txtMaSV_Click);
            this.txtMaSV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaSV_KeyPress);
            this.txtMaSV.Leave += new System.EventHandler(this.txtMaSV_Leave);
            // 
            // lblTenSV
            // 
            this.lblTenSV.AutoSize = true;
            this.lblTenSV.Location = new System.Drawing.Point(546, 248);
            this.lblTenSV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenSV.Name = "lblTenSV";
            this.lblTenSV.Size = new System.Drawing.Size(213, 29);
            this.lblTenSV.TabIndex = 12;
            this.lblTenSV.Text = "Họ và tên sinh viên";
            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Location = new System.Drawing.Point(50, 248);
            this.lblMaSV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(178, 29);
            this.lblMaSV.TabIndex = 11;
            this.lblMaSV.Text = "Mã số sinh viên";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(1570, 186);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(172, 48);
            this.btnThem.TabIndex = 35;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(1750, 186);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(172, 48);
            this.btnXoa.TabIndex = 36;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Location = new System.Drawing.Point(1750, 288);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(172, 48);
            this.btnLamMoi.TabIndex = 38;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(1570, 288);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(172, 48);
            this.btnSua.TabIndex = 37;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(1654, 370);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(172, 48);
            this.btnThoat.TabIndex = 39;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lblTTSV
            // 
            this.lblTTSV.AutoSize = true;
            this.lblTTSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTTSV.Location = new System.Drawing.Point(675, 14);
            this.lblTTSV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTTSV.Name = "lblTTSV";
            this.lblTTSV.Size = new System.Drawing.Size(675, 69);
            this.lblTTSV.TabIndex = 40;
            this.lblTTSV.Text = "THÔNG TIN SINH VIÊN";
            // 
            // errorMaSV
            // 
            this.errorMaSV.ContainerControl = this;
            // 
            // errorTenSV
            // 
            this.errorTenSV.ContainerControl = this;
            // 
            // errorDiaChi
            // 
            this.errorDiaChi.ContainerControl = this;
            // 
            // errorQueQuan
            // 
            this.errorQueQuan.ContainerControl = this;
            // 
            // errorCCCD
            // 
            this.errorCCCD.ContainerControl = this;
            // 
            // THONGTINSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1924, 978);
            this.Controls.Add(this.lblTTSV);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "THONGTINSV";
            this.Text = "THÔNG TIN SINH VIÊN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.THONGTINSV_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSV)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorMaSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTenSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDiaChi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorQueQuan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCCCD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvSV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboNienKhoa;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Label lblCMND;
        private System.Windows.Forms.Label lblNienKhoa;
        private System.Windows.Forms.TextBox txtTenSV;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label lblTenSV;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.TextBox txtQueQuan;
        private System.Windows.Forms.Label lblQueQuan;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblTTSV;
        private System.Windows.Forms.DateTimePicker dtpNgSinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.ErrorProvider errorMaSV;
        private System.Windows.Forms.ErrorProvider errorTenSV;
        private System.Windows.Forms.ErrorProvider errorDiaChi;
        private System.Windows.Forms.ErrorProvider errorQueQuan;
        private System.Windows.Forms.ErrorProvider errorCCCD;
    }
}

