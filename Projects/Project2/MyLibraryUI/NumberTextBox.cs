
using System;
using System.ComponentModel;

using System.Windows.Forms;

namespace MyLibraryUI
{
    public partial class NumberTextBox : ColorTextBox
    {
        public NumberTextBox()
        {
            InitializeComponent();
            this.TextAlign = HorizontalAlignment.Right;
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
                base.Text = string.Format("{0:#,###0}",Convert.ToDouble(value.Replace(",","")));
            }
        }
        public int IntValue
        {
            get 
            {
                return Convert.ToInt32(Text.Replace(",", ""));
            }
            //set
            //{
            //    this.Text = value.ToString();
            //}
        }
        public long LongValue
        {
            get
            {
                return Convert.ToInt64(Text.Replace(",", ""));
            }
        }
        public double DoubleValue
        {
            get
            {
                return Convert.ToDouble(Text.Replace(",", ""));
            }
        }
        private double vAT = 0.1;
        public double VAT
        {
            get { return vAT; }
            set { vAT = value; }
        }
        public double VATValue
        {
            get
            {
                return Convert.ToDouble(Text.Replace(",", ""))* (1-vAT);
            }
        }
        public NumberTextBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 46 && e.KeyChar != 45 && e.KeyChar != 8))
                e.Handled = true;
            base.OnKeyPress(e);
        }

        protected override void OnTextChanged(EventArgs e)
        {
            this.Text= string.Format("{0:#,###0}", Convert.ToDouble(this.Text.Replace(",", "")));
            base.OnTextChanged(e);
        }
        protected override void OnKeyUp(KeyEventArgs e)
        {
            if(base.Text.Length!=0)
            {
                int p = this.SelectionStart;
                int l = this.Text.Length;
                this.Text = base.Text;
                if(this.TextAlign==HorizontalAlignment.Left)
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
    }
}
