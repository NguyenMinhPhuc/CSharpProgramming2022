using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pro01_20CT114
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            HienThiFormLogin();
        }

        private void HienThiFormLogin()
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ThongTin = "Chương trình demo";
            //frmLogin.Show();//Hiển thị form 
            frmLogin.ShowDialog();//HIển thị form theo dạng Dialog
            lblThoiGian.Text = DateTime.Now.ToString();
            tmrGioHeThong.Start();
            lblThongTinDangNhap.Text =string.Format("Hệ thống được đăng nhập bởi: {0}" , ClsMain.taiKhoan) ;
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            HienThiFormLogin();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tmrGioHeThong_Tick(object sender, EventArgs e)
        {
            lblThoiGian.Text = DateTime.Now.ToString();
        }

        private void mnuQuanLyNguoiDung_Click(object sender, EventArgs e)
        {
            FrmQuanLyNguoiDung_Main frmQuanLyNguoiDung_Main = new FrmQuanLyNguoiDung_Main();
            frmQuanLyNguoiDung_Main.ShowDialog();
        }

        private void mnuDoiMatKhau_Click(object sender, EventArgs e)
        {
            Frm_DoiMatKhau frm_DoiMatKhau = new Frm_DoiMatKhau();
            frm_DoiMatKhau.ShowDialog();
        }
    }
}
