using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro03_20CT114.DataLayer.DatabaseType
{
   public interface IDatabaseConnectFactory
    {
        void CreateDatabaseType(TypeDatabase typeDatabase);
    }
}
