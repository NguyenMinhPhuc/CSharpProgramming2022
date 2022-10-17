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
    public partial class Frm_GameTrucXanh : Form
    {
        public Frm_GameTrucXanh()
        {
            InitializeComponent();
        }

        private void btnMaTran2_Click(object sender, EventArgs e)
        {
            TaoButtonDongVaoFlowLayout(2, 2);
        }

        private void btnMaTran4_Click(object sender, EventArgs e)
        {
            TaoButtonDongVaoFlowLayout(4, 4);
        }

        private void btnMaTran6_Click(object sender, EventArgs e)
        {
            TaoButtonDongVaoFlowLayout(6, 6);
        }


        string[] mangKyTu = { "1", "1", "2", "2", "3", "3", "4", "4", "5", "5", "6", "6", "7", "7", "8", "8", "9", "9", "10", "10", "11", "11", "12", "12", "13", "13", "14", "14", "15", "15", "16", "16", "17", "17", "18", "18" };

        Random r = new Random();
        public void Shuffle(int dong, int cot, string[] deck)
        {
            for (int n = dong * cot - 1; n > 0; --n)
            {
                int k = r.Next(n + 1);
                string temp = deck[n];
                deck[n] = deck[k];
                deck[k] = temp;
            }
        } 
        
        private void TaoButtonDongVaoFlowLayout(int dong, int cot)
        {
            
            Shuffle(dong,cot,mangKyTu);
            Button btn;
            int index = 0;
            pnlContainer.Controls.Clear();
            for (int i = 0; i < dong * cot; i++)
            {
                btn = new Button()
                {
                    Name = string.Format("btn_{0}", index),
                    Text = mangKyTu[index].ToString(),
                    Size = new Size(200, 200),
                };
                index++;
                btn.Click += Btn_Click;
                pnlContainer.Controls.Add(btn);
            }
        }
        public void SinhSoNgauNhien()
        {
            Random rand = new Random();
            string s = "";
            int temp = 0;
            int num = 10;
            List<int> list = new List<int>();
            for (int i = 0; i < num; i++)
            {
                list.Add(i);
            }
            //random
            for (int i = 0; i < num; i++)
            {
                temp = rand.Next(list.Count);
                s += list[temp] + "\n";
                list.RemoveAt(temp);
            }
            MessageBox.Show(s);
        }
        string truoc = string.Empty;
        private void Btn_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button button = (Button)sender;
                if(string.IsNullOrEmpty(truoc))
                { 
                    truoc = button.Text; 
                }
                else
                {
                    if(truoc==button.Text)
                    {
                        foreach (Control item in pnlContainer.Controls)
                        {
                            if (item.Text == button.Text)
                                pnlContainer.Controls.Remove(item);
                        }
                    }    
                    truoc = string.Empty;
                }
            }

        }
    }
}
