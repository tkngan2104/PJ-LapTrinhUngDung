using _5._2_PROJECT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2;
using WindowsFormsApp3;
using WindowsFormsApp4;
using WindowsFormsApp5;

namespace WindowsFormsApp1
{
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
        }
        
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có chắc muốn đăng xuất hay không ?", "ĐĂNG XUẤT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                this.Hide();
                DANGNHAP a = new DANGNHAP();
                a.ShowDialog();
                this.Close();
            }
        }
        private TRACUUTHONGTINSV a;
        private void sinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (a == null || a.IsDisposed)
            {
                a = new TRACUUTHONGTINSV();
                a.Show();
                a.MdiParent = this;
            }
        }
        private TRACUUTHONGTINGV b;
        private void giaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (b == null || b.IsDisposed)
            {
                b = new TRACUUTHONGTINGV();
                b.Show();
                b.MdiParent = this;
            }
        }
        private TRACUDANHSACHLOPHOC traCuuDSLopHoc;
        private void lớpHọcToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (traCuuDSLopHoc == null || traCuuDSLopHoc.IsDisposed)
            {
                traCuuDSLopHoc = new TRACUDANHSACHLOPHOC();
                traCuuDSLopHoc.Show();
                traCuuDSLopHoc.MdiParent = this;
            }           
        }
        private TRACUUDANHSACHHP hocPhan;
        private void họcPhầnToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (hocPhan == null || hocPhan.IsDisposed)
            {
                hocPhan = new TRACUUDANHSACHHP();
                hocPhan.Show();
                hocPhan.MdiParent = this;
            }
            
        }
        private TRACUUDANHSACHLOPHP traCuuDSLopHP;
        private void lớpHọcPhầnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (traCuuDSLopHP == null || traCuuDSLopHP.IsDisposed)
            {
                traCuuDSLopHP = new TRACUUDANHSACHLOPHP();
                traCuuDSLopHP.Show();
                traCuuDSLopHP.MdiParent = this;
            }
            
        }
        private DONGHOCPHI dongHocPhi;
        private void đóngHọcPhíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dongHocPhi == null || dongHocPhi.IsDisposed)
            {
                dongHocPhi = new DONGHOCPHI();
                dongHocPhi.Show();
                dongHocPhi.MdiParent = this;
            }       
        }
        private THONGTINSV ttSV;
        private void thôngTinSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ttSV == null || ttSV.IsDisposed)
            {
                ttSV = new THONGTINSV();
                ttSV.Show();
                ttSV.MdiParent = this;
            }        
        }
        private THONGTINGV ttGV;
        private void thôngTinGiảngViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ttGV == null || ttGV.IsDisposed)
            {
                ttGV = new THONGTINGV();
                ttGV.MdiParent = this;
                ttGV.Show();
            }          
        }
        private HOCPHAN hP;
        private void họcPhầnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (hP == null || hP.IsDisposed)
            {
                hP = new HOCPHAN();
                hP.Show();
                hP.MdiParent = this;
            }          
        }
        private LOPHOCPHAN lopHP;
        private void lớpHọcPhầnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lopHP == null || lopHP.IsDisposed)
            {
                lopHP = new LOPHOCPHAN();
                lopHP.Show();
                lopHP.MdiParent = this;
            }        
        }
        private KHOA khoa;
        private void khoaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (khoa == null || khoa.IsDisposed)
            {
                khoa = new KHOA();
                khoa.Show();
                khoa.MdiParent = this;
            }       
        }
        private LOPHOC lopHoc;
        private void lớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lopHoc == null || lopHoc.IsDisposed)
            {
                lopHoc = new LOPHOC();
                lopHoc.Show();
                lopHoc.MdiParent = this;
            }
            
        }
        private CHUYENNGANH chuyenNganh;
        private void chuyênNgànhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (chuyenNganh == null || chuyenNganh.IsDisposed)
            {
                chuyenNganh = new CHUYENNGANH();
                chuyenNganh.Show();
                chuyenNganh.MdiParent = this;
            }          
        }
        private DIEMHOCPHAN diemHP;
        private void điểmHọcPhầnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (diemHP == null || diemHP.IsDisposed)
            {
                diemHP = new DIEMHOCPHAN();
                diemHP.Show();
                diemHP.MdiParent = this;
            }          
        }
        private DIEMRENLUYEN diemRL;
        private void điểmRènLuyệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (diemRL == null || diemRL.IsDisposed)
            {
                diemRL = new DIEMRENLUYEN();
                diemRL.Show();
                diemRL.MdiParent = this;
            }
            
        }

        private void MENU_Load(object sender, EventArgs e)
        {
            
        }
        private TraCuu frmTraCuu;
        private void tRACỨUDỮLIỆUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmTraCuu == null || frmTraCuu.IsDisposed)
            {
                frmTraCuu = new TraCuu();
                frmTraCuu.Show();
                frmTraCuu.MdiParent = this;
            }
            
        }
        private TraCuuKhoa traCuuKhoa;
        private void traCứuKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (traCuuKhoa == null || traCuuKhoa.IsDisposed)
            {
                traCuuKhoa = new TraCuuKhoa();
                traCuuKhoa.Show();
                traCuuKhoa.MdiParent = this;
            }       
        }
        private TraCuuChuyenNganh traCuuChuyenNganh;
        private void traCứuChuyênNgànhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (traCuuChuyenNganh == null || traCuuChuyenNganh.IsDisposed)
            {
                traCuuChuyenNganh = new TraCuuChuyenNganh();
                traCuuChuyenNganh.Show();
                traCuuChuyenNganh.MdiParent = this;
            }        
        }
        private TraCuuDiemRL traCuuDiemRL;
        private void traCứuĐiểmRènLuyệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (traCuuDiemRL == null || traCuuDiemRL.IsDisposed)
            {
                traCuuDiemRL = new TraCuuDiemRL();
                traCuuDiemRL.Show();
                traCuuDiemRL.MdiParent = this;
            }
            
        }
    }
}
