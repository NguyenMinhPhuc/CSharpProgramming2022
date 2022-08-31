using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro01_20CT111.DataLayer
{
   public class Database
    {
        string path = string.Empty;
        public Database(string path)
        {
            this.path = path;
        }
        //Doc file
        public List<User> ReadUsers(ref string err)
        {
            List<User> users=null;
            try
            {
                using (FileStream fileStream=new FileStream(path,FileMode.Open,FileAccess.Read,FileShare.Read))
                {
                    using (StreamReader streamReader = new StreamReader(fileStream))
                    {
                        string line = string.Empty;
                        User user;//khai bao user
                        users = new List<User>();//khoi tao listUser
                        while ((line=streamReader.ReadLine())!=null)
                        {
                            string[] vs = line.Split(',');
                            //khoi tao user va gan gia tri cho thuoc tinh
                            user = new User()
                            {
                                ID = Convert.ToInt32(vs[0]),
                                TaiKhoan = vs[1],
                                MatKhau = vs[2],
                                HoVaTen = vs[3],
                                NhoMatKhau = Convert.ToBoolean(vs[4])
                            };
                            users.Add(user);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }
            return users;
        }

        //ghi file
        public bool WriterUser(ref string err,List<User> users)
        {
            bool result = false;
            try
            {
                using (FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write, FileShare.Write))
                {
                    using (StreamWriter streamWriter = new StreamWriter(fileStream, Encoding.UTF8))
                    {
                        foreach (User item in users)
                        {
                            streamWriter.WriteLine(item.ToString());
                        }
                       
                    }
                }
                result = true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }
            return result;
        }
    }
}
