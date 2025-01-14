namespace WindowsFormsApp1
{
    partial class LOPHOC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOPHOC));
            this.lblLopHoc = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvLop = new System.Windows.Forms.DataGridView();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboGVDN = new System.Windows.Forms.ComboBox();
            this.lblGVDN = new System.Windows.Forms.Label();
            this.cboChuyenNganh = new System.Windows.Forms.ComboBox();
            this.txtMaLH = new System.Windows.Forms.TextBox();
            this.lblChuyenNganh = new System.Windows.Forms.Label();
            this.lblMaLH = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.errorMaLH = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorMaLH)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLopHoc
            // 
            this.lblLopHoc.AutoSize = true;
            this.lblLopHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLopHoc.Location = new System.Drawing.Point(950, 14);
            this.lblLopHoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLopHoc.Name = "lblLopHoc";
            this.lblLopHoc.Size = new System.Drawing.Size(299, 69);
            this.lblLopHoc.TabIndex = 80;
            this.lblLopHoc.Text = "LỚP HỌC";
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(452, 848);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(172, 48);
            this.btnThoat.TabIndex = 79;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvLop);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1106, 88);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(897, 854);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách lớp";
            // 
            // dgvLop
            // 
            this.dgvLop.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLop.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvLop.Location = new System.Drawing.Point(4, 38);
            this.dgvLop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvLop.Name = "dgvLop";
            this.dgvLop.RowHeadersWidth = 62;
            this.dgvLop.Size = new System.Drawing.Size(889, 811);
            this.dgvLop.TabIndex = 33;
            this.dgvLop.Click += new System.EventHandler(this.dgvLop_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Location = new System.Drawing.Point(801, 762);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(172, 48);
            this.btnLamMoi.TabIndex = 78;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboGVDN);
            this.groupBox2.Controls.Add(this.lblGVDN);
            this.groupBox2.Controls.Add(this.cboChuyenNganh);
            this.groupBox2.Controls.Add(this.txtMaLH);
            this.groupBox2.Controls.Add(this.lblChuyenNganh);
            this.groupBox2.Controls.Add(this.lblMaLH);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(50, 88);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(1020, 571);
            this.groupBox2.TabIndex = 74;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết";
            // 
            // cboGVDN
            // 
            this.cboGVDN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGVDN.FormattingEnabled = true;
            this.cboGVDN.Location = new System.Drawing.Point(220, 452);
            this.cboGVDN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboGVDN.Name = "cboGVDN";
            this.cboGVDN.Size = new System.Drawing.Size(547, 37);
            this.cboGVDN.TabIndex = 19;
            // 
            // lblGVDN
            // 
            this.lblGVDN.AutoSize = true;
            this.lblGVDN.Location = new System.Drawing.Point(214, 398);
            this.lblGVDN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGVDN.Name = "lblGVDN";
            this.lblGVDN.Size = new System.Drawing.Size(238, 29);
            this.lblGVDN.TabIndex = 17;
            this.lblGVDN.Text = "Giảng viên đảm nhận";
            // 
            // cboChuyenNganh
            // 
            this.cboChuyenNganh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChuyenNganh.FormattingEnabled = true;
            this.cboChuyenNganh.Location = new System.Drawing.Point(220, 294);
            this.cboChuyenNganh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboChuyenNganh.Name = "cboChuyenNganh";
            this.cboChuyenNganh.Size = new System.Drawing.Size(547, 37);
            this.cboChuyenNganh.TabIndex = 15;
            this.cboChuyenNganh.SelectedIndexChanged += new System.EventHandler(this.cboChuyenNganh_SelectedIndexChanged);
            // 
            // txtMaLH
            // 
            this.txtMaLH.Location = new System.Drawing.Point(220, 135);
            this.txtMaLH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaLH.MaxLength = 7;
            this.txtMaLH.Multiline = true;
            this.txtMaLH.Name = "txtMaLH";
            this.txtMaLH.Size = new System.Drawing.Size(547, 42);
            this.txtMaLH.TabIndex = 13;
            this.txtMaLH.Click += new System.EventHandler(this.txtMaLH_Click);
            this.txtMaLH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaLH_KeyPress);
            this.txtMaLH.Leave += new System.EventHandler(this.txtMaLH_Leave);
            // 
            // lblChuyenNganh
            // 
            this.lblChuyenNganh.AutoSize = true;
            this.lblChuyenNganh.Location = new System.Drawing.Point(214, 240);
            this.lblChuyenNganh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChuyenNganh.Name = "lblChuyenNganh";
            this.lblChuyenNganh.Size = new System.Drawing.Size(166, 29);
            this.lblChuyenNganh.TabIndex = 12;
            this.lblChuyenNganh.Text = "Chuyên ngành";
            // 
            // lblMaLH
            // 
            this.lblMaLH.AutoSize = true;
            this.lblMaLH.Location = new System.Drawing.Point(214, 82);
            this.lblMaLH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaLH.Name = "lblMaLH";
            this.lblMaLH.Size = new System.Drawing.Size(131, 29);
            this.lblMaLH.TabIndex = 11;
            this.lblMaLH.Text = "Mã lớp học";
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(336, 762);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(172, 48);
            this.btnXoa.TabIndex = 76;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(567, 762);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(172, 48);
            this.btnSua.TabIndex = 77;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(105, 762);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(172, 48);
            this.btnThem.TabIndex = 75;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // errorMaLH
            // 
            this.errorMaLH.ContainerControl = this;
            // 
            // LOPHOC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1924, 954);
            this.Controls.Add(this.lblLopHoc);
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
            this.Name = "LOPHOC";
            this.Text = "LỚP HỌC";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LOPHOC_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorMaLH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLopHoc;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvLop;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMaLH;
        private System.Windows.Forms.Label lblChuyenNganh;
        private System.Windows.Forms.Label lblMaLH;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cboChuyenNganh;
        private System.Windows.Forms.ComboBox cboGVDN;
        private System.Windows.Forms.Label lblGVDN;
        private System.Windows.Forms.ErrorProvider errorMaLH;
    }
}

