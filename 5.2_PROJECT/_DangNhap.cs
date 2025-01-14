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
using WindowsFormsApp1;

namespace _5._2_PROJECT
{
    public partial class DANGNHAP : Form
    {
        

        public DANGNHAP()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-FQR7ETF\\SQLEXPRESS;Initial Catalog=QLSV;Integrated Security=True");
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtUser.Clear();
            txtPassword.Clear();
            txtUser.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (radAdmin.Checked == true)
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "LayDSTKDangNhapAdminByTen";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;
                    SqlParameter tenDN = new SqlParameter("@TenTK", txtUser.Text);
                    cmd.Parameters.Add(tenDN);
                    using (SqlDataReader sqlDataReader = cmd.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            string tenTK = sqlDataReader["TenTaiKhoan"].ToString();
                            string matKhau = sqlDataReader["MatKhau"].ToString();
                            if (txtPassword.Text.Equals(matKhau))
                            {
                                MessageBox.Show("Đăng nhập thành công");
                                this.Hide();
                                MENU menu = new MENU();
                                menu.ShowDialog();
                                this.Close();
                            }
                            if (txtPassword.Text.Equals(matKhau) == false)
                            {
                                MessageBox.Show("Đăng nhập thất bại");
                            }

                        }
                        if (!sqlDataReader.HasRows)
                        {
                            MessageBox.Show("Tài khoản không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                }

            }
            if (radGiangVien.Checked == true)
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "LayDSTKDangNhapGVByMa";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;
                    SqlParameter ma = new SqlParameter("@MaGV", txtUser.Text);
                    cmd.Parameters.Add(ma);
                    using (SqlDataReader sqlDataReader = cmd.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            string tenTK = sqlDataReader["MaGV"].ToString();
                            string matKhau = sqlDataReader["MatKhau"].ToString();
                            if (txtPassword.Text.Equals(matKhau))
                            {
                                MessageBox.Show("Đăng nhập thành công");
                                this.Hide();
                                MENU menu = new MENU();
                                menu.ShowDialog();
                                this.Close();
                            }
                            if (txtPassword.Text.Equals(matKhau) == false)
                            {
                                MessageBox.Show("Đăng nhập thất bại");
                            }
                        }
                        if (!sqlDataReader.HasRows)
                        {
                            MessageBox.Show("Tài khoản không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                }
            }

        }


        private void txtUser_Leave(object sender, EventArgs e)
        {
            //bắt lỗi bỏ trống ô nhập.

            Control ctr = (Control)sender;

            if (ctr.Text.Length == 0)
            {
                this.errorUser.SetError(txtUser, "Vui lòng nhập User của bạn !");

                //trỏ chuột về đầu ô nhập.

                txtUser.Focus();
            }
            else
            {
                this.errorUser.Clear();
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            //bắt lỗi bỏ trống ô nhập.

            Control ctr = (Control)sender;

            if (ctr.Text.Length == 0)
            {
                this.errorMK.SetError(txtPassword, "Vui lòng nhập Password của bạn !");

                //trỏ chuột về đầu ô nhập.

                txtPassword.Focus();
            }
            else
            {
                this.errorMK.Clear();
            }
        }

        private void DANGNHAP_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            //kiểm tra nếu ký tự không phải là ký tự chữ cái hoặc là số.
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                //Ngăn không cho ký tự được nhập vào textbox.
                e.Handled = true;
            }
        }
    }
}
