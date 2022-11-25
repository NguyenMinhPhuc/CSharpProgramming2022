using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro03_20CT114.DataLayer.DatabaseType
{
    public class DatabaseFactory : IDatabaseConnectFactory
    {
        IDatabaseConnect connect;
        public IDatabaseConnect Connect { get { return connect; } set { connect = value; } }
        public void CreateDatabaseType(TypeDatabase typeDatabase)
        {
            switch (typeDatabase)
            {
                case TypeDatabase.INI:
                    connect = new DatabaseConnectWithINI();
                    break;
                case TypeDatabase.BINARY:
                    connect = new DatabaseConnectWithBinary();
                    break;
                case TypeDatabase.SQL:
                    connect = new DatabaseConnectWithBinary();
                    break;
            }
        }
    }
}
