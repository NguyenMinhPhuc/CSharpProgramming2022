using Pro03_20CT111_QuaySo.DataLayer.DatabaseType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro03_20CT111_QuaySo.DataLayer
{
   public class Database
    {
        private DatabaseFactory databaseFac;
        public DatabaseFactory DatabaseFac {
            get { return databaseFac; }
            set { databaseFac = value; } 
        }

        public Database(DataType type)
        {
            databaseFac = new DatabaseFactory();
            databaseFac.CreateDatabaseConnect(type);
        }
    }
}
