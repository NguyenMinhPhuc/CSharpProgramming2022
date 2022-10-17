using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pro2_20CT112_113.BaiTap2
{
    public partial class FrmCauTracNghiem : Form
    {
        public FrmCauTracNghiem()
        {
            InitializeComponent();
        }
        List<CauHoi> cauHois;
        private void FrmCauTracNghiem_Load(object sender, EventArgs e)
        {
            cauHois = new List<CauHoi>()
            {
                new CauHoi()
                {
                    Id="1",
                    NoiDungCauHoi="Ban bao nhieu tuoi",
                    DapAn=new List<CauTraLoi>()
                    {
                       new CauTraLoi(){NoiDungTraLoi="10",DapAn=true},
                       new CauTraLoi(){NoiDungTraLoi="11",DapAn=false},
                       new CauTraLoi(){NoiDungTraLoi="12",DapAn=false},
                       new CauTraLoi(){NoiDungTraLoi="13",DapAn=false},
                    }
                },
                new CauHoi()
                {
                    Id="2",
                    NoiDungCauHoi="Hoc lop nao",
                    DapAn=new List<CauTraLoi>()
                    {
                       new CauTraLoi(){NoiDungTraLoi="21CT111",DapAn=true},
                       new CauTraLoi(){NoiDungTraLoi="21CT111",DapAn=false},
                       new CauTraLoi(){NoiDungTraLoi="21CT111",DapAn=false},
                       new CauTraLoi(){NoiDungTraLoi="21CT111",DapAn=false},
                    }
                }
            };
        }
    }
}
