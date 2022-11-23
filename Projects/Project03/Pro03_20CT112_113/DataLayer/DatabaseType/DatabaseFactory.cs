using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro03_20CT112_113.DataLayer.DatabaseType
{
   public class DatabaseFactory : IDatabaseFactory
    {
        IDatabaseConnect database;//field
        //properties
        public IDatabaseConnect Database 
        { 
            get { return database; }
            set { database = value; }
        }
        //method
        public void CreateDatabaseType(TypeDatabase typeDatabase)
        {
            switch (typeDatabase)
            {
                case TypeDatabase.INI:
                    database = new DatabaseConnectINI();
                    break;
                case TypeDatabase.TEXT:
                    database = new DatabaseConnectText();
                    break;
                case TypeDatabase.BINARY:
                    database = new DatabaseConnectBinary();
                    break;
                case TypeDatabase.EXCEL:
                    database = new DatabaseConnectExcel();
                    break;

            }
        }
    }
}
