using Pro01_20CT112_113.BusinessLayer;
using Pro01_20CT112_113.DataLayer;
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
    public partial class Frm_DoiMatKhau : Form
    {
        public Frm_DoiMatKhau()
        {
            InitializeComponent();
        }

        private void Frm_DoiMatKhau_Load(object sender, EventArgs e)
        {
            bd = new BLLUser(ClsMain.pathUserFile);
            if (!ClsMain.taiKhoan.Equals("admin"))
            {
                gbAdmin.Enabled = false;
            }
            else
            {
                loadComboUser();
            }
        }

        private void loadComboUser()
        {
            cboUser.DataSource = ClsMain.users;

            cboUser.DisplayMember = "TaiKhoan";
            cboUser.ValueMember = "TaiKhoan";

            cboUser.SelectedIndex = -1;
            cboUser.Text = "---Chọn User---";
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMatKhau1.Text) && (!string.IsNullOrEmpty(txtMatKhau2.Text)))
            {
                if (txtMatKhau1.Text.Equals(txtMatKhau2.Text))
                {
                    DoiMatKhau(txtMatKhau1.Text);
                }
            }
        }
        BLLUser bd;
        private void DoiMatKhau(string matKhau)
        {
            foreach (User item in ClsMain.users)
            {
                if (ClsMain.taiKhoan == item.TaiKhoan)
                {
                    item.MatKhau = matKhau;
                    break;
                }
                    
            }
            bd.GhiUser(ClsMain.pathUserFile, ClsMain.users);
        }
        private void DoiMatKhau(string taiKhoan,string matKhau)
        {
            foreach (User item in ClsMain.users)
            {
                if (taiKhoan == item.TaiKhoan)
                {
                    item.MatKhau = matKhau;
                    break;
                }

            }
            bd.GhiUser(ClsMain.pathUserFile, ClsMain.users);
        }

        private void btnResetMatKhau_Click(object sender, EventArgs e)
        {
            DoiMatKhau(cboUser.SelectedValue.ToString(),"Ujdl89DIDk");
        }
    }
}
