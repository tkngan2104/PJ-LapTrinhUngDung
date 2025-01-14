namespace _5._2_PROJECT
{
    partial class TraCuuDiemRL
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptTraCuuDiemRLTheoMaSV1 = new _5._2_PROJECT.rptTraCuuDiemRLTheoMaSV();
            this.dgvTraCuu = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnInDL = new System.Windows.Forms.Button();
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.cboKhoa = new System.Windows.Forms.ComboBox();
            this.radMaKhoa = new System.Windows.Forms.RadioButton();
            this.radMaSV = new System.Windows.Forms.RadioButton();
            this.txtTuKhoa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.crystalReportViewer2 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptTraCuuDiemRLTheoMaKhoa1 = new _5._2_PROJECT.rptTraCuuDiemRLTheoMaKhoa();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraCuu)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.crystalReportViewer2);
            this.groupBox1.Controls.Add(this.crystalReportViewer1);
            this.groupBox1.Controls.Add(this.dgvTraCuu);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnLamMoi);
            this.groupBox1.Controls.Add(this.btnInDL);
            this.groupBox1.Controls.Add(this.btnTraCuu);
            this.groupBox1.Controls.Add(this.cboKhoa);
            this.groupBox1.Controls.Add(this.radMaKhoa);
            this.groupBox1.Controls.Add(this.radMaSV);
            this.groupBox1.Controls.Add(this.txtTuKhoa);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(91, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1778, 872);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tra cứu điểm rèn luyện";
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 327);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.rptTraCuuDiemRLTheoMaSV1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1778, 545);
            this.crystalReportViewer1.TabIndex = 10;
            // 
            // dgvTraCuu
            // 
            this.dgvTraCuu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTraCuu.Location = new System.Drawing.Point(0, 327);
            this.dgvTraCuu.Name = "dgvTraCuu";
            this.dgvTraCuu.RowHeadersWidth = 62;
            this.dgvTraCuu.RowTemplate.Height = 28;
            this.dgvTraCuu.Size = new System.Drawing.Size(1778, 545);
            this.dgvTraCuu.TabIndex = 9;
            this.dgvTraCuu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(1144, 162);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(181, 61);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Location = new System.Drawing.Point(883, 162);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(181, 61);
            this.btnLamMoi.TabIndex = 7;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnInDL
            // 
            this.btnInDL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInDL.Location = new System.Drawing.Point(1144, 52);
            this.btnInDL.Name = "btnInDL";
            this.btnInDL.Size = new System.Drawing.Size(181, 61);
            this.btnInDL.TabIndex = 6;
            this.btnInDL.Text = "In dữ liệu";
            this.btnInDL.UseVisualStyleBackColor = true;
            this.btnInDL.Click += new System.EventHandler(this.btnInDL_Click);
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraCuu.Location = new System.Drawing.Point(883, 53);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(181, 61);
            this.btnTraCuu.TabIndex = 5;
            this.btnTraCuu.Text = "Tra cứu";
            this.btnTraCuu.UseVisualStyleBackColor = true;
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // cboKhoa
            // 
            this.cboKhoa.FormattingEnabled = true;
            this.cboKhoa.Location = new System.Drawing.Point(234, 60);
            this.cboKhoa.Name = "cboKhoa";
            this.cboKhoa.Size = new System.Drawing.Size(489, 54);
            this.cboKhoa.TabIndex = 4;
            // 
            // radMaKhoa
            // 
            this.radMaKhoa.AutoSize = true;
            this.radMaKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMaKhoa.Location = new System.Drawing.Point(568, 148);
            this.radMaKhoa.Name = "radMaKhoa";
            this.radMaKhoa.Size = new System.Drawing.Size(129, 33);
            this.radMaKhoa.TabIndex = 3;
            this.radMaKhoa.TabStop = true;
            this.radMaKhoa.Text = "Mã khoa";
            this.radMaKhoa.UseVisualStyleBackColor = true;
            this.radMaKhoa.CheckedChanged += new System.EventHandler(this.radMaKhoa_CheckedChanged);
            // 
            // radMaSV
            // 
            this.radMaSV.AutoSize = true;
            this.radMaSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMaSV.Location = new System.Drawing.Point(289, 148);
            this.radMaSV.Name = "radMaSV";
            this.radMaSV.Size = new System.Drawing.Size(108, 33);
            this.radMaSV.TabIndex = 2;
            this.radMaSV.TabStop = true;
            this.radMaSV.Text = "Mã SV";
            this.radMaSV.UseVisualStyleBackColor = true;
            this.radMaSV.CheckedChanged += new System.EventHandler(this.radMaSV_CheckedChanged);
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Location = new System.Drawing.Point(234, 60);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(489, 53);
            this.txtTuKhoa.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ khóa";
            // 
            // crystalReportViewer2
            // 
            this.crystalReportViewer2.ActiveViewIndex = 0;
            this.crystalReportViewer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer2.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer2.Location = new System.Drawing.Point(0, 327);
            this.crystalReportViewer2.Name = "crystalReportViewer2";
            this.crystalReportViewer2.ReportSource = this.rptTraCuuDiemRLTheoMaKhoa1;
            this.crystalReportViewer2.Size = new System.Drawing.Size(1778, 545);
            this.crystalReportViewer2.TabIndex = 11;
            // 
            // TraCuuDiemRL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1924, 994);
            this.Controls.Add(this.groupBox1);
            this.Name = "TraCuuDiemRL";
            this.Text = "TraCuuDiemRL";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TraCuuDiemRL_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraCuu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTuKhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radMaKhoa;
        private System.Windows.Forms.RadioButton radMaSV;
        private System.Windows.Forms.ComboBox cboKhoa;
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnInDL;
        private System.Windows.Forms.DataGridView dgvTraCuu;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer2;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private rptTraCuuDiemRLTheoMaSV rptTraCuuDiemRLTheoMaSV1;
        private rptTraCuuDiemRLTheoMaKhoa rptTraCuuDiemRLTheoMaKhoa1;
    }
}