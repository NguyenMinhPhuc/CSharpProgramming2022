using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro03_20CT111_QuaySo.DataLayer.Entity
{
   public class GiaiThuong
    {
        string maGiaiThuong, tenGiaiThuong;
        double giaTri;

        public string MaGiaiThuong
        {
            get { return maGiaiThuong; }
            set { maGiaiThuong = value; }
        }
        public string TenGiaiThuong
        {
            get { return tenGiaiThuong; }
            set { tenGiaiThuong = value; }
        }
        public double GiaTri
        {
            get { return giaTri; }
            set { giaTri = value; }
        }
    }
}
