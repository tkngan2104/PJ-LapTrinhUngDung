namespace WindowsFormsApp1
{
    partial class CHUYENNGANH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CHUYENNGANH));
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lblMaCN = new System.Windows.Forms.Label();
            this.lblTenCN = new System.Windows.Forms.Label();
            this.txtMaCN = new System.Windows.Forms.TextBox();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.cboKhoa = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTenCN = new System.Windows.Forms.TextBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.dgvCN = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblCNganh = new System.Windows.Forms.Label();
            this.errorMaCN = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorTenCN = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCN)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorMaCN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTenCN)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(105, 762);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(172, 48);
            this.btnThem.TabIndex = 83;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(567, 762);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(172, 48);
            this.btnSua.TabIndex = 85;
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
            this.btnXoa.TabIndex = 84;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lblMaCN
            // 
            this.lblMaCN.AutoSize = true;
            this.lblMaCN.Location = new System.Drawing.Point(214, 82);
            this.lblMaCN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaCN.Name = "lblMaCN";
            this.lblMaCN.Size = new System.Drawing.Size(200, 29);
            this.lblMaCN.TabIndex = 11;
            this.lblMaCN.Text = "Mã chuyên ngành";
            // 
            // lblTenCN
            // 
            this.lblTenCN.AutoSize = true;
            this.lblTenCN.Location = new System.Drawing.Point(214, 240);
            this.lblTenCN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenCN.Name = "lblTenCN";
            this.lblTenCN.Size = new System.Drawing.Size(210, 29);
            this.lblTenCN.TabIndex = 12;
            this.lblTenCN.Text = "Tên chuyên ngành";
            // 
            // txtMaCN
            // 
            this.txtMaCN.Location = new System.Drawing.Point(220, 135);
            this.txtMaCN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaCN.MaxLength = 8;
            this.txtMaCN.Multiline = true;
            this.txtMaCN.Name = "txtMaCN";
            this.txtMaCN.Size = new System.Drawing.Size(547, 42);
            this.txtMaCN.TabIndex = 13;
            this.txtMaCN.Click += new System.EventHandler(this.txtMaCN_Click);
            this.txtMaCN.TextChanged += new System.EventHandler(this.txtMaCN_TextChanged);
            this.txtMaCN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaCN_KeyPress);
            this.txtMaCN.Leave += new System.EventHandler(this.txtMaCN_Leave);
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Location = new System.Drawing.Point(214, 398);
            this.lblKhoa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(69, 29);
            this.lblKhoa.TabIndex = 17;
            this.lblKhoa.Text = "Khoa";
            // 
            // cboKhoa
            // 
            this.cboKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhoa.FormattingEnabled = true;
            this.cboKhoa.Location = new System.Drawing.Point(220, 452);
            this.cboKhoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboKhoa.Name = "cboKhoa";
            this.cboKhoa.Size = new System.Drawing.Size(547, 37);
            this.cboKhoa.TabIndex = 19;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTenCN);
            this.groupBox2.Controls.Add(this.cboKhoa);
            this.groupBox2.Controls.Add(this.lblKhoa);
            this.groupBox2.Controls.Add(this.txtMaCN);
            this.groupBox2.Controls.Add(this.lblTenCN);
            this.groupBox2.Controls.Add(this.lblMaCN);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(50, 88);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(1020, 571);
            this.groupBox2.TabIndex = 82;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết";
            // 
            // txtTenCN
            // 
            this.txtTenCN.Location = new System.Drawing.Point(220, 294);
            this.txtTenCN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenCN.Multiline = true;
            this.txtTenCN.Name = "txtTenCN";
            this.txtTenCN.Size = new System.Drawing.Size(547, 42);
            this.txtTenCN.TabIndex = 20;
            this.txtTenCN.Click += new System.EventHandler(this.txtTenCN_Click);
            this.txtTenCN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenCN_KeyPress);
            this.txtTenCN.Leave += new System.EventHandler(this.txtTenCN_Leave);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Location = new System.Drawing.Point(801, 762);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(172, 48);
            this.btnLamMoi.TabIndex = 86;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // dgvCN
            // 
            this.dgvCN.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCN.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvCN.Location = new System.Drawing.Point(4, 38);
            this.dgvCN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvCN.Name = "dgvCN";
            this.dgvCN.RowHeadersWidth = 62;
            this.dgvCN.Size = new System.Drawing.Size(889, 811);
            this.dgvCN.TabIndex = 33;
            this.dgvCN.Click += new System.EventHandler(this.dgvCN_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvCN);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1106, 88);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(897, 854);
            this.groupBox1.TabIndex = 81;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách chuyên ngành";
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(452, 848);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(172, 48);
            this.btnThoat.TabIndex = 87;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lblCNganh
            // 
            this.lblCNganh.AutoSize = true;
            this.lblCNganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCNganh.Location = new System.Drawing.Point(813, 12);
            this.lblCNganh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCNganh.Name = "lblCNganh";
            this.lblCNganh.Size = new System.Drawing.Size(514, 69);
            this.lblCNganh.TabIndex = 88;
            this.lblCNganh.Text = "CHUYÊN NGÀNH";
            // 
            // errorMaCN
            // 
            this.errorMaCN.ContainerControl = this;
            // 
            // errorTenCN
            // 
            this.errorTenCN.ContainerControl = this;
            // 
            // CHUYENNGANH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1924, 921);
            this.Controls.Add(this.lblCNganh);
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
            this.Name = "CHUYENNGANH";
            this.Text = "CHUYÊN NGÀNH";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CHUYENNGANH_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCN)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorMaCN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTenCN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label lblMaCN;
        private System.Windows.Forms.Label lblTenCN;
        private System.Windows.Forms.TextBox txtMaCN;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.ComboBox cboKhoa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.DataGridView dgvCN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblCNganh;
        private System.Windows.Forms.TextBox txtTenCN;
        private System.Windows.Forms.ErrorProvider errorMaCN;
        private System.Windows.Forms.ErrorProvider errorTenCN;
    }
}

