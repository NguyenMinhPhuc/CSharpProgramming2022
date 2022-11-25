using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro03_20CT114.DataLayer.DatabaseType
{
    public class DatabaseConnectWithBinary : IDatabaseConnect
    {
        public List<string> DocFile(string path)
        {

            List<string> listString = new List<string>();
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                using (BinaryReader sr = new BinaryReader(fs))
                {
                    while (sr.PeekChar()!=-1)
                    {
                        listString.Add(sr.ReadString());
                    }
                }
            }
            return listString;
        }

        public void GhiFile(string path, List<string> vs)
        {
            if (File.Exists(path))
                File.Delete(path);
            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.Write))
            {
                using (BinaryWriter sw = new BinaryWriter(fs))
                {
                    foreach (string item in vs)
                    {
                        sw.Write(item);
                    }
                }
            }
        }
    }
}
