using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro03_20CT114.DataLayer.DatabaseType
{
   public class Database
    {
        //fields - Bien
        DatabaseFactory databaseFac;
        //properties - thuoc tinh
        public DatabaseFactory DatabaseFac {
            get { return databaseFac; }
            set { databaseFac = value; } }
        //contructor - ham tao
        public Database(TypeDatabase typeDatabase)
        {
            databaseFac = new DatabaseFactory();
            databaseFac.CreateDatabaseType(typeDatabase);
        }

    }
}
