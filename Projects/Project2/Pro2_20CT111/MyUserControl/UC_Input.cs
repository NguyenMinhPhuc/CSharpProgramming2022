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
    public partial class UC_Input : UserControl
    {
        public UC_Input()
        {
            InitializeComponent();
          
        }

        private void UC_Input_Load(object sender, EventArgs e)
        {

        }

        private void txtInput1_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtInput1.Text))
            {
                MessageBox.Show("text khong rỗng");
            }    
        }

        private void txtInput1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar)&&!char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
