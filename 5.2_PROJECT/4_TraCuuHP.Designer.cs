namespace WindowsFormsApp5
{
    partial class TRACUUDANHSACHHP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TRACUUDANHSACHHP));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.crystalReportViewer2 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptTTHPBangTenHP1 = new _5._2_PROJECT.rptTTHPBangTenHP();
            this.radMaHP = new System.Windows.Forms.RadioButton();
            this.radTenHP = new System.Windows.Forms.RadioButton();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptTTHP1 = new _5._2_PROJECT.rptTTHP();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnInDuLieu = new System.Windows.Forms.Button();
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.dgvTraCuuHP = new System.Windows.Forms.DataGridView();
            this.txtMaHP = new System.Windows.Forms.TextBox();
            this.lblMaHP = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraCuuHP)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.crystalReportViewer2);
            this.groupBox1.Controls.Add(this.radMaHP);
            this.groupBox1.Controls.Add(this.radTenHP);
            this.groupBox1.Controls.Add(this.crystalReportViewer1);
            this.groupBox1.Controls.Add(this.btnLamMoi);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnInDuLieu);
            this.groupBox1.Controls.Add(this.btnTraCuu);
            this.groupBox1.Controls.Add(this.dgvTraCuuHP);
            this.groupBox1.Controls.Add(this.txtMaHP);
            this.groupBox1.Controls.Add(this.lblMaHP);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(99, 80);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1778, 872);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TRA CỨU THÔNG TIN HỌC PHẦN";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // crystalReportViewer2
            // 
            this.crystalReportViewer2.ActiveViewIndex = 0;
            this.crystalReportViewer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer2.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer2.Location = new System.Drawing.Point(8, 445);
            this.crystalReportViewer2.Name = "crystalReportViewer2";
            this.crystalReportViewer2.ReportSource = this.rptTTHPBangTenHP1;
            this.crystalReportViewer2.Size = new System.Drawing.Size(1763, 301);
            this.crystalReportViewer2.TabIndex = 18;
            // 
            // radMaHP
            // 
            this.radMaHP.AutoSize = true;
            this.radMaHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMaHP.Location = new System.Drawing.Point(1071, 306);
            this.radMaHP.Name = "radMaHP";
            this.radMaHP.Size = new System.Drawing.Size(129, 36);
            this.radMaHP.TabIndex = 17;
            this.radMaHP.Text = "Mã HP";
            this.radMaHP.UseVisualStyleBackColor = true;
            // 
            // radTenHP
            // 
            this.radTenHP.AutoSize = true;
            this.radTenHP.Checked = true;
            this.radTenHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTenHP.Location = new System.Drawing.Point(562, 295);
            this.radTenHP.Name = "radTenHP";
            this.radTenHP.Size = new System.Drawing.Size(140, 36);
            this.radTenHP.TabIndex = 16;
            this.radTenHP.TabStop = true;
            this.radTenHP.Text = "Tên HP";
            this.radTenHP.UseVisualStyleBackColor = true;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(4, 445);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.rptTTHP1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1770, 301);
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
            // dgvTraCuuHP
            // 
            this.dgvTraCuuHP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTraCuuHP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTraCuuHP.Location = new System.Drawing.Point(4, 445);
            this.dgvTraCuuHP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvTraCuuHP.Name = "dgvTraCuuHP";
            this.dgvTraCuuHP.RowHeadersWidth = 62;
            this.dgvTraCuuHP.Size = new System.Drawing.Size(1770, 422);
            this.dgvTraCuuHP.TabIndex = 8;
            // 
            // txtMaHP
            // 
            this.txtMaHP.Location = new System.Drawing.Point(562, 211);
            this.txtMaHP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaHP.Name = "txtMaHP";
            this.txtMaHP.Size = new System.Drawing.Size(684, 53);
            this.txtMaHP.TabIndex = 2;
            // 
            // lblMaHP
            // 
            this.lblMaHP.AutoSize = true;
            this.lblMaHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHP.Location = new System.Drawing.Point(379, 232);
            this.lblMaHP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaHP.Name = "lblMaHP";
            this.lblMaHP.Size = new System.Drawing.Size(124, 32);
            this.lblMaHP.TabIndex = 0;
            this.lblMaHP.Text = "Từ khóa:";
            // 
            // TRACUUDANHSACHHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1910, 823);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TRACUUDANHSACHHP";
            this.Text = "TRA CỨU DANH SÁCH HỌC PHẦN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TRACUUDANHSACHHP_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraCuuHP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnInDuLieu;
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.DataGridView dgvTraCuuHP;
        private System.Windows.Forms.TextBox txtMaHP;
        private System.Windows.Forms.Label lblMaHP;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private _5._2_PROJECT.rptTTHP rptTTHP1;
        private System.Windows.Forms.RadioButton radMaHP;
        private System.Windows.Forms.RadioButton radTenHP;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer2;
        private _5._2_PROJECT.rptTTHPBangTenHP rptTTHPBangTenHP1;
    }
}

