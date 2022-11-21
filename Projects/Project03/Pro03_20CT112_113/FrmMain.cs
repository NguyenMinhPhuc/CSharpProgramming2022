using Pro03_20CT112_113.BusinessLayer;
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
            bd = new BLLEmployee();
        }

        private void btnChooseList_Click(object sender, EventArgs e)
        {
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
                btnStart.Text = "Stop";
                trangThaiBat = true;
            }else
            {
                timer1.Stop();
                btnStart.Text = "Start";
                trangThaiBat = false;
                SaveNhanVienTrungThuong(empID);
            }
        }

        private void SaveNhanVienTrungThuong(string empID)
        {
            throw new NotImplementedException();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            int number = random.Next(0, employees.Count - 1);
            empID = employees[number].EmpID;
            SplitEmpID(empID);
        }

        private void SplitEmpID(string empID)
        {
            lblN1.Text = empID[0].ToString();
            lblN2.Text = empID[1].ToString();
            lblN3.Text = empID[2].ToString();
            lblN4.Text = empID[3].ToString();
            lblN5.Text = empID[4].ToString();
        }
    }
}
