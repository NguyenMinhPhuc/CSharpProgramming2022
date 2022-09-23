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
    public partial class Frm_DoiMatKhau : Form
    {
        public Frm_DoiMatKhau()
        {
            InitializeComponent();
        }
        string err = string.Empty;
        BLLUser bd;

        public int id = 0;
        private void Frm_DoiMatKhau_Load(object sender, EventArgs e)
        {
            bd = new BLLUser(ref err,ClsMain.path);
            if(!ClsMain.taiKhoan.Equals("admin"))
            {
                gbAdmin.Enabled = false;
                gbUser.Text = string.Format("User: {0}", ClsMain.taiKhoan);
                txtPassword1.Focus();


            }
            else
            {
                LoadCboUsers();
                cboUsers.SelectedValue = id;
            }
        }

        private void LoadCboUsers()
        {
            cboUsers.DataSource = ClsMain.users;

            cboUsers.DisplayMember = "TaiKhoan";
            cboUsers.ValueMember = "ID";

            cboUsers.SelectedIndex = -1;
            cboUsers.Text = "---Select user---";

        }
        
        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            ChangedPassword(id.ToString(), "123456789", true);
        }
       
        private void cboUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboUsers.SelectedIndex>0)
            {
                id = Convert.ToInt32(cboUsers.SelectedValue.ToString());
            }
        }

      

        private void ChangedPassword(string taiKhoan, string matKhau, bool isID)
        {
            if (isID)
            {
                foreach (User item in ClsMain.users)
                {
                    if (item.ID.ToString().Equals(taiKhoan))
                    {
                        item.MatKhau = matKhau;
                        break;
                    }
                }
                
            }
            else
            {
                foreach (User item in ClsMain.users)
                {
                    if (item.TaiKhoan.Equals(taiKhoan))
                    {
                        item.MatKhau = matKhau;
                        break;
                    }
                }
            }
            //ghi file
                if (bd.WriterUser(ref err, ClsMain.users))
                {
                    MessageBox.Show("Thanh cong");
                    this.Close();
                }
        }

        private void btnChangedPassword_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPassword1.Text))
            {
                if (!string.IsNullOrEmpty(txtPassword2.Text))
                {
                    if (txtPassword1.Text.Equals(txtPassword2.Text))
                    {
                        ChangedPassword(ClsMain.taiKhoan, txtPassword2.Text, false);
                    }
                }
            }
        }
    }
}
