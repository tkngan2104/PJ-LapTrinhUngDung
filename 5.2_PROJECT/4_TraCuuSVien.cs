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
using _5._2_PROJECT;

namespace WindowsFormsApp1
{
    public partial class TRACUUTHONGTINSV : Form
    {
        public TRACUUTHONGTINSV()
        {
            InitializeComponent();
        }
        DataTable dt;
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-FQR7ETF\\SQLEXPRESS;Initial Catalog=QLSV;Integrated Security=True");
        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            dgvTraCuuSV.Visible = true;
            crystalReportViewer1.Visible = false;
            crystalReportViewer2.Visible = false;
            if (radThongTin.Checked == true)
            {
                dgvTraCuuSV.DataSource = LayTTSinhVien();
            }
            if(radBangDiem.Checked == true)
            {
                dgvTraCuuSV.DataSource = LayTTDiem();
            }
        }
        public DataTable LayTTSinhVien()
        {            
            dt = new DataTable();
            try
            {
                dt.Clear();
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "LayDuLieuTheoMaSV";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                SqlParameter maSV = new SqlParameter("@sMaSV", txtMaSV.Text);
                cmd.Parameters.Add(maSV);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                sqlDataAdapter.Fill(dt);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public DataTable LayTTDiem()
        {
            
            dt = new DataTable();
            try
            {
                dt.Clear();
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "LayDiemHocPhanTheoMaSV";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                SqlParameter maSV = new SqlParameter("@MaSV", txtMaSV.Text);
                cmd.Parameters.Add(maSV);
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

        private void btnInDuLieu_Click(object sender, EventArgs e)
        {
            dgvTraCuuSV.Visible = false;
            
            if (radThongTin.Checked == true)
            {
                crystalReportViewer1.Visible = true;
                crystalReportViewer2.Visible = false;
                rptTTSV rpt = new rptTTSV();
                ParameterValues para = new ParameterValues();
                ParameterDiscreteValue val = new ParameterDiscreteValue();
                val.Value = txtMaSV.Text;
                para.Add(val);
                rpt.DataDefinition.ParameterFields["@sMaSV"].ApplyCurrentValues(para);
                crystalReportViewer1.ReportSource = rpt;
                
            }
            if(radBangDiem.Checked == true)
            {
                crystalReportViewer2.Visible = true;
                crystalReportViewer1.Visible = false;
                rptBangDiemCuaSV rpt = new rptBangDiemCuaSV();
                ParameterValues para = new ParameterValues();
                ParameterDiscreteValue val = new ParameterDiscreteValue();
                val.Value = txtMaSV.Text;
                para.Add(val);
                rpt.DataDefinition.ParameterFields["@sMaSV"].ApplyCurrentValues(para);
                crystalReportViewer2.ReportSource = rpt;
            }
        }

        private void TRACUUTHONGTINSV_Load(object sender, EventArgs e)
        {
            dgvTraCuuSV.Visible = true;
            dgvTraCuuSV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvTraCuuSV.DefaultCellStyle.Font = new Font("Arial", 14);
            crystalReportViewer1.Visible = false;
            crystalReportViewer2.Visible =false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaSV.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có muốn đóng form không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(ret == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
