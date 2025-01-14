namespace WindowsFormsApp1
{
    partial class LOPHOCPHAN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOPHOCPHAN));
            this.lblLopHocPhan = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvLHP = new System.Windows.Forms.DataGridView();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboHP = new System.Windows.Forms.ComboBox();
            this.txtPH = new System.Windows.Forms.TextBox();
            this.lblPH = new System.Windows.Forms.Label();
            this.txtMaLopHP = new System.Windows.Forms.TextBox();
            this.lblTenHP = new System.Windows.Forms.Label();
            this.lblMaLHP = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.errorMaLHP = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorMaPH = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLHP)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorMaLHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMaPH)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLopHocPhan
            // 
            this.lblLopHocPhan.AutoSize = true;
            this.lblLopHocPhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLopHocPhan.Location = new System.Drawing.Point(824, 14);
            this.lblLopHocPhan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLopHocPhan.Name = "lblLopHocPhan";
            this.lblLopHocPhan.Size = new System.Drawing.Size(481, 69);
            this.lblLopHocPhan.TabIndex = 64;
            this.lblLopHocPhan.Text = "LỚP HỌC PHẦN";
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(452, 848);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(172, 48);
            this.btnThoat.TabIndex = 63;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvLHP);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1106, 88);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(897, 854);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách lớp học phần";
            // 
            // dgvLHP
            // 
            this.dgvLHP.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvLHP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLHP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvLHP.Location = new System.Drawing.Point(4, 38);
            this.dgvLHP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvLHP.Name = "dgvLHP";
            this.dgvLHP.RowHeadersWidth = 62;
            this.dgvLHP.Size = new System.Drawing.Size(889, 811);
            this.dgvLHP.TabIndex = 33;
            this.dgvLHP.Click += new System.EventHandler(this.dgvLHP_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Location = new System.Drawing.Point(801, 762);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(172, 48);
            this.btnLamMoi.TabIndex = 62;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboHP);
            this.groupBox2.Controls.Add(this.txtPH);
            this.groupBox2.Controls.Add(this.lblPH);
            this.groupBox2.Controls.Add(this.txtMaLopHP);
            this.groupBox2.Controls.Add(this.lblTenHP);
            this.groupBox2.Controls.Add(this.lblMaLHP);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(50, 88);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(1020, 571);
            this.groupBox2.TabIndex = 58;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết";
            // 
            // cboHP
            // 
            this.cboHP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHP.FormattingEnabled = true;
            this.cboHP.Location = new System.Drawing.Point(550, 194);
            this.cboHP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboHP.Name = "cboHP";
            this.cboHP.Size = new System.Drawing.Size(402, 37);
            this.cboHP.TabIndex = 19;
            // 
            // txtPH
            // 
            this.txtPH.Location = new System.Drawing.Point(56, 389);
            this.txtPH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPH.Multiline = true;
            this.txtPH.Name = "txtPH";
            this.txtPH.Size = new System.Drawing.Size(402, 42);
            this.txtPH.TabIndex = 17;
            this.txtPH.Click += new System.EventHandler(this.txtPH_Click);
            this.txtPH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPH_KeyPress);
            this.txtPH.Leave += new System.EventHandler(this.txtPH_Leave);
            // 
            // lblPH
            // 
            this.lblPH.AutoSize = true;
            this.lblPH.Location = new System.Drawing.Point(50, 338);
            this.lblPH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPH.Name = "lblPH";
            this.lblPH.Size = new System.Drawing.Size(128, 29);
            this.lblPH.TabIndex = 16;
            this.lblPH.Text = "Phòng học";
            // 
            // txtMaLopHP
            // 
            this.txtMaLopHP.Location = new System.Drawing.Point(54, 194);
            this.txtMaLopHP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaLopHP.MaxLength = 11;
            this.txtMaLopHP.Multiline = true;
            this.txtMaLopHP.Name = "txtMaLopHP";
            this.txtMaLopHP.Size = new System.Drawing.Size(402, 42);
            this.txtMaLopHP.TabIndex = 13;
            this.txtMaLopHP.Click += new System.EventHandler(this.txtMaLopHP_Click);
            this.txtMaLopHP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaLopHP_KeyPress);
            this.txtMaLopHP.Leave += new System.EventHandler(this.txtMaLopHP_Leave);
            // 
            // lblTenHP
            // 
            this.lblTenHP.AutoSize = true;
            this.lblTenHP.Location = new System.Drawing.Point(544, 140);
            this.lblTenHP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenHP.Name = "lblTenHP";
            this.lblTenHP.Size = new System.Drawing.Size(160, 29);
            this.lblTenHP.TabIndex = 12;
            this.lblTenHP.Text = "Tên học phần";
            // 
            // lblMaLHP
            // 
            this.lblMaLHP.AutoSize = true;
            this.lblMaLHP.Location = new System.Drawing.Point(48, 140);
            this.lblMaLHP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaLHP.Name = "lblMaLHP";
            this.lblMaLHP.Size = new System.Drawing.Size(190, 29);
            this.lblMaLHP.TabIndex = 11;
            this.lblMaLHP.Text = "Mã lớp học phần";
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(336, 762);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(172, 48);
            this.btnXoa.TabIndex = 60;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(567, 762);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(172, 48);
            this.btnSua.TabIndex = 61;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click_1);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(105, 762);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(172, 48);
            this.btnThem.TabIndex = 59;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // errorMaLHP
            // 
            this.errorMaLHP.ContainerControl = this;
            // 
            // errorMaPH
            // 
            this.errorMaPH.ContainerControl = this;
            // 
            // LOPHOCPHAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1924, 934);
            this.Controls.Add(this.lblLopHocPhan);
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
            this.Name = "LOPHOCPHAN";
            this.Text = "LỚP HỌC PHẦN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LOPHOCPHAN_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLHP)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorMaLHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMaPH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLopHocPhan;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvLHP;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPH;
        private System.Windows.Forms.Label lblPH;
        private System.Windows.Forms.TextBox txtMaLopHP;
        private System.Windows.Forms.Label lblTenHP;
        private System.Windows.Forms.Label lblMaLHP;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cboHP;
        private System.Windows.Forms.ErrorProvider errorMaLHP;
        private System.Windows.Forms.ErrorProvider errorMaPH;
    }
}

