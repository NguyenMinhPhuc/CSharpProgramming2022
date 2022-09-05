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
    public partial class FrmQuanLyUser_Modifies : Form
    {
        public FrmQuanLyUser_Modifies()
        {
            InitializeComponent();
        }
        public User user;
        public bool isAdd = false;
        private void FrmQuanLyUser_Modifies_Load(object sender, EventArgs e)
        {
            bd = new BLLUser(ClsMain.pathUserFile);
            if(isAdd)
            {
                //tao id tu dong
                txtID.Enabled = false;
               txtID.Text= HamTangID().ToString();
            }
            else
            {
                txtID.Enabled = false;
                txtID.Text = user.ID.ToString();
                txtTaiKhoan.Text = user.TaiKhoan;
                txtMatKhau.Text = user.MatKhau;
                txtHoVaTen.Text = user.HoVaTen;
                ckbNhoMatKhau.Checked = user.NhoMatKhau;
            }
        }

        private int HamTangID()
        {
            int max = 0;
            foreach (User item in ClsMain.users)
            {
                if (item.ID >= max)
                    max = item.ID;
            }
            return max + 1;
        }

        BLLUser bd;
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtID.Text))
            {
                if(!string.IsNullOrEmpty(txtTaiKhoan.Text))
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
                            if (isAdd)
                            {
                                ClsMain.users.Add(user);
                            }
                            else
                            {
                                //sua
                                UpdateUser();
                            }
                          
                            //Ghi file
                            bd.GhiUser(ClsMain.pathUserFile, ClsMain.users);
                            this.Close();
                        }
                    }
                }
            }
        }

        private void UpdateUser()
        {
            foreach (User item in ClsMain.users)
            {
                if (item.ID == user.ID)
                {
                    item.TaiKhoan = user.TaiKhoan;
                    item.MatKhau = user.MatKhau;
                    item.HoVaTen = user.HoVaTen;
                    item.NhoMatKhau = user.NhoMatKhau;
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
           // txtID.ResetText();
            txtTaiKhoan.ResetText();
            txtMatKhau.ResetText();
            txtHoVaTen.ResetText();
           
        }
    }
}
