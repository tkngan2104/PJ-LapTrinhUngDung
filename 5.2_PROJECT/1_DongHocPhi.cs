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

namespace WindowsFormsApp1
{
    public partial class DONGHOCPHI : Form
    {
        public DONGHOCPHI()
        {
            InitializeComponent();
        }

        private void DONGHOCPHI_Load(object sender, EventArgs e)
        {
            crystalReportViewer1.Visible = false;
            dgvHoaDon.Visible = true;
            dgvHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvHoaDon.DefaultCellStyle.Font = new Font("Arial", 14);
        }
        DataTable dt = new DataTable();
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-FQR7ETF\\SQLEXPRESS;Initial Catalog=QLSV;Integrated Security=True");
        
        public float LayHoaDonNhoMaSV()
        {
            float tongTien = 0;
            try
            {
                conn.Open();
                SqlCommand cmdHocPhi = new SqlCommand();
                cmdHocPhi.CommandText = "LayTongTienNhoMaSV";
                cmdHocPhi.CommandType = CommandType.StoredProcedure;
                cmdHocPhi.Connection = conn;
                SqlParameter maSV = new SqlParameter("@MaSV", txtMaSV.Text);
                cmdHocPhi.Parameters.Add(maSV);
                object result = cmdHocPhi.ExecuteScalar();
                tongTien = Convert.ToSingle(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                conn.Close();
            }
            return tongTien;
        }

        public DataTable LayDSMonHocDangKy()
        {
            dt.Clear();
            try
            {
                conn.Open();
                SqlCommand cmdHocPhi = new SqlCommand();
                cmdHocPhi.CommandText = "LayDSMonHocNhoMaSV";
                cmdHocPhi.CommandType = CommandType.StoredProcedure;
                cmdHocPhi.Connection = conn;
                SqlParameter maSV = new SqlParameter("@MaSV", txtMaSV.Text);
                cmdHocPhi.Parameters.Add(maSV);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmdHocPhi);
                sqlDataAdapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        public void ThemMaSVDeDongTienHocPhi()
        {
            try
            {
                if (DemSoLanXHCuaMaSV() == 0)
                {
                    conn.Open();
                    SqlCommand cmdHocPhi = new SqlCommand();
                    cmdHocPhi.CommandText = "NhapMaSinhVienChoDongHocPhi";
                    cmdHocPhi.CommandType = CommandType.StoredProcedure;
                    cmdHocPhi.Connection = conn;
                    SqlParameter maSV = new SqlParameter("@sMaSV", txtMaSV.Text);
                    cmdHocPhi.Parameters.Add(maSV);
                    cmdHocPhi.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                conn.Close();
            }

        }
        public int DemSoLanXHCuaMaSV()
        {
            int n = 0;
            try
            {
                conn.Open();
                SqlCommand cmdHocPhi = new SqlCommand();
                cmdHocPhi.CommandText = "DemSoLanXuatHienCuaMaSV";
                cmdHocPhi.CommandType = CommandType.StoredProcedure;
                cmdHocPhi.Connection = conn;
                SqlParameter maSV = new SqlParameter("@MaSV", txtMaSV.Text);
                cmdHocPhi.Parameters.Add(maSV);
                n = (int)cmdHocPhi.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                conn.Close();
            }
            return n;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaSV.Text) || string.IsNullOrEmpty(txtMaSV.Text))
            {
                MessageBox.Show("Không được để trống ô nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaSV.Focus();
            }
            else
            {
                dgvHoaDon.Visible = true;
                crystalReportViewer1.Visible = false;
                ThemMaSVDeDongTienHocPhi();
                dgvHoaDon.DataSource = LayDSMonHocDangKy();
                txtTongTien.Text = LayHoaDonNhoMaSV().ToString();
            }
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có muốn đóng form không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(ret == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void btnInHD_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaSV.Text) || string.IsNullOrEmpty(txtMaSV.Text))
            {
                MessageBox.Show("Không được để trống ô nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dgvHoaDon.Visible = false;
                crystalReportViewer1.Visible = true;
                rptInHoaDon rptInHoaDon = new rptInHoaDon();
                ParameterValues para = new ParameterValues();
                ParameterDiscreteValue val = new ParameterDiscreteValue();
                val.Value = txtMaSV.Text;
                para.Add(val);
                rptInHoaDon.DataDefinition.ParameterFields["@sMaSV"].ApplyCurrentValues(para);
                crystalReportViewer1.ReportSource = rptInHoaDon;
            }           
        }

        private void txtMaSV_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtMaSV_KeyPress(object sender, KeyPressEventArgs e)
        {
            //kiểm tra nếu ký tự không phải là ký tự chữ cái hoặc là số.
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                //Ngăn không cho ký tự được nhập vào textbox.
                e.Handled = true;
            }
        }

        private void txtMaSV_Click(object sender, EventArgs e)
        {
        }

        private void txtMaSV_Leave(object sender, EventArgs e)
        {

        }
    }
}
