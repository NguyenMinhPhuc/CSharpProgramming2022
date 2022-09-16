using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro01_20CT114.DataLayer
{
   public class UserDao
    {
        //Contructor- ham tao
        Database database;
        public UserDao(string path)
        {
            database = new Database(path);
        }
        //Get data
        public bool KiemTraDangNhap(string taiKhoan,string matKhau)
        {
            bool result = false;
            List<User> users = database.ReadUserFromFileINI();
            foreach (User item in users)
            {
                if (item.TaiKhoan.Equals(taiKhoan) && item.MatKhau.Equals(matKhau))
                {
                    result = true;
                    break;
                }
            }
            return result;
        }
        /// <summary>
        /// Lấy danh sách users từ file users.ini
        /// </summary>
        /// <returns>trả về ds users kiểu List<User></returns>
        public List<User> GetUsers()
        {
            return database.ReadUserFromFileINI();
        }
        //add data
        public bool CapNhatDuLieu(List<User> users)
        {
            return database.WriterUserToFileINI(users);
        }
        //update data
        //delete
    }
}
