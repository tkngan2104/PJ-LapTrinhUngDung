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

namespace WindowsFormsApp4
{
    public partial class TRACUUDANHSACHLOPHP : Form
    {
        public TRACUUDANHSACHLOPHP()
        {
            InitializeComponent();
        }
        DataTable dt;
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-FQR7ETF\\SQLEXPRESS;Initial Catalog=QLSV;Integrated Security=True");
        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            dgvTraCuuLHP.Visible = true;
            crystalReportViewer1.Visible = false;
            crystalReportViewer2.Visible = false;
            if(radThongTin.Checked == true)
            {
                dgvTraCuuLHP.DataSource = layThongTinLopHP();
            }
            if(radSVLop.Checked == true)
            {
                dgvTraCuuLHP.DataSource = layThongTinSVLopHP();
            }
        }
        public DataTable layThongTinLopHP()
        {
            dt = new DataTable();
            try
            {
                dt.Clear();
                conn.Close();
                SqlCommand cmdLopHP = new SqlCommand();
                cmdLopHP.CommandText = "LayTTLopHP";
                cmdLopHP.CommandType = CommandType.StoredProcedure;
                cmdLopHP.Connection = conn;
                SqlParameter maLopHP = new SqlParameter("@sMaLopHP", txtMaLHP.Text);
                cmdLopHP.Parameters.Add(maLopHP);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmdLopHP);
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

        public DataTable layThongTinSVLopHP()
        {
            dt = new DataTable();
            try
            {
                dt.Clear();
                conn.Close();
                SqlCommand cmdLopHP = new SqlCommand();
                cmdLopHP.CommandText = "LayDSSinhVienCuaLopHP";
                cmdLopHP.CommandType = CommandType.StoredProcedure;
                cmdLopHP.Connection = conn;
                SqlParameter maLopHP = new SqlParameter("@sMaLopHP", txtMaLHP.Text);
                cmdLopHP.Parameters.Add(maLopHP);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmdLopHP);
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TRACUUDANHSACHLOPHP_Load(object sender, EventArgs e)
        {
            dgvTraCuuLHP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvTraCuuLHP.DefaultCellStyle.Font = new Font("Arial", 14);
            dgvTraCuuLHP.Visible = true;
            crystalReportViewer1.Visible = false;
            crystalReportViewer2.Visible = false;
        }

        private void btnInDuLieu_Click(object sender, EventArgs e)
        {
            dgvTraCuuLHP.Visible=false;
            if(radThongTin.Checked == true)
            {
                crystalReportViewer1.Visible = true;
                crystalReportViewer2.Visible = false;
                rptTTLopHP rptTTLopHP = new rptTTLopHP();
                ParameterValues para = new ParameterValues();
                ParameterDiscreteValue val = new ParameterDiscreteValue();
                val.Value = txtMaLHP.Text;
                para.Add(val);
                rptTTLopHP.DataDefinition.ParameterFields["@sMaLopHP"].ApplyCurrentValues(para);
                crystalReportViewer1.ReportSource = rptTTLopHP;
            }
            if(radSVLop.Checked == true)
            {
                crystalReportViewer2.Visible = true;
                crystalReportViewer1.Visible=false;
                rptDSSinhVienLopHP rptDSSVLopHP = new rptDSSinhVienLopHP();
                ParameterValues para = new ParameterValues();
                ParameterDiscreteValue val = new ParameterDiscreteValue();
                val.Value = txtMaLHP.Text;
                para.Add(val);
                rptDSSVLopHP.DataDefinition.ParameterFields["@sMaLopHP"].ApplyCurrentValues(para);
                crystalReportViewer2.ReportSource = rptDSSVLopHP;
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaLHP.Clear();
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
