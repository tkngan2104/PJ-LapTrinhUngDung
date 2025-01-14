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
    public partial class TraCuuDiemRL : Form
    {
        public TraCuuDiemRL()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        DBConnect db = new DBConnect();
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-FQR7ETF\\SQLEXPRESS;Initial Catalog=QLSV;Integrated Security=True");
        DataTable dt;
        private void TraCuuDiemRL_Load(object sender, EventArgs e)
        {
            cboKhoa.Items.Clear();
            cboKhoa.DataSource = db.ExeTable("LayDSKhoa");
            cboKhoa.DisplayMember = "TenKhoa";
            cboKhoa.ValueMember = "MaKhoa";
            txtTuKhoa.Visible = true;
            cboKhoa.Visible = false;
            dgvTraCuu.Visible = true;
            crystalReportViewer1.Visible = false;
            crystalReportViewer2.Visible = false;
            dgvTraCuu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvTraCuu.DefaultCellStyle.Font = new Font("Arial", 14);
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            dgvTraCuu.Visible = true;
            crystalReportViewer1.Visible = false;
            crystalReportViewer2.Visible = false;
            if (radMaSV.Checked == true)
            {
                txtTuKhoa.Visible = true;
                cboKhoa.Visible = false;
                dgvTraCuu.DataSource = LayDiemRLMaSV();
            }
            if(radMaKhoa.Checked == true)
            {
                txtTuKhoa.Visible = false;
                cboKhoa.Visible = true;
                dgvTraCuu.DataSource = LayDSDiemRLMaKhoa();
            }
        }
        public DataTable LayDiemRLMaSV()
        {
            dt = new DataTable();
            try
            {
                dt.Clear();
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "LayDiemRLTheoMaSV";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                SqlParameter ma = new SqlParameter("@sMaSV", txtTuKhoa.Text);
                cmd.Parameters.Add(ma);
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

        public DataTable LayDSDiemRLMaKhoa()
        {
            dt = new DataTable();
            try
            {
                dt.Clear();
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "LayDiemRLTheoMaKhoa";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                SqlParameter ma = new SqlParameter("@sMaKhoa", cboKhoa.SelectedValue);
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

        private void btnInDL_Click(object sender, EventArgs e)
        {
            if (radMaSV.Checked == true)
            {
                txtTuKhoa.Visible = true;
                cboKhoa.Visible = false;
                dgvTraCuu.Visible = false;
                crystalReportViewer1.Visible = true;
                crystalReportViewer2.Visible = false;
                rptTraCuuDiemRLTheoMaSV rpt = new rptTraCuuDiemRLTheoMaSV();
                ParameterValues para = new ParameterValues();
                ParameterDiscreteValue val = new ParameterDiscreteValue();
                val.Value = txtTuKhoa.Text;
                para.Add(val);
                rpt.DataDefinition.ParameterFields["@sMaSV"].ApplyCurrentValues(para);
                crystalReportViewer1.ReportSource = rpt;

            }
            if (radMaKhoa.Checked == true)
            {
                txtTuKhoa.Visible = false;
                cboKhoa.Visible = true;
                crystalReportViewer2.Visible = true;
                crystalReportViewer1.Visible = false;
                dgvTraCuu.Visible = false;
                rptTraCuuDiemRLTheoMaKhoa rpt = new rptTraCuuDiemRLTheoMaKhoa();
                ParameterValues para = new ParameterValues();
                ParameterDiscreteValue val = new ParameterDiscreteValue();
                val.Value = cboKhoa.SelectedValue;
                para.Add(val);
                rpt.DataDefinition.ParameterFields["@sMaKhoa"].ApplyCurrentValues(para);
                crystalReportViewer2.ReportSource = rpt;
            }
        }

        private void radMaSV_CheckedChanged(object sender, EventArgs e)
        {
            txtTuKhoa.Visible = true;
            cboKhoa.Visible = false;
        }

        private void radMaKhoa_CheckedChanged(object sender, EventArgs e)
        {
            txtTuKhoa.Visible = false;
            cboKhoa.Visible = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có muốn đóng form không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTuKhoa.Clear();
            cboKhoa.SelectedIndex = 0;
        }
    }
}
