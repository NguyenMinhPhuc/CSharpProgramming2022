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

        private void btnThem_Click(object sender, EventArgs e)
        {
            FrmQuanLyTaiKhoan_Modified frmQuanLyTaiKhoan_Modified = new FrmQuanLyTaiKhoan_Modified();
            frmQuanLyTaiKhoan_Modified.ShowDialog();
            LoadUsers();
        }

        private void FrmQuanLyTaiKhoan_Main_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void LoadUsers()
        {
            var bindingList = new BindingList<User>(ClsMain.users);
            var source = new BindingSource(bindingList, null);
        
            dgvUsers.DataSource = source;
        }
    }
}
