using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pro2_20CT111.MyUserControl
{
    public partial class UC_QuanLyNguoiDung : UserControl
    {
        public UC_QuanLyNguoiDung()
        {
            InitializeComponent();
        }

        private void UC_QuanLyNguoiDung_Load(object sender, EventArgs e)
        {

            uC_Input1.label1.Text = "User name: ";
            uC_Input2.label1.Text = "password: ";
            uC_Input1.txtInput1.Width = 300;
        }
    }
}
