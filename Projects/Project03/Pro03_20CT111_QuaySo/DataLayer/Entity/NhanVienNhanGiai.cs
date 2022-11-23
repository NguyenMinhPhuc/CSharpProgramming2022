using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro03_20CT111_QuaySo.DataLayer.Entity
{
  public  class NhanVienNhanGiai:NhanVien
    {
        string tenGiaiThuong;
        public string TenGiaiThuong
        {
            get { return tenGiaiThuong; }
            set { tenGiaiThuong = value; }
        }

        public override string ToString()
        {
            return string.Format("{0},{1},{2},{3}", MaNhanVien, TenNhanVien, PhongBan, TenGiaiThuong);
        }
    }
}
