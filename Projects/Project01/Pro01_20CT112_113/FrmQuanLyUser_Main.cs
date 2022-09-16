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
    public partial class FrmQuanLyUser_Main : Form
    {
        public FrmQuanLyUser_Main()
        {
            InitializeComponent();
        }
        BLLUser bd;
        //List<User> users;//khai bao 1 danh sach user 
        private void FrmQuanLyUser_Main_Load(object sender, EventArgs e)
        {
            bd = new BLLUser(ClsMain.pathUserFile);

            HienThiDanhSachUsers();
        }

        private void HienThiDanhSachUsers()
        {
            //users = new List<User>();
            //users = bLLUser.GetUsers();

            //dua du lieu vao luoi (datagridview)
            var bindingList = new BindingList<User>(ClsMain.users);
            var source = new BindingSource(bindingList, null);

            dgvTaiKhoan.DataSource = source;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FrmQuanLyUser_Modifies frmQuanLyUser_Modifies = new FrmQuanLyUser_Modifies();
            frmQuanLyUser_Modifies.isAdd = true;
            frmQuanLyUser_Modifies.ShowDialog();

            HienThiDanhSachUsers();
        }
        User user;
        int index = -1;
        private void dgvTaiKhoan_Click(object sender, EventArgs e)
        {
            if (dgvTaiKhoan.Rows.Count > 0)
            {
                user = new User()
                {
                    ID = Convert.ToInt32(dgvTaiKhoan.CurrentRow.Cells["colID"].Value.ToString()),
                    TaiKhoan = dgvTaiKhoan.CurrentRow.Cells["colTaiKhoan"].Value.ToString(),
                    MatKhau = dgvTaiKhoan.CurrentRow.Cells["colMatKhau"].Value.ToString(),
                    HoVaTen = dgvTaiKhoan.CurrentRow.Cells["colHoVaTen"].Value.ToString(),
                    NhoMatKhau = Convert.ToBoolean(dgvTaiKhoan.CurrentRow.Cells["colNhoMatKhau"].Value.ToString())
                };
                index = dgvTaiKhoan.CurrentRow.Index;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(user!=null)
            {
                FrmQuanLyUser_Modifies frmQuanLyUser_Modifies = new FrmQuanLyUser_Modifies();
                frmQuanLyUser_Modifies.user = user;
                frmQuanLyUser_Modifies.isAdd = false;
                frmQuanLyUser_Modifies.ShowDialog();
                HienThiDanhSachUsers();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (user != null)
            {
                ClsMain.users.RemoveAt(index);
                bd.GhiUser(ClsMain.pathUserFile, ClsMain.users);
                HienThiDanhSachUsers();
            }
            else
            {
                MessageBox.Show("chua chon");
            }
        }

        private void btnNapLai_Click(object sender, EventArgs e)
        {
            HienThiDanhSachUsers();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
