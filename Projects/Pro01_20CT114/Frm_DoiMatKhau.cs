using Pro01_20CT114.BusinessLayer;
using Pro01_20CT114.DataLayer;
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
    public partial class Frm_DoiMatKhau : Form
    {
        public Frm_DoiMatKhau()
        {
            InitializeComponent();
        }
        BLLUser bd;
        private void Frm_DoiMatKhau_Load(object sender, EventArgs e)
        {
           if(!ClsMain.taiKhoan.Equals("admin"))
            {
                gbAdmin.Enabled = false;
            }else
            {
                bd = new BLLUser(ClsMain.pathUser);
                ClsMain.users = bd.GetUsers();
                LoadCboUser();
            }
        }

        private void LoadCboUser()
        {
            cboUser.DataSource = ClsMain.users;

            cboUser.DisplayMember = "TaiKhoan";
            cboUser.ValueMember = "ID";

            cboUser.SelectedIndex = -1;
            cboUser.Text = "---Chọn User---";
        }

        private void btnResetMatKhau_Click(object sender, EventArgs e)
        {
            if (cboUser.SelectedIndex > -1)
            {
                CapNhatMatKhau(cboUser.SelectedValue.ToString(), "cntt@123",true);
            }
        }

        private void CapNhatMatKhau(string iD, string matKhau,bool isID)
        {
            foreach (User item in ClsMain.users)
            {
                if (isID)
                {
                    if (item.ID.ToString().Equals(iD))
                    {
                        item.MatKhau = matKhau;
                        break;
                    }
                }
                else
                {
                    if (item.TaiKhoan.ToString().Equals(iD))
                    {
                        item.MatKhau = matKhau;
                        break;
                    }
                }

            }
            ClsMain.CapNhatData(ClsMain.pathUser, ClsMain.users);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtMatKhau1.Text)&&!string.IsNullOrEmpty(txtMatKhau2.Text))
            {
                if(txtMatKhau1.Text.Equals(txtMatKhau2.Text))
                {
                   
                        CapNhatMatKhau(ClsMain.taiKhoan, txtMatKhau1.Text, false);
                    
                }
                else
                {
                    MessageBox.Show("Khong trung mat khau");
                }
            }
            else
            {
                MessageBox.Show("Khong duoc de trong");
                txtMatKhau1.Focus();
            }
        }
    }
}
