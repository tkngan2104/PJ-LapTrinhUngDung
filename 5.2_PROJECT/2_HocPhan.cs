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
    public partial class HOCPHAN : Form
    {
        public HOCPHAN()
        {
            InitializeComponent();
        }

        private void HOCPHAN_Load(object sender, EventArgs e)
        {
            dgvHP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvHP.DefaultCellStyle.Font = new Font("Arial", 14);
            dgvHP.DataSource = db.ExeTable("LayDSHocPhan");
            cboKhoa.Items.Clear();
            cboKhoa.DataSource = db.ExeTable("LayDSKhoa");
            cboKhoa.DisplayMember = "TenKhoa";
            cboKhoa.ValueMember = "MaKhoa";
        }

        DBConnect db = new DBConnect();
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-FQR7ETF\\SQLEXPRESS;Initial Catalog=QLSV;Integrated Security=True");

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có muốn thực hiện không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    SqlCommand cmdHP = new SqlCommand();
                    cmdHP.CommandText = "ThemHocPhan";
                    cmdHP.CommandType = CommandType.StoredProcedure;
                    cmdHP.Connection = conn;
                    SqlParameter maHP = new SqlParameter("@sMaHP", txtMaHP.Text);
                    SqlParameter tenHP = new SqlParameter("@sTenHP", txtTenHP.Text);
                    SqlParameter soTC = new SqlParameter("@sSoTC", txtSTC.Text);
                    SqlParameter khoa = new SqlParameter("@sMaKhoa", cboKhoa.SelectedValue.ToString());
                    if (radHK1.Checked == true)
                    {
                        SqlParameter hocKy = new SqlParameter("@sHocKy", radHK1.Text);
                        cmdHP.Parameters.Add(hocKy);
                    }
                    if (radHK2.Checked == true)
                    {
                        SqlParameter hocKy = new SqlParameter("@sHocKy", radHK2.Text);
                        cmdHP.Parameters.Add(hocKy);
                    }
                    if (radHK3.Checked == true)
                    {
                        SqlParameter hocKy = new SqlParameter("@sHocKy", radHK3.Text);
                        cmdHP.Parameters.Add(hocKy);
                    }
                    cmdHP.Parameters.Add(maHP);
                    cmdHP.Parameters.Add(tenHP);
                    cmdHP.Parameters.Add(soTC);
                    cmdHP.Parameters.Add(khoa);
                    if (cmdHP.ExecuteNonQuery() > 0)
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
                    dgvHP.DataSource = db.ExeTable("LayDSHocPhan");
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
                    if (dgvHP.SelectedRows.Count == 0)
                    {
                        MessageBox.Show("Bạn chưa chọn dòng muốn xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        SqlCommand cmdHP = new SqlCommand();
                        cmdHP.CommandText = "XoaHocPhan";
                        cmdHP.CommandType = CommandType.StoredProcedure;
                        cmdHP.Connection = conn;
                        SqlParameter ma = new SqlParameter("@sMaHP", txtMaHP.Text);
                        cmdHP.Parameters.Add(ma);
                        if (cmdHP.ExecuteNonQuery() > 0)
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
                    dgvHP.DataSource = db.ExeTable("LayDSHocPhan");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có muốn thực hiện sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    if (dgvHP.SelectedRows.Count == 0)
                    {
                        MessageBox.Show("Bạn chưa chọn dòng muốn sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        SqlCommand cmdHP = new SqlCommand();
                        cmdHP.CommandText = "SuaHocPhan";
                        cmdHP.CommandType = CommandType.StoredProcedure;
                        cmdHP.Connection = conn;
                        SqlParameter maHP = new SqlParameter("@sMaHP", txtMaHP.Text);
                        SqlParameter tenHP = new SqlParameter("@sTenHP", txtTenHP.Text);
                        SqlParameter soTC = new SqlParameter("@sSoTC", txtSTC.Text);
                        SqlParameter khoa = new SqlParameter("@sMaKhoa", cboKhoa.SelectedValue.ToString());
                        if (radHK1.Checked == true)
                        {
                            SqlParameter hocKy = new SqlParameter("@sHocKy", radHK1.Text);
                            cmdHP.Parameters.Add(hocKy);
                        }
                        if (radHK2.Checked == true)
                        {
                            SqlParameter hocKy = new SqlParameter("@sHocKy", radHK2.Text);
                            cmdHP.Parameters.Add(hocKy);
                        }
                        if (radHK3.Checked == true)
                        {
                            SqlParameter hocKy = new SqlParameter("@sHocKy", radHK3.Text);
                            cmdHP.Parameters.Add(hocKy);
                        }
                        cmdHP.Parameters.Add(maHP);
                        cmdHP.Parameters.Add(tenHP);
                        cmdHP.Parameters.Add(soTC);
                        cmdHP.Parameters.Add(khoa);
                        if (cmdHP.ExecuteNonQuery() > 0)
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
                    dgvHP.DataSource = db.ExeTable("LayDSHocPhan");
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaHP.Clear();
            txtTenHP.Clear();
            txtSTC.Clear();
            cboKhoa.SelectedIndex = 0;
            radHK1.Checked = true;
            radHK2.Checked = false;
            radHK3.Checked = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có muốn đóng form này không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtMaHP_Click(object sender, EventArgs e)
        {
            
        }

        private void txtMaHP_KeyPress(object sender, KeyPressEventArgs e)
        {
            //kiểm tra nếu ký tự không phải là ký tự chữ cái hoặc là số.
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                //ngăn không cho ký tự được nhập vào textbox.
                e.Handled = true;
            }
        }

        private void txtTenHP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                //ngăn không cho ký tự được nhập vào textbox.
                e.Handled = true;
            }
        }

        private void txtTenHP_Click(object sender, EventArgs e)
        {
            
        }

        private void txtSTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            //kiểm tra nếu ký tự không phải là ký tự chữ cái hoặc là số.
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                //ngăn không cho ký tự được nhập vào textbox.
                e.Handled = true;
            }

            //kiểm tra nếu ký tự không phải là số.
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                //ngăn không cho ký tự được nhập vào textbox.
                e.Handled = true;
            }
        }

        private void txtSTC_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvHP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvHP_Click(object sender, EventArgs e)
        {
            int dong = dgvHP.CurrentCell.RowIndex;
            if (dong >= 0)
            {
                txtMaHP.Text = dgvHP.Rows[dong].Cells[0].Value.ToString();
                txtTenHP.Text = dgvHP.Rows[dong].Cells[1].Value.ToString();
                txtSTC.Text = dgvHP.Rows[dong].Cells[2].Value.ToString();
                cboKhoa.SelectedValue = dgvHP.Rows[dong].Cells[3].Value.ToString();
                if (dgvHP.Rows[dong].Cells[4].Value.ToString().Equals("1"))
                {
                    radHK1.Checked = true;
                }
                if (dgvHP.Rows[dong].Cells[4].Value.ToString().Equals("2"))
                {
                    radHK2.Checked = true;
                }
                if (dgvHP.Rows[dong].Cells[4].Value.ToString().Equals("3"))
                {
                    radHK3.Checked = true;
                }
            }
        }

        private void txtTenHP_Leave(object sender, EventArgs e)
        {
            //bắt lỗi bỏ trống ô nhập.

            Control ctr = (Control)sender;

            if (ctr.Text.Length == 0)
            {
                this.errorTenHP.SetError(txtTenHP, "Vui lòng nhập tên của học phần !");

                //trỏ chuột về đầu ô nhập.

                txtTenHP.Focus();
            }
            else
            {
                this.errorTenHP.Clear();
            }
        }

        private void txtMaHP_Leave(object sender, EventArgs e)
        {
            //bắt lỗi bỏ trống ô nhập.

            Control ctr = (Control)sender;

            if (ctr.Text.Length == 0)
            {
                this.errorMaHP.SetError(txtMaHP, "Vui lòng nhập mã học phần !");

                //trỏ chuột về đầu ô nhập.

                txtMaHP.Focus();
            }
            else
            {
                this.errorMaHP.Clear();
            }
        }

        private void txtSTC_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSTC_Leave(object sender, EventArgs e)
        {
            //bắt lỗi bỏ trống ô nhập.

            Control ctr = (Control)sender;

            if (ctr.Text.Length == 0)
            {
                this.errorTC.SetError(txtSTC, "Vui lòng nhập số tín chỉ !");

                //trỏ chuột về đầu ô nhập.

                txtSTC.Focus();
            }
            else
            {
                this.errorTC.Clear();
            }
        }
    }
}
