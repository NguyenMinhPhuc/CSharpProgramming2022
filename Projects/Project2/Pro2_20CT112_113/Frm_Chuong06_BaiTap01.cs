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
    public partial class Frm_Chuong06_BaiTap01 : Form
    {
        public Frm_Chuong06_BaiTap01()
        {
            InitializeComponent();
        }

        private void Frm_Chuong06_BaiTap01_Load(object sender, EventArgs e)
        {
            txtSoLuongNut.Text = "50";
            txtSoLuongNutTrenHang.Text = "10";
        }

        private void txtSoLuongNut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar)&&!char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSoLuongNutTrenHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        int soLuongNut = 0;
        int soLuongTrenDong = 0;
        private void btnPhatSinh_Click(object sender, EventArgs e)
        {
            pnlContainer.Controls.Clear();
            if (!string.IsNullOrEmpty(txtSoLuongNut.Text))
            {
                if (!string.IsNullOrEmpty(txtSoLuongNutTrenHang.Text))
                {
                    soLuongNut = Convert.ToInt32(txtSoLuongNut.Text);
                    soLuongTrenDong = Convert.ToInt32(txtSoLuongNutTrenHang.Text);
                    TaoButtonDong(soLuongNut, soLuongTrenDong);
                }
                else
                {
                    MessageBox.Show("Chưa nhập số lượng nút trên dòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập số lượng nút", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void TaoButtonDong(int soLuongNut, int soLuongTrenDong)
        {
            Button btn;
           int  margin = 20;
            int index = 1;
            for (int i =0; i < soLuongNut/soLuongTrenDong+1 ; i++)
            {
                for (int j = 0; j < soLuongTrenDong; j++)
                {
                    if (index <= soLuongNut)
                    {
                        btn = new Button()
                        {
                            Name = string.Format("btn_{0}", index),
                            Text = index.ToString(),
                            Size = new Size(100, 50),
                        };
                        index++;
                        btn.Location = new Point(j * 100 + margin, i * 50 + margin);

                        btn.Click += Btn_Click;
                        pnlContainer.Controls.Add(btn);
                    }
                }
                //Game truc xanh (lập hình)

            }
        }
        private void TaoButtonDongVaoFlowLayout(int soLuongNut, int soLuongTrenDong)
        {
            Button btn;
            int index = 1;
            for (int i = 0; i < soLuongNut; i++)
            {
                btn = new Button()
                {
                    Name = string.Format("btn_{0}", index),
                    Text = index.ToString(),
                    Size = new Size(100, 50),
                };
                index++;
                btn.Click += Btn_Click;
                flowLayoutPanel1.Controls.Add(btn);
            }
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button btn = (Button)sender;
                if(btn.Text.Equals("10"))
                {
                    MessageBox.Show("Xin chuc mung ban da chung gia 1 ty dong","Trung thuong",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(string.Format("ban da an vao nut {0}",btn.Text), "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
               

        }
    }
}
