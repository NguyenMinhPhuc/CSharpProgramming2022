using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryUI
{
    public partial class WasterMaskTextBox : ColorTextBox
    {
        public WasterMaskTextBox()
        {
            this.Text = WasterMask;
            this.ForeColor = Color.LightGray;
            InitializeComponent();
            
        }
        private string wasterMask = "Enter...";
        private bool enableWasterMask = false;
        public string WasterMask { get => wasterMask; set => wasterMask = value; }
        public bool EnableWasterMask { get => enableWasterMask; set => enableWasterMask = value; }

        protected override void OnEnter(EventArgs e)
        {
            this.Text = string.Empty;
            this.ForeColor = Color.Black;
            base.OnEnter(e);
        }
        protected override void OnLeave(EventArgs e)
        {
            if (this.Text.Length == 0)
            {
                this.Text = wasterMask;
                this.ForeColor = Color.LightGray;
            }
            else
            {
                this.ForeColor = Color.Black;
            }
              
            base.OnLeave(e);
        }
        public WasterMaskTextBox(IContainer container)
        {
            this.Text = wasterMask;
            this.ForeColor = Color.LightGray;
            container.Add(this);
           
            InitializeComponent();
        }
    }
}
