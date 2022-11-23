using Pro03_20CT111_QuaySo.BusinessLayer;
using Pro03_20CT111_QuaySo.DataLayer.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pro03_20CT111_QuaySo
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }
        BLL_NhanVien bLL_NhanVien;
        List<NhanVien> nhanViens;
        private void Frm_Main_Load(object sender, EventArgs e)
        {
            bLL_NhanVien = new BLL_NhanVien();
            nhanViens = new List<NhanVien>();
            LoadCboGiaiThuong();
        }

        private void LoadCboGiaiThuong()
        {
            List<GiaiThuong> giaiThuongs = new List<GiaiThuong>()
            {
                new GiaiThuong(){MaGiaiThuong="GT001",TenGiaiThuong="Giải đặc biệt",GiaTri=10000000},
                new GiaiThuong(){MaGiaiThuong="GT002",TenGiaiThuong="Giải Nhất",GiaTri=5000000},
                new GiaiThuong(){MaGiaiThuong="GT003",TenGiaiThuong="Giải Nhì",GiaTri=3000000},
                new GiaiThuong(){MaGiaiThuong="GT004",TenGiaiThuong="Giải ba",GiaTri=1000000}
            };
            cboGiaiThuong.DataSource = giaiThuongs;

            cboGiaiThuong.DisplayMember = "TenGiaiThuong";
            cboGiaiThuong.ValueMember = "TenGiaiThuong";
            cboGiaiThuong.SelectedIndex = -1;
            cboGiaiThuong.Text = "---Chọn giải---";
        }

        private void btnChonDanhSach_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.ini)|*.ini|All files (*.*)|*.*";
            openFileDialog.InitialDirectory=@"d:\";
            openFileDialog.Title = "Chọn tập tin danh sách nhân viên";
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                nhanViens = new List<NhanVien>();
               nhanViens= bLL_NhanVien.LayDanhSachNhanVien(openFileDialog.FileName);
                HienThiNhanVien();
            }

        }

        private void HienThiNhanVien()
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = nhanViens;

            dgvNhanVien.DataSource = bindingSource;
        }
        bool statusQuay = false;
        private void btnBatDau_Click(object sender, EventArgs e)
        {
            if (cboGiaiThuong.SelectedIndex > -1)
            {
                if (dgvNhanVien.Rows.Count > 0)
                {
                    if (!statusQuay)
                    {
                        timer1.Start();
                        btnBatDau.Text = "Dừng";
                        statusQuay = true;
                    }
                    else
                    {
                        timer1.Stop();
                        btnBatDau.Text = "Bắt đầu";
                        statusQuay = false;
                        LayNhanVienTrungGiai(maNhanVien);
                    }
                }
                else
                {
                    MessageBox.Show("Chua co danh sach nhan vien");
                }
            }
            else
            {
                MessageBox.Show("Chua chon giai");
            }
        }
        List<NhanVienNhanGiai> nhanVienNhanGiais = new List<NhanVienNhanGiai>();
        private void LayNhanVienTrungGiai(string maNhanVien)
        {
            NhanVienNhanGiai nhanVienNhanGiai;// = new NhanVienNhanGiai();
            foreach (NhanVien item in nhanViens)
            {
                if (item.MaNhanVien.Equals(maNhanVien))
                {
                    //them nhanvien vao list trung giai
                    nhanVienNhanGiai = new NhanVienNhanGiai();
                    nhanVienNhanGiai.MaNhanVien = item.MaNhanVien;
                    nhanVienNhanGiai.TenNhanVien = item.TenNhanVien;
                    nhanVienNhanGiai.PhongBan = item.PhongBan;
                    nhanVienNhanGiai.TenGiaiThuong = cboGiaiThuong.SelectedValue.ToString();
                    nhanVienNhanGiais.Add(nhanVienNhanGiai);
                    //them vao luoi trung giai
                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = nhanVienNhanGiais;

                    dgvNhanVienNhanGiai.DataSource = bindingSource;
                    //xoa khoi danh sach nhan vien
                    nhanViens.Remove(item);
                    HienThiNhanVien();
                    break;
                }
            }
           
           

        }

        string maNhanVien=string.Empty;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            int index = r.Next(0, nhanViens.Count - 1);
            int indexColor = r.Next(0, colors.Length - 1);
            maNhanVien = nhanViens[index].MaNhanVien;
            TatMaNhanVien(indexColor);
        }
        Color[] colors = { Color.Red,Color.Blue,Color.Yellow,Color.Orange,Color.Green,Color.Crimson,Color.Cyan,Color.LightCyan};
        private void TatMaNhanVien(int indexColor)
        {
            lblN1.ForeColor = colors[indexColor];
            lblN2.ForeColor = colors[(indexColor + 1)>colors.Length-1?0: indexColor + 1];
            lblN3.ForeColor = colors[(indexColor + 2) > colors.Length - 1 ? 1 : indexColor + 1];
            lblN4.ForeColor = colors[(indexColor + 3) > colors.Length - 1 ? 2 : indexColor + 1];
            lblN5.ForeColor = colors[(indexColor + 4) > colors.Length - 1 ? 3 : indexColor + 1];

            lblN1.Text = maNhanVien[0].ToString();
            lblN2.Text = maNhanVien[1].ToString();
            lblN3.Text = maNhanVien[2].ToString();
            lblN4.Text = maNhanVien[3].ToString();
            lblN5.Text = maNhanVien[4].ToString();
        }

        private void btnXuatFileINI_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "DanhSachTrungThuong";
            saveFileDialog.Title = "Luu danh sach trung giai";
            saveFileDialog.InitialDirectory = "d:\\";
            saveFileDialog.DefaultExt = "ini";
            if(saveFileDialog.ShowDialog()==DialogResult.OK)
            {
                bLL_NhanVien.GhiDanhSachTrungGiai(saveFileDialog.FileName, nhanVienNhanGiais);
            }
        }
    }
}
