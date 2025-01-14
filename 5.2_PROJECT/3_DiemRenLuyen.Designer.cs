namespace WindowsFormsApp1
{
    partial class DIEMRENLUYEN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DIEMRENLUYEN));
            this.lblDiemRL = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpThoiGIan = new System.Windows.Forms.DateTimePicker();
            this.radHK3 = new System.Windows.Forms.RadioButton();
            this.radHK2 = new System.Windows.Forms.RadioButton();
            this.radHK1 = new System.Windows.Forms.RadioButton();
            this.lblThoiGian = new System.Windows.Forms.Label();
            this.lblTenHD = new System.Windows.Forms.Label();
            this.txtTenHD = new System.Windows.Forms.TextBox();
            this.lblHocKy = new System.Windows.Forms.Label();
            this.cboNamHoc = new System.Windows.Forms.ComboBox();
            this.txtDiemRL = new System.Windows.Forms.TextBox();
            this.lblDiem = new System.Windows.Forms.Label();
            this.lblNienKhoa = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.lblHD = new System.Windows.Forms.Label();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDiemRL = new System.Windows.Forms.DataGridView();
            this.errorMaSV = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorMaHD = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemRL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMaSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMaHD)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDiemRL
            // 
            this.lblDiemRL.AutoSize = true;
            this.lblDiemRL.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiemRL.Location = new System.Drawing.Point(741, 14);
            this.lblDiemRL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiemRL.Name = "lblDiemRL";
            this.lblDiemRL.Size = new System.Drawing.Size(537, 69);
            this.lblDiemRL.TabIndex = 56;
            this.lblDiemRL.Text = "ĐIỂM RÈN LUYỆN";
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(1667, 392);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(172, 48);
            this.btnThoat.TabIndex = 55;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Location = new System.Drawing.Point(1755, 309);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(172, 48);
            this.btnLamMoi.TabIndex = 54;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(1575, 309);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(172, 48);
            this.btnSua.TabIndex = 53;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(1764, 187);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(172, 48);
            this.btnXoa.TabIndex = 52;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(1575, 187);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(172, 48);
            this.btnThem.TabIndex = 51;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpThoiGIan);
            this.groupBox2.Controls.Add(this.radHK3);
            this.groupBox2.Controls.Add(this.radHK2);
            this.groupBox2.Controls.Add(this.radHK1);
            this.groupBox2.Controls.Add(this.lblThoiGian);
            this.groupBox2.Controls.Add(this.lblTenHD);
            this.groupBox2.Controls.Add(this.txtTenHD);
            this.groupBox2.Controls.Add(this.lblHocKy);
            this.groupBox2.Controls.Add(this.cboNamHoc);
            this.groupBox2.Controls.Add(this.txtDiemRL);
            this.groupBox2.Controls.Add(this.lblDiem);
            this.groupBox2.Controls.Add(this.lblNienKhoa);
            this.groupBox2.Controls.Add(this.txtMaHD);
            this.groupBox2.Controls.Add(this.txtMaSV);
            this.groupBox2.Controls.Add(this.lblHD);
            this.groupBox2.Controls.Add(this.lblMaSV);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(48, 89);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(1504, 592);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết";
            // 
            // dtpThoiGIan
            // 
            this.dtpThoiGIan.Location = new System.Drawing.Point(1046, 131);
            this.dtpThoiGIan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpThoiGIan.Name = "dtpThoiGIan";
            this.dtpThoiGIan.Size = new System.Drawing.Size(402, 35);
            this.dtpThoiGIan.TabIndex = 37;
            // 
            // radHK3
            // 
            this.radHK3.AutoSize = true;
            this.radHK3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radHK3.Location = new System.Drawing.Point(902, 128);
            this.radHK3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radHK3.Name = "radHK3";
            this.radHK3.Size = new System.Drawing.Size(51, 33);
            this.radHK3.TabIndex = 36;
            this.radHK3.Text = "3";
            this.radHK3.UseVisualStyleBackColor = true;
            // 
            // radHK2
            // 
            this.radHK2.AutoSize = true;
            this.radHK2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radHK2.Location = new System.Drawing.Point(726, 129);
            this.radHK2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radHK2.Name = "radHK2";
            this.radHK2.Size = new System.Drawing.Size(51, 33);
            this.radHK2.TabIndex = 35;
            this.radHK2.Text = "2";
            this.radHK2.UseVisualStyleBackColor = true;
            // 
            // radHK1
            // 
            this.radHK1.AutoSize = true;
            this.radHK1.Checked = true;
            this.radHK1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radHK1.Location = new System.Drawing.Point(552, 129);
            this.radHK1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radHK1.Name = "radHK1";
            this.radHK1.Size = new System.Drawing.Size(51, 33);
            this.radHK1.TabIndex = 34;
            this.radHK1.TabStop = true;
            this.radHK1.Text = "1";
            this.radHK1.UseVisualStyleBackColor = true;
            // 
            // lblThoiGian
            // 
            this.lblThoiGian.AutoSize = true;
            this.lblThoiGian.Location = new System.Drawing.Point(1040, 72);
            this.lblThoiGian.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.Size = new System.Drawing.Size(114, 29);
            this.lblThoiGian.TabIndex = 27;
            this.lblThoiGian.Text = "Thời gian";
            // 
            // lblTenHD
            // 
            this.lblTenHD.AutoSize = true;
            this.lblTenHD.Location = new System.Drawing.Point(1040, 248);
            this.lblTenHD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenHD.Name = "lblTenHD";
            this.lblTenHD.Size = new System.Drawing.Size(169, 29);
            this.lblTenHD.TabIndex = 23;
            this.lblTenHD.Text = "Tên hoạt động";
            // 
            // txtTenHD
            // 
            this.txtTenHD.Location = new System.Drawing.Point(1046, 303);
            this.txtTenHD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenHD.Multiline = true;
            this.txtTenHD.Name = "txtTenHD";
            this.txtTenHD.Size = new System.Drawing.Size(402, 39);
            this.txtTenHD.TabIndex = 24;
            // 
            // lblHocKy
            // 
            this.lblHocKy.AutoSize = true;
            this.lblHocKy.Location = new System.Drawing.Point(546, 72);
            this.lblHocKy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHocKy.Name = "lblHocKy";
            this.lblHocKy.Size = new System.Drawing.Size(85, 29);
            this.lblHocKy.TabIndex = 19;
            this.lblHocKy.Text = "Học kỳ";
            // 
            // cboNamHoc
            // 
            this.cboNamHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNamHoc.FormattingEnabled = true;
            this.cboNamHoc.Items.AddRange(new object[] {
            "2021-2022",
            "2022-2023"});
            this.cboNamHoc.Location = new System.Drawing.Point(56, 128);
            this.cboNamHoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboNamHoc.Name = "cboNamHoc";
            this.cboNamHoc.Size = new System.Drawing.Size(402, 37);
            this.cboNamHoc.TabIndex = 18;
            // 
            // txtDiemRL
            // 
            this.txtDiemRL.Location = new System.Drawing.Point(552, 474);
            this.txtDiemRL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDiemRL.Multiline = true;
            this.txtDiemRL.Name = "txtDiemRL";
            this.txtDiemRL.Size = new System.Drawing.Size(402, 41);
            this.txtDiemRL.TabIndex = 17;
            // 
            // lblDiem
            // 
            this.lblDiem.AutoSize = true;
            this.lblDiem.Location = new System.Drawing.Point(546, 417);
            this.lblDiem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiem.Name = "lblDiem";
            this.lblDiem.Size = new System.Drawing.Size(188, 29);
            this.lblDiem.TabIndex = 16;
            this.lblDiem.Text = "Điểm được cộng";
            // 
            // lblNienKhoa
            // 
            this.lblNienKhoa.AutoSize = true;
            this.lblNienKhoa.Location = new System.Drawing.Point(50, 72);
            this.lblNienKhoa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNienKhoa.Name = "lblNienKhoa";
            this.lblNienKhoa.Size = new System.Drawing.Size(109, 29);
            this.lblNienKhoa.TabIndex = 15;
            this.lblNienKhoa.Text = "Năm học";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(552, 302);
            this.txtMaHD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaHD.MaxLength = 5;
            this.txtMaHD.Multiline = true;
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(402, 41);
            this.txtMaHD.TabIndex = 14;
            this.txtMaHD.Leave += new System.EventHandler(this.txtMaHD_Leave);
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(56, 302);
            this.txtMaSV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaSV.MaxLength = 11;
            this.txtMaSV.Multiline = true;
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(402, 41);
            this.txtMaSV.TabIndex = 13;
            this.txtMaSV.Leave += new System.EventHandler(this.txtMaSV_Leave);
            // 
            // lblHD
            // 
            this.lblHD.AutoSize = true;
            this.lblHD.Location = new System.Drawing.Point(546, 248);
            this.lblHD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHD.Name = "lblHD";
            this.lblHD.Size = new System.Drawing.Size(159, 29);
            this.lblHD.TabIndex = 12;
            this.lblHD.Text = "Mã hoạt động";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDiemRL);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(48, 691);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1953, 252);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách sinh viên đã cập nhật điểm";
            // 
            // dgvDiemRL
            // 
            this.dgvDiemRL.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDiemRL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiemRL.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDiemRL.Location = new System.Drawing.Point(4, 32);
            this.dgvDiemRL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDiemRL.Name = "dgvDiemRL";
            this.dgvDiemRL.RowHeadersWidth = 62;
            this.dgvDiemRL.Size = new System.Drawing.Size(1945, 215);
            this.dgvDiemRL.TabIndex = 33;
            this.dgvDiemRL.Click += new System.EventHandler(this.dgvDiemRL_Click);
            // 
            // errorMaSV
            // 
            this.errorMaSV.ContainerControl = this;
            // 
            // errorMaHD
            // 
            this.errorMaHD.ContainerControl = this;
            // 
            // DIEMRENLUYEN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1924, 985);
            this.Controls.Add(this.lblDiemRL);
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
            this.Name = "DIEMRENLUYEN";
            this.Text = "ĐIỂM RÈN LUYỆN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DIEMRENLUYEN_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemRL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMaSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMaHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDiemRL;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblThoiGian;
        private System.Windows.Forms.Label lblTenHD;
        private System.Windows.Forms.TextBox txtTenHD;
        private System.Windows.Forms.Label lblHocKy;
        private System.Windows.Forms.ComboBox cboNamHoc;
        private System.Windows.Forms.TextBox txtDiemRL;
        private System.Windows.Forms.Label lblDiem;
        private System.Windows.Forms.Label lblNienKhoa;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label lblHD;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDiemRL;
        private System.Windows.Forms.RadioButton radHK3;
        private System.Windows.Forms.RadioButton radHK2;
        private System.Windows.Forms.RadioButton radHK1;
        private System.Windows.Forms.DateTimePicker dtpThoiGIan;
        private System.Windows.Forms.ErrorProvider errorMaSV;
        private System.Windows.Forms.ErrorProvider errorMaHD;
    }
}

