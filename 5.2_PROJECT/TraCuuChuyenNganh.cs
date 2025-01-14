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
    public partial class TraCuuChuyenNganh : Form
    {
        public TraCuuChuyenNganh()
        {
            InitializeComponent();
        }
        DBConnect db = new DBConnect();
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-FQR7ETF\\SQLEXPRESS;Initial Catalog=QLSV;Integrated Security=True");
        DataTable dt;
        public DataTable LayTTChuyenNganh()
        {
            dt = new DataTable();
            try
            {
                dt.Clear();
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "TraCuuTTCNTheoMaCN";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                SqlParameter ma = new SqlParameter("@MaCN", cboCN.SelectedValue);
                cmd.Parameters.Add(ma);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                sqlDataAdapter.Fill(dt);
            }
            catch(Exception ex) {
                MessageBox.Show("Lỗi: " + ex.Message,"Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public DataTable LayDSHocPhan()
        {
            dt = new DataTable();
            try
            {
                dt.Clear();
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "TraCuuTTDSHocPhanTheoMaCN";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                SqlParameter ma = new SqlParameter("@MaCN", cboCN.SelectedValue);
                cmd.Parameters.Add(ma);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                sqlDataAdapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            dgvTraCuu.Visible = true;
            crystalReportViewer1.Visible = false;
            crystalReportViewer2.Visible = false;
            if (radTTCN.Checked == true)
            {
                dgvTraCuu.DataSource = LayTTChuyenNganh();
            }
            if(radDSHP.Checked == true)
            {
                dgvTraCuu.DataSource = LayDSHocPhan();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TraCuuChuyenNganh_Load(object sender, EventArgs e)
        {
            cboCN.Items.Clear();
            cboCN.DataSource = db.ExeTable("LayDSChuyenNganh");
            cboCN.DisplayMember = "TenChuyenNganh";
            cboCN.ValueMember = "MaChuyenNganh";
            dgvTraCuu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvTraCuu.DefaultCellStyle.Font = new Font("Arial", 14);
            dgvTraCuu.Visible = true;
            crystalReportViewer1.Visible = false;
            crystalReportViewer2.Visible = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có muốn đóng form không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnInDL_Click(object sender, EventArgs e)
        {
            dgvTraCuu.Visible = false;
            if(radTTCN.Checked == true) {
                rptTTChuyenNganhBangMaCN rpt = new rptTTChuyenNganhBangMaCN();
                ParameterValues para = new ParameterValues();
                ParameterDiscreteValue val = new ParameterDiscreteValue();
                val.Value = cboCN.SelectedValue;
                para.Add(val);
                rpt.DataDefinition.ParameterFields["@MaCN"].ApplyCurrentValues(para);
                crystalReportViewer1.ReportSource = rpt;
                crystalReportViewer1.Visible = true;
                crystalReportViewer2.Visible = false;
            }
            if(radDSHP.Checked == true)
            {
                rptDSHocPhanTheoMaCN rpt = new rptDSHocPhanTheoMaCN();
                ParameterValues para = new ParameterValues();
                ParameterDiscreteValue val = new ParameterDiscreteValue();
                val.Value = cboCN.SelectedValue;
                para.Add(val);
                rpt.DataDefinition.ParameterFields["@MaCN"].ApplyCurrentValues(para);
                crystalReportViewer2.ReportSource = rpt;
                crystalReportViewer1.Visible = false;
                crystalReportViewer2.Visible = true;
            }
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer2_Load(object sender, EventArgs e)
        {

        }
    }
}
