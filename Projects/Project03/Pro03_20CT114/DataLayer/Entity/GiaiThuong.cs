using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro03_20CT114.DataLayer.Entity
{
    public class GiaiThuong
    {
        private int maGiaiThuong;
        private string tenGiaiThuong;
        private double giaTriGiaiThuong;

        public int MaGiaiThuong { 
            get { return maGiaiThuong; } 
            set { maGiaiThuong = value; } 
        }
        public string TenGiaiThuong {
            get { return tenGiaiThuong; }
            set { tenGiaiThuong = value; }
        }
        public double GiaTriGiaiThuong {
            get { return giaTriGiaiThuong; }
            set { giaTriGiaiThuong = value; }
        }
    }
}
