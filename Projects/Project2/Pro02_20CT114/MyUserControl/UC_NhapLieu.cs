using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pro02_20CT114.MyUserControl
{
    public partial class UC_NhapLieu : UserControl
    {
        public UC_NhapLieu()
        {
            InitializeComponent();
        }

        private void txtNhapLieu_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNhapLieu.Text))
            {
                MessageBox.Show("Khong duoc de trong");
            }
        }
    }
}
