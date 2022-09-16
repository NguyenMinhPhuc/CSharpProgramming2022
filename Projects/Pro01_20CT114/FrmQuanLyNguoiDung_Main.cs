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
            HienThiDanhSachUsers();
        }

        private void HienThiDanhSachUsers()
        {
            ClsMain.users=bd.GetUsers();

            var bindingList = new BindingList<User>(ClsMain.users);
            var source = new BindingSource(bindingList, null);

            dgvUsers.DataSource = source;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Frm_QuanLyNguoiDung_Modified frm_QuanLyNguoiDung_Modified = new Frm_QuanLyNguoiDung_Modified();
            frm_QuanLyNguoiDung_Modified.isAdd = true;
            frm_QuanLyNguoiDung_Modified.ShowDialog();
            HienThiDanhSachUsers();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (user != null)
            {


                Frm_QuanLyNguoiDung_Modified frm_QuanLyNguoiDung_Modified = new Frm_QuanLyNguoiDung_Modified();
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
    }
}
