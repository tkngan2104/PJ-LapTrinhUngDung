namespace WindowsFormsApp1
{
    partial class TRACUUTHONGTINSV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TRACUUTHONGTINSV));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.crystalReportViewer2 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptBangDiemCuaSV1 = new _5._2_PROJECT.rptBangDiemCuaSV();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptTTSV1 = new _5._2_PROJECT.rptTTSV();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dgvTraCuuSV = new System.Windows.Forms.DataGridView();
            this.btnInDuLieu = new System.Windows.Forms.Button();
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.radBangDiem = new System.Windows.Forms.RadioButton();
            this.radThongTin = new System.Windows.Forms.RadioButton();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.lblLoaiTT = new System.Windows.Forms.Label();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.errorMaSV = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraCuuSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMaSV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.crystalReportViewer2);
            this.groupBox1.Controls.Add(this.crystalReportViewer1);
            this.groupBox1.Controls.Add(this.btnLamMoi);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.dgvTraCuuSV);
            this.groupBox1.Controls.Add(this.btnInDuLieu);
            this.groupBox1.Controls.Add(this.btnTraCuu);
            this.groupBox1.Controls.Add(this.radBangDiem);
            this.groupBox1.Controls.Add(this.radThongTin);
            this.groupBox1.Controls.Add(this.txtMaSV);
            this.groupBox1.Controls.Add(this.lblLoaiTT);
            this.groupBox1.Controls.Add(this.lblMaSV);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(116, 77);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1778, 857);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TRA CỨU THÔNG TIN SINH VIÊN";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // crystalReportViewer2
            // 
            this.crystalReportViewer2.ActiveViewIndex = 0;
            this.crystalReportViewer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer2.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer2.Location = new System.Drawing.Point(7, 406);
            this.crystalReportViewer2.Name = "crystalReportViewer2";
            this.crystalReportViewer2.ReportSource = this.rptBangDiemCuaSV1;
            this.crystalReportViewer2.Size = new System.Drawing.Size(1771, 443);
            this.crystalReportViewer2.TabIndex = 12;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(4, 406);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.rptTTSV1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1774, 446);
            this.crystalReportViewer1.TabIndex = 11;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Location = new System.Drawing.Point(1562, 155);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(142, 54);
            this.btnLamMoi.TabIndex = 10;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(1562, 277);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(142, 54);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dgvTraCuuSV
            // 
            this.dgvTraCuuSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTraCuuSV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTraCuuSV.Location = new System.Drawing.Point(4, 406);
            this.dgvTraCuuSV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvTraCuuSV.Name = "dgvTraCuuSV";
            this.dgvTraCuuSV.RowHeadersWidth = 62;
            this.dgvTraCuuSV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTraCuuSV.Size = new System.Drawing.Size(1770, 446);
            this.dgvTraCuuSV.TabIndex = 8;
            // 
            // btnInDuLieu
            // 
            this.btnInDuLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInDuLieu.Location = new System.Drawing.Point(1368, 277);
            this.btnInDuLieu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInDuLieu.Name = "btnInDuLieu";
            this.btnInDuLieu.Size = new System.Drawing.Size(142, 54);
            this.btnInDuLieu.TabIndex = 7;
            this.btnInDuLieu.Text = "In dữ liệu";
            this.btnInDuLieu.UseVisualStyleBackColor = true;
            this.btnInDuLieu.Click += new System.EventHandler(this.btnInDuLieu_Click);
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraCuu.Location = new System.Drawing.Point(1368, 155);
            this.btnTraCuu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(142, 54);
            this.btnTraCuu.TabIndex = 6;
            this.btnTraCuu.Text = "Tra cứu";
            this.btnTraCuu.UseVisualStyleBackColor = true;
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // radBangDiem
            // 
            this.radBangDiem.AutoSize = true;
            this.radBangDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBangDiem.Location = new System.Drawing.Point(903, 291);
            this.radBangDiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radBangDiem.Name = "radBangDiem";
            this.radBangDiem.Size = new System.Drawing.Size(295, 36);
            this.radBangDiem.TabIndex = 4;
            this.radBangDiem.Text = "Bảng điểm sinh viên";
            this.radBangDiem.UseVisualStyleBackColor = true;
            // 
            // radThongTin
            // 
            this.radThongTin.AutoSize = true;
            this.radThongTin.Checked = true;
            this.radThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radThongTin.Location = new System.Drawing.Point(572, 291);
            this.radThongTin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radThongTin.Name = "radThongTin";
            this.radThongTin.Size = new System.Drawing.Size(278, 36);
            this.radThongTin.TabIndex = 3;
            this.radThongTin.TabStop = true;
            this.radThongTin.Text = "Thông tin sinh viên";
            this.radThongTin.UseVisualStyleBackColor = true;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(572, 146);
            this.txtMaSV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(630, 53);
            this.txtMaSV.TabIndex = 2;
            // 
            // lblLoaiTT
            // 
            this.lblLoaiTT.AutoSize = true;
            this.lblLoaiTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiTT.Location = new System.Drawing.Point(180, 297);
            this.lblLoaiTT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoaiTT.Name = "lblLoaiTT";
            this.lblLoaiTT.Size = new System.Drawing.Size(287, 32);
            this.lblLoaiTT.TabIndex = 1;
            this.lblLoaiTT.Text = "Loại thông tin tra cứu:";
            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSV.Location = new System.Drawing.Point(180, 162);
            this.lblMaSV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(181, 32);
            this.lblMaSV.TabIndex = 0;
            this.lblMaSV.Text = "Mã sinh viên:";
            // 
            // errorMaSV
            // 
            this.errorMaSV.ContainerControl = this;
            // 
            // TRACUUTHONGTINSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1911, 1005);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TRACUUTHONGTINSV";
            this.Text = "TRA CỨU THÔNG TIN SINH VIÊN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TRACUUTHONGTINSV_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraCuuSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMaSV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radThongTin;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label lblLoaiTT;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.RadioButton radBangDiem;
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.Button btnInDuLieu;
        private System.Windows.Forms.DataGridView dgvTraCuuSV;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ErrorProvider errorMaSV;
        private System.Windows.Forms.Button btnLamMoi;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private _5._2_PROJECT.rptTTSV rptTTSV1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer2;
        private _5._2_PROJECT.rptBangDiemCuaSV rptBangDiemCuaSV1;
    }
}

