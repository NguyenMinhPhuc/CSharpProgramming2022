using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro03_20CT111_QuaySo.DataLayer.Entity
{
   public class NhanVien
    {
        //field - camel
        string maNhanVien, tenNhanVien, phongBan;
        //properties - pascal
        public string MaNhanVien 
        {
            get { return maNhanVien; }
            set { maNhanVien = value; } 
        }
        public string TenNhanVien
        {
            get { return tenNhanVien; }
            set { tenNhanVien = value; }
        }
        public string PhongBan
        {
            get { return phongBan; }
            set { phongBan = value; }
        }
    }
}
