namespace _5._2_PROJECT
{
    partial class TraCuuChuyenNganh
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.crystalReportViewer2 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptDSHocPhanTheoMaCN1 = new _5._2_PROJECT.rptDSHocPhanTheoMaCN();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptTTChuyenNganhBangMaCN1 = new _5._2_PROJECT.rptTTChuyenNganhBangMaCN();
            this.radDSHP = new System.Windows.Forms.RadioButton();
            this.radTTCN = new System.Windows.Forms.RadioButton();
            this.dgvTraCuu = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnInDL = new System.Windows.Forms.Button();
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.cboCN = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraCuu)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.crystalReportViewer2);
            this.groupBox1.Controls.Add(this.crystalReportViewer1);
            this.groupBox1.Controls.Add(this.radDSHP);
            this.groupBox1.Controls.Add(this.radTTCN);
            this.groupBox1.Controls.Add(this.dgvTraCuu);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnInDL);
            this.groupBox1.Controls.Add(this.btnTraCuu);
            this.groupBox1.Controls.Add(this.cboCN);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1778, 872);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tra cứu chuyên ngành";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // crystalReportViewer2
            // 
            this.crystalReportViewer2.ActiveViewIndex = 0;
            this.crystalReportViewer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer2.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer2.Location = new System.Drawing.Point(0, 266);
            this.crystalReportViewer2.Name = "crystalReportViewer2";
            this.crystalReportViewer2.ReportSource = this.rptDSHocPhanTheoMaCN1;
            this.crystalReportViewer2.Size = new System.Drawing.Size(1778, 606);
            this.crystalReportViewer2.TabIndex = 9;
            this.crystalReportViewer2.Load += new System.EventHandler(this.crystalReportViewer2_Load);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 266);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.rptTTChuyenNganhBangMaCN1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1778, 606);
            this.crystalReportViewer1.TabIndex = 8;
            this.crystalReportViewer1.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // radDSHP
            // 
            this.radDSHP.AutoSize = true;
            this.radDSHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radDSHP.Location = new System.Drawing.Point(636, 167);
            this.radDSHP.Name = "radDSHP";
            this.radDSHP.Size = new System.Drawing.Size(254, 33);
            this.radDSHP.TabIndex = 7;
            this.radDSHP.Text = "Danh sách học phần";
            this.radDSHP.UseVisualStyleBackColor = true;
            // 
            // radTTCN
            // 
            this.radTTCN.AutoSize = true;
            this.radTTCN.Checked = true;
            this.radTTCN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTTCN.Location = new System.Drawing.Point(226, 167);
            this.radTTCN.Name = "radTTCN";
            this.radTTCN.Size = new System.Drawing.Size(293, 33);
            this.radTTCN.TabIndex = 6;
            this.radTTCN.TabStop = true;
            this.radTTCN.Text = "Thông tin chuyên ngành";
            this.radTTCN.UseVisualStyleBackColor = true;
            // 
            // dgvTraCuu
            // 
            this.dgvTraCuu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTraCuu.Location = new System.Drawing.Point(0, 266);
            this.dgvTraCuu.Name = "dgvTraCuu";
            this.dgvTraCuu.RowHeadersWidth = 62;
            this.dgvTraCuu.RowTemplate.Height = 28;
            this.dgvTraCuu.Size = new System.Drawing.Size(1793, 615);
            this.dgvTraCuu.TabIndex = 5;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(1173, 160);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(138, 64);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnInDL
            // 
            this.btnInDL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInDL.Location = new System.Drawing.Point(1275, 77);
            this.btnInDL.Name = "btnInDL";
            this.btnInDL.Size = new System.Drawing.Size(226, 63);
            this.btnInDL.TabIndex = 3;
            this.btnInDL.Text = "In dữ liệu";
            this.btnInDL.UseVisualStyleBackColor = true;
            this.btnInDL.Click += new System.EventHandler(this.btnInDL_Click);
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraCuu.Location = new System.Drawing.Point(1066, 77);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(138, 66);
            this.btnTraCuu.TabIndex = 2;
            this.btnTraCuu.Text = "Tra cứu";
            this.btnTraCuu.UseVisualStyleBackColor = true;
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // cboCN
            // 
            this.cboCN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCN.FormattingEnabled = true;
            this.cboCN.Location = new System.Drawing.Point(300, 69);
            this.cboCN.Name = "cboCN";
            this.cboCN.Size = new System.Drawing.Size(471, 45);
            this.cboCN.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chuyên ngành";
            // 
            // TraCuuChuyenNganh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1924, 994);
            this.Controls.Add(this.groupBox1);
            this.Name = "TraCuuChuyenNganh";
            this.Text = "TraCuuChuyenNganh";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TraCuuChuyenNganh_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraCuu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCN;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnInDL;
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.DataGridView dgvTraCuu;
        private System.Windows.Forms.RadioButton radDSHP;
        private System.Windows.Forms.RadioButton radTTCN;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer2;
        private rptTTChuyenNganhBangMaCN rptTTChuyenNganhBangMaCN1;
        private rptDSHocPhanTheoMaCN rptDSHocPhanTheoMaCN1;
    }
}