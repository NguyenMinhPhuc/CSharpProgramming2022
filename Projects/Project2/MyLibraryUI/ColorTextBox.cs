using System;
using System.Windows.Forms;
using System.Drawing;

namespace MyLibraryUI
{
    public class ColorTextBox:TextBox
    {
        public ColorTextBox()
        {
            this.Font = new Font("Arial", 18F);
            this.TextAlign = HorizontalAlignment.Left;
            this.BackColor = Color.White;
        }
        private Color backColorFocus = Color.Aqua;
        public Color BackColorFocus
        {
            get { return backColorFocus; }
            set { backColorFocus = value; }
        }

        protected override void OnEnter(EventArgs e)
        {
            this.BackColor = backColorFocus;
            base.OnEnter(e);
        }

        protected override void OnLeave(EventArgs e)
        {
            this.BackColor = Color.White;
            base.OnLeave(e);
        }
    }
}
