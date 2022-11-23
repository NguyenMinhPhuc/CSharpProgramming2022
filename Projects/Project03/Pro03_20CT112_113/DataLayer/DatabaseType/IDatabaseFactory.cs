using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro03_20CT112_113.DataLayer.DatabaseType
{
   public interface IDatabaseFactory
    {
        void CreateDatabaseType(TypeDatabase typeDatabase);
    }
}
