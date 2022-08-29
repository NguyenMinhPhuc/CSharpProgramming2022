using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro01_20CT112_113.DataLayer
{
   public class UserDao
    {
        private List<User> listUser;
        public List<User> ListUser { get { return listUser; } set { listUser = value; } }

        DocGhiFile docGhi;

        public UserDao()
        {
            listUser = new List<User>()
            {
                new User(){ID=1,TaiKhoan="admin",MatKhau="admin",HoVaTen="Nguyễn Minh Phúc",NhoMatKhau=true },
                 new User(){ID=2,TaiKhoan="user01",MatKhau="123456",HoVaTen="Nguyễn Minh Hoàng",NhoMatKhau=false }
            };
        }
        public UserDao(string path)
        {
            listUser = new List<User>();
            docGhi = new DocGhiFile(path);
            listUser = docGhi.DocUser();


        }

        //Thuc hiện các phương thức
        //Thêm

        //Sửa

        //Xóa

    }
}
