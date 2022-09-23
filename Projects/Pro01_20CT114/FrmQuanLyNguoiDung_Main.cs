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
    public partial class FrmQuanLyNguoiDung_Main : Form
    {
        public FrmQuanLyNguoiDung_Main()
        {
            InitializeComponent();
        }
        BLLUser bd;
        private void FrmQuanLyNguoiDung_Main_Load(object sender, EventArgs e)
        {
            bd = new BLLUser(ClsMain.pathUser);
            ClsMain.users=bd.GetUsers();
            HienThiDanhSachUsers();
        }

        private void HienThiDanhSachUsers()
        {
            var bindingList = new BindingList<User>(ClsMain.users);
            var source = new BindingSource(bindingList, null);

            dgvUsers.DataSource = source;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FrmQuanLyNguoiDung_Modified frm_QuanLyNguoiDung_Modified = new FrmQuanLyNguoiDung_Modified();
            frm_QuanLyNguoiDung_Modified.isAdd = true;
            frm_QuanLyNguoiDung_Modified.ShowDialog();
            HienThiDanhSachUsers();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (user != null)
            {


                FrmQuanLyNguoiDung_Modified frm_QuanLyNguoiDung_Modified = new FrmQuanLyNguoiDung_Modified();
                frm_QuanLyNguoiDung_Modified.isAdd = false;
                frm_QuanLyNguoiDung_Modified.user = user;
                frm_QuanLyNguoiDung_Modified.ShowDialog();
                HienThiDanhSachUsers();
                user = null;
            }
        }
        User user=null;
        private void dgvUsers_Click(object sender, EventArgs e)
        {
            if(dgvUsers.Rows.Count>0)
            {
                user = new User()
                {
                    ID =Convert.ToInt32( dgvUsers.CurrentRow.Cells["colID"].Value.ToString()),
                    HoVaTen= dgvUsers.CurrentRow.Cells["colHoVaTen"].Value.ToString(),
                    TaiKhoan = dgvUsers.CurrentRow.Cells["colTaiKhoan"].Value.ToString(),
                    MatKhau = dgvUsers.CurrentRow.Cells["colMatKhau"].Value.ToString(),
                    NhoMatKhau =Convert.ToBoolean( dgvUsers.CurrentRow.Cells["colNhoMatKhau"].Value.ToString())

                };
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (user != null)
            {
                XoaUser(user.ID);
            }
            else
            {
                MessageBox.Show("chua chon use");
            }
        }

        private void XoaUser(int iD)
        {
            foreach (User item in ClsMain.users.ToList())
            {
                if (item.ID == iD)
                {
                    ClsMain.users.Remove(user);
                    HienThiDanhSachUsers();
                    user = null;
                    break;
                }
            }

            ClsMain.CapNhatData(ClsMain.pathUser,ClsMain.users);
        }
        private void XoaUser(string iD)
        {
            User user = TimKiem(Convert.ToInt32(iD))[0];

            ClsMain.users.Remove(user);
            HienThiDanhSachUsers();

            ClsMain.CapNhatData(ClsMain.pathUser, ClsMain.users);
        }
        public List<User> TimKiem(int iD)
        {
            List<User>  results = ClsMain.users.FindAll(
            delegate (User user)
            {
                return user.ID ==iD;
            }
            );
            if (results.Count != 0)
            {
                return results;
            }
            else
            {
                return null;
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
