namespace WindowsFormsApp3
{
    partial class TRACUDANHSACHLOPHOC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TRACUDANHSACHLOPHOC));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.crystalReportViewer2 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptDSSVLopHoc1 = new _5._2_PROJECT.rptDSSVLopHoc();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptTTLopHoc1 = new _5._2_PROJECT.rptTTLopHoc();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnInDuLieu = new System.Windows.Forms.Button();
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.dgvTraCuuLH = new System.Windows.Forms.DataGridView();
            this.radSVLop = new System.Windows.Forms.RadioButton();
            this.radThongTin = new System.Windows.Forms.RadioButton();
            this.txtMaLH = new System.Windows.Forms.TextBox();
            this.lblLoaiTT = new System.Windows.Forms.Label();
            this.lblMaLH = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraCuuLH)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.crystalReportViewer2);
            this.groupBox1.Controls.Add(this.crystalReportViewer1);
            this.groupBox1.Controls.Add(this.btnLamMoi);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnInDuLieu);
            this.groupBox1.Controls.Add(this.btnTraCuu);
            this.groupBox1.Controls.Add(this.dgvTraCuuLH);
            this.groupBox1.Controls.Add(this.radSVLop);
            this.groupBox1.Controls.Add(this.radThongTin);
            this.groupBox1.Controls.Add(this.txtMaLH);
            this.groupBox1.Controls.Add(this.lblLoaiTT);
            this.groupBox1.Controls.Add(this.lblMaLH);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(87, 63);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1778, 872);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TRA CỨU THÔNG TIN LỚP HỌC";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // crystalReportViewer2
            // 
            this.crystalReportViewer2.ActiveViewIndex = 0;
            this.crystalReportViewer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer2.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer2.Location = new System.Drawing.Point(0, 445);
            this.crystalReportViewer2.Name = "crystalReportViewer2";
            this.crystalReportViewer2.ReportSource = this.rptDSSVLopHoc1;
            this.crystalReportViewer2.Size = new System.Drawing.Size(1746, 318);
            this.crystalReportViewer2.TabIndex = 16;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 445);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.rptTTLopHoc1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1746, 318);
            this.crystalReportViewer1.TabIndex = 15;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Location = new System.Drawing.Point(1566, 158);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(142, 54);
            this.btnLamMoi.TabIndex = 14;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(1566, 288);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(142, 54);
            this.btnThoat.TabIndex = 13;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnInDuLieu
            // 
            this.btnInDuLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInDuLieu.Location = new System.Drawing.Point(1372, 288);
            this.btnInDuLieu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInDuLieu.Name = "btnInDuLieu";
            this.btnInDuLieu.Size = new System.Drawing.Size(142, 54);
            this.btnInDuLieu.TabIndex = 12;
            this.btnInDuLieu.Text = "In dữ liệu";
            this.btnInDuLieu.UseVisualStyleBackColor = true;
            this.btnInDuLieu.Click += new System.EventHandler(this.btnInDuLieu_Click);
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraCuu.Location = new System.Drawing.Point(1372, 158);
            this.btnTraCuu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(142, 54);
            this.btnTraCuu.TabIndex = 11;
            this.btnTraCuu.Text = "Tra cứu";
            this.btnTraCuu.UseVisualStyleBackColor = true;
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // dgvTraCuuLH
            // 
            this.dgvTraCuuLH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTraCuuLH.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTraCuuLH.Location = new System.Drawing.Point(4, 445);
            this.dgvTraCuuLH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvTraCuuLH.Name = "dgvTraCuuLH";
            this.dgvTraCuuLH.RowHeadersWidth = 62;
            this.dgvTraCuuLH.Size = new System.Drawing.Size(1770, 422);
            this.dgvTraCuuLH.TabIndex = 8;
            // 
            // radSVLop
            // 
            this.radSVLop.AutoSize = true;
            this.radSVLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSVLop.Location = new System.Drawing.Point(932, 298);
            this.radSVLop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radSVLop.Name = "radSVLop";
            this.radSVLop.Size = new System.Drawing.Size(309, 36);
            this.radSVLop.TabIndex = 4;
            this.radSVLop.Text = "Sinh viên của lớp học";
            this.radSVLop.UseVisualStyleBackColor = true;
            // 
            // radThongTin
            // 
            this.radThongTin.AutoSize = true;
            this.radThongTin.Checked = true;
            this.radThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radThongTin.Location = new System.Drawing.Point(561, 298);
            this.radThongTin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radThongTin.Name = "radThongTin";
            this.radThongTin.Size = new System.Drawing.Size(257, 36);
            this.radThongTin.TabIndex = 3;
            this.radThongTin.TabStop = true;
            this.radThongTin.Text = "Thông tin lớp học";
            this.radThongTin.UseVisualStyleBackColor = true;
            // 
            // txtMaLH
            // 
            this.txtMaLH.Location = new System.Drawing.Point(561, 154);
            this.txtMaLH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaLH.Name = "txtMaLH";
            this.txtMaLH.Size = new System.Drawing.Size(684, 53);
            this.txtMaLH.TabIndex = 2;
            // 
            // lblLoaiTT
            // 
            this.lblLoaiTT.AutoSize = true;
            this.lblLoaiTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiTT.Location = new System.Drawing.Point(170, 305);
            this.lblLoaiTT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoaiTT.Name = "lblLoaiTT";
            this.lblLoaiTT.Size = new System.Drawing.Size(287, 32);
            this.lblLoaiTT.TabIndex = 1;
            this.lblLoaiTT.Text = "Loại thông tin tra cứu:";
            // 
            // lblMaLH
            // 
            this.lblMaLH.AutoSize = true;
            this.lblMaLH.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaLH.Location = new System.Drawing.Point(170, 169);
            this.lblMaLH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaLH.Name = "lblMaLH";
            this.lblMaLH.Size = new System.Drawing.Size(160, 32);
            this.lblMaLH.TabIndex = 0;
            this.lblMaLH.Text = "Mã lớp học:";
            // 
            // TRACUDANHSACHLOPHOC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1856, 852);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TRACUDANHSACHLOPHOC";
            this.Text = "TRA CỨU DANH SÁCH LỚP HỌC";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TRACUDANHSACHLOPHOC_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraCuuLH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnInDuLieu;
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.DataGridView dgvTraCuuLH;
        private System.Windows.Forms.RadioButton radSVLop;
        private System.Windows.Forms.RadioButton radThongTin;
        private System.Windows.Forms.TextBox txtMaLH;
        private System.Windows.Forms.Label lblLoaiTT;
        private System.Windows.Forms.Label lblMaLH;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private _5._2_PROJECT.rptTTLopHoc rptTTLopHoc1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer2;
        private _5._2_PROJECT.rptDSSVLopHoc rptDSSVLopHoc1;
    }
}

