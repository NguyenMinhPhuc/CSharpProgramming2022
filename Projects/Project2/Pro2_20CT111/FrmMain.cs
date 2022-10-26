using Pro2_20CT111.MyUserControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pro2_20CT111
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            pnlHeThong.Height = 261;
            pnlDanhMuc.Height = 46;
            pnlTacVu.Height = 46;

            TaoButtonDong(4, 4);

            panel1.Dock = DockStyle.Fill;
            panel1.Size = new Size(120,120);
        }
        string[] mangA = { "1", "2", "3", "4", "5", "6", "7", "8", "1", "2", "3", "4", "5", "6", "7", "8" };

     
        private void TaoButtonDong(int row, int colum)
        {
            Button button;
            int index = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < colum; j++)
                {
                    button = new Button();
                    button.BackColor = System.Drawing.Color.Blue;
                    button.FlatAppearance.BorderSize = 0;
                    button.FlatAppearance.MouseOverBackColor = SystemColors.ControlDark;
                    button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    button.Font = new System.Drawing.Font("Webdings", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    button.ForeColor = System.Drawing.Color.White;

                    button.Location = new System.Drawing.Point(i*(120+5), j*(120+5));

                    button.Name = string.Format("btn{0:00}", ++index);
                    button.Size = new System.Drawing.Size(120, 120);
                    button.TabIndex = index;
                    button.Text = mangA[new Random().Next(0, 15)];
                    button.Tag = "0";
                    button.UseVisualStyleBackColor = false;
                    button.Click += Button_Click;
                    tabPage1.Controls.Add(button);
                }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = Color.Red;
            button.Text = string.Format("{0:00}",Convert.ToInt32(button.Tag) + 1);
            button.Tag= (Convert.ToInt32(button.Tag) + 1).ToString();



        }

        private void btnHeThong_Click(object sender, EventArgs e)
        {
            if(pnlHeThong.Height==261)
            {
                pnlHeThong.Height = 46;
            }
            else
            {
                pnlHeThong.Height = 261;
                pnlDanhMuc.Height = 46;
                pnlTacVu.Height = 46;
            }
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            if (pnlDanhMuc.Height == 261)
            {
                pnlDanhMuc.Height = 46;
            }
            else
            {
                pnlDanhMuc.Height = 261;
                pnlHeThong.Height = 46;
                pnlTacVu.Height = 46;
            }
        }

        private void btnTacVu_Click(object sender, EventArgs e)
        {

            if (pnlTacVu.Height == 261)
            {
                pnlTacVu.Height = 46;
            }
            else
            {
                pnlTacVu.Height = 261;
                pnlHeThong.Height = 46;
                pnlDanhMuc.Height = 46;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            UC_QuanLyNguoiDung uC_QuanLyNguoiDung = new UC_QuanLyNguoiDung();
            uC_QuanLyNguoiDung.Dock = DockStyle.Fill;
            tpUserControl.Controls.Add(uC_QuanLyNguoiDung);
            
        }
    }
}
