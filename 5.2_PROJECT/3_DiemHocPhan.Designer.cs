namespace WindowsFormsApp1
{
    partial class DIEMHOCPHAN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DIEMHOCPHAN));
            this.lblDiemHP = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radHK3 = new System.Windows.Forms.RadioButton();
            this.radHK2 = new System.Windows.Forms.RadioButton();
            this.radHK1 = new System.Windows.Forms.RadioButton();
            this.lblHocKy = new System.Windows.Forms.Label();
            this.lblDiemThi = new System.Windows.Forms.Label();
            this.txtDiemThi = new System.Windows.Forms.TextBox();
            this.cboLopHP = new System.Windows.Forms.ComboBox();
            this.txtXepLoai = new System.Windows.Forms.TextBox();
            this.lblXepLoai = new System.Windows.Forms.Label();
            this.txtDiemHS1 = new System.Windows.Forms.TextBox();
            this.lblDiemHS1 = new System.Windows.Forms.Label();
            this.lblDiemHS2 = new System.Windows.Forms.Label();
            this.txtDiemHS2 = new System.Windows.Forms.TextBox();
            this.lblLopHP = new System.Windows.Forms.Label();
            this.txtDiemTBM = new System.Windows.Forms.TextBox();
            this.lblDiemTBM = new System.Windows.Forms.Label();
            this.txtMaGV = new System.Windows.Forms.TextBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.lblMaGV = new System.Windows.Forms.Label();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDiemHP = new System.Windows.Forms.DataGridView();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.errorMaSV = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorMaGV = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorD1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorD2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDThi = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMaSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMaGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorD1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorD2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDThi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDiemHP
            // 
            this.lblDiemHP.AutoSize = true;
            this.lblDiemHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiemHP.Location = new System.Drawing.Point(741, 14);
            this.lblDiemHP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiemHP.Name = "lblDiemHP";
            this.lblDiemHP.Size = new System.Drawing.Size(511, 69);
            this.lblDiemHP.TabIndex = 48;
            this.lblDiemHP.Text = "ĐIỂM HỌC PHẦN";
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(1652, 338);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(172, 48);
            this.btnThoat.TabIndex = 47;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(1560, 258);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(172, 48);
            this.btnSua.TabIndex = 45;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(1560, 172);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(172, 48);
            this.btnThem.TabIndex = 43;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radHK3);
            this.groupBox2.Controls.Add(this.radHK2);
            this.groupBox2.Controls.Add(this.radHK1);
            this.groupBox2.Controls.Add(this.lblHocKy);
            this.groupBox2.Controls.Add(this.lblDiemThi);
            this.groupBox2.Controls.Add(this.txtDiemThi);
            this.groupBox2.Controls.Add(this.cboLopHP);
            this.groupBox2.Controls.Add(this.txtXepLoai);
            this.groupBox2.Controls.Add(this.lblXepLoai);
            this.groupBox2.Controls.Add(this.txtDiemHS1);
            this.groupBox2.Controls.Add(this.lblDiemHS1);
            this.groupBox2.Controls.Add(this.lblDiemHS2);
            this.groupBox2.Controls.Add(this.txtDiemHS2);
            this.groupBox2.Controls.Add(this.lblLopHP);
            this.groupBox2.Controls.Add(this.txtDiemTBM);
            this.groupBox2.Controls.Add(this.lblDiemTBM);
            this.groupBox2.Controls.Add(this.txtMaGV);
            this.groupBox2.Controls.Add(this.txtMaSV);
            this.groupBox2.Controls.Add(this.lblMaGV);
            this.groupBox2.Controls.Add(this.lblMaSV);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(48, 89);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(1504, 601);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // radHK3
            // 
            this.radHK3.AutoSize = true;
            this.radHK3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radHK3.Location = new System.Drawing.Point(405, 132);
            this.radHK3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radHK3.Name = "radHK3";
            this.radHK3.Size = new System.Drawing.Size(51, 33);
            this.radHK3.TabIndex = 40;
            this.radHK3.Text = "3";
            this.radHK3.UseVisualStyleBackColor = true;
            // 
            // radHK2
            // 
            this.radHK2.AutoSize = true;
            this.radHK2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radHK2.Location = new System.Drawing.Point(230, 134);
            this.radHK2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radHK2.Name = "radHK2";
            this.radHK2.Size = new System.Drawing.Size(51, 33);
            this.radHK2.TabIndex = 39;
            this.radHK2.Text = "2";
            this.radHK2.UseVisualStyleBackColor = true;
            // 
            // radHK1
            // 
            this.radHK1.AutoSize = true;
            this.radHK1.Checked = true;
            this.radHK1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radHK1.Location = new System.Drawing.Point(56, 134);
            this.radHK1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radHK1.Name = "radHK1";
            this.radHK1.Size = new System.Drawing.Size(51, 33);
            this.radHK1.TabIndex = 38;
            this.radHK1.TabStop = true;
            this.radHK1.Text = "1";
            this.radHK1.UseVisualStyleBackColor = true;
            // 
            // lblHocKy
            // 
            this.lblHocKy.AutoSize = true;
            this.lblHocKy.Location = new System.Drawing.Point(50, 72);
            this.lblHocKy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHocKy.Name = "lblHocKy";
            this.lblHocKy.Size = new System.Drawing.Size(85, 29);
            this.lblHocKy.TabIndex = 37;
            this.lblHocKy.Text = "Học kỳ";
            // 
            // lblDiemThi
            // 
            this.lblDiemThi.AutoSize = true;
            this.lblDiemThi.Location = new System.Drawing.Point(1040, 415);
            this.lblDiemThi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiemThi.Name = "lblDiemThi";
            this.lblDiemThi.Size = new System.Drawing.Size(101, 29);
            this.lblDiemThi.TabIndex = 32;
            this.lblDiemThi.Text = "Điểm thi";
            // 
            // txtDiemThi
            // 
            this.txtDiemThi.Location = new System.Drawing.Point(1046, 474);
            this.txtDiemThi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDiemThi.Multiline = true;
            this.txtDiemThi.Name = "txtDiemThi";
            this.txtDiemThi.Size = new System.Drawing.Size(402, 39);
            this.txtDiemThi.TabIndex = 33;
            this.txtDiemThi.Click += new System.EventHandler(this.txtDiemThi_Click);
            this.txtDiemThi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiemThi_KeyPress);
            this.txtDiemThi.Leave += new System.EventHandler(this.txtDiemThi_Leave);
            // 
            // cboLopHP
            // 
            this.cboLopHP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLopHP.FormattingEnabled = true;
            this.cboLopHP.Location = new System.Drawing.Point(552, 128);
            this.cboLopHP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboLopHP.Name = "cboLopHP";
            this.cboLopHP.Size = new System.Drawing.Size(402, 37);
            this.cboLopHP.TabIndex = 31;
            // 
            // txtXepLoai
            // 
            this.txtXepLoai.Enabled = false;
            this.txtXepLoai.Location = new System.Drawing.Point(56, 474);
            this.txtXepLoai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtXepLoai.Multiline = true;
            this.txtXepLoai.Name = "txtXepLoai";
            this.txtXepLoai.Size = new System.Drawing.Size(402, 42);
            this.txtXepLoai.TabIndex = 30;
            // 
            // lblXepLoai
            // 
            this.lblXepLoai.AutoSize = true;
            this.lblXepLoai.Location = new System.Drawing.Point(50, 415);
            this.lblXepLoai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblXepLoai.Name = "lblXepLoai";
            this.lblXepLoai.Size = new System.Drawing.Size(103, 29);
            this.lblXepLoai.TabIndex = 29;
            this.lblXepLoai.Text = "Xếp loại";
            // 
            // txtDiemHS1
            // 
            this.txtDiemHS1.Location = new System.Drawing.Point(1046, 128);
            this.txtDiemHS1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDiemHS1.Multiline = true;
            this.txtDiemHS1.Name = "txtDiemHS1";
            this.txtDiemHS1.Size = new System.Drawing.Size(402, 42);
            this.txtDiemHS1.TabIndex = 28;
            this.txtDiemHS1.Click += new System.EventHandler(this.txtDiemHS1_Click);
            this.txtDiemHS1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiemHS1_KeyPress);
            this.txtDiemHS1.Leave += new System.EventHandler(this.txtDiemHS1_Leave);
            // 
            // lblDiemHS1
            // 
            this.lblDiemHS1.AutoSize = true;
            this.lblDiemHS1.Location = new System.Drawing.Point(1040, 72);
            this.lblDiemHS1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiemHS1.Name = "lblDiemHS1";
            this.lblDiemHS1.Size = new System.Drawing.Size(167, 29);
            this.lblDiemHS1.TabIndex = 27;
            this.lblDiemHS1.Text = "Điểm hệ số 01";
            // 
            // lblDiemHS2
            // 
            this.lblDiemHS2.AutoSize = true;
            this.lblDiemHS2.Location = new System.Drawing.Point(1040, 248);
            this.lblDiemHS2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiemHS2.Name = "lblDiemHS2";
            this.lblDiemHS2.Size = new System.Drawing.Size(167, 29);
            this.lblDiemHS2.TabIndex = 23;
            this.lblDiemHS2.Text = "Điểm hệ số 02";
            // 
            // txtDiemHS2
            // 
            this.txtDiemHS2.Location = new System.Drawing.Point(1046, 302);
            this.txtDiemHS2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDiemHS2.Multiline = true;
            this.txtDiemHS2.Name = "txtDiemHS2";
            this.txtDiemHS2.Size = new System.Drawing.Size(402, 39);
            this.txtDiemHS2.TabIndex = 24;
            this.txtDiemHS2.Click += new System.EventHandler(this.txtDiemHS2_Click);
            this.txtDiemHS2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiemHS2_KeyPress);
            this.txtDiemHS2.Leave += new System.EventHandler(this.txtDiemHS2_Leave);
            // 
            // lblLopHP
            // 
            this.lblLopHP.AutoSize = true;
            this.lblLopHP.Location = new System.Drawing.Point(546, 72);
            this.lblLopHP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLopHP.Name = "lblLopHP";
            this.lblLopHP.Size = new System.Drawing.Size(158, 29);
            this.lblLopHP.TabIndex = 19;
            this.lblLopHP.Text = "Lớp học phần";
            // 
            // txtDiemTBM
            // 
            this.txtDiemTBM.Enabled = false;
            this.txtDiemTBM.Location = new System.Drawing.Point(552, 474);
            this.txtDiemTBM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDiemTBM.Multiline = true;
            this.txtDiemTBM.Name = "txtDiemTBM";
            this.txtDiemTBM.ReadOnly = true;
            this.txtDiemTBM.Size = new System.Drawing.Size(402, 42);
            this.txtDiemTBM.TabIndex = 17;
            // 
            // lblDiemTBM
            // 
            this.lblDiemTBM.AutoSize = true;
            this.lblDiemTBM.Location = new System.Drawing.Point(546, 418);
            this.lblDiemTBM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiemTBM.Name = "lblDiemTBM";
            this.lblDiemTBM.Size = new System.Drawing.Size(235, 29);
            this.lblDiemTBM.TabIndex = 16;
            this.lblDiemTBM.Text = "Điểm trung bình môn";
            // 
            // txtMaGV
            // 
            this.txtMaGV.Location = new System.Drawing.Point(552, 302);
            this.txtMaGV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaGV.MaxLength = 11;
            this.txtMaGV.Multiline = true;
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(402, 42);
            this.txtMaGV.TabIndex = 14;
            this.txtMaGV.Click += new System.EventHandler(this.txtMaGV_Click);
            this.txtMaGV.TextChanged += new System.EventHandler(this.txtMaGV_TextChanged);
            this.txtMaGV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaGV_KeyPress);
            this.txtMaGV.Leave += new System.EventHandler(this.txtMaGV_Leave);
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(56, 302);
            this.txtMaSV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaSV.Multiline = true;
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(402, 42);
            this.txtMaSV.TabIndex = 13;
            this.txtMaSV.Click += new System.EventHandler(this.txtMaSV_Click);
            this.txtMaSV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaSV_KeyPress);
            this.txtMaSV.Leave += new System.EventHandler(this.txtMaSV_Leave);
            // 
            // lblMaGV
            // 
            this.lblMaGV.AutoSize = true;
            this.lblMaGV.Location = new System.Drawing.Point(546, 248);
            this.lblMaGV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaGV.Name = "lblMaGV";
            this.lblMaGV.Size = new System.Drawing.Size(194, 29);
            this.lblMaGV.TabIndex = 12;
            this.lblMaGV.Text = "Mã số giảng viên";
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
            this.groupBox1.Controls.Add(this.dgvDiemHP);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(48, 691);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1953, 252);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách sinh viên đã cập nhật điểm";
            // 
            // dgvDiemHP
            // 
            this.dgvDiemHP.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDiemHP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiemHP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDiemHP.Location = new System.Drawing.Point(4, 32);
            this.dgvDiemHP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDiemHP.Name = "dgvDiemHP";
            this.dgvDiemHP.RowHeadersWidth = 62;
            this.dgvDiemHP.Size = new System.Drawing.Size(1945, 215);
            this.dgvDiemHP.TabIndex = 33;
            this.dgvDiemHP.Click += new System.EventHandler(this.dgvDiemHP_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Location = new System.Drawing.Point(1750, 258);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(172, 48);
            this.btnLamMoi.TabIndex = 46;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(1750, 172);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(172, 48);
            this.btnXoa.TabIndex = 44;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // errorMaSV
            // 
            this.errorMaSV.ContainerControl = this;
            // 
            // errorMaGV
            // 
            this.errorMaGV.ContainerControl = this;
            // 
            // errorD1
            // 
            this.errorD1.ContainerControl = this;
            // 
            // errorD2
            // 
            this.errorD2.ContainerControl = this;
            // 
            // errorDThi
            // 
            this.errorDThi.ContainerControl = this;
            // 
            // DIEMHOCPHAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 978);
            this.Controls.Add(this.lblDiemHP);
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
            this.Name = "DIEMHOCPHAN";
            this.Text = "ĐIỂM HỌC PHẦN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DIEMHOCPHAN_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMaSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMaGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorD1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorD2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDThi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDiemHP;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDiemHS1;
        private System.Windows.Forms.Label lblDiemHS1;
        private System.Windows.Forms.Label lblDiemHS2;
        private System.Windows.Forms.TextBox txtDiemHS2;
        private System.Windows.Forms.Label lblLopHP;
        private System.Windows.Forms.TextBox txtDiemTBM;
        private System.Windows.Forms.Label lblDiemTBM;
        private System.Windows.Forms.TextBox txtMaGV;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label lblMaGV;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDiemHP;
        private System.Windows.Forms.TextBox txtXepLoai;
        private System.Windows.Forms.Label lblXepLoai;
        private System.Windows.Forms.Label lblDiemThi;
        private System.Windows.Forms.TextBox txtDiemThi;
        private System.Windows.Forms.ComboBox cboLopHP;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.RadioButton radHK3;
        private System.Windows.Forms.RadioButton radHK2;
        private System.Windows.Forms.RadioButton radHK1;
        private System.Windows.Forms.Label lblHocKy;
        private System.Windows.Forms.ErrorProvider errorMaSV;
        private System.Windows.Forms.ErrorProvider errorMaGV;
        private System.Windows.Forms.ErrorProvider errorD1;
        private System.Windows.Forms.ErrorProvider errorD2;
        private System.Windows.Forms.ErrorProvider errorDThi;
    }
}

