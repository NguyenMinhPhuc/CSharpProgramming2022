using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pro01_20CT114
{
    public partial class Frm_Chuong03_Bai06 : Form
    {
        public Frm_Chuong03_Bai06()
        {
            InitializeComponent();
        }
        List<Product> products;
        List<Product> hoaDon;
        private void Frm_Chuong03_Bai06_Load(object sender, EventArgs e)
        {
            products = new List<Product>()
            {
                new Product(){ProductName="Phở bò",Price=50000},
                new Product("Hủ tíu nam vang",45000),
                new Product("Bún riêu",35000,0.1),
                new Product("Bún bò",30000),
                new Product("Bánh mì",15000,0.2),
                new Product("Bánh cuốn",20000),
                new Product("Cháo lòng",25000)
            };
            hoaDon = new List<Product>();
            LoadMenu(products);
           
        }

        private void LoadMenu(List<Product> products)
        {
           lbMenu.Items.Clear();
            lbMenu.DataSource = products;

            lbMenu.DisplayMember = "Display";
            lbMenu.ValueMember = "ProductName";

            lbMenu.SelectedIndex = 0;
        }

        private void lbMenu_Click(object sender, EventArgs e)
        {
           // MessageBox.Show(lbMenu.SelectedValue.ToString());
        }
       private Product ChonSanPham(string productName)
        {
            foreach (Product item in products)
            {
                if (item.ProductName == productName)
                   return item;
            }
            return null;
        }
        private void btnChon_Click(object sender, EventArgs e)
        {
            if (lbMenu.SelectedIndex >= 0)
            {
                hoaDon.Add(ChonSanPham(lbMenu.SelectedValue.ToString()));
            }
            LoadHoaDon(hoaDon);
        }
        double tongThanhTien = 0;
        private void LoadHoaDon(List<Product> hoaDon)
        {
            //Xóa datasource và items trên listBox
            lbHoaDon.DataSource = null;
            lbHoaDon.Items.Clear();
            //gán lại Datasource và thuộc tính Displaymember cho listBox.
            lbHoaDon.DataSource = hoaDon;  
            lbHoaDon.DisplayMember = "Display";
            //Tính tổng thành tiền của hóa đơn
            TinhTien(ref tongThanhTien, hoaDon);
        }

        private void TinhTien(ref double tongThanhTien, List<Product> hoaDon)
        {
            tongThanhTien = 0;
            foreach (Product item in hoaDon)
            {
                tongThanhTien += item.Price * (1 - item.Discount);
            }
            lblThanhTien.Text = string.Format("Tổng thành tiền: {0:#,###0} VND", tongThanhTien);
        }

        private void btnThucHienLai_Click(object sender, EventArgs e)
        {
            Huy();
           
        }

        private void Huy()
        {
            lbHoaDon.DataSource = null;
            lbHoaDon.Items.Clear();
            tongThanhTien = 0;
            lblThanhTien.Text = string.Format("Tổng thành tiền: {0:#,###0} VND", tongThanhTien);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (lbHoaDon.SelectedIndex >= 0)
            {
                hoaDon.RemoveAt(lbHoaDon.SelectedIndex);
                LoadHoaDon(hoaDon);
            }    
        }

        private void btnChonHet_Click(object sender, EventArgs e)
        {
            hoaDon = products;
            LoadHoaDon(hoaDon);
        }

        private void btnHuyHet_Click(object sender, EventArgs e)
        {
            Huy();
        }
    }
}
