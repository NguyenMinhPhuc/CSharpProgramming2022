using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro03_20CT112_113.DataLayer.Entity
{
   public class Employee
    {
        private string empID;
        private string empName;
        private string department;

        public string EmpID { 
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
    }
}
