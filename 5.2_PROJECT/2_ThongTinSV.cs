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
    public partial class THONGTINSV : Form
    {
        public THONGTINSV()
        {
            InitializeComponent();
        }
        DBConnect db = new DBConnect();
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-FQR7ETF\\SQLEXPRESS;Initial Catalog=QLSV;Integrated Security=True");
        private void btnThem_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có muốn thực hiện thêm không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    SqlCommand cmdSV = new SqlCommand();
                    cmdSV.CommandText = "ThemSinhVien";
                    cmdSV.CommandType = CommandType.StoredProcedure;
                    cmdSV.Connection = conn;
                    SqlParameter maSV = new SqlParameter("@sMaSV", txtMaSV.Text);
                    cmdSV.Parameters.Add(maSV);
                    SqlParameter tenSV = new SqlParameter("@sTenSV", txtTenSV.Text);
                    cmdSV.Parameters.Add(tenSV);
                    if (radNam.Checked == true)
                    {
                        SqlParameter gioiTinh = new SqlParameter("@sGioiTinh", radNam.Text);
                        cmdSV.Parameters.Add(gioiTinh);
                    }
                    if (radNu.Checked == true)
                    {
                        SqlParameter gioiTinh = new SqlParameter("@sGioiTinh", radNu.Text);
                        cmdSV.Parameters.Add(gioiTinh);
                    }
                    DateTime nSinh = dtpNgSinh.Value;
                    string ngSinh = nSinh.ToString("yyyy-MM-dd");
                    SqlParameter ngaySinh = new SqlParameter("@sNgaySinh", ngSinh);
                    SqlParameter CCCD = new SqlParameter("@sCCCD", txtCMND.Text);
                    SqlParameter diaChi = new SqlParameter("@sDiaChi", txtDiaChi.Text);
                    SqlParameter queQuan = new SqlParameter("@sQueQuan", txtQueQuan.Text);
                    SqlParameter nienKhoa = new SqlParameter("@sNienKhoa", cboNienKhoa.Text);
                    SqlParameter lop = new SqlParameter("@sMaLop", cboLop.SelectedValue.ToString());
                    cmdSV.Parameters.Add(ngaySinh);
                    cmdSV.Parameters.Add(CCCD);
                    cmdSV.Parameters.Add(diaChi);
                    cmdSV.Parameters.Add(queQuan);
                    cmdSV.Parameters.Add(nienKhoa);
                    cmdSV.Parameters.Add(lop);
                    if (cmdSV.ExecuteNonQuery() > 0)
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
                    dgvSV.DataSource = db.ExeTable("LayDSSinhVien");
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
                    if (dgvSV.SelectedRows.Count == 0)
                    {
                        MessageBox.Show("Bạn chưa chọn dòng muốn xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        SqlCommand cmdSV = new SqlCommand();
                        cmdSV.CommandText = "XoaSinhVien";
                        cmdSV.CommandType = CommandType.StoredProcedure;
                        cmdSV.Connection = conn;
                        SqlParameter ma = new SqlParameter("@sMaSV", txtMaSV.Text);
                        cmdSV.Parameters.Add(ma);
                        int rowAffected = cmdSV.ExecuteNonQuery();
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
                    dgvSV.DataSource = db.ExeTable("LayDSSinhVien");
                }
            }
        }

        private void THONGTINSV_Load(object sender, EventArgs e)
        {
            dgvSV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvSV.DefaultCellStyle.Font = new Font("Arial", 14);
            dgvSV.DataSource = db.ExeTable("LayDSSinhVien");
            cboLop.Items.Clear();
            cboLop.DataSource = db.ExeTable("LayDSSLop");
            cboLop.DisplayMember = "MaLop";
            cboLop.ValueMember = "MaLop";
        }

        private void dgvSV_Click(object sender, EventArgs e)
        {
            int dong = dgvSV.CurrentCell.RowIndex;
            if (dong >= 0)
            {
                txtMaSV.Text = dgvSV.Rows[dong].Cells[0].Value.ToString();
                txtTenSV.Text = dgvSV.Rows[dong].Cells[1].Value.ToString();
                if (dgvSV.Rows[dong].Cells[2].Value.ToString().Equals("Nữ"))
                {
                    radNu.Checked = true;
                }
                if (dgvSV.Rows[dong].Cells[2].Value.ToString().Equals("Nam"))
                {
                    radNam.Checked = true;
                }
                dtpNgSinh.Text = dgvSV.Rows[dong].Cells[3].Value.ToString();
                txtCMND.Text = dgvSV.Rows[dong].Cells[4].Value.ToString();
                txtDiaChi.Text = dgvSV.Rows[dong].Cells[5].Value.ToString();
                txtQueQuan.Text = dgvSV.Rows[dong].Cells[6].Value.ToString();
                cboNienKhoa.Text = dgvSV.Rows[dong].Cells[7].Value.ToString();
                cboLop.SelectedValue = dgvSV.Rows[dong].Cells[8].Value.ToString();
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
                    if (dgvSV.SelectedRows.Count == 0)
                    {
                        MessageBox.Show("Bạn chưa chọn dòng muốn sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        SqlCommand cmdSV = new SqlCommand();
                        cmdSV.CommandText = "SuaSinhVien";
                        cmdSV.CommandType = CommandType.StoredProcedure;
                        cmdSV.Connection = conn;
                        SqlParameter maSV = new SqlParameter("@sMaSV", txtMaSV.Text);
                        SqlParameter tenSV = new SqlParameter("@sTenSV", txtTenSV.Text);
                        if (radNam.Checked == true)
                        {
                            SqlParameter gioiTinh = new SqlParameter("@sGioiTinh", radNam.Text);
                            cmdSV.Parameters.Add(gioiTinh);
                        }
                        if (radNu.Checked == true)
                        {
                            SqlParameter gioiTinh = new SqlParameter("@sGioiTinh", radNu.Text);
                            cmdSV.Parameters.Add(gioiTinh);
                        }
                        DateTime nSinh = dtpNgSinh.Value;
                        string ngSinh = nSinh.ToString("yyyy-MM-dd");
                        SqlParameter ngaySinh = new SqlParameter("@sNgaySinh", ngSinh);
                        SqlParameter CCCD = new SqlParameter("@sCCCD", txtCMND.Text);
                        SqlParameter diaChi = new SqlParameter("@sDiaChi", txtDiaChi.Text);
                        SqlParameter queQuan = new SqlParameter("@sQueQuan", txtQueQuan.Text);
                        SqlParameter nienKhoa = new SqlParameter("@sNienKhoa", cboNienKhoa.Text);
                        SqlParameter lop = new SqlParameter("@sMaLop", cboLop.SelectedValue.ToString());
                        cmdSV.Parameters.Add(maSV);
                        cmdSV.Parameters.Add(tenSV);
                        cmdSV.Parameters.Add(ngaySinh);
                        cmdSV.Parameters.Add(CCCD);
                        cmdSV.Parameters.Add(diaChi);
                        cmdSV.Parameters.Add(queQuan);
                        cmdSV.Parameters.Add(nienKhoa);
                        cmdSV.Parameters.Add(lop);
                        if (cmdSV.ExecuteNonQuery() > 0)
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
                    dgvSV.DataSource = db.ExeTable("LayDSSinhVien");
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaSV.Clear();
            txtTenSV.Clear();
            radNam.Checked = true;
            radNu.Checked = false;
            dtpNgSinh.Value = DateTime.Now;
            txtDiaChi.Clear();
            txtCMND.Clear();
            txtQueQuan.Clear();
            cboNienKhoa.SelectedIndex = 0;
            cboLop.SelectedIndex = 0;
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
            DateTime ngaySinh = dtpNgSinh.Value;

            // Tính tuổi bằng cách trừ năm hiện tại cho năm sinh
            int tuoi = DateTime.Now.Year - ngaySinh.Year;

            // Kiểm tra nếu tuổi nhỏ hơn 17
            if (tuoi < 17)
            {
                MessageBox.Show("Sinh viên phải lớn hơn hoặc bằng 17 tuổi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtMaSV_KeyPress(object sender, KeyPressEventArgs e)
        {
            //kiểm tra nếu ký tự không phải là ký tự chữ cái hoặc là số.
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                //ngăn không cho ký tự được nhập vào textbox.
                e.Handled = true;
            }
        }

        private void txtMaSV_Click(object sender, EventArgs e)
        {
            //bắt lỗi bỏ trống ô nhập.

            Control ctr = (Control)sender;

            if (ctr.Text.Length == 0)
            {
                this.errorMaSV.SetError(txtMaSV, "Vui lòng nhập mã của sinh viên !");

                //trỏ chuột về đầu ô nhập.

                txtMaSV.Focus();
            }
            else
            {
                this.errorMaSV.Clear();
            }
        }

        private void txtTenSV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                //ngăn không cho ký tự được nhập vào textbox.
                e.Handled = true;
            }
        }

        private void txtTenSV_Click(object sender, EventArgs e)
        {
            //bắt lỗi bỏ trống ô nhập.

            Control ctr = (Control)sender;

            if (ctr.Text.Length == 0)
            {
                this.errorTenSV.SetError(txtTenSV, "Vui lòng nhập tên của sinh viên !");

                //trỏ chuột về đầu ô nhập.

                txtTenSV.Focus();
            }
            else
            {
                this.errorTenSV.Clear();
            }
        }

        private void txtQueQuan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                //ngăn không cho ký tự được nhập vào textbox.
                e.Handled = true;
            }
        }

        private void txtQueQuan_Click(object sender, EventArgs e)
        {
            //bắt lỗi bỏ trống ô nhập.

            Control ctr = (Control)sender;

            if (ctr.Text.Length == 0)
            {
                this.errorQueQuan.SetError(txtQueQuan, "Vui lòng nhập quê quán !");

                //trỏ chuột về đầu ô nhập.

                txtQueQuan.Focus();
            }
            else
            {
                this.errorQueQuan.Clear();
            }
        }

        private void txtDiaChi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                //ngăn không cho ký tự được nhập vào textbox.
                e.Handled = true;
            }
        }

        private void txtDiaChi_Click(object sender, EventArgs e)
        {
            //bắt lỗi bỏ trống ô nhập.

            Control ctr = (Control)sender;

            if (ctr.Text.Length == 0)
            {
                this.errorDiaChi.SetError(txtDiaChi, "Vui lòng nhập địa chỉ !");

                //trỏ chuột về đầu ô nhập.

                txtDiaChi.Focus();
            }
            else
            {
                this.errorDiaChi.Clear();
            }
        }

        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCMND_Click(object sender, EventArgs e)
        {
            //bắt lỗi bỏ trống ô nhập.

            Control ctr = (Control)sender;

            if (ctr.Text.Length == 0)
            {
                this.errorCCCD.SetError(txtCMND, "Vui lòng nhập CCCD !");

                //trỏ chuột về đầu ô nhập.

                txtCMND.Focus();
            }
            else
            {
                this.errorCCCD.Clear();
            }
        }

        private void txtMaSV_Leave(object sender, EventArgs e)
        {
            //bắt lỗi bỏ trống ô nhập.

            Control ctr = (Control)sender;

            if (ctr.Text.Length == 0)
            {
                this.errorMaSV.SetError(txtMaSV, "Vui lòng nhập mã của sinh viên !");

                //trỏ chuột về đầu ô nhập.

                txtMaSV.Focus();
            }
            else
            {
                this.errorMaSV.Clear();
            }
        }

        private void txtTenSV_Leave(object sender, EventArgs e)
        {
            //bắt lỗi bỏ trống ô nhập.

            Control ctr = (Control)sender;

            if (ctr.Text.Length == 0)
            {
                this.errorTenSV.SetError(txtTenSV, "Vui lòng nhập tên của sinh viên !");

                //trỏ chuột về đầu ô nhập.

                txtTenSV.Focus();
            }
            else
            {
                this.errorTenSV.Clear();
            }
            }

        private void txtQueQuan_Leave(object sender, EventArgs e)
        {
            //bắt lỗi bỏ trống ô nhập.

            Control ctr = (Control)sender;

            if (ctr.Text.Length == 0)
            {
                this.errorQueQuan.SetError(txtQueQuan, "Vui lòng nhập quê quán !");

                //trỏ chuột về đầu ô nhập.

                txtQueQuan.Focus();
            }
            else
            {
                this.errorQueQuan.Clear();
            }
        }

        private void txtCMND_Leave(object sender, EventArgs e)
        {
            //bắt lỗi bỏ trống ô nhập.

            Control ctr = (Control)sender;

            if (ctr.Text.Length == 0)
            {
                this.errorCCCD.SetError(txtCMND, "Vui lòng nhập CCCD !");

                //trỏ chuột về đầu ô nhập.

                txtCMND.Focus();
            }
            else
            {
                this.errorCCCD.Clear();
            }
        }

        private void txtDiaChi_Leave(object sender, EventArgs e)
        {
            //bắt lỗi bỏ trống ô nhập.

            Control ctr = (Control)sender;

            if (ctr.Text.Length == 0)
            {
                this.errorDiaChi.SetError(txtDiaChi, "Vui lòng nhập địa chỉ !");

                //trỏ chuột về đầu ô nhập.

                txtDiaChi.Focus();
            }
            else
            {
                this.errorDiaChi.Clear();
            }
        }
    }
}
