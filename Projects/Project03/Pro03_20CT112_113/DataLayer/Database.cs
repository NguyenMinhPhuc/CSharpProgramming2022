using Pro03_20CT112_113.DataLayer.DatabaseType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro03_20CT112_113.DataLayer
{
   public class Database
    {
        DatabaseFactory databaseFac;
        public DatabaseFactory DatabaseFac 
        { 
            get { return databaseFac; } 
            set { databaseFac = value; } 
        }

        TypeDatabase typeDatabase;

        //Contructor
        public Database(TypeDatabase typeDatabase)
        {
            this.typeDatabase = typeDatabase;

            databaseFac = new DatabaseFactory();
            databaseFac.CreateDatabaseType(typeDatabase);
        }
    }
}
