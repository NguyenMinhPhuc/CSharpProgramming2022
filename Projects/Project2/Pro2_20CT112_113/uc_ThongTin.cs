using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pro2_20CT112_113
{
    public partial class uc_ThongTin : UserControl
    {
        public uc_ThongTin()
        {
            InitializeComponent();
        }

        private void uc_ThongTin_Load(object sender, EventArgs e)
        {
            Button button;
            int k = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    button = new Button();
                    button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
                    button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
                    button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    button.ForeColor = System.Drawing.Color.White;
                  
                    button.Name = string.Format("btn{0:00}", ++k);
                    button.Text= string.Format("{0:0}", k);
                    button.Font = new Font("Wingdings", 60);
                    button.TabIndex = k;
                    int x = 300;
                    int y = 300;
                    button.Size = new Size(x, y);
                   
                    button.Location = new Point(j*(x+20), i*(y+20));
                    button.Click += Button_Click;
                    this.Controls.Add(button);
                }
                
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = Color.Blue;
            MessageBox.Show(button.Name);
        }
    }
}
