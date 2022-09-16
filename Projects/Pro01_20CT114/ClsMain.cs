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
    }
}
