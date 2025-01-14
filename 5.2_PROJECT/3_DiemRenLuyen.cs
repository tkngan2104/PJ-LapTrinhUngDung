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
    public partial class DIEMRENLUYEN : Form
    {
        public DIEMRENLUYEN()
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
                    SqlCommand cmdDiemRL = new SqlCommand();
                    cmdDiemRL.CommandText = "ThemDiemRenLuyen";
                    cmdDiemRL.CommandType = CommandType.StoredProcedure;
                    cmdDiemRL.Connection = conn;
                    SqlParameter maHD = new SqlParameter("@sMaHD", txtMaHD.Text);
                    cmdDiemRL.Parameters.Add(maHD);
                    SqlParameter namHoc = new SqlParameter("@sNamHoc", cboNamHoc.Text);
                    cmdDiemRL.Parameters.Add(namHoc);
                    if (radHK1.Checked == true)
                    {
                        SqlParameter hocKy = new SqlParameter("@sHocKy", radHK1.Text);
                        cmdDiemRL.Parameters.Add(hocKy);
                    }
                    if (radHK2.Checked == true)
                    {
                        SqlParameter hocKy = new SqlParameter("@sHocKy", radHK2.Text);
                        cmdDiemRL.Parameters.Add(hocKy);
                    }
                    if (radHK3.Checked == true)
                    {
                        SqlParameter hocKy = new SqlParameter("@sHocKy", radHK3.Text);
                        cmdDiemRL.Parameters.Add(hocKy);
                    }
                    SqlParameter tenHD = new SqlParameter("@sTenHD", txtTenHD.Text);
                    cmdDiemRL.Parameters.Add(tenHD);
                    DateTime tg = dtpThoiGIan.Value;
                    string tgian = tg.ToString("yyyy-MM-dd");
                    SqlParameter thoiGian = new SqlParameter("@sThoiGian", tgian);
                    cmdDiemRL.Parameters.Add(thoiGian);
                    SqlParameter diem = new SqlParameter("@sDiem", txtDiemRL.Text);
                    cmdDiemRL.Parameters.Add(diem);
                    SqlParameter maSV = new SqlParameter("@sMaSV", txtMaSV.Text);
                    cmdDiemRL.Parameters.Add(maSV);
                    if (cmdDiemRL.ExecuteNonQuery() > 0)
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
                    dgvDiemRL.DataSource = db.ExeTable("LayDSDiemRenLuyen");
                }
            }
        }

        private void DIEMRENLUYEN_Load(object sender, EventArgs e)
        {
            dgvDiemRL.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvDiemRL.DefaultCellStyle.Font = new Font("Arial", 14);
            dgvDiemRL.DataSource = db.ExeTable("LayDSDiemRenLuyen");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có muốn thực hiện xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                try
                {
                    if (dgvDiemRL.SelectedRows.Count == 0)
                    {
                        MessageBox.Show("Bạn chưa chọn dòng muốn xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        conn.Open();
                        SqlCommand cmdDiemRL = new SqlCommand();
                        cmdDiemRL.CommandText = "XoaRenLuyen";
                        cmdDiemRL.CommandType = CommandType.StoredProcedure;
                        cmdDiemRL.Connection = conn;
                        SqlParameter maHD = new SqlParameter("@sMaHD", txtMaHD.Text);
                        cmdDiemRL.Parameters.Add(maHD);
                        SqlParameter maSV = new SqlParameter("@sMaSV", txtMaSV.Text);
                        cmdDiemRL.Parameters.Add(maSV);
                        int rowAffected = cmdDiemRL.ExecuteNonQuery();
                        if (rowAffected > 0)
                        {
                            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                    dgvDiemRL.DataSource = db.ExeTable("LayDSDiemRenLuyen");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có muốn thực hiện thêm không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    if (dgvDiemRL.SelectedRows.Count == 0)
                    {
                        MessageBox.Show("Bạn chưa chọn dòng muốn sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        SqlCommand cmdDiemRL = new SqlCommand();
                        cmdDiemRL.CommandText = "SuaRenLuyen";
                        cmdDiemRL.CommandType = CommandType.StoredProcedure;
                        cmdDiemRL.Connection = conn;
                        SqlParameter maHD = new SqlParameter("@sMaHD", txtMaHD.Text);
                        cmdDiemRL.Parameters.Add(maHD);
                        SqlParameter namHoc = new SqlParameter("@sNamHoc", cboNamHoc.Text);
                        cmdDiemRL.Parameters.Add(namHoc);
                        if (radHK1.Checked == true)
                        {
                            SqlParameter hocKy = new SqlParameter("@sHocKy", radHK1.Text);
                            cmdDiemRL.Parameters.Add(hocKy);
                        }
                        if (radHK2.Checked == true)
                        {
                            SqlParameter hocKy = new SqlParameter("@sHocKy", radHK2.Text);
                            cmdDiemRL.Parameters.Add(hocKy);
                        }
                        if (radHK3.Checked == true)
                        {
                            SqlParameter hocKy = new SqlParameter("@sHocKy", radHK3.Text);
                            cmdDiemRL.Parameters.Add(hocKy);
                        }
                        SqlParameter tenHD = new SqlParameter("@sTenHD", txtTenHD.Text);
                        cmdDiemRL.Parameters.Add(tenHD);
                        DateTime tg = dtpThoiGIan.Value;
                        string tgian = tg.ToString("yyyy-MM-dd");
                        SqlParameter thoiGian = new SqlParameter("@sThoiGian", tgian);
                        cmdDiemRL.Parameters.Add(thoiGian);
                        SqlParameter diem = new SqlParameter("@sDiem", txtDiemRL.Text);
                        cmdDiemRL.Parameters.Add(diem);
                        SqlParameter maSV = new SqlParameter("@sMaSV", txtMaSV.Text);
                        cmdDiemRL.Parameters.Add(maSV);
                        if (cmdDiemRL.ExecuteNonQuery() > 0)
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
                    dgvDiemRL.DataSource = db.ExeTable("LayDSDiemRenLuyen");
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaHD.Clear();
            txtTenHD.Clear();
            dtpThoiGIan.Value = DateTime.Now;
            txtMaSV.Clear();
            txtDiemRL.Clear();
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

        private void dgvDiemRL_Click(object sender, EventArgs e)
        {
            int dong = dgvDiemRL.CurrentCell.RowIndex;
            if (dong >= 0)
            {
                txtMaHD.Text = dgvDiemRL.Rows[dong].Cells[0].Value.ToString();
                cboNamHoc.Text = dgvDiemRL.Rows[dong].Cells[1].Value.ToString();
                if (dgvDiemRL.Rows[dong].Cells[2].Value.ToString().Equals("1"))
                {
                    radHK1.Checked = true;
                }
                if (dgvDiemRL.Rows[dong].Cells[2].Value.ToString().Equals("2"))
                {
                    radHK2.Checked = true;
                }
                if (dgvDiemRL.Rows[dong].Cells[2].Value.ToString().Equals("3"))
                {
                    radHK3.Checked = true;
                }
                txtTenHD.Text = dgvDiemRL.Rows[dong].Cells[3].Value.ToString();
                dtpThoiGIan.Text = dgvDiemRL.Rows[dong].Cells[4].Value.ToString();
                txtDiemRL.Text = dgvDiemRL.Rows[dong].Cells[5].Value.ToString();
                txtMaSV.Text = dgvDiemRL.Rows[dong].Cells[6].Value.ToString();
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

        private void txtMaHD_Leave(object sender, EventArgs e)
        {
            //bắt lỗi bỏ trống ô nhập.
            Control ctr = (Control)sender;
            if (ctr.Text.Length == 0)
            {
                this.errorMaHD.SetError(txtMaHD, "Vui lòng nhập mã hoạt động !");
                //trỏ chuột về đầu ô nhập.
                txtMaHD.Focus();
            }
            else
            {
                this.errorMaHD.Clear();
            }
        }
    }
}
