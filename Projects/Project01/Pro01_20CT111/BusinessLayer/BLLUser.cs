using Pro01_20CT111.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Pro01_20CT111.BusinessLayer
{
    public class BLLUser
    {
        UserDao userDao;
        public BLLUser()
        {
            userDao = new UserDao();
        }
        public BLLUser(ref string err,string path)
        {
            userDao = new UserDao(ref err, path);
        }
        public bool KiemTraUser(string taiKhoan, string matKhau)
        {
            foreach (User item in userDao.Users)
            {
                if (item.TaiKhoan.Equals(taiKhoan) && item.MatKhau.Equals(matKhau))
                    return true;
            }
            return false;
        }


        public bool WriterUser(ref string err,List<User> users)
        {
            return userDao.WriterUser(ref err,users);
        }

        public List<User> GetUsers()
        {
            return userDao.Users;
        }
    }
}
