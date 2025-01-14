using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5._2_PROJECT
{
    public partial class TraCuu : Form
    {
        public TraCuu()
        {
            InitializeComponent();
        }
        DBConnect db = new DBConnect();
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-FQR7ETF\\SQLEXPRESS;Initial Catalog=QLSV;Integrated Security=True");
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }
        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            dgvTraCuuDL.Visible = true;
            crystalReportViewer1.Visible = false;
            crystalReportViewer2.Visible = false;
            crystalReportViewer3.Visible = false;
            crystalReportViewer4.Visible = false;
            crystalReportViewer5.Visible = false;
            crystalReportViewer6.Visible = false;
            crystalReportViewer7.Visible = false;
            crystalReportViewer8.Visible = false;
            crystalReportViewer9.Visible = false;
            if (radDSKhoa.Checked == true)
            {
                dgvTraCuuDL.DataSource = db.ExeTable("LayDSKhoa");
            }
            if(radDSSV.Checked == true)
            {
                dgvTraCuuDL.DataSource = db.ExeTable("LayDSSinhVien");
            }
            if(radDSLopHoc.Checked == true)
            {
                dgvTraCuuDL.DataSource = db.ExeTable("TraCuuDLLopHoc");
            }
            if(radHP.Checked == true)
            {
                dgvTraCuuDL.DataSource = db.ExeTable("TraCuuDLHocPhan");
            }
            if(radDSLopHP.Checked == true)
            {
                dgvTraCuuDL.DataSource = db.ExeTable("TraCuuDLLopHP");
            }
            if(radChuyenNganh.Checked == true)
            {
                dgvTraCuuDL.DataSource = db.ExeTable("TraCuuDLChuyenNganh");
            }
            if(radDamNhan.Checked == true)
            {
                dgvTraCuuDL.DataSource = db.ExeTable("TraCuuDLDamNhan");
            }
            if(radDSDangKy.Checked == true)
            {
                dgvTraCuuDL.DataSource = db.ExeTable("TraCuuDLDangKy");
            }
            if(radDSGiangVien.Checked == true)
            {
                dgvTraCuuDL.DataSource = db.ExeTable("TraCuuDSGiangVien");
            }
        }

        private void TraCuu_Load(object sender, EventArgs e)
        {
            dgvTraCuuDL.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvTraCuuDL.DefaultCellStyle.Font = new Font("Arial", 14);
            dgvTraCuuDL.Visible = true;
            crystalReportViewer1.Visible = false;
            crystalReportViewer2.Visible = false;
            crystalReportViewer3.Visible = false;
            crystalReportViewer4.Visible = false;
            crystalReportViewer5.Visible = false;
            crystalReportViewer6.Visible = false;
            crystalReportViewer7.Visible = false;
            crystalReportViewer8.Visible = false;
            crystalReportViewer9.Visible = false;
        }

        private void btnInDuLieu_Click(object sender, EventArgs e)
        {
            dgvTraCuuDL.Visible = false;
            if(radDSKhoa.Checked == true)
            {
                rptTraCuuDLDSKhoa rpt = new rptTraCuuDLDSKhoa();
                crystalReportViewer1.ReportSource = rpt;
                crystalReportViewer1.Visible = true;
                crystalReportViewer2.Visible = false;
                crystalReportViewer3.Visible = false;
                crystalReportViewer4.Visible = false;
                crystalReportViewer5.Visible = false;
                crystalReportViewer6.Visible = false;
                crystalReportViewer7.Visible = false;
                crystalReportViewer8.Visible = false;
                crystalReportViewer9.Visible = false;
            }
            if (radDSSV.Checked == true)
            {
                rptTraCuuDLSinhVien rpt = new rptTraCuuDLSinhVien();
                crystalReportViewer2.ReportSource = rpt;
                crystalReportViewer1.Visible = false;
                crystalReportViewer2.Visible = true;
                crystalReportViewer3.Visible = false;
                crystalReportViewer4.Visible = false;
                crystalReportViewer5.Visible = false;
                crystalReportViewer6.Visible = false;
                crystalReportViewer7.Visible = false;
                crystalReportViewer8.Visible = false;
                crystalReportViewer9.Visible = false;
            }
            if(radDSLopHoc.Checked == true)
            {
                rptTraCuuDLLopHoc rpt = new rptTraCuuDLLopHoc();
                crystalReportViewer3.ReportSource = rpt;
                crystalReportViewer1.Visible = false;
                crystalReportViewer2.Visible = false;
                crystalReportViewer3.Visible = true;
                crystalReportViewer4.Visible = false;
                crystalReportViewer5.Visible = false;
                crystalReportViewer6.Visible = false;
                crystalReportViewer7.Visible = false;
                crystalReportViewer8.Visible = false;
                crystalReportViewer9.Visible = false;
            }
            if(radHP.Checked == true)
            {
                rptTraCuuDLHocPhan rpt = new rptTraCuuDLHocPhan();
                crystalReportViewer4.ReportSource = rpt;
                crystalReportViewer1.Visible = false;
                crystalReportViewer2.Visible = false;
                crystalReportViewer5.Visible = false;
                crystalReportViewer4.Visible = true;
                crystalReportViewer3.Visible = false;
                crystalReportViewer6.Visible = false;
                crystalReportViewer7.Visible = false;
                crystalReportViewer8.Visible = false;
                crystalReportViewer9.Visible = false;
            }
            if(radDSLopHP.Checked == true)
            {
                rptTraCuuDLLopHocPhan rpt = new rptTraCuuDLLopHocPhan();
                crystalReportViewer5.ReportSource = rpt;
                crystalReportViewer1.Visible = false;
                crystalReportViewer2.Visible = false;
                crystalReportViewer5.Visible = true;
                crystalReportViewer3.Visible = false;
                crystalReportViewer4.Visible = false;
                crystalReportViewer6.Visible = false;
                crystalReportViewer7.Visible = false;
                crystalReportViewer8.Visible = false;
                crystalReportViewer9.Visible = false;
            }
            if(radChuyenNganh.Checked == true)
            {
                rptTraCuuDLChuyenNganh rpt = new rptTraCuuDLChuyenNganh();
                crystalReportViewer6.ReportSource = rpt;
                crystalReportViewer1.Visible = false;
                crystalReportViewer2.Visible = false;
                crystalReportViewer5.Visible = false;
                crystalReportViewer3.Visible = false;
                crystalReportViewer4.Visible = false;
                crystalReportViewer6.Visible = true;
                crystalReportViewer7.Visible = false;
                crystalReportViewer8.Visible = false;
                crystalReportViewer9.Visible = false;
            }
            if(radDamNhan.Checked == true)
            {
                rptTraCuuDLDamNhan rpt = new rptTraCuuDLDamNhan();
                crystalReportViewer7.ReportSource = rpt;
                crystalReportViewer1.Visible = false;
                crystalReportViewer2.Visible = false;
                crystalReportViewer5.Visible = false;
                crystalReportViewer3.Visible = false;
                crystalReportViewer4.Visible = false;
                crystalReportViewer6.Visible = false;
                crystalReportViewer7.Visible = true;
                crystalReportViewer8.Visible = false;
                crystalReportViewer9.Visible = false;
            }
            if(radDSDangKy.Checked == true)
            {
                rptTraCuuDLDangKy rpt = new rptTraCuuDLDangKy();
                crystalReportViewer8.ReportSource = rpt;
                crystalReportViewer1.Visible = false;
                crystalReportViewer2.Visible = false;
                crystalReportViewer5.Visible = false;
                crystalReportViewer3.Visible = false;
                crystalReportViewer4.Visible = false;
                crystalReportViewer6.Visible = false;
                crystalReportViewer7.Visible = false;
                crystalReportViewer8.Visible = true;
                crystalReportViewer9.Visible = false;
            }
            if(radDSGiangVien.Checked == true)
            {
                rptTraCuuDLGV rpt = new rptTraCuuDLGV();
                crystalReportViewer9.ReportSource = rpt;
                crystalReportViewer1.Visible = false;
                crystalReportViewer2.Visible = false;
                crystalReportViewer5.Visible = false;
                crystalReportViewer3.Visible = false;
                crystalReportViewer4.Visible = false;
                crystalReportViewer6.Visible = false;
                crystalReportViewer7.Visible = false;
                crystalReportViewer8.Visible = false;
                crystalReportViewer9.Visible = true;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có muốn đóng form không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(ret == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            
        }
    }
}
