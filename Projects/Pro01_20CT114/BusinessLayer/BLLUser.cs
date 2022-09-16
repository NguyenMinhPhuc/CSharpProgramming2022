using Pro01_20CT114.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro01_20CT114.BusinessLayer
{
    public class BLLUser
    {
        UserDao userDao;
        public BLLUser(string path)
        {
            userDao = new UserDao(path);
        }

        public bool KiemTraDangNhap(string taiKhoan,string matKhau)
        {
            return userDao.KiemTraDangNhap(taiKhoan, matKhau);
        }

        public List<User> GetUsers()
        {
            return userDao.GetUsers();
        }

        public bool CapNhatDuLieu(List<User> users)
        {
            return userDao.CapNhatDuLieu(users);
        }
    }
}
