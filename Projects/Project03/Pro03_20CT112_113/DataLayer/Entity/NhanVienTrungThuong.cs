using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro03_20CT112_113.DataLayer.Entity
{
   public class NhanVienTrungThuong
    {
        private string empID;
        private string empName;
        private string department;
        private string giaiThuong;
        public string EmpID
        {
            get { return empID; }
            set { empID = value; }
        }
        public string EmpName
        {
            get { return empName; }
            set { empName = value; }
        }
        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        public string GiaiThuong {
            get { return giaiThuong; }
            set { giaiThuong = value; }
        }

        public override string ToString()
        {
            return string.Format("{0},{1},{2},{3}", empID, EmpName, department, giaiThuong);
        }
    }
}
