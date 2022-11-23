using Pro03_20CT112_113.BusinessLayer;
using Pro03_20CT112_113.DataLayer.DatabaseType;
using Pro03_20CT112_113.DataLayer.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pro03_20CT112_113
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        BLLEmployee bd;
        List<Employee> employees;
        private void FrmMain_Load(object sender, EventArgs e)
        {
            bd = new BLLEmployee(ClsMain.typeDatabase);
        }

        private void btnChooseList_Click(object sender, EventArgs e)
        {
            bd = new BLLEmployee(ClsMain.typeDatabase);
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.InitialDirectory = @"D:\";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                employees = bd.GetEmployees(openFileDialog.FileName);
                LoadDataEmployeeToDgv(employees);
            }
        }

        private void LoadDataEmployeeToDgv(List<Employee> employees)
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = employees;

            dgvEmployee.DataSource = bindingSource;
        }
        bool trangThaiBat = false;
        string empID = string.Empty;

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!trangThaiBat)
            {
                timer1.Start();
                timer2.Start();
                btnStart.Text = "Stop";
                trangThaiBat = true;
            }else
            {
                timer1.Stop();
                timer2.Stop();
                btnStart.Text = "Start";
                trangThaiBat = false;
                SaveNhanVienTrungThuong(empID);
            }
        }
        private Employee LayNhanVienTheoID(string empID)
        {
            foreach (Employee item in employees)
            {
                if (item.EmpID.Equals(empID))
                    return item;
            }
            return null;
        }
        List<NhanVienTrungThuong> nhanVienTrungThuongs=new List<NhanVienTrungThuong>();
        private void SaveNhanVienTrungThuong(string empID)
        {
            //Luu vao luoi
            Employee employee = LayNhanVienTheoID(empID);
           
            NhanVienTrungThuong nhanVienTrungThuong = new NhanVienTrungThuong();
            nhanVienTrungThuong.EmpID = employee.EmpID;
            nhanVienTrungThuong.EmpName = employee.EmpName;
            nhanVienTrungThuong.Department = employee.Department;
            nhanVienTrungThuong.GiaiThuong = cboGiaiThuong.Text;
          
            nhanVienTrungThuongs.Add(nhanVienTrungThuong);
            LoadDataToGridView(nhanVienTrungThuongs);
        
            //xoa danh sach tren luoi
            employees.Remove(employee);
            //Goi lai luoi
            LoadDataEmployeeToDgv(employees);
        }

        private void LoadDataToGridView(List<NhanVienTrungThuong> nhanVienTrungThuongs)
        {

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = nhanVienTrungThuongs;

            dgvNhanVienTrungThuong.DataSource = bindingSource;
        }

        int dem = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            int number = random.Next(0, employees.Count - 1);
            empID = employees[number].EmpID;
            SplitEmpID(empID);
            timer1.Interval += 1;
           
        }

        private void SplitEmpID(string empID)
        {
            int i = new Random().Next(0, colors.Length - 1);
            lblN1.Text = empID[0].ToString();
            lblN1.ForeColor = colors[i];
            lblN2.Text = empID[1].ToString();
            lblN2.ForeColor = colors[(i + 1) > colors.Length - 1 ? 0 : i + 1];
            lblN3.Text = empID[2].ToString();
            lblN3.ForeColor = colors[(i + 2) > colors.Length - 1 ? 0 : i + 2];
            lblN4.Text = empID[3].ToString();
            lblN4.ForeColor = colors[(i + 3) > colors.Length - 1 ? 0 : i + 3];
            lblN5.Text = empID[4].ToString();
            lblN5.ForeColor = colors[(i + 4)>colors.Length-1?0:i+4];
        }

        private void rdoIni_CheckedChanged(object sender, EventArgs e)
        {
            if(rdoIni.Checked)
            {
                ClsMain.typeDatabase = TypeDatabase.INI;
            }
            else
            {
                ClsMain.typeDatabase = TypeDatabase.TEXT;
            }
        }

        private void btnLuuNhanVienTrungThuong_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.DefaultExt = "ini";
            saveFileDialog.InitialDirectory = "D:\\";
            saveFileDialog.FileName = "NhanVienTrungThuong";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                bd.LuuDanhSachNhanVienTrungThuong(saveFileDialog.FileName, nhanVienTrungThuongs);
            }
        }

        Color[] colors = { Color.Red, Color.Green, Color.Blue, Color.Black, Color.Violet, Color.Orange, Color.Aqua };

        private void timer2_Tick(object sender, EventArgs e)
        {
            dem++;
            if (dem == 1000)
            {   timer1.Stop();
                btnStart.Text = "Start";
                trangThaiBat = false;
                SaveNhanVienTrungThuong(empID);
            }
                

        }
    }
}
