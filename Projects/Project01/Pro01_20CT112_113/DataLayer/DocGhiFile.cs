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
        //Biến chứa đường dẫn file
        string path;
        //Hàm tạo của Class dùng để khởi tạo đường dẫn file Users.ini
        public DocGhiFile(string path)
        {
            this.path = path;
        }
       /// <summary>
       /// Phương thức đọc file Users.ini và trả về danh sách users chứa trong file
       /// </summary>
       /// <returns>Danh sách users kiểu List<User></returns>
        public List<User> DocUser()
        {
            //Khai báo biến danh sách kiểu User 
            List<User> users = null;
            //Cú pháp để khai báo làm việc với file
            using (FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                //Cú pháp khai báo để làm việc với Class StreamReader để đọc file text.
                using (StreamReader streamReader = new StreamReader(fileStream))
                {
                    string line = string.Empty;
                   // Khai báo biến kiểu User 
                    User user;
                    //Khởi tạo danh sách User 
                    users = new List<User>();
                    //Vòng lặp đọc nội dung trong file, vòng lặp dừng khi đọc hết file (null)
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        //Xử lý từng dòng đọc được trong file text
                        if (!string.IsNullOrEmpty(line))
                        {
                            user = new User();//khoi tao mot user
                                              // users.Add(user.DocUser(line));
                            string[] mang = line.Split(',');
                            user.ID = Convert.ToInt32(mang[0]);
                            user.TaiKhoan = mang[1];
                            user.MatKhau = mang[2];
                            user.HoVaTen = mang[3];
                            user.NhoMatKhau = Convert.ToBoolean(mang[4]);
                            //Thêm User đọc được vào danh sách Users
                            users.Add(user);//Them user vao danh sach
                        }
                    }
                }
            }
            //Trả về danh sách đọc được từ file Users.ini
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
