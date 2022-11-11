using Pro02_20CT114.MyUserControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pro02_20CT114
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlHeThong.Height = 251;
            pnlDanhMuc.Height = 45;
            timer1.Enabled = true;
            lblGioHeThong.Text = string.Format("{0}", DateTime.Now.ToString());
            //timer1.Start();

            SinhButton(10);
        }

        private void SinhButton(int soLuong)
        {
            Button btn;
            for (int i = 0; i < 100; i++)
            {
                btn = new Button();
                btn.BackColor = System.Drawing.Color.Green;
                btn.FlatAppearance.BorderSize = 0;
                btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
                btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
                
                btn.Name = "btn"+(i+1).ToString();
                btn.Size = new System.Drawing.Size(100, 100);
                btn.TabIndex = i;
                btn.Text = new Random().Next(1, 100).ToString();
                btn.UseVisualStyleBackColor = false;
                btn.Click += Btn_Click;
                pnlContainer.Controls.Add(btn);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            if(sender is Button)
            {
                MessageBox.Show(((Button)sender).Text);
            }    
        }

        private void btnHeThong_Click(object sender, EventArgs e)
        {
            if(pnlHeThong.Height==251)
            {
                pnlHeThong.Height = 45;
            }
            else
            {
                pnlHeThong.Height = 251;
                pnlDanhMuc.Height = 45;
            }  
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            if (pnlDanhMuc.Height == 251)
            {
                pnlDanhMuc.Height = 45;
            }
            else
            {
                pnlDanhMuc.Height = 251;
                pnlHeThong.Height = 45;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblGioHeThong.Text = string.Format("{0}", DateTime.Now.ToString());
        }

        private void btnQuanLyNguoiDung_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            UC_QuanLyNguoiDung uC_QuanLyNguoiDung = new UC_QuanLyNguoiDung();
            uC_QuanLyNguoiDung.Dock = DockStyle.Fill;
            tpUserControl.Controls.Add(uC_QuanLyNguoiDung);
        }
    }
}
