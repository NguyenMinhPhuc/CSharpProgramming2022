using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyUI_CT114
{
    public partial class MyNumberTextBox : MyTextBox
    {
        public MyNumberTextBox()
        {
            InitializeComponent();
         
            this.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        }
        public new string Text
        {
            get
            {
                if (string.IsNullOrEmpty(base.Text))
                    return "0";
                return base.Text;
            }
            set
            {
                base.Text = string.Format("{0:#,###0}", Convert.ToDouble(base.Text.Replace(",", "")));
            }
        }
        public MyNumberTextBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
          
            this.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
            base.OnKeyPress(e);
        }

        protected override void OnTextChanged(EventArgs e)
        {
            if (!string.IsNullOrEmpty(base.Text))
            {
                base.Text = string.Format("{0:#,###0}", Convert.ToDouble(base.Text.Replace(",", "")));
            }
            base.OnTextChanged(e);
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            if (base.Text.Length != 0)
            {
                int p = this.SelectionStart;
                int l = this.Text.Length;
                this.Text = base.Text;
                if (this.TextAlign == HorizontalAlignment.Left)
                {
                    this.SelectionStart = this.Text.Length < p ? Math.Abs(this.Text.Length) : Math.Abs(this.Text.Length + p - l);
                }
                else
                {
                    this.SelectionStart = this.Text.Length > p ? Math.Abs(this.Text.Length) : Math.Abs(this.Text.Length + p - l);
                }

            }
            base.OnKeyUp(e);
        }

        public int IntValue
        {
            get
            {
                return Convert.ToInt32(base.Text.Replace(",", ""));
            }
        }

        public long LongValue
        {
            get
            {
                return Convert.ToInt64(base.Text.Replace(",", ""));
            }
        }

        public double DoubleValue
        {
            get
            {
                return Convert.ToDouble(base.Text.Replace(",", ""));
            }
        }

        public float FloatValue
        {
            get
            {
                return float.Parse(base.Text.Replace(",", ""));
            }
        }
    }
}
