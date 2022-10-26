using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pro2_20CT111.MyComponents
{
    public partial class MyNumberTextBox : MyColorTextBox
    {
        public MyNumberTextBox()
        {
            InitializeComponent();
            this.TextAlign = HorizontalAlignment.Right;
            base.Text = "0";

        }
        public new string Text
        {
            get
            {
                if (base.Text.Length == 0)
                    return "0";
                return base.Text.Trim();
            }
            set
            {
                base.Text = string.Format("{0:#,###0}", Convert.ToDouble(value.Replace(",", "")));
            }
        }
        public MyNumberTextBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            this.TextAlign = HorizontalAlignment.Right;
            base.Text = "0";
        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar)&&!char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }
        protected override void OnTextChanged(EventArgs e)
        {
            this.Text = string.Format("{0:#,###0}", Convert.ToDouble(this.Text.Replace(",", "")));
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

        public int IntValue { get 
            { 
                if(!string.IsNullOrEmpty(base.Text))
                return Convert.ToInt32(base.Text.Replace(",",""));
                return 0;
            } 
        }
        public long LongValue { get { return Convert.ToInt64(base.Text.Replace(",", "")); } }
        public double DoubleValue { get { return Convert.ToDouble(base.Text.Replace(",", "")); } }
        public float FloatValue { get { return float.Parse(base.Text.Replace(",", "")); } }
    }
}
