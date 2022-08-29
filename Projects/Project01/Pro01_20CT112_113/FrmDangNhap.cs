using Pro01_20CT112_113.BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pro01_20CT112_113
{
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();

        }
        BLLUser bd;

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
            bd = new BLLUser(string.Format(@"{0}\Users.ini",Application.StartupPath));
        }
        /// <summary>
        /// Button thoát, để đóng chương trình
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThoat_Click(object sender, EventArgs e)
        {
            //this.Close();//đòng 1 form
            /*
             comment nhiều dòng*/
            trangThaiDongForm = true;
            Application.Exit();//Đóng cả chương trình
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTaiKhoan.Text))
            {
                if (!string.IsNullOrEmpty(txtMatKhau.Text))
                {
                    if (KiemTraDangNhap(txtTaiKhoan.Text, txtMatKhau.Text))
                    {
                        trangThaiDongForm = true;
                        ClsMain.taiKhoan = txtTaiKhoan.Text;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản hay mật khẩu không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtTaiKhoan.ResetText();//txtTaiKhoan.SelectAll();
                        txtMatKhau.ResetText();
                        txtTaiKhoan.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu chưa nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMatKhau.Focus();
                }
            }
            else
            {
                MessageBox.Show("Tài khoản chưa nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTaiKhoan.Focus();
            }
        }
        /// <summary>
        /// Phương thức kiểm tra đăng nhập
        /// </summary>
        /// <param name="taiKhoan">Textbox Tài khoản</param>
        /// <param name="matKhau">TextBox mật khẩu</param>
        /// <returns>true nếu trùng, false không trùng</returns>
        private bool KiemTraDangNhap(string taiKhoan, string matKhau)
        {
            return bd.KiemTraTaiKhoan(taiKhoan, matKhau);
             
        }
        bool trangThaiDongForm = false;
        private void FrmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (trangThaiDongForm == true)
                e.Cancel = false;//Cho phép đóng form
            else
                e.Cancel = true;//không cho phép đóng form
        }

       
    }
}
