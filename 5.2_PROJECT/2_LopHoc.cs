using _5._2_PROJECT;
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
    public partial class LOPHOC : Form
    {
        public LOPHOC()
        {
            InitializeComponent();
        }
        DBConnect db = new DBConnect();
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-FQR7ETF\\SQLEXPRESS;Initial Catalog=QLSV;Integrated Security=True");
        private void LOPHOC_Load(object sender, EventArgs e)
        {
            dgvLop.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvLop.DefaultCellStyle.Font = new Font("Arial", 14);
            dgvLop.DataSource = db.ExeTable("LayDSSLop");
            cboChuyenNganh.Items.Clear();
            cboChuyenNganh.DataSource = db.ExeTable("LayDSChuyenNganh");
            cboChuyenNganh.DisplayMember = "TenChuyenNganh";
            cboChuyenNganh.ValueMember = "MaChuyenNganh";
        }

        DataTable dt = new DataTable();
        public DataTable LayDLTheoChucVu()
        {
            try
            {
                dt.Clear();
                conn.Open();
                SqlCommand cmdCV = new SqlCommand();
                cmdCV.CommandText = "LayGiangVienTheoChucVuVaKhoa";
                cmdCV.CommandType = CommandType.StoredProcedure;
                cmdCV.Connection = conn;
                SqlParameter chucVu = new SqlParameter("@sChucVu", "CVHT");
                SqlParameter khoa = new SqlParameter("@sMaCN", cboChuyenNganh.SelectedValue.ToString());
                cmdCV.Parameters.Add(chucVu);
                cmdCV.Parameters.Add(khoa);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmdCV);
                sqlDataAdapter.Fill(dt);
            }
            catch (Exception ex)
            {
                dt = null;

            }
            finally
            {
                conn.Close();

            }
            return dt;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có muốn thực hiện thêm không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "ThemLop";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;
                    SqlParameter ma = new SqlParameter("@sMaLop", txtMaLH.Text);
                    SqlParameter chuyenNganh = new SqlParameter("@sMaChuyenNganh", cboChuyenNganh.SelectedValue.ToString());
                    SqlParameter tenCVHT = new SqlParameter("@sMaGV", cboGVDN.SelectedValue.ToString());
                    cmd.Parameters.Add(ma);
                    cmd.Parameters.Add(chuyenNganh);
                    cmd.Parameters.Add(tenCVHT);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    conn.Close();
                    dgvLop.DataSource = db.ExeTable("LayDSSLop");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có muốn thực hiện xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    if (dgvLop.SelectedRows.Count == 0)
                    {
                        MessageBox.Show("Bạn chưa chọn dòng muốn sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandText = "XoaLop";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = conn;
                        SqlParameter ma = new SqlParameter("@sMaLop", txtMaLH.Text);
                        cmd.Parameters.Add(ma);
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    conn.Close();
                    dgvLop.DataSource = db.ExeTable("LayDSSLop");
                }
            }
        }

        private void cboChuyenNganh_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboGVDN.DataSource = LayDLTheoChucVu();
            cboGVDN.DisplayMember = "TenGV";
            cboGVDN.ValueMember = "MaGV";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có muốn thực hiện sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                try
                {
                    if (dgvLop.SelectedRows.Count == 0)
                    {
                        MessageBox.Show("Bạn chưa chọn dòng muốn sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandText = "SuaLop";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = conn;
                        SqlParameter ma = new SqlParameter("@sMaLop", txtMaLH.Text);
                        SqlParameter chuyenNganh = new SqlParameter("@sMaChuyenNganh", cboChuyenNganh.SelectedValue.ToString());
                        SqlParameter tenCVHT = new SqlParameter("@sMaGV", cboGVDN.SelectedValue.ToString());
                        cmd.Parameters.Add(ma);
                        cmd.Parameters.Add(chuyenNganh);
                        cmd.Parameters.Add(tenCVHT);
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    conn.Close();
                    dgvLop.DataSource = db.ExeTable("LayDSSLop");
                }
            }
        }

        private void dgvLop_Click(object sender, EventArgs e)
        {
            int dong = dgvLop.CurrentCell.RowIndex;
            if (dong >= 0)
            {
                txtMaLH.Text = dgvLop.Rows[dong].Cells[0].Value.ToString();
                cboChuyenNganh.SelectedValue = dgvLop.Rows[dong].Cells[1].Value.ToString();
                cboGVDN.SelectedValue = dgvLop.Rows[dong].Cells[2].Value.ToString();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaLH.Clear();
            txtMaLH.Focus();
            cboChuyenNganh.SelectedIndex = 0;
           
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có muốn đóng form này không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtMaLH_KeyPress(object sender, KeyPressEventArgs e)
        {
            //kiểm tra nếu ký tự không phải là ký tự chữ cái hoặc là số.
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                //ngăn không cho ký tự được nhập vào textbox.
                e.Handled = true;
            }
        }

        private void txtMaLH_Click(object sender, EventArgs e)
        {
            //bắt lỗi bỏ trống ô nhập.

            Control ctr = (Control)sender;

            if (ctr.Text.Length == 0)
            {
                this.errorMaLH.SetError(txtMaLH, "Vui lòng nhập mã lớp học !");

                //trỏ chuột về đầu ô nhập.

                txtMaLH.Focus();
            }
            else
            {
                this.errorMaLH.Clear();
            }
        }

        private void txtMaLH_Leave(object sender, EventArgs e)
        {
            //bắt lỗi bỏ trống ô nhập.

            Control ctr = (Control)sender;

            if (ctr.Text.Length == 0)
            {
                this.errorMaLH.SetError(txtMaLH, "Vui lòng nhập mã lớp học !");

                //trỏ chuột về đầu ô nhập.

                txtMaLH.Focus();
            }
            else
            {
                this.errorMaLH.Clear();
            }
        }
    }
}