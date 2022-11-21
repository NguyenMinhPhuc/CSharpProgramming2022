using Pro03_20CT112_113.DataLayer.Dao;
using Pro03_20CT112_113.DataLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro03_20CT112_113.BusinessLayer
{
   public class BLLEmployee
    {
        EmployeeDao employeeDao;
        public BLLEmployee()
        {
            employeeDao = new EmployeeDao();
        }

        public List<Employee> GetEmployees(string path)
        {
            return employeeDao.GetEmployees(path);
        }
    }
}
