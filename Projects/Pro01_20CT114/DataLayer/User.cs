using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro01_20CT114.DataLayer
{
   public class User: IComparable
    {
        //1,admin,admin,Nguyen Minh Phuc,True
        //field-Bien thanh vien
        private int iD;
        private string taiKhoan;
        private string matKhau;
        private string hoVaTen;
        private bool nhoMatKhau;
        //Properties
        public int ID { get { return iD; } set { iD = value; } }
        public string TaiKhoan { get { return taiKhoan; } set { taiKhoan = value; } }
        public string MatKhau { get { return matKhau; } set { matKhau = value; } }
        public string HoVaTen { get { return hoVaTen; } set { hoVaTen = value; } }
        public bool NhoMatKhau { get { return nhoMatKhau; } set { nhoMatKhau = value; } }
        //cach tao properties nhanh
        //Ctrl+R+E

        public override string ToString()
        {
            return string.Format("{0},{1},{2},{3},{4}", ID, TaiKhoan, MatKhau, HoVaTen, NhoMatKhau.ToString());
        }

        public override bool Equals(object obj)
        {
            if(obj is User)
            {
                return ((User)obj).ID.ToString().Equals(this.ID.ToString());
            }
            return false;
        }

        public int CompareTo(object obj)
        {
            if (obj is User)
            {
                return ((User)obj).ID.CompareTo(this.ID);
            }
            return -1;
        }
    }
}
