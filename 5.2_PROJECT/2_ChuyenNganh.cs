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
    public partial class CHUYENNGANH : Form
    {
        public CHUYENNGANH()
        {
            InitializeComponent();
        }

        private void CHUYENNGANH_Load(object sender, EventArgs e)
        {
            dgvCN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvCN.DefaultCellStyle.Font = new Font("Arial", 14);
            dgvCN.DataSource = dBConnect.ExeTable("LayDSChuyenNganh");
            cboKhoa.Items.Clear();
            cboKhoa.DataSource = dBConnect.ExeTable("LayDSKhoa");
            cboKhoa.DisplayMember = "TenKhoa";
            cboKhoa.ValueMember = "MaKhoa";
        }

        DBConnect dBConnect = new DBConnect();
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-FQR7ETF\\SQLEXPRESS;Initial Catalog=QLSV;Integrated Security=True");

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaCN.Text) && !string.IsNullOrEmpty(txtTenCN.Text))
            {
                DialogResult ret = MessageBox.Show("Bạn có muốn thực hiện thêm không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ret == DialogResult.Yes)
                {
                    try
                    {
                        SqlCommand cmdCN = new SqlCommand();
                        conn.Open();
                        cmdCN.CommandText = "ThemChuyenNganh";
                        cmdCN.CommandType = CommandType.StoredProcedure;
                        cmdCN.Connection = conn;
                        SqlParameter ma = new SqlParameter("@sMaChuyenNganh", txtMaCN.Text);
                        SqlParameter ten = new SqlParameter("@sTenChuyenNganh", txtTenCN.Text);
                        SqlParameter khoa = new SqlParameter("@sMaKhoa", cboKhoa.SelectedValue.ToString());
                        cmdCN.Parameters.Add(ma);
                        cmdCN.Parameters.Add(ten);
                        cmdCN.Parameters.Add(khoa);
                        if (cmdCN.ExecuteNonQuery() > 0)
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
                        dgvCN.DataSource = dBConnect.ExeTable("LayDSChuyenNganh");
                    }
                }
            }
            else
            {
                MessageBox.Show("Không được để trống ô nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    if (dgvCN.SelectedRows.Count == 0)
                    {
                        MessageBox.Show("Bạn chưa chọn dòng muốn xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        SqlCommand cmdCN = new SqlCommand();
                        cmdCN.CommandText = "XoaChuyenNganh";
                        cmdCN.CommandType = CommandType.StoredProcedure;
                        cmdCN.Connection = conn;
                        SqlParameter ma = new SqlParameter("@sMaChuyenNganh", txtMaCN.Text);
                        cmdCN.Parameters.Add(ma);
                        int rowAffect = cmdCN.ExecuteNonQuery();
                        if (rowAffect > 0)
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
                    dgvCN.DataSource = dBConnect.ExeTable("LayDSChuyenNganh");
                }
            }
        }

        private void dgvCN_Click(object sender, EventArgs e)
        {
            int dong = dgvCN.CurrentCell.RowIndex;
            if (dong >= 0)
            {
                txtMaCN.Text = dgvCN.Rows[dong].Cells[0].Value.ToString();
                txtTenCN.Text = dgvCN.Rows[dong].Cells[1].Value.ToString();
                cboKhoa.SelectedValue = dgvCN.Rows[dong].Cells[2].Value.ToString();
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
                    if (dgvCN.SelectedRows.Count == 0)
                    {
                        MessageBox.Show("Bạn chưa chọn dòng muốn sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        SqlCommand cmdCN = new SqlCommand();
                        cmdCN.CommandText = "SuaChuyenNganh";
                        cmdCN.CommandType = CommandType.StoredProcedure;
                        cmdCN.Connection = conn;
                        SqlParameter ma = new SqlParameter("@sMaChuyenNganh", txtMaCN.Text);
                        SqlParameter ten = new SqlParameter("@sTenChuyenNganh", txtTenCN.Text);
                        SqlParameter khoa = new SqlParameter("@sMaKhoa", cboKhoa.SelectedValue.ToString());
                        cmdCN.Parameters.Add(ma);
                        cmdCN.Parameters.Add(ten);
                        cmdCN.Parameters.Add(khoa);
                        if (cmdCN.ExecuteNonQuery() > 0)
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
                    dgvCN.DataSource = dBConnect.ExeTable("LayDSChuyenNganh");
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaCN.Clear();
            txtTenCN.Clear();
            cboKhoa.SelectedIndex = 0;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có muốn đóng form này không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtMaCN_Click(object sender, EventArgs e)
        {
            
        }

        private void txtMaCN_KeyPress(object sender, KeyPressEventArgs e)
        {
            //kiểm tra nếu ký tự không phải là số.
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                //ngăn không cho ký tự được nhập vào textbox.
                e.Handled = true;
            }
        }

        private void txtTenCN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && (char.IsDigit(e.KeyChar) || !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true; // Ngăn người dùng nhập ký tự là số hoặc ký tự đặc biệt (ngoại trừ khoảng trắng)
            }
        }

        private void txtTenCN_Click(object sender, EventArgs e)
        {
        }

        private void txtMaCN_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaCN_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaCN.Text))
            {
                MessageBox.Show("Không được để trống ô nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaCN.Focus();
            }
        }

        private void txtTenCN_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenCN.Text))
            {
                MessageBox.Show("Không được để trống ô nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenCN.Focus();
            }
        }
    }
}
