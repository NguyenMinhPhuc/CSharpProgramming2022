using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro01_20CT112_113.DataLayer
{
    public class DocGhiFile
    {
        string path;
        public DocGhiFile(string path)
        {
            this.path = path;
        }
        //Doc file
        public List<User> DocUser()
        {
            List<User> users = null;//Khai bao danh sach User
            using (FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                using (StreamReader streamReader = new StreamReader(fileStream))
                {
                    string line = string.Empty;
                    User user;
                    users = new List<User>();//khoi tao danh sach
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        if (!string.IsNullOrEmpty(line))
                        {
                            user = new User();//khoi tao mot user
                            users.Add(user.DocUser(line));
                            //string[] mang = line.Split(',');
                            //user.ID =Convert.ToInt32( mang[0]);
                            //user.TaiKhoan =mang[1];
                            //user.MatKhau = mang[2];
                            //user.HoVaTen = mang[3];
                            //user.NhoMatKhau = Convert.ToBoolean(mang[4]);
                            //users.Add(user);//Them user vao danh sach
                        }
                    }
                }
            }
            return users;
        }
        //Ghi file
        public bool GhiFile(string path, List<User> users)
        {
            try
            {
                using (FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write, FileShare.Write))
                {
                    using (StreamWriter streamWrite = new StreamWriter(fileStream))
                    {
                        foreach (User item in users)
                        {
                           // item.GhiUser(streamWrite);
                            streamWrite.WriteLine(string.Format("{0},{1},{2},{3},{4}", item.ID, item.TaiKhoan, item.MatKhau, item.HoVaTen, item.NhoMatKhau));
                        }
                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}
