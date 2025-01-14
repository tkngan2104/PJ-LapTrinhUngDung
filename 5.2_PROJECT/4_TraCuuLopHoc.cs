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

namespace WindowsFormsApp3
{
    public partial class TRACUDANHSACHLOPHOC : Form
    {
        public TRACUDANHSACHLOPHOC()
        {
            InitializeComponent();
        }
        DataTable dt;
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-FQR7ETF\\SQLEXPRESS;Initial Catalog=QLSV;Integrated Security=True");
        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            dgvTraCuuLH.Visible = true;
            crystalReportViewer1.Visible = false;
            crystalReportViewer2.Visible = false;
            if (radThongTin.Checked == true)
            {
                dgvTraCuuLH.DataSource = LayDSLopHoc();
            }
            if(radSVLop.Checked == true)
            {
                dgvTraCuuLH.DataSource = LayDSSVLopHoc();
            }
        }
        public DataTable LayDSLopHoc()
        {
            dt = new DataTable();
            try
            {
                dt.Clear();
                conn.Close();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "LayDSLopHoc";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                SqlParameter maLopHoc = new SqlParameter("@sMaLop", txtMaLH.Text);
                cmd.Parameters.Add(maLopHoc);
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

        public DataTable LayDSSVLopHoc()
        {
            dt = new DataTable();
            try
            {
                dt.Clear();
                conn.Close();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "LaySVLopHoc";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                SqlParameter maLopHoc = new SqlParameter("@sMaLop", txtMaLH.Text);
                cmd.Parameters.Add(maLopHoc);
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

        private void TRACUDANHSACHLOPHOC_Load(object sender, EventArgs e)
        {
            dgvTraCuuLH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvTraCuuLH.DefaultCellStyle.Font = new Font("Arial", 14);
            dgvTraCuuLH.Visible = true;
            crystalReportViewer1.Visible = false;
            crystalReportViewer2.Visible = false;
        }

        private void btnInDuLieu_Click(object sender, EventArgs e)
        {
            dgvTraCuuLH.Visible = false;
            if(radThongTin.Checked == true)
            {
                crystalReportViewer1.Visible = true;
                crystalReportViewer2.Visible = false;
                rptTTLopHoc rptTTLopHoc = new rptTTLopHoc();
                ParameterValues para = new ParameterValues();
                ParameterDiscreteValue val = new ParameterDiscreteValue();
                val.Value = txtMaLH.Text;
                para.Add(val);
                rptTTLopHoc.DataDefinition.ParameterFields["@sMaLop"].ApplyCurrentValues(para);
                crystalReportViewer1.ReportSource = rptTTLopHoc;
            }
            if(radSVLop.Checked == true)
            {
                crystalReportViewer2.Visible = true;
                crystalReportViewer1.Visible =false;
                rptDSSVLopHoc rptDSSVLopHoc = new rptDSSVLopHoc();
                ParameterValues para = new ParameterValues();
                ParameterDiscreteValue val = new ParameterDiscreteValue();
                val.Value = txtMaLH.Text;
                para.Add(val);
                rptDSSVLopHoc.DataDefinition.ParameterFields["@sMaLop"].ApplyCurrentValues(para);
                crystalReportViewer2.ReportSource = rptDSSVLopHoc;
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaLH.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có muốn đóng form không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(ret == DialogResult.Yes) {
                this.Close();
            }
        }
    }
}
