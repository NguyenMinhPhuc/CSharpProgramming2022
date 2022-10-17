using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLibraryUI
{
    public partial class MyCheckBox : CheckBox
    {
        public MyCheckBox()
        {
            InitializeComponent();
            this.Checked = true;
        }

        public MyCheckBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
