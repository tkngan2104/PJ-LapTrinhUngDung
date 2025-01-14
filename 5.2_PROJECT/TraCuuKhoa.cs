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
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;

namespace _5._2_PROJECT
{
    public partial class TraCuuKhoa : Form
    {
        public TraCuuKhoa()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        DBConnect db = new DBConnect();
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-FQR7ETF\\SQLEXPRESS;Initial Catalog=QLSV;Integrated Security=True");
        private void TraCuuKhoa_Load(object sender, EventArgs e)
        {
            dgvTraCuu.Visible = true;
            crystalReportViewer1.Visible = false;
            crystalReportViewer2.Visible = false;
            crystalReportViewer3.Visible = false;
            crystalReportViewer4.Visible = false;
            cboKhoa.DataSource = db.ExeTable("LayDSKhoa");
            cboKhoa.DisplayMember = "TenKhoa";
            cboKhoa.ValueMember = "MaKhoa";
            dgvTraCuu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvTraCuu.DefaultCellStyle.Font = new Font("Arial", 14);
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            dgvTraCuu.Visible = true;
            crystalReportViewer1.Visible = false;
            crystalReportViewer2.Visible = false;
            crystalReportViewer3.Visible = false;
            crystalReportViewer4.Visible = false;
            if (radDSSV.Checked == true)
            {
                dgvTraCuu.DataSource = LaySVTheoKhoa();
            }
            if(radDSL.Checked == true)
            {
                dgvTraCuu.DataSource = LayDSLopTheoKhoa();
            }
            if(radDSCN.Checked == true)
            {
                dgvTraCuu.DataSource = LayDSCNTheoKhoa();
            }
            if(radDSHP.Checked == true)
            {
                dgvTraCuu.DataSource = LayDSHPTheoKhoa() ;
            }
        }
        DataTable dt;
        public DataTable LaySVTheoKhoa()
        {
            dt = new DataTable();
            try
            {
                dt.Clear();
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "LayDSSinhVienTheoKhoa";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                SqlParameter ten = new SqlParameter("@MaKhoa", cboKhoa.SelectedValue);
                cmd.Parameters.Add(ten);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                sqlDataAdapter.Fill(dt);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public DataTable LayDSLopTheoKhoa()
        {
            dt = new DataTable();
            try
            {
                dt.Clear();
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "TraCuuDSLopTheoTenKhoa";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                SqlParameter ten = new SqlParameter("@MaKhoa", cboKhoa.SelectedValue);
                cmd.Parameters.Add(ten);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                sqlDataAdapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        public DataTable LayDSCNTheoKhoa()
        {
            dt = new DataTable();
            try
            {
                dt.Clear();
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "TraCuuDSChuyenNganhTheoTenKhoa";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                SqlParameter ten = new SqlParameter("@MaKhoa", cboKhoa.SelectedValue);
                cmd.Parameters.Add(ten);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                sqlDataAdapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        public DataTable LayDSHPTheoKhoa()
        {
            dt = new DataTable();
            try
            {
                dt.Clear();
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "TraCuuDSHocPhanTheoTenKhoa";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                SqlParameter ten = new SqlParameter("@MaKhoa", cboKhoa.SelectedValue);
                cmd.Parameters.Add(ten);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                sqlDataAdapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        private void btnInDL_Click(object sender, EventArgs e)
        {
            dgvTraCuu.Visible = false;
            if(radDSSV.Checked == true)
            {
                crystalReportViewer1.Visible = true;
                crystalReportViewer2.Visible = false;
                crystalReportViewer3.Visible = false;
                crystalReportViewer4.Visible = false;
                rptDSSVTheoKhoa rpt = new rptDSSVTheoKhoa();
                ParameterValues para = new ParameterValues();
                ParameterDiscreteValue val = new ParameterDiscreteValue();
                val.Value = cboKhoa.SelectedValue;
                para.Add(val);
                rpt.DataDefinition.ParameterFields["@MaKhoa"].ApplyCurrentValues(para);
                crystalReportViewer1.ReportSource = rpt;
            }
            if(radDSCN.Checked == true)
            {
                crystalReportViewer1.Visible = false;
                crystalReportViewer2.Visible = true;
                crystalReportViewer3.Visible = false;
                crystalReportViewer4.Visible = false;
                rptTraCuuDSChuyenNganhTheoTenKhoa rpt = new rptTraCuuDSChuyenNganhTheoTenKhoa();
                ParameterValues para = new ParameterValues();
                ParameterDiscreteValue val = new ParameterDiscreteValue();
                val.Value = cboKhoa.SelectedValue;
                para.Add(val);
                rpt.DataDefinition.ParameterFields["@MaKhoa"].ApplyCurrentValues(para);
                crystalReportViewer2.ReportSource = rpt;
            }
            if(radDSHP.Checked == true)
            {
                crystalReportViewer1.Visible = false;
                crystalReportViewer2.Visible = false ;
                crystalReportViewer3.Visible = true;
                crystalReportViewer4.Visible = false;
                rptTraCuuHPTheoMaKhoa rpt = new rptTraCuuHPTheoMaKhoa();
                ParameterValues para = new ParameterValues();
                ParameterDiscreteValue val = new ParameterDiscreteValue();
                val.Value = cboKhoa.SelectedValue;
                para.Add(val);
                rpt.DataDefinition.ParameterFields["@MaKhoa"].ApplyCurrentValues(para);
                crystalReportViewer3.ReportSource = rpt;
            }
            if(radDSL.Checked == true)
            {
                crystalReportViewer1.Visible = false;
                crystalReportViewer2.Visible = false;
                crystalReportViewer3.Visible = false;
                crystalReportViewer4.Visible = true;
                rptTraCuuDSLopTheoMaKhoa rpt = new rptTraCuuDSLopTheoMaKhoa();
                ParameterValues para = new ParameterValues();
                ParameterDiscreteValue val = new ParameterDiscreteValue();
                val.Value = cboKhoa.SelectedValue;
                para.Add(val);
                rpt.DataDefinition.ParameterFields["@MaKhoa"].ApplyCurrentValues(para);
                crystalReportViewer4.ReportSource = rpt;
            }
        }

        private void crystalReportViewer3_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có muốn đóng form không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
