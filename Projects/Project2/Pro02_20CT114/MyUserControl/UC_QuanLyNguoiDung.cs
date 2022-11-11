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
    public partial class UC_QuanLyNguoiDung : UserControl
    {
        public UC_QuanLyNguoiDung()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtNumber.Text,"Text");
            MessageBox.Show(txtNumber.IntValue.ToString(), "Int");
            MessageBox.Show(txtNumber.LongValue.ToString(), "Long");
            MessageBox.Show(txtNumber.DoubleValue.ToString(), "Double");
            MessageBox.Show(txtNumber.FloatValue.ToString(), "Float");
        }
    }
}
