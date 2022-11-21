using Pro03_20CT112_113.DataLayer.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro03_20CT112_113.DataLayer.Dao
{
   public class EmployeeDao
    {

        public List<Employee> GetEmployees(string path)
        {
            List<Employee> employees=null;
            Employee employee;
            using(FileStream fs =new FileStream(path,FileMode.Open,FileAccess.Read,FileShare.Read))
            {
                using(StreamReader sr=new StreamReader(fs))
                {
                    string line = string.Empty;
                    employees = new List<Employee>();
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (!string.IsNullOrEmpty(line))
                        {
                            string[] vs = line.Split(',');
                            employee = new Employee();
                            employee.EmpID = vs[0];
                            employee.EmpName = vs[1];
                            employee.Department = vs[2];
                            employees.Add(employee);
                        }
                    }
                }
            }
            return employees;
        }
    }
}
