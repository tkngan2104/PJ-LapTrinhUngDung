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
    public partial class THONGTINGV : Form
    {
        public THONGTINGV()
        {
            InitializeComponent();
        }
        DBConnect db = new DBConnect();

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-FQR7ETF\\SQLEXPRESS;Initial Catalog=QLSV;Integrated Security=True");
        private void THONGTINGV_Load(object sender, EventArgs e)
        {
            dgvGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvGV.DefaultCellStyle.Font = new Font("Arial", 14);
            dgvGV.DataSource = db.ExeTable("LayDSGiangVien");
            cboKhoa.Items.Clear();
            cboKhoa.DataSource = db.ExeTable("LayDSKhoa");
            cboKhoa.DisplayMember = "TenKhoa";
            cboKhoa.ValueMember = "MaKhoa";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có muốn thực hiện thêm không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    SqlCommand cmdGV = new SqlCommand();
                    cmdGV.CommandText = "ThemGiangVien";
                    cmdGV.CommandType = CommandType.StoredProcedure;
                    cmdGV.Connection = conn;
                    SqlParameter ma = new SqlParameter("@sMaGV", txtMaGV.Text);
                    SqlParameter ten = new SqlParameter("@sTenGV", txtTenGV.Text);
                    if (radNam.Checked == true)
                    {
                        SqlParameter gioitinh = new SqlParameter("@sGioiTinh", radNam.Text);
                        cmdGV.Parameters.Add(gioitinh);
                    }
                    else if (radNu.Checked == true)
                    {
                        SqlParameter gioitinh = new SqlParameter("@sGioiTinh", radNu.Text);
                        cmdGV.Parameters.Add(gioitinh);
                    }
                    DateTime ngaySinhValue = dtpNgSinh.Value;
                    string ngaySinhString = ngaySinhValue.ToString("yyyy-MM-dd");
                    SqlParameter ngaysinh = new SqlParameter("@sNgaySinh", ngaySinhString);
                    SqlParameter chucvu = new SqlParameter("@sChucVu", txtChucVu.Text);
                    SqlParameter khoa = new SqlParameter("@sMaKhoa", cboKhoa.SelectedValue.ToString());
                    cmdGV.Parameters.Add(ma);
                    cmdGV.Parameters.Add(ten);
                    cmdGV.Parameters.Add(ngaysinh);
                    cmdGV.Parameters.Add(chucvu);
                    cmdGV.Parameters.Add(khoa);
                    if (cmdGV.ExecuteNonQuery() > 0)
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
                    dgvGV.DataSource = db.ExeTable("LayDSGiangVien");
                }
            }

        }

        private void lblNienKhoa_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có muốn thực hiện xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    if (dgvGV.SelectedRows.Count == 0)
                    {
                        MessageBox.Show("Bạn chưa chọn dòng muốn xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        SqlCommand cmdGV = new SqlCommand();
                        cmdGV.CommandText = "XoaGiangVien";
                        cmdGV.CommandType = CommandType.StoredProcedure;
                        cmdGV.Connection = conn;
                        SqlParameter ma = new SqlParameter("@sMaGV", txtMaGV.Text);
                        cmdGV.Parameters.Add(ma);
                        int rowAffected = cmdGV.ExecuteNonQuery();
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
                    dgvGV.DataSource = db.ExeTable("LayDSGiangVien");
                }
            }
        }

        private void dgvGV_Click(object sender, EventArgs e)
        {
            int dong = dgvGV.CurrentCell.RowIndex;
            if (dong >= 0)
            {
                txtMaGV.Text = dgvGV.Rows[dong].Cells[0].Value.ToString();
                txtTenGV.Text = dgvGV.Rows[dong].Cells[1].Value.ToString();
                if (dgvGV.Rows[dong].Cells[2].Value.ToString().Equals("Nam"))
                {
                    radNam.Checked = true;
                }
                if (dgvGV.Rows[dong].Cells[2].Value.ToString().Equals("Nữ"))
                {
                    radNu.Checked = true;
                }

                dtpNgSinh.Text = dgvGV.Rows[dong].Cells[3].Value.ToString();
                txtChucVu.Text = dgvGV.Rows[dong].Cells[4].Value.ToString();
                cboKhoa.SelectedValue = dgvGV.Rows[dong].Cells[5].Value.ToString();
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
                    if (dgvGV.SelectedRows.Count == 0)
                    {
                        MessageBox.Show("Bạn chưa chọn dòng muốn sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        SqlCommand cmdGV = new SqlCommand();
                        cmdGV.CommandText = "SuaGiangVien";
                        cmdGV.CommandType = CommandType.StoredProcedure;
                        cmdGV.Connection = conn;
                        SqlParameter maGV = new SqlParameter("@sMaGV", txtMaGV.Text);
                        SqlParameter tenGV = new SqlParameter("@sTenGV", txtTenGV.Text);
                        if (radNam.Checked == true)
                        {
                            SqlParameter gioiTinh = new SqlParameter("@sGioiTinh", radNam.Text);
                            cmdGV.Parameters.Add(gioiTinh);
                        }
                        if (radNu.Checked == true)
                        {
                            SqlParameter gioiTinh = new SqlParameter("@sGioiTinh", radNu.Text);
                            cmdGV.Parameters.Add(gioiTinh);
                        }
                        DateTime ngSinh = dtpNgSinh.Value;
                        string nSinh = ngSinh.ToString("yyyy-MM-dd");
                        SqlParameter ngaySinh = new SqlParameter("@sNgaySinh", nSinh);
                        SqlParameter chucVu = new SqlParameter("@sChucVu", txtChucVu.Text);
                        SqlParameter maKhoa = new SqlParameter("@sMaKhoa", cboKhoa.SelectedValue.ToString());
                        cmdGV.Parameters.Add(maGV);
                        cmdGV.Parameters.Add(tenGV);
                        cmdGV.Parameters.Add(ngaySinh);
                        cmdGV.Parameters.Add(chucVu);
                        cmdGV.Parameters.Add(maKhoa);
                        int rowAffected = cmdGV.ExecuteNonQuery();
                        if (rowAffected > 0)
                        {
                            MessageBox.Show("Cập nhập thành công");
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
                    dgvGV.DataSource = db.ExeTable("LayDSGiangVien");
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaGV.Clear();
            txtMaGV.Focus();
            txtTenGV.Clear();
            txtChucVu.Clear();
            cboKhoa.SelectedIndex = 0;
            radNam.Checked = true;
            radNu.Checked = false;
            dtpNgSinh.Value = DateTime.Now;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có muốn đóng form này không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dtpNgSinh_ValueChanged(object sender, EventArgs e)
        {
            if(radNam.Checked == true)
            {
                DateTime ngaySinh = dtpNgSinh.Value;

                // Tính tuổi bằng cách trừ năm hiện tại cho năm sinh
                int tuoi = DateTime.Now.Year - ngaySinh.Year;

                // Kiểm tra nếu tuổi nhỏ hơn 17
                if (tuoi > 60 || tuoi < 20)
                {
                    MessageBox.Show("Quá tuổi về hưu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if(radNu.Checked == true)
            {
                DateTime ngaySinh = dtpNgSinh.Value;

                // Tính tuổi bằng cách trừ năm hiện tại cho năm sinh
                int tuoi = DateTime.Now.Year - ngaySinh.Year;

                // Kiểm tra nếu tuổi nhỏ hơn 17
                if (tuoi > 55 || tuoi < 20)
                {
                    MessageBox.Show("Qúa tuổi về hưu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtMaGV_KeyPress(object sender, KeyPressEventArgs e)
        {
            //kiểm tra nếu ký tự không phải là ký tự chữ cái hoặc là số.
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                //ngăn không cho ký tự được nhập vào textbox.
                e.Handled = true;
            }
        }

        private void txtMaGV_Click(object sender, EventArgs e)
        {
            //bắt lỗi bỏ trống ô nhập.

            Control ctr = (Control)sender;

            if (ctr.Text.Length == 0)
            {
                this.errorMaGV.SetError(txtMaGV, "Vui lòng nhập mã của giảng viên !");

                //trỏ chuột về đầu ô nhập.

                txtMaGV.Focus();
            }
            else
            {
                this.errorMaGV.Clear();
            }
        }

        private void txtTenGV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                //ngăn không cho ký tự được nhập vào textbox.
                e.Handled = true;
            }
        }

        private void txtTenGV_Click(object sender, EventArgs e)
        {
            //bắt lỗi bỏ trống ô nhập.

            Control ctr = (Control)sender;

            if (ctr.Text.Length == 0)
            {
                this.errorTenGV.SetError(txtTenGV, "Vui lòng nhập tên của giảng viên !");

                //trỏ chuột về đầu ô nhập.

                txtTenGV.Focus();
            }
            else
            {
                this.errorTenGV.Clear();
            }
        }

        private void txtChucVu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                //ngăn không cho ký tự được nhập vào textbox.
                e.Handled = true;
            }
        }

        private void txtChucVu_Click(object sender, EventArgs e)
        {
            //bắt lỗi bỏ trống ô nhập.

            Control ctr = (Control)sender;

            if (ctr.Text.Length == 0)
            {
                this.errorChucVu.SetError(txtChucVu, "Vui lòng nhập chức vụ của giảng viên !");

                //trỏ chuột về đầu ô nhập.

                txtChucVu.Focus();
            }
            else
            {
                this.errorChucVu.Clear();
            }
        }

        private void txtMaGV_Leave(object sender, EventArgs e)
        {
            //bắt lỗi bỏ trống ô nhập.

            Control ctr = (Control)sender;

            if (ctr.Text.Length == 0)
            {
                this.errorMaGV.SetError(txtMaGV, "Vui lòng nhập mã của giảng viên !");

                //trỏ chuột về đầu ô nhập.

                txtMaGV.Focus();
            }
            else
            {
                this.errorMaGV.Clear();
            }
        }

        private void txtTenGV_Leave(object sender, EventArgs e)
        {
            //bắt lỗi bỏ trống ô nhập.

            Control ctr = (Control)sender;

            if (ctr.Text.Length == 0)
            {
                this.errorTenGV.SetError(txtTenGV, "Vui lòng nhập tên của giảng viên !");

                //trỏ chuột về đầu ô nhập.

                txtTenGV.Focus();
            }
            else
            {
                this.errorTenGV.Clear();
            }
        }

        private void txtChucVu_Leave(object sender, EventArgs e)
        {
            //bắt lỗi bỏ trống ô nhập.

            Control ctr = (Control)sender;

            if (ctr.Text.Length == 0)
            {
                this.errorChucVu.SetError(txtChucVu, "Vui lòng nhập chức vụ của giảng viên !");

                //trỏ chuột về đầu ô nhập.

                txtChucVu.Focus();
            }
            else
            {
                this.errorChucVu.Clear();
            }
        }
    }
}
