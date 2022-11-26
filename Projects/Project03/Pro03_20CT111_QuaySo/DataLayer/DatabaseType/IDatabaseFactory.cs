using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro03_20CT111_QuaySo.DataLayer.DatabaseType
{
   public interface IDatabaseFactory
    {
        void CreateDatabaseConnect(DataType type);
    }
}
