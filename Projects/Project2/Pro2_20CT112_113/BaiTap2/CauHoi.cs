using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro2_20CT112_113.BaiTap2
{
   public class CauHoi
    {
        string id;
        string noiDungCauHoi;
        List<CauTraLoi> dapAn=new List<CauTraLoi>();

        public string Id { get => id; set => id = value; }
        public string NoiDungCauHoi { get => noiDungCauHoi; set => noiDungCauHoi = value; }
        public List<CauTraLoi> DapAn { get => dapAn; set => dapAn = value; }
    }
}
