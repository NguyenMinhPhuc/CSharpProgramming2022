using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro01_20CT111.DataLayer
{
    //Class Entity
   public class User
    {
        //field-bien thanh vien
        private int iD;
        private string taiKhoan;
        private string matKhau;
        private string hoVaTen;
        private bool nhoMatKhau;
        //properties
        public int ID {get { return iD; }set { iD = value; }}

        //dung phim tat Ctrl+R+E

        public string TaiKhoan { get { return taiKhoan; } set { taiKhoan = value; } }
        public string MatKhau { get { return matKhau; } set { matKhau = value; } }
        public string HoVaTen { get { return hoVaTen; } set { hoVaTen = value; } }
        public bool NhoMatKhau { get { return nhoMatKhau; } set { nhoMatKhau = value; } }

        public override string ToString()
        {
            return string.Format("{0},{1},{2},{3},{4}", ID, taiKhoan, matKhau, hoVaTen, nhoMatKhau.ToString());
        }
    }
}
