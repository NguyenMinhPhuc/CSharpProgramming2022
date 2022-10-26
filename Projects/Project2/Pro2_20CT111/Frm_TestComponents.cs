using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pro2_20CT111
{
    public partial class Frm_TestComponents : Form
    {
        public Frm_TestComponents()
        {
            InitializeComponent();
        }

        private void btnInt_Click(object sender, EventArgs e)
        {
            MessageBox.Show(myNumberTextBox1.IntValue.ToString());
        }
    }
}
