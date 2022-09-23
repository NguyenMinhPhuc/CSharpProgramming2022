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
    public partial class FrmQuanLyTaiKhoan_Main : Form
    {
        public FrmQuanLyTaiKhoan_Main()
        {
            InitializeComponent();
        }
        BLLUser bd;
        string err = string.Empty;
        private void btnThem_Click(object sender, EventArgs e)
        {
            FrmQuanLyTaiKhoan_Modified frmQuanLyTaiKhoan_Modified = new FrmQuanLyTaiKhoan_Modified();
            frmQuanLyTaiKhoan_Modified.isAdd = true;
            frmQuanLyTaiKhoan_Modified.ShowDialog();
            LoadUsers();
        }

        private void FrmQuanLyTaiKhoan_Main_Load(object sender, EventArgs e)
        {
            bd = new BLLUser(ref err, ClsMain.path);
            LoadUsers();
        }

        private void LoadUsers()
        {
            var bindingList = new BindingList<User>(ClsMain.users);
            var source = new BindingSource(bindingList, null);

            dgvUsers.DataSource = source;
        }
        //khai báo 1 (đối tượng) biến kiểu User 
        User user=null;
        private void dgvUsers_Click(object sender, EventArgs e)
        {
            //Lấy dữ liệu User tại dòng hiện tại của lưới
            if (dgvUsers.Rows.Count > 0)
            {
                user = new User()
                {
                    ID = Convert.ToInt32(dgvUsers.CurrentRow.Cells["colID"].Value.ToString()),

                    TaiKhoan = dgvUsers.CurrentRow.Cells["colTaiKhoan"].Value.ToString(),

                    MatKhau = dgvUsers.CurrentRow.Cells["colMatKhau"].Value.ToString(),

                    HoVaTen = dgvUsers.CurrentRow.Cells["colHoVaTen"].Value.ToString(),

                    NhoMatKhau = Convert.ToBoolean(dgvUsers.CurrentRow.Cells["colNhoMatKhau"].Value.ToString())
                };
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (user != null)
            {
                FrmQuanLyTaiKhoan_Modified frmQuanLyTaiKhoan_Modified = new FrmQuanLyTaiKhoan_Modified();
                frmQuanLyTaiKhoan_Modified.user = user;
                frmQuanLyTaiKhoan_Modified.isAdd = false;
                frmQuanLyTaiKhoan_Modified.ShowDialog();
                //Goi lai ds load user 
                LoadUsers();
                user = null;

            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(user!=null)
            {
                int index = 0;
                foreach (User item in ClsMain.users.ToList())
                {
                    if (item.ID == user.ID)
                    {
                        ClsMain.users.RemoveAt(index);
                        break;
                    } 
                    index++;
                }
               
                if (bd.WriterUser(ref err, ClsMain.users))
                { 
                    LoadUsers();
                    MessageBox.Show("Thanh cong");
                   
                }
                user = null;
            }
            else
            {
                MessageBox.Show("Chưa chọn tài khoản cần xóa!\nXin vui lòng chọn lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnChangedPassword_Click(object sender, EventArgs e)
        {
            if (user != null)
            {
                if(ClsMain.taiKhoan.Equals("admin"))
                { Frm_DoiMatKhau frm_DoiMatKhau = new Frm_DoiMatKhau();
                frm_DoiMatKhau.id = user.ID;
                frm_DoiMatKhau.ShowDialog();
                user = null;
                }
                else
                {
                    MessageBox.Show("User khong co quyen nay");
                }
               
            }
            else
            {
                MessageBox.Show("Chua chon User");
            }
            
        }
    }
}
