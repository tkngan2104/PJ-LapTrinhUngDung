namespace WindowsFormsApp1
{
    partial class HOCPHAN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HOCPHAN));
            this.lblHocPhan = new System.Windows.Forms.Label();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvHP = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radHK3 = new System.Windows.Forms.RadioButton();
            this.radHK2 = new System.Windows.Forms.RadioButton();
            this.radHK1 = new System.Windows.Forms.RadioButton();
            this.lblHocKy = new System.Windows.Forms.Label();
            this.cboKhoa = new System.Windows.Forms.ComboBox();
            this.txtSTC = new System.Windows.Forms.TextBox();
            this.lblSTC = new System.Windows.Forms.Label();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.txtTenHP = new System.Windows.Forms.TextBox();
            this.txtMaHP = new System.Windows.Forms.TextBox();
            this.lblTenHP = new System.Windows.Forms.Label();
            this.lblMaHP = new System.Windows.Forms.Label();
            this.errorMaHP = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorTenHP = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorTC = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHP)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorMaHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTenHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTC)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHocPhan
            // 
            this.lblHocPhan.AutoSize = true;
            this.lblHocPhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHocPhan.Location = new System.Drawing.Point(868, 14);
            this.lblHocPhan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHocPhan.Name = "lblHocPhan";
            this.lblHocPhan.Size = new System.Drawing.Size(345, 69);
            this.lblHocPhan.TabIndex = 56;
            this.lblHocPhan.Text = "HỌC PHẦN";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Location = new System.Drawing.Point(801, 762);
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
            this.btnSua.Location = new System.Drawing.Point(567, 762);
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
            this.btnXoa.Location = new System.Drawing.Point(336, 762);
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
            this.btnThem.Location = new System.Drawing.Point(105, 762);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(172, 48);
            this.btnThem.TabIndex = 51;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(452, 848);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(172, 48);
            this.btnThoat.TabIndex = 55;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvHP);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1106, 88);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(897, 854);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách học phần";
            // 
            // dgvHP
            // 
            this.dgvHP.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvHP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvHP.Location = new System.Drawing.Point(4, 38);
            this.dgvHP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvHP.Name = "dgvHP";
            this.dgvHP.RowHeadersWidth = 62;
            this.dgvHP.Size = new System.Drawing.Size(889, 811);
            this.dgvHP.TabIndex = 33;
            this.dgvHP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHP_CellContentClick);
            this.dgvHP.Click += new System.EventHandler(this.dgvHP_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radHK3);
            this.groupBox2.Controls.Add(this.radHK2);
            this.groupBox2.Controls.Add(this.radHK1);
            this.groupBox2.Controls.Add(this.lblHocKy);
            this.groupBox2.Controls.Add(this.cboKhoa);
            this.groupBox2.Controls.Add(this.txtSTC);
            this.groupBox2.Controls.Add(this.lblSTC);
            this.groupBox2.Controls.Add(this.lblKhoa);
            this.groupBox2.Controls.Add(this.txtTenHP);
            this.groupBox2.Controls.Add(this.txtMaHP);
            this.groupBox2.Controls.Add(this.lblTenHP);
            this.groupBox2.Controls.Add(this.lblMaHP);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(50, 88);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(1020, 571);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết";
            // 
            // radHK3
            // 
            this.radHK3.AutoSize = true;
            this.radHK3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radHK3.Location = new System.Drawing.Point(738, 472);
            this.radHK3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radHK3.Name = "radHK3";
            this.radHK3.Size = new System.Drawing.Size(51, 33);
            this.radHK3.TabIndex = 28;
            this.radHK3.Text = "3";
            this.radHK3.UseVisualStyleBackColor = true;
            // 
            // radHK2
            // 
            this.radHK2.AutoSize = true;
            this.radHK2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radHK2.Location = new System.Drawing.Point(478, 472);
            this.radHK2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radHK2.Name = "radHK2";
            this.radHK2.Size = new System.Drawing.Size(51, 33);
            this.radHK2.TabIndex = 26;
            this.radHK2.Text = "2";
            this.radHK2.UseVisualStyleBackColor = true;
            // 
            // radHK1
            // 
            this.radHK1.AutoSize = true;
            this.radHK1.Checked = true;
            this.radHK1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radHK1.Location = new System.Drawing.Point(230, 472);
            this.radHK1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radHK1.Name = "radHK1";
            this.radHK1.Size = new System.Drawing.Size(51, 33);
            this.radHK1.TabIndex = 25;
            this.radHK1.TabStop = true;
            this.radHK1.Text = "1";
            this.radHK1.UseVisualStyleBackColor = true;
            // 
            // lblHocKy
            // 
            this.lblHocKy.AutoSize = true;
            this.lblHocKy.Location = new System.Drawing.Point(50, 408);
            this.lblHocKy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHocKy.Name = "lblHocKy";
            this.lblHocKy.Size = new System.Drawing.Size(85, 29);
            this.lblHocKy.TabIndex = 20;
            this.lblHocKy.Text = "Học kỳ";
            // 
            // cboKhoa
            // 
            this.cboKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhoa.FormattingEnabled = true;
            this.cboKhoa.Location = new System.Drawing.Point(552, 128);
            this.cboKhoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboKhoa.Name = "cboKhoa";
            this.cboKhoa.Size = new System.Drawing.Size(402, 37);
            this.cboKhoa.TabIndex = 18;
            // 
            // txtSTC
            // 
            this.txtSTC.Location = new System.Drawing.Point(552, 302);
            this.txtSTC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSTC.Multiline = true;
            this.txtSTC.Name = "txtSTC";
            this.txtSTC.Size = new System.Drawing.Size(402, 42);
            this.txtSTC.TabIndex = 17;
            this.txtSTC.Click += new System.EventHandler(this.txtSTC_Click);
            this.txtSTC.TextChanged += new System.EventHandler(this.txtSTC_TextChanged);
            this.txtSTC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSTC_KeyPress);
            this.txtSTC.Leave += new System.EventHandler(this.txtSTC_Leave);
            // 
            // lblSTC
            // 
            this.lblSTC.AutoSize = true;
            this.lblSTC.Location = new System.Drawing.Point(546, 248);
            this.lblSTC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSTC.Name = "lblSTC";
            this.lblSTC.Size = new System.Drawing.Size(111, 29);
            this.lblSTC.TabIndex = 16;
            this.lblSTC.Text = "Số tín chỉ";
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Location = new System.Drawing.Point(546, 72);
            this.lblKhoa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(69, 29);
            this.lblKhoa.TabIndex = 15;
            this.lblKhoa.Text = "Khoa";
            // 
            // txtTenHP
            // 
            this.txtTenHP.Location = new System.Drawing.Point(56, 302);
            this.txtTenHP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenHP.Multiline = true;
            this.txtTenHP.Name = "txtTenHP";
            this.txtTenHP.Size = new System.Drawing.Size(402, 42);
            this.txtTenHP.TabIndex = 14;
            this.txtTenHP.Click += new System.EventHandler(this.txtTenHP_Click);
            this.txtTenHP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenHP_KeyPress);
            this.txtTenHP.Leave += new System.EventHandler(this.txtTenHP_Leave);
            // 
            // txtMaHP
            // 
            this.txtMaHP.Location = new System.Drawing.Point(56, 126);
            this.txtMaHP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaHP.MaxLength = 11;
            this.txtMaHP.Multiline = true;
            this.txtMaHP.Name = "txtMaHP";
            this.txtMaHP.Size = new System.Drawing.Size(402, 42);
            this.txtMaHP.TabIndex = 13;
            this.txtMaHP.Click += new System.EventHandler(this.txtMaHP_Click);
            this.txtMaHP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaHP_KeyPress);
            this.txtMaHP.Leave += new System.EventHandler(this.txtMaHP_Leave);
            // 
            // lblTenHP
            // 
            this.lblTenHP.AutoSize = true;
            this.lblTenHP.Location = new System.Drawing.Point(50, 248);
            this.lblTenHP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenHP.Name = "lblTenHP";
            this.lblTenHP.Size = new System.Drawing.Size(160, 29);
            this.lblTenHP.TabIndex = 12;
            this.lblTenHP.Text = "Tên học phần";
            // 
            // lblMaHP
            // 
            this.lblMaHP.AutoSize = true;
            this.lblMaHP.Location = new System.Drawing.Point(50, 72);
            this.lblMaHP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaHP.Name = "lblMaHP";
            this.lblMaHP.Size = new System.Drawing.Size(182, 29);
            this.lblMaHP.TabIndex = 11;
            this.lblMaHP.Text = "Mã số học phần";
            // 
            // errorMaHP
            // 
            this.errorMaHP.ContainerControl = this;
            // 
            // errorTenHP
            // 
            this.errorTenHP.ContainerControl = this;
            // 
            // errorTC
            // 
            this.errorTC.ContainerControl = this;
            // 
            // HOCPHAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.lblHocPhan);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "HOCPHAN";
            this.Text = "HỌC PHẦN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HOCPHAN_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHP)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorMaHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTenHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHocPhan;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvHP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radHK2;
        private System.Windows.Forms.RadioButton radHK1;
        private System.Windows.Forms.Label lblHocKy;
        private System.Windows.Forms.ComboBox cboKhoa;
        private System.Windows.Forms.TextBox txtSTC;
        private System.Windows.Forms.Label lblSTC;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.TextBox txtTenHP;
        private System.Windows.Forms.Label lblTenHP;
        private System.Windows.Forms.TextBox txtMaHP;
        private System.Windows.Forms.Label lblMaHP;
        private System.Windows.Forms.RadioButton radHK3;
        private System.Windows.Forms.ErrorProvider errorMaHP;
        private System.Windows.Forms.ErrorProvider errorTenHP;
        private System.Windows.Forms.ErrorProvider errorTC;
    }
}

