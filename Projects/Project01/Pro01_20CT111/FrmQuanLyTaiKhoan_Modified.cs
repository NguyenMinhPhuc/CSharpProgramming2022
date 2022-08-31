using Pro01_20CT111.BusinessLayer;
using Pro01_20CT111.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pro01_20CT111
{
    public partial class FrmQuanLyTaiKhoan_Modified : Form
    {
        public FrmQuanLyTaiKhoan_Modified()
        {
            InitializeComponent();
        }
        User user;
        BLLUser bd;
        string err = string.Empty;
        private void FrmQuanLyTaiKhoan_Modified_Load(object sender, EventArgs e)
        {
            bd = new BLLUser(ref err,ClsMain.path);
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            //kiem tra du lieu
            if(!string.IsNullOrEmpty(txtID.Text))
            {
                if (!string.IsNullOrEmpty(txtTaiKhoan.Text))
                {
                    if(!string.IsNullOrEmpty(txtMatKhau.Text))
                    {
                        if(!string.IsNullOrEmpty(txtHoVaTen.Text))
                        {
                            user = new User()
                            {
                                ID = Convert.ToInt32(txtID.Text),
                                TaiKhoan = txtTaiKhoan.Text,
                                MatKhau = txtMatKhau.Text,
                                HoVaTen = txtHoVaTen.Text,
                                NhoMatKhau = ckbNhoMatKhau.Checked
                            };
                            ClsMain.users.Add(user);
                            if(bd.WriterUser(ref err,ClsMain.users))
                            {
                                MessageBox.Show("Thanh cong");
                                this.Close();
                            }
                        }
                    }
                }
            }
        }

        
    }
}
