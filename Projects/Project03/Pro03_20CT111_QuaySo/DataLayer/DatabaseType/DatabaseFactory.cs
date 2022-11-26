using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro03_20CT111_QuaySo.DataLayer.DatabaseType
{
    public class DatabaseFactory : IDatabaseFactory
    {
        private IDatabaseConnect connect;
        public IDatabaseConnect Connect {
            get { return connect; }
            set { connect = value; } 
        }
        public void CreateDatabaseConnect(DataType type)
        {
            switch (type)
            {
                case DataType.INI:
                    connect = new DatabaseConnectWithINI();
                    break;
                case DataType.BINARY:
                    connect = new DatabaseConnectWithBinary();
                    break;
                case DataType.SQL:
                    break;
            }
        }
    }
}
