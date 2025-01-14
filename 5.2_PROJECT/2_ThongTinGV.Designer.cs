namespace WindowsFormsApp1
{
    partial class THONGTINGV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(THONGTINGV));
            this.lblTTSV = new System.Windows.Forms.Label();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvGV = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpNgSinh = new System.Windows.Forms.DateTimePicker();
            this.txtChucVu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboKhoa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblNienKhoa = new System.Windows.Forms.Label();
            this.txtTenGV = new System.Windows.Forms.TextBox();
            this.txtMaGV = new System.Windows.Forms.TextBox();
            this.lblTenGV = new System.Windows.Forms.Label();
            this.lblMaGV = new System.Windows.Forms.Label();
            this.errorMaGV = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorTenGV = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorChucVu = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGV)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorMaGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTenGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorChucVu)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTTSV
            // 
            this.lblTTSV.AutoSize = true;
            this.lblTTSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTTSV.Location = new System.Drawing.Point(676, 12);
            this.lblTTSV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTTSV.Name = "lblTTSV";
            this.lblTTSV.Size = new System.Drawing.Size(726, 69);
            this.lblTTSV.TabIndex = 48;
            this.lblTTSV.Text = "THÔNG TIN GIẢNG VIÊN";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Location = new System.Drawing.Point(1753, 318);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(172, 48);
            this.btnLamMoi.TabIndex = 46;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(1573, 318);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(172, 48);
            this.btnSua.TabIndex = 45;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(1753, 204);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(172, 48);
            this.btnXoa.TabIndex = 44;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(1573, 204);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(172, 48);
            this.btnThem.TabIndex = 43;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(1677, 396);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(172, 48);
            this.btnThoat.TabIndex = 47;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvGV);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(50, 689);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1953, 252);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách giảng viên đã thêm";
            // 
            // dgvGV
            // 
            this.dgvGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvGV.Location = new System.Drawing.Point(4, 32);
            this.dgvGV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvGV.Name = "dgvGV";
            this.dgvGV.RowHeadersWidth = 62;
            this.dgvGV.Size = new System.Drawing.Size(1945, 215);
            this.dgvGV.TabIndex = 33;
            this.dgvGV.Click += new System.EventHandler(this.dgvGV_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpNgSinh);
            this.groupBox2.Controls.Add(this.txtChucVu);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cboKhoa);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.radNu);
            this.groupBox2.Controls.Add(this.radNam);
            this.groupBox2.Controls.Add(this.lblGioiTinh);
            this.groupBox2.Controls.Add(this.lblNienKhoa);
            this.groupBox2.Controls.Add(this.txtTenGV);
            this.groupBox2.Controls.Add(this.txtMaGV);
            this.groupBox2.Controls.Add(this.lblTenGV);
            this.groupBox2.Controls.Add(this.lblMaGV);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(50, 88);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(1504, 592);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết";
            // 
            // dtpNgSinh
            // 
            this.dtpNgSinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgSinh.Location = new System.Drawing.Point(55, 129);
            this.dtpNgSinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgSinh.Name = "dtpNgSinh";
            this.dtpNgSinh.Size = new System.Drawing.Size(403, 35);
            this.dtpNgSinh.TabIndex = 33;
            this.dtpNgSinh.ValueChanged += new System.EventHandler(this.dtpNgSinh_ValueChanged);
            // 
            // txtChucVu
            // 
            this.txtChucVu.Location = new System.Drawing.Point(1020, 304);
            this.txtChucVu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtChucVu.Multiline = true;
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.Size = new System.Drawing.Size(402, 42);
            this.txtChucVu.TabIndex = 32;
            this.txtChucVu.Click += new System.EventHandler(this.txtChucVu_Click);
            this.txtChucVu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtChucVu_KeyPress);
            this.txtChucVu.Leave += new System.EventHandler(this.txtChucVu_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1036, 239);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 29);
            this.label2.TabIndex = 31;
            this.label2.Text = "Chức vụ";
            // 
            // cboKhoa
            // 
            this.cboKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhoa.FormattingEnabled = true;
            this.cboKhoa.Location = new System.Drawing.Point(36, 304);
            this.cboKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboKhoa.Name = "cboKhoa";
            this.cboKhoa.Size = new System.Drawing.Size(381, 37);
            this.cboKhoa.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 248);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 29);
            this.label1.TabIndex = 29;
            this.label1.Text = "Khoa";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNu.Location = new System.Drawing.Point(1210, 124);
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
            this.radNam.Location = new System.Drawing.Point(1045, 124);
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
            this.lblGioiTinh.Location = new System.Drawing.Point(1040, 72);
            this.lblGioiTinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(101, 29);
            this.lblGioiTinh.TabIndex = 20;
            this.lblGioiTinh.Text = "Giới tính";
            // 
            // lblNienKhoa
            // 
            this.lblNienKhoa.AutoSize = true;
            this.lblNienKhoa.Location = new System.Drawing.Point(50, 72);
            this.lblNienKhoa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNienKhoa.Name = "lblNienKhoa";
            this.lblNienKhoa.Size = new System.Drawing.Size(119, 29);
            this.lblNienKhoa.TabIndex = 15;
            this.lblNienKhoa.Text = "Ngày sinh";
            this.lblNienKhoa.Click += new System.EventHandler(this.lblNienKhoa_Click);
            // 
            // txtTenGV
            // 
            this.txtTenGV.Location = new System.Drawing.Point(552, 302);
            this.txtTenGV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenGV.Multiline = true;
            this.txtTenGV.Name = "txtTenGV";
            this.txtTenGV.Size = new System.Drawing.Size(402, 42);
            this.txtTenGV.TabIndex = 14;
            this.txtTenGV.Click += new System.EventHandler(this.txtTenGV_Click);
            this.txtTenGV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenGV_KeyPress);
            this.txtTenGV.Leave += new System.EventHandler(this.txtTenGV_Leave);
            // 
            // txtMaGV
            // 
            this.txtMaGV.Location = new System.Drawing.Point(552, 126);
            this.txtMaGV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaGV.MaxLength = 11;
            this.txtMaGV.Multiline = true;
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(402, 42);
            this.txtMaGV.TabIndex = 13;
            this.txtMaGV.Click += new System.EventHandler(this.txtMaGV_Click);
            this.txtMaGV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaGV_KeyPress);
            this.txtMaGV.Leave += new System.EventHandler(this.txtMaGV_Leave);
            // 
            // lblTenGV
            // 
            this.lblTenGV.AutoSize = true;
            this.lblTenGV.Location = new System.Drawing.Point(546, 248);
            this.lblTenGV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenGV.Name = "lblTenGV";
            this.lblTenGV.Size = new System.Drawing.Size(229, 29);
            this.lblTenGV.TabIndex = 12;
            this.lblTenGV.Text = "Họ và tên giảng viên";
            // 
            // lblMaGV
            // 
            this.lblMaGV.AutoSize = true;
            this.lblMaGV.Location = new System.Drawing.Point(546, 72);
            this.lblMaGV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaGV.Name = "lblMaGV";
            this.lblMaGV.Size = new System.Drawing.Size(194, 29);
            this.lblMaGV.TabIndex = 11;
            this.lblMaGV.Text = "Mã số giảng viên";
            // 
            // errorMaGV
            // 
            this.errorMaGV.ContainerControl = this;
            // 
            // errorTenGV
            // 
            this.errorTenGV.ContainerControl = this;
            // 
            // errorChucVu
            // 
            this.errorChucVu.ContainerControl = this;
            // 
            // THONGTINGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.lblTTSV);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "THONGTINGV";
            this.Text = "THÔNG TIN GIẢNG VIÊN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.THONGTINGV_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGV)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorMaGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTenGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorChucVu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTTSV;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvGV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblNienKhoa;
        private System.Windows.Forms.TextBox txtTenGV;
        private System.Windows.Forms.TextBox txtMaGV;
        private System.Windows.Forms.Label lblTenGV;
        private System.Windows.Forms.Label lblMaGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboKhoa;
        private System.Windows.Forms.TextBox txtChucVu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpNgSinh;
        private System.Windows.Forms.ErrorProvider errorMaGV;
        private System.Windows.Forms.ErrorProvider errorTenGV;
        private System.Windows.Forms.ErrorProvider errorChucVu;
    }
}

