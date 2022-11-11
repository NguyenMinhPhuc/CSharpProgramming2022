using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace MyUI_CT114
{
    public class MyTextBox:TextBox
    {
        public MyTextBox()
        {
            this.BackColor = Color.White;
            this.Font = new Font("Arial", 18F);
            this.TextAlign = HorizontalAlignment.Left;
        }
        private Color focusBackground=Color.Aqua;
        public Color FocusBackground { get { return focusBackground; } set { focusBackground = value; } }
        protected override void OnEnter(EventArgs e)
        {
            this.BackColor = focusBackground;
            base.OnEnter(e);
        }

        protected override void OnLeave(EventArgs e)
        {
            this.BackColor = Color.White;
            if(this.Text.Length>0)
            {

            }
            base.OnLeave(e);
        }

    }
}
