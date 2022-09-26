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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //vi tri 1

            uc_Test1.txtID.Text = 4.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //vi tri 2
            pnlMenuLeft.Width = 254;

            pnlDanhMuc.Width = 250;
            pnlDanhMuc.Height = 267;

            pnlTacVu.Width = 250;
            pnlTacVu.Height = 43;

            uc_ThongTin uc_ThongTin = new uc_ThongTin();
            uc_ThongTin.Dock = DockStyle.Fill;
            uc_ThongTin.BackColor = SystemColors.GrayText;
            tp01.Controls.Add(uc_ThongTin);
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            if(pnlDanhMuc.Height== 267)
            {
                pnlDanhMuc.Height = 43;

                pnlTacVu.Height = 267;
            }
            else
            {
                pnlDanhMuc.Height = 267;

                pnlTacVu.Height = 43;
            }
        }

        private void btnTacVu_Click(object sender, EventArgs e)
        {
            if (pnlTacVu.Height == 267)
            {
                pnlTacVu.Height = 43;

                pnlDanhMuc.Height = 267;
            }
            else
            {
                pnlTacVu.Height = 267;

                pnlDanhMuc.Height = 43;
            }
        }
    }
}
