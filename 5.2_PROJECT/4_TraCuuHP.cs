using _5._2_PROJECT;
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

namespace WindowsFormsApp5
{
    public partial class TRACUUDANHSACHHP : Form
    {
        public TRACUUDANHSACHHP()
        {
            InitializeComponent();
        }
        DataTable dt;
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-FQR7ETF\\SQLEXPRESS;Initial Catalog=QLSV;Integrated Security=True");
        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            dgvTraCuuHP.Visible = true;
            crystalReportViewer2.Visible = false;
            crystalReportViewer1.Visible = false;
            if (radMaHP.Checked == true)
            {               
                dgvTraCuuHP.DataSource = LayTTHP();
            }
            if(radTenHP.Checked == true)
            {
                dgvTraCuuHP.DataSource = LayTTHPBangTen();
            }
        }
        public DataTable LayTTHP()
        {
            dt = new DataTable();
            try
            {
                dt.Clear();
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "LayHocPhanBangTenHocPhan";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                SqlParameter ma = new SqlParameter("@sMaHP", txtMaHP.Text);
                cmd.Parameters.Add(ma);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch(Exception ex) {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public DataTable LayTTHPBangTen()
        {
            dt = new DataTable();
            try
            {
                dt.Clear();
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "LayHP";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                SqlParameter ma = new SqlParameter("@sTenHP", txtMaHP.Text);
                cmd.Parameters.Add(ma);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TRACUUDANHSACHHP_Load(object sender, EventArgs e)
        {
            dgvTraCuuHP.Visible = true;
            crystalReportViewer1.Visible = false;
            crystalReportViewer2.Visible = false;
            dgvTraCuuHP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvTraCuuHP.DefaultCellStyle.Font = new Font("Arial", 14);
        }

        private void btnInDuLieu_Click(object sender, EventArgs e)
        {
            dgvTraCuuHP.Visible = false;
            if(radMaHP.Checked == true)
            {
                crystalReportViewer1.Visible = true;
                crystalReportViewer2.Visible = false;
                rptTTHP rptTTHP = new rptTTHP();
                ParameterValues para = new ParameterValues();
                ParameterDiscreteValue val = new ParameterDiscreteValue();
                val.Value = txtMaHP.Text;
                para.Add(val);
                rptTTHP.DataDefinition.ParameterFields["@sMaHP"].ApplyCurrentValues(para);
                crystalReportViewer1.ReportSource = rptTTHP;
            }
            if (radTenHP.Checked == true)
            {
                crystalReportViewer1.Visible = false;
                crystalReportViewer2.Visible = true;
                rptTTHPBangTenHP rptTTHP = new rptTTHPBangTenHP();
                ParameterValues para = new ParameterValues();
                ParameterDiscreteValue val = new ParameterDiscreteValue();
                val.Value = txtMaHP.Text;
                para.Add(val);
                rptTTHP.DataDefinition.ParameterFields["@sTenHP"].ApplyCurrentValues(para);
                crystalReportViewer2.ReportSource = rptTTHP;
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaHP.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có muốn đóng form không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
