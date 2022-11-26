using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro03_20CT111_QuaySo.DataLayer.DatabaseType
{
   public interface IDatabaseConnect
    {
        //read
        List<string> ReadFile(string path);

        //write
        void WriteFile(string path, List<string> listString);
    }
}
