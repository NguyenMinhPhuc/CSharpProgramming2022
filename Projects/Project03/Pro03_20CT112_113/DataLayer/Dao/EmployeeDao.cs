using Pro03_20CT112_113.DataLayer.DatabaseType;
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

        Database database;

        public EmployeeDao(TypeDatabase typeDatabase)
        {
            database = new Database(typeDatabase);
        }

        public List<Employee> GetEmployees(string path)
        {
            List<Employee> employees = new List<Employee>() ;

            List<string> listString = database.DatabaseFac.Database.ReadFile(path);
            Employee employee;
            foreach (string item in listString)
            {
                string[] vs = item.Split(',');
                employee = new Employee();
                employee.EmpID = vs[0];
                employee.EmpName = vs[1];
                employee.Department = vs[2];
                employees.Add(employee);
            }
            return employees;
        }
        public void LuuDanhSachNhanVienTrungThuong(string path,List<NhanVienTrungThuong> employees)
        {
            List<string> vs = new List<string>();
            foreach (NhanVienTrungThuong item in employees)
            {
                vs.Add(item.ToString());
            }

            database.DatabaseFac.Database.WriteToFile(path, vs);
        }
    }
}
