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
    public partial class KHOA : Form
    {
        public KHOA()
        {
            InitializeComponent();
        }

        
        DBConnect db = new DBConnect();
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-FQR7ETF\\SQLEXPRESS;Initial Catalog=QLSV;Integrated Security=True");
        private void KHOA_Load(object sender, EventArgs e)
        {
            dgvKhoa.DataSource = db.ExeTable("LayDSKhoa");
            dgvKhoa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvKhoa.DefaultCellStyle.Font = new Font("Arial", 14);
        }
        SqlCommand cmdKhoa;
        SqlDataAdapter daKhoa;
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaKhoa.Text) && !string.IsNullOrEmpty(txtTenKhoa.Text))
            {
                try
                {
                    DialogResult ret = MessageBox.Show("Bạn có muốn thực hiện thêm không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (ret == DialogResult.Yes)
                    {
                        conn.Open();
                        cmdKhoa = new SqlCommand();
                        cmdKhoa.CommandText = "themKhoa";
                        cmdKhoa.CommandType = CommandType.StoredProcedure;
                        cmdKhoa.Connection = conn;
                        SqlParameter ma = new SqlParameter("@sMaKhoa", txtMaKhoa.Text);
                        SqlParameter ten = new SqlParameter("@sTenKhoa", txtTenKhoa.Text);
                        cmdKhoa.Parameters.Add(ma);
                        cmdKhoa.Parameters.Add(ten);
                        if (cmdKhoa.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Them thanh cong");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Loi: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                    dgvKhoa.DataSource = db.ExeTable("LayDSKhoa");
                }
            }
            else
            {
                MessageBox.Show("Không được để trống ô nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                if (dgvKhoa.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Bạn chưa chọn dòng muốn xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult ret = MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (ret == DialogResult.Yes)
                    {
                        cmdKhoa = new SqlCommand();
                        cmdKhoa.CommandText = "xoaKhoa";
                        cmdKhoa.CommandType = CommandType.StoredProcedure;
                        cmdKhoa.Connection = conn;
                        SqlParameter ma = new SqlParameter("@sMaKhoa", txtMaKhoa.Text);
                        cmdKhoa.Parameters.Add(ma);
                        int rowsAffected = cmdKhoa.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Dữ liệu đã được cập nhật thành công.");
                        }
                        else
                        {
                            MessageBox.Show("Không có sự thay đổi nào được thực hiện.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
                dgvKhoa.DataSource = db.ExeTable("LayDSKhoa");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvKhoa.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Bạn chưa chọn dòng muốn sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult ret = MessageBox.Show("Bạn có muốn thực hiện sửa hay không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (ret == DialogResult.Yes)
                    {
                        conn.Open();
                        cmdKhoa = new SqlCommand();
                        cmdKhoa.CommandText = "suaKhoa";
                        cmdKhoa.CommandType = CommandType.StoredProcedure;
                        cmdKhoa.Connection = conn;
                        SqlParameter ma = new SqlParameter("@sMaKhoa", txtMaKhoa.Text);
                        SqlParameter ten = new SqlParameter("@sTenKhoa", txtTenKhoa.Text);
                        cmdKhoa.Parameters.Add(ma);
                        cmdKhoa.Parameters.Add(ten);
                        int rowsAffected = cmdKhoa.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Dữ liệu đã được cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Không có sự thay đổi nào được thực hiện.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
                dgvKhoa.DataSource = db.ExeTable("LayDSKhoa");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaKhoa.Clear();
            txtTenKhoa.Clear();
        }

        private void txtMaKhoa_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaKhoa.Text))
            {
                MessageBox.Show("Không được để trống ô nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaKhoa.Focus();
            }
        }

        private void txtTenKhoa_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenKhoa.Text))
            {
                MessageBox.Show("Không được để trống ô nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenKhoa.Focus();
            }
        }

        private void txtTenKhoa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && (char.IsDigit(e.KeyChar) || !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true; // Ngăn người dùng nhập ký tự là số hoặc ký tự đặc biệt (ngoại trừ khoảng trắng)
            }
        }

        private void txtMaKhoa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && (char.IsDigit(e.KeyChar) || !char.IsLetterOrDigit(e.KeyChar)))
            {
                e.Handled = true; // Ngăn người dùng nhập ký tự là số hoặc ký tự đặc biệt
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có muốn đóng form này không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dgvKhoa_Click(object sender, EventArgs e)
        {
            int dong = dgvKhoa.CurrentCell.RowIndex;
            if (dong >= 0)
            {
                txtMaKhoa.Text = dgvKhoa.Rows[dong].Cells[0].Value.ToString();
                txtTenKhoa.Text = dgvKhoa.Rows[dong].Cells[1].Value.ToString();
            }
        }

        private void txtMaKhoa_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaKhoa_Click(object sender, EventArgs e)
        {
        }

        private void txtTenKhoa_Click(object sender, EventArgs e)
        {
        }
    }
}
