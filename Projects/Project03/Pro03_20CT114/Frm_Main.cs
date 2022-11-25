using Pro03_20CT114.BussinessLayer;
using Pro03_20CT114.DataLayer.DatabaseType;
using Pro03_20CT114.DataLayer.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pro03_20CT114
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }
        BLL_NhanVien bd;
        List<NhanVien> nhanViens;
        //string path = string.Format(@"{0}\database\NhanVien.ini", Application.StartupPath);

        Color[] colors = { Color.Green, Color.Red, Color.Black, Color.Blue, Color.Aqua, Color.Purple, Color.AliceBlue, Color.Cyan, Color.Orange };
        int indexColor = 0;
        private void Frm_Main_Load(object sender, EventArgs e)
        {
            bd = new BLL_NhanVien(ClsMain.type);
            nhanViens = new List<NhanVien>();
        }

        private void btnLayDanhSach_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.ini)|*.ini|All files (*.*)|*.*";
            openFileDialog.InitialDirectory=@"D:\";
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                LoadNhanVien(openFileDialog.FileName);
            }    
        }

        private void LoadNhanVien(string path)
        {
            nhanViens = bd.LayDanhSachNhanVien(path);
            if (nhanViens.Count > 0)
            {
                dgvDanhSachNhanVien.DataSource = null;
                dgvDanhSachNhanVien.DataSource = nhanViens;
                gbNhanVien.Text = string.Format("Số nhân viên : {0}", nhanViens.Count);
            }
        }
        private void LoadNhanVien()
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = nhanViens;
            dgvDanhSachNhanVien.DataSource = bindingSource;
            gbNhanVien.Text = string.Format("Số nhân viên : {0}", nhanViens.Count);

        }
        bool trangThaiQuay = false;
        private void btnQuaySo_Click(object sender, EventArgs e)
        {
            if (nhanViens.Count > 0)
            {
                if (!trangThaiQuay)//Quay
                {
                    timer1.Start();
                    btnQuaySo.Text = "Stop";
                    trangThaiQuay = true;
                }
                else //dung
                {
                    timer1.Stop();
                    btnQuaySo.Text = "Start";
                    trangThaiQuay = false;

                    //Luu danh sach giai
                    LuuNhanVienTrungGiai();
                }
            }
            else
            {
                MessageBox.Show("chua co nhan vien");
            }
        }
        List<NhanVienNhanGiai> nhanVienNhanGiais = new List<NhanVienNhanGiai>();
        private void LuuNhanVienTrungGiai()
        {
            NhanVien nhanVien = LayNhanVienTheoMaNhanVien(maNhanVien);
            NhanVienNhanGiai nhanVienNhanGiai = new NhanVienNhanGiai();

            nhanVienNhanGiai.MaNhanVien = nhanVien.MaNhanVien;
            nhanVienNhanGiai.TenNhanVien = nhanVien.TenNhanVien;
            nhanVienNhanGiai.PhongBan = nhanVien.PhongBan;
            nhanVienNhanGiai.GiaiThuong =cboGiaiThuong.Text;


            nhanVienNhanGiais.Add(nhanVienNhanGiai);
            nhanViens.Remove(nhanVien);
            LoadNhanVien();
            LoadNhanVienNhanGiai();
        }

        private void LoadNhanVienNhanGiai()
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = nhanVienNhanGiais;

            dgvNhanVienNhanGiai.DataSource = bindingSource;
        }

        string maNhanVien = string.Empty;
        private NhanVien LayNhanVienTheoMaNhanVien(string maNhanVien)
        {
            foreach (NhanVien item in nhanViens)
            {
                if (item.MaNhanVien.Equals(maNhanVien))
                {
                    return item;
                }
            }
            return null;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            int number = random.Next(0, nhanViens.Count - 1);
            indexColor = number % colors.Length;
            maNhanVien = nhanViens[number].MaNhanVien;
            TachSo(maNhanVien,indexColor);

        }

        private void TachSo(string maNhanVien,int indexcolor)
        {
            lblN1.Text = maNhanVien[0].ToString();
            lblN2.Text = maNhanVien[1].ToString();
            lblN3.Text = maNhanVien[2].ToString();
            lblN4.Text = maNhanVien[3].ToString();
            lblN5.Text = maNhanVien[4].ToString();
            lblN1.ForeColor = colors[indexColor];
            lblN2.ForeColor = colors[indexColor];
            lblN3.ForeColor = colors[indexColor];
            lblN4.ForeColor = colors[indexColor];
            lblN5.ForeColor = colors[indexColor];

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "";
            saveFileDialog.DefaultExt = "ini";
            saveFileDialog.Title = "Lưu danh sách trúng thường";
            saveFileDialog.InitialDirectory=@"D:\";
            saveFileDialog.AddExtension = true;
            saveFileDialog.FileName = string.Format("{0:0000}{1:00}{2:00}_{3}", DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, "GiaiThuong");
            if(saveFileDialog.ShowDialog()==DialogResult.OK)
            {
                //Lưu file
                MessageBox.Show(saveFileDialog.FileName);

            }    
        }

        private void dgvDanhSachNhanVien_DoubleClick(object sender, EventArgs e)
        {
            NhanVien nhanVien = LayNhanVienTheoMaNhanVien(dgvDanhSachNhanVien.CurrentRow.Cells["colMaNhanVien"].Value.ToString());
            nhanViens.Remove(nhanVien);
            LoadNhanVien();
        }

        private void btnBinary_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "";
            saveFileDialog.DefaultExt = "dat";
            saveFileDialog.Title = "Lưu danh sách trúng thường";
            saveFileDialog.InitialDirectory = @"D:\";
            saveFileDialog.AddExtension = true;
            saveFileDialog.FileName = string.Format("{0:0000}{1:00}{2:00}_{3}", DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, "GiaiThuong");
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                bd.GhiFileNhiPhan(saveFileDialog.FileName, nhanViens);

            }
           
        }

        private void rdoini_CheckedChanged(object sender, EventArgs e)
        {
            if(rdoini.Checked)
            {
                ClsMain.type = TypeDatabase.INI;
            }
            else
            {
                ClsMain.type = TypeDatabase.BINARY;
            }
            bd = new BLL_NhanVien(ClsMain.type);
        }
    }
}
