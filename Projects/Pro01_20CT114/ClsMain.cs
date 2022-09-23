using Pro01_20CT114.BusinessLayer;
using Pro01_20CT114.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pro01_20CT114
{
   public class ClsMain
    {
        public static string taiKhoan = string.Empty;
        //biến lưu đường dẫn file users.ini
        public static string pathUser = string.Format(@"{0}\users.ini",Application.StartupPath);

        public static List<User> users = null;

        public static void CapNhatData(string path,List<User> users)
        {
            BLLUser bd = new BLLUser(path);
            //ghi file
            if (bd.CapNhatDuLieu(ClsMain.users))
            {
                
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 
            }
            else
            {
                MessageBox.Show("cập nhật không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
