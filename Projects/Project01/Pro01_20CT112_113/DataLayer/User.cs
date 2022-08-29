using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro01_20CT112_113.DataLayer
{
   public class User
    {
        //Field
        private int iD;
        private string taiKhoan;
        private string matKhau;
        private string hoVaTen;
        private bool nhoMatKhau;
        //Properties
        public int ID { 
            get { return iD; } 
            set { iD = value;} 
        }
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public string HoVaTen { get; set; }
        public bool NhoMatKhau { get; set; }

        public User DocUser(string line)
        {
            User user = new User();//khoi tao mot user
            string[] mang = line.Split(',');
            user.ID = Convert.ToInt32(mang[0]);
            user.TaiKhoan = mang[1];
            user.MatKhau = mang[2];
            user.HoVaTen = mang[3];
            user.NhoMatKhau = Convert.ToBoolean(mang[4]);

            return user;
        }
        public void GhiUser(StreamWriter streamWriter)
        {
            streamWriter.WriteLine(string.Format("{0},{1},{2},{3},{4}",ID,TaiKhoan,MatKhau,HoVaTen,NhoMatKhau));
        }
    }
}
