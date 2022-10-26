using System;
using System.Drawing;

using System.Windows.Forms;

namespace Pro2_20CT111.MyComponents
{
   public class MyColorTextBox:TextBox
    {
        private Color backColorMyTextBox;
        public Color BackColorMyTextBox 
        {
            get { return backColorMyTextBox; }
            set { backColorMyTextBox = value; } 
        }
        public MyColorTextBox()
        {
            //khong lam gi
            this.Font = new Font("Arial", 18F);
        }

        protected override void OnEnter(EventArgs e)
        {
            BackColor = backColorMyTextBox;
            base.OnEnter(e);
        }
        protected override void OnLeave(EventArgs e)
        {
            BackColor = Color.White;
            base.OnLeave(e);
        }

    }
}
