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
using CrystalDecisions.CrystalReports.Engine;

namespace WindowsFormsApp2
{
    public partial class TRACUUTHONGTINGV : Form
    {
        public TRACUUTHONGTINGV()
        {
            InitializeComponent();
        }
        DataTable dt;
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-FQR7ETF\\SQLEXPRESS;Initial Catalog=QLSV;Integrated Security=True");
        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            dgvTraCuuGV.Visible = true;
            crystalReportViewer1.Visible = false;
            crystalReportViewer2.Visible = false;
            crystalReportViewer3.Visible = false;
            if(radThongTin.Checked == true)
            {
                dgvTraCuuGV.DataSource = LayTTGV();
            }
            if(radLopCV.Checked == true)
            {
                dgvTraCuuGV.DataSource = LayTTLopDamNhanCoVanHT();
            }
            if(radLopHP.Checked == true)
            {
                dgvTraCuuGV.DataSource = LayTTLopDamNhanGiangDay();
            }
        }
        public DataTable LayTTGV()
        {
            dt = new DataTable();
            try
            {
                dt.Clear();
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "LayTTGVTheoMaGV";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                SqlParameter maGV = new SqlParameter("@sMaGV",txtMaGV.Text);
                cmd.Parameters.Add(maGV);
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

        public DataTable LayTTLopDamNhanGiangDay()
        {
            dt = new DataTable();
            try
            {
                dt.Clear();
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "LayDuLieuDamNhan";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                SqlParameter maGV = new SqlParameter("@sMaGV", txtMaGV.Text);
                cmd.Parameters.Add(maGV);
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

        public DataTable LayTTLopDamNhanCoVanHT()
        {
            dt = new DataTable();
            try
            {
                dt.Clear();
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "LayDuLieuLopTheoMaGV";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                SqlParameter maGV = new SqlParameter("@sMaGV", txtMaGV.Text);
                cmd.Parameters.Add(maGV);
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

        private void TRACUUTHONGTINGV_Load(object sender, EventArgs e)
        {
            dgvTraCuuGV.Visible = true;
            dgvTraCuuGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvTraCuuGV.DefaultCellStyle.Font = new Font("Arial", 14);
            crystalReportViewer1.Visible = false;
            crystalReportViewer2.Visible = false;
            crystalReportViewer3.Visible = false;
        }

        private void btnInDuLieu_Click(object sender, EventArgs e)
        {
            dgvTraCuuGV.Visible = false;
            if (radThongTin.Checked == true)
            {
                crystalReportViewer1.Visible =true;
                crystalReportViewer2.Visible = false;
                crystalReportViewer3.Visible = false;
                rptTTGV rptTTGV = new rptTTGV();
                ParameterValues para = new ParameterValues();
                ParameterDiscreteValue val = new ParameterDiscreteValue();
                val.Value = txtMaGV.Text;
                para.Add(val);
                rptTTGV.DataDefinition.ParameterFields["@sMaGV"].ApplyCurrentValues(para);
                crystalReportViewer1.ReportSource = rptTTGV;
                
            }
            if(radLopHP.Checked == true)
            {
                crystalReportViewer2.Visible = true;
                crystalReportViewer1.Visible = false;
                crystalReportViewer3.Visible = false;
                rptDSLopDamNhanBoiGV rptTTLopDN = new rptDSLopDamNhanBoiGV();
                ParameterValues para = new ParameterValues();
                ParameterDiscreteValue val = new ParameterDiscreteValue();
                val.Value = txtMaGV.Text;
                para.Add(val);
                rptTTLopDN.DataDefinition.ParameterFields["@sMaGV"].ApplyCurrentValues(para);
                crystalReportViewer2.ReportSource = rptTTLopDN;
            }
            if(radLopCV.Checked == true)
            {
                crystalReportViewer2.Visible = false;
                crystalReportViewer1.Visible = false;
                crystalReportViewer3.Visible = true;
                rptDSLopLamCVHT rptCVHT = new rptDSLopLamCVHT();
                ParameterValues para = new ParameterValues();
                ParameterDiscreteValue val = new ParameterDiscreteValue();
                val.Value = txtMaGV.Text;
                para.Add(val);
                rptCVHT.DataDefinition.ParameterFields["@sMaGV"].ApplyCurrentValues(para);
                crystalReportViewer3.ReportSource = rptCVHT;
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaGV.Clear();
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
