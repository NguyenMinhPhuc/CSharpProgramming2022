using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro03_20CT111_QuaySo.DataLayer.DatabaseType
{
    class DatabaseConnectWithBinary : IDatabaseConnect
    {
        public List<string> ReadFile(string path)
        {
            List<string> result = new List<string>();
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                using (BinaryReader sr = new BinaryReader(fs))
                {
                    string line = string.Empty;
                    while (sr.PeekChar()!=-1)
                    {
                        line = sr.ReadString();
                        result.Add(line);
                    }
                }
            }
            return result;
        }

        public void WriteFile(string path, List<string> listString)
        {
            if (File.Exists(path))
                File.Delete(path);

            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.Write))
            {
                using (BinaryWriter sw = new BinaryWriter(fs))
                {
                    foreach (string item in listString)
                    {
                        sw.Write(item);
                    }
                }
            }
        }
    }
}
