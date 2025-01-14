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
    public partial class DIEMHOCPHAN : Form
    {
        public DIEMHOCPHAN()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-FQR7ETF\\SQLEXPRESS;Initial Catalog=QLSV;Integrated Security=True");
        DBConnect connect = new DBConnect();
        private void DIEMHOCPHAN_Load(object sender, EventArgs e)
        {
            dgvDiemHP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvDiemHP.DefaultCellStyle.Font = new Font("Arial", 14);
            dgvDiemHP.DataSource = connect.ExeTable("LayDSDiemHP");
        }
        DataTable dt;
        public DataTable LayDSLopHPNhoMaGV()
        {
            dt = new DataTable();
            try
            {
                dt.Clear();
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "LayDuLieuDuLieuDamNhanTheoMaGV";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                SqlParameter maGV = new SqlParameter("@sMaGV", txtMaGV.Text);
                cmd.Parameters.Add(maGV);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
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
        public DataTable LayDSDiemNhoMaGVSV()
        {
            dt = new DataTable();
            try
            {
                dt.Clear();
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "LayDSDiemHPTheoMaSVVaHocKy";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                SqlParameter maSV = new SqlParameter("@sMaSV", txtMaSV.Text);
                cmd.Parameters.Add(maSV);
                if (radHK1.Checked == true)
                {
                    SqlParameter hocKy = new SqlParameter("@sHocKy", radHK1.Text);
                    cmd.Parameters.Add(hocKy);
                }
                if (radHK2.Checked == true)
                {
                    SqlParameter hocKy = new SqlParameter("@sHocKy", radHK2.Text);
                    cmd.Parameters.Add(hocKy);
                }
                if (radHK3.Checked == true)
                {
                    SqlParameter hocKy = new SqlParameter("@sHocKy", radHK3.Text);
                    cmd.Parameters.Add(hocKy);
                }
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                sqlDataAdapter.Fill(dt);
            }
            catch (Exception ex)
            {
                dt = null;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return dt;
        }

        public int DemSoLanXuatHienMaSVTrongLopHP()
        {
            int n = 0;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "DemSoLanXuatHienCuaMaSVTrongLopHP";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                SqlParameter maSV = new SqlParameter("@sMaSV", txtMaSV.Text);
                cmd.Parameters.Add(maSV);
                SqlParameter maLopHP = new SqlParameter("@sMaLopHP", cboLopHP.SelectedValue.ToString());
                cmd.Parameters.Add(maLopHP);
                n = (int)cmd.ExecuteScalar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return n;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (DemSoLanXuatHienMaSVTrongLopHP() > 0)
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "ThemDiemHocPhan";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;
                    SqlParameter diemThi = new SqlParameter("@sDiemThi", txtDiemThi.Text);
                    cmd.Parameters.Add(diemThi);
                    SqlParameter diemHS1 = new SqlParameter("@DiemHeSo1", txtDiemHS1.Text);
                    cmd.Parameters.Add(diemHS1);
                    SqlParameter diemHS2 = new SqlParameter("@DiemHeSo2", txtDiemHS2.Text);
                    cmd.Parameters.Add(diemHS2);
                    if (radHK1.Checked == true)
                    {
                        SqlParameter hocKy = new SqlParameter("@sNamHoc", radHK1.Text);
                        cmd.Parameters.Add(hocKy);
                    }
                    if (radHK2.Checked == true)
                    {
                        SqlParameter hocKy = new SqlParameter("@sNamHoc", radHK2.Text);
                        cmd.Parameters.Add(hocKy);
                    }
                    if (radHK3.Checked == true)
                    {
                        SqlParameter hocKy = new SqlParameter("@sNamHoc", radHK3.Text);
                        cmd.Parameters.Add(hocKy);
                    }
                    SqlParameter maSV = new SqlParameter("@sMaSV", txtMaSV.Text);
                    cmd.Parameters.Add(maSV);
                    SqlParameter maLopHP = new SqlParameter("@sMaLopHP", cboLopHP.SelectedValue.ToString());
                    cmd.Parameters.Add(maLopHP);
                    SqlParameter maGV = new SqlParameter("@sMaGV", txtMaGV.Text);
                    cmd.Parameters.Add(maGV);
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
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                    dgvDiemHP.DataSource = LayDSDiemNhoMaGVSV();
                    txtDiemTBM.Text = LayDiemTBTichLuy().ToString();
                    txtXepLoai.Text = LayXepLoai().ToString();
                }
            }
            else
            {
                MessageBox.Show("Sinh viên không có trong danh sách");
            }
        }

        private void txtMaGV_TextChanged(object sender, EventArgs e)
        {
            cboLopHP.DataSource = LayDSLopHPNhoMaGV();
            cboLopHP.DisplayMember = "MaLopHP";
            cboLopHP.ValueMember = "MaLopHP";
        }
        public float LayDiemTBTichLuy()
        {
            float diemTB = 0;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "LayDiemTBTichLuy";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                SqlParameter maSV = new SqlParameter("@sMaSV", txtMaSV.Text);
                cmd.Parameters.Add(maSV);
                object result = cmd.ExecuteScalar();
                diemTB = Convert.ToSingle(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return diemTB;
        }

        public string LayXepLoai()
        {
            string xepLoai = "";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "LayXepLoai";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                SqlParameter maSV = new SqlParameter("@sMaSV", txtMaSV.Text);
                cmd.Parameters.Add(maSV);
                object result = cmd.ExecuteScalar();
                xepLoai = Convert.ToString(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return xepLoai;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "xoaDiem";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                SqlParameter maSV = new SqlParameter("@MaSV", txtMaSV.Text);
                cmd.Parameters.Add(maSV);
                SqlParameter maLopHP = new SqlParameter("@MaLopHP", cboLopHP.SelectedValue.ToString());
                cmd.Parameters.Add(maLopHP);
                SqlParameter maGV = new SqlParameter("@MaGV", txtMaGV.Text);
                cmd.Parameters.Add(maGV);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                dgvDiemHP.DataSource = LayDSDiemNhoMaGVSV();
                txtDiemTBM.Text = LayDiemTBTichLuy().ToString();
                txtXepLoai.Text = LayXepLoai().ToString();
            }
        }

        private void dgvDiemHP_Click(object sender, EventArgs e)
        {
            int dong = dgvDiemHP.CurrentCell.RowIndex;
            if (dong >= 0)
            {
                txtDiemThi.Text = dgvDiemHP.Rows[dong].Cells[0].Value.ToString();
                txtDiemHS1.Text = dgvDiemHP.Rows[dong].Cells[1].Value.ToString();
                txtDiemHS2.Text = dgvDiemHP.Rows[dong].Cells[2].Value.ToString();
                if (dgvDiemHP.Rows[dong].Cells[5].Value.ToString().Equals("1"))
                {
                    radHK1.Checked = true;
                }
                if (dgvDiemHP.Rows[dong].Cells[5].Value.ToString().Equals("2"))
                {
                    radHK2.Checked = true;
                }
                if (dgvDiemHP.Rows[dong].Cells[5].Value.ToString().Equals("3"))
                {
                    radHK3.Checked = true;
                }
                txtMaSV.Text = dgvDiemHP.Rows[dong].Cells[6].Value.ToString();
                cboLopHP.SelectedValue = dgvDiemHP.Rows[dong].Cells[7].Value.ToString();
                txtMaGV.Text = dgvDiemHP.Rows[dong].Cells[8].Value.ToString();
                txtDiemTBM.Text = LayDiemTBTichLuy().ToString();
                txtXepLoai.Text = LayXepLoai().ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "suaDiem";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                SqlParameter diemThi = new SqlParameter("@DiemThi", txtDiemThi.Text);
                cmd.Parameters.Add(diemThi);
                SqlParameter diemHS1 = new SqlParameter("@DiemHeSo1", txtDiemHS1.Text);
                cmd.Parameters.Add(diemHS1);
                SqlParameter diemHS2 = new SqlParameter("@DiemHeSo2", txtDiemHS2.Text);
                cmd.Parameters.Add(diemHS2);
                if (radHK1.Checked == true)
                {
                    SqlParameter hocKy = new SqlParameter("@NamHoc", radHK1.Text);
                    cmd.Parameters.Add(hocKy);
                }
                if (radHK2.Checked == true)
                {
                    SqlParameter hocKy = new SqlParameter("@NamHoc", radHK2.Text);
                    cmd.Parameters.Add(hocKy);
                }
                if (radHK3.Checked == true)
                {
                    SqlParameter hocKy = new SqlParameter("@NamHoc", radHK3.Text);
                    cmd.Parameters.Add(hocKy);
                }
                SqlParameter maSV = new SqlParameter("@MaSV", txtMaSV.Text);
                cmd.Parameters.Add(maSV);
                SqlParameter maLopHP = new SqlParameter("@MaLopHP", cboLopHP.SelectedValue.ToString());
                cmd.Parameters.Add(maLopHP);
                SqlParameter maGV = new SqlParameter("@MaGV", txtMaGV.Text);
                cmd.Parameters.Add(maGV);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                dgvDiemHP.DataSource = LayDSDiemNhoMaGVSV();
                txtDiemTBM.Text = LayDiemTBTichLuy().ToString();
                txtXepLoai.Text = LayXepLoai().ToString();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaGV.Clear();
            txtMaSV.Clear();
            txtDiemHS1.Clear();
            radHK1.Checked = true;
            radHK2.Checked = false;
            radHK3.Checked = false;
            txtDiemHS2.Clear();
            txtDiemTBM.Clear();
            txtXepLoai.Clear();
            txtDiemThi.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn muốn đóng form không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                this.Close();
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
                this.errorMaGV.SetError(txtMaGV, "Vui lòng nhập mã giảng viên !");

                //trỏ chuột về đầu ô nhập.

                txtMaGV.Focus();
            }
            else
            {
                this.errorMaGV.Clear();
            }
        }

        private void txtDiemHS1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra nếu ký tự không phải là số, không phải dấu chấm thập phân và không phải là ký tự control (như Backspace)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ngăn không cho ký tự được nhập vào TextBox
            }

            // Kiểm tra nếu đã có một dấu chấm thập phân và người dùng lại nhập một dấu chấm nữa
            if (e.KeyChar == '.' && txtDiemHS1.Text.Contains("."))
            {
                e.Handled = true; // Ngăn không cho ký tự được nhập vào TextBox
            }
        }

        private void txtDiemHS1_Click(object sender, EventArgs e)
        {
            
        }

        private void txtDiemHS2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra nếu ký tự không phải là số, không phải dấu chấm thập phân và không phải là ký tự control (như Backspace)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ngăn không cho ký tự được nhập vào TextBox
            }

            // Kiểm tra nếu đã có một dấu chấm thập phân và người dùng lại nhập một dấu chấm nữa
            if (e.KeyChar == '.' && txtDiemHS2.Text.Contains("."))
            {
                e.Handled = true; // Ngăn không cho ký tự được nhập vào TextBox
            }
        }

        private void txtDiemHS2_Click(object sender, EventArgs e)
        {
            
        }

        private void txtDiemThi_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra nếu ký tự không phải là số, không phải dấu chấm thập phân và không phải là ký tự control (như Backspace)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ngăn không cho ký tự được nhập vào TextBox
            }

            // Kiểm tra nếu đã có một dấu chấm thập phân và người dùng lại nhập một dấu chấm nữa
            if (e.KeyChar == '.' && txtDiemThi.Text.Contains("."))
            {
                e.Handled = true; // Ngăn không cho ký tự được nhập vào TextBox
            }
        }

        private void txtDiemThi_Click(object sender, EventArgs e)
        {
            
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

        private void txtMaGV_Leave(object sender, EventArgs e)
        {
            //bắt lỗi bỏ trống ô nhập.

            Control ctr = (Control)sender;

            if (ctr.Text.Length == 0)
            {
                this.errorMaGV.SetError(txtMaGV, "Vui lòng nhập mã giảng viên !");
                //trỏ chuột về đầu ô nhập.

                txtMaGV.Focus();
            }
            else
            {
                this.errorMaGV.Clear();
            }
        }

        private void txtDiemHS1_Leave(object sender, EventArgs e)
        {
            //bắt lỗi bỏ trống ô nhập.

            Control ctr = (Control)sender;

            if (ctr.Text.Length == 0)
            {
                this.errorD1.SetError(txtDiemHS1, "Vui lòng nhập điểm hệ số 1 !");

                //trỏ chuột về đầu ô nhập.

                txtDiemHS1.Focus();
            }
            else
            {
                this.errorD1.Clear();
            }
        }

        private void txtDiemHS2_Leave(object sender, EventArgs e)
        {
            //bắt lỗi bỏ trống ô nhập.

            Control ctr = (Control)sender;

            if (ctr.Text.Length == 0)
            {
                this.errorD2.SetError(txtDiemHS2, "Vui lòng nhập điểm hệ số 2 !");

                //trỏ chuột về đầu ô nhập.

                txtDiemHS2.Focus();
            }
            else
            {
                this.errorD2.Clear();
            }
        }

        private void txtDiemThi_Leave(object sender, EventArgs e)
        {
            //bắt lỗi bỏ trống ô nhập.

            Control ctr = (Control)sender;

            if (ctr.Text.Length == 0)
            {
                this.errorDThi.SetError(txtDiemThi, "Vui lòng nhập điểm thi !");

                //trỏ chuột về đầu ô nhập.

                txtDiemThi.Focus();
            }
            else
            {
                this.errorDThi.Clear();
            }
        }
    }
}

