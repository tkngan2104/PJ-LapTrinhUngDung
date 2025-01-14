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
    public partial class LOPHOCPHAN : Form
    {
        public LOPHOCPHAN()
        {
            InitializeComponent();
        }
        DBConnect db = new DBConnect();
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-FQR7ETF\\SQLEXPRESS;Initial Catalog=QLSV;Integrated Security=True");
        private void LOPHOCPHAN_Load(object sender, EventArgs e)
        {
            dgvLHP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvLHP.DefaultCellStyle.Font = new Font("Arial", 14);
            dgvLHP.DataSource = db.ExeTable("LayDSLopHP");
            cboHP.Items.Clear();
            cboHP.DataSource = db.ExeTable("LayDSHocPhan");
            cboHP.DisplayMember = "TenHP";
            cboHP.ValueMember = "MaHP";
        }
        private void txtMaLopHP_KeyPress(object sender, KeyPressEventArgs e)
        {
            //kiểm tra nếu ký tự không phải là ký tự chữ cái hoặc là số.
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                //ngăn không cho ký tự được nhập vào textbox.
                e.Handled = true;
            }
        }

        private void txtMaLopHP_Click(object sender, EventArgs e)
        {
        }

        private void txtPH_KeyPress(object sender, KeyPressEventArgs e)
        {
            //kiểm tra nếu ký tự không phải là ký tự chữ cái hoặc là số.
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                //ngăn không cho ký tự được nhập vào textbox.
                e.Handled = true;
            }
        }

        private void txtPH_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvLHP_Click(object sender, EventArgs e)
        {
            int dong = dgvLHP.CurrentCell.RowIndex;
            if (dong > 0)
            {    
                txtMaLopHP.Text = dgvLHP.Rows[dong].Cells[1].Value.ToString();
                cboHP.SelectedValue = dgvLHP.Rows[dong].Cells[0].Value.ToString();
                txtPH.Text = dgvLHP.Rows[dong].Cells[2].Value.ToString();
            }
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có muốn thực hiện thêm không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    SqlCommand cmdLopHP = new SqlCommand();
                    cmdLopHP.CommandText = "ThemLopHocPhan";
                    cmdLopHP.CommandType = CommandType.StoredProcedure;
                    cmdLopHP.Connection = conn;
                    SqlParameter tenHP = new SqlParameter("@sMaHP", cboHP.SelectedValue.ToString());
                    SqlParameter tenLopHP = new SqlParameter("@sMaLopHP", txtMaLopHP.Text);
                    SqlParameter phongHoc = new SqlParameter("@sPhongHoc", txtPH.Text);
                    cmdLopHP.Parameters.Add(tenHP);
                    cmdLopHP.Parameters.Add(tenLopHP);
                    cmdLopHP.Parameters.Add(phongHoc);
                    if (cmdLopHP.ExecuteNonQuery() > 0)
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
                    dgvLHP.DataSource = db.ExeTable("LayDSLopHP");
                }
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có muốn thực hiện xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                try
                {
                    if (dgvLHP.SelectedRows.Count == 0)
                    {
                        MessageBox.Show("Bạn chưa chọn dòng muốn xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        conn.Open();
                        SqlCommand cmdLopHP = new SqlCommand();
                        cmdLopHP.CommandText = "XoaLopHocPhan";
                        cmdLopHP.CommandType = CommandType.StoredProcedure;
                        cmdLopHP.Connection = conn;
                        SqlParameter maLopHP = new SqlParameter("@sMaLopHP", txtMaLopHP.Text);
                        cmdLopHP.Parameters.Add(maLopHP);
                        int rowAffected = cmdLopHP.ExecuteNonQuery();
                        if (rowAffected > 0)
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
                    dgvLHP.DataSource = db.ExeTable("LayDSLopHP");
                }

            }
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có muốn thực hiện sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    if (dgvLHP.SelectedRows.Count == 0)
                    {
                        MessageBox.Show("Bạn chưa chọn dòng muốn sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        SqlCommand cmdLopHP = new SqlCommand();
                        cmdLopHP.CommandText = "SuaLopHocPhan";
                        cmdLopHP.CommandType = CommandType.StoredProcedure;
                        cmdLopHP.Connection = conn;
                        SqlParameter tenHP = new SqlParameter("@sMaHP", cboHP.SelectedValue.ToString());
                        SqlParameter tenLopHP = new SqlParameter("@sMaLopHP", txtMaLopHP.Text);
                        SqlParameter phongHoc = new SqlParameter("@sPhongHoc", txtPH.Text);
                        cmdLopHP.Parameters.Add(tenHP);
                        cmdLopHP.Parameters.Add(tenLopHP);
                        cmdLopHP.Parameters.Add(phongHoc);
                        if (cmdLopHP.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Sừa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    dgvLHP.DataSource = db.ExeTable("LayDSLopHP");
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            cboHP.SelectedIndex = 0;
            txtMaLopHP.Clear();
            txtMaLopHP.Focus();
            txtPH.Clear();
            
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có muốn đóng form này không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtMaLopHP_Leave(object sender, EventArgs e)
        {
            //bắt lỗi bỏ trống ô nhập.

            Control ctr = (Control)sender;

            if (ctr.Text.Length == 0)
            {
                this.errorMaLHP.SetError(txtMaLopHP, "Vui lòng nhập mã lớp học phần !");

                //trỏ chuột về đầu ô nhập.

                txtMaLopHP.Focus();
            }
            else
            {
                this.errorMaLHP.Clear();
            }
        }

        private void txtPH_Leave(object sender, EventArgs e)
        {
            //bắt lỗi bỏ trống ô nhập.

            Control ctr = (Control)sender;
            if (ctr.Text.Length == 0)
            {
                this.errorMaPH.SetError(txtPH, "Vui lòng nhập phòng học !");
                //trỏ chuột về đầu ô nhập.

                txtPH.Focus();
            }
            else
            {
                this.errorMaPH.Clear();
            }
        }
    }
}
