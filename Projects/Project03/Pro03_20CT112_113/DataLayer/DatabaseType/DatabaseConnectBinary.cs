using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro03_20CT112_113.DataLayer.DatabaseType
{
    public class DatabaseConnectBinary : IDatabaseConnect
    {
        public List<string> ReadFile(string path)
        {
            List<string> result = null;
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                using (BinaryReader sr = new BinaryReader(fs))
                {
                    
                    while (sr.PeekChar()!=-1)
                    {
                        result.Add(sr.ReadString());
                    }
                }
            }
            return result;
        }

        public void WriteToFile(string path, List<string> vs)
        {
            if (File.Exists(path))
                File.Delete(path);
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write, FileShare.Write))
            {
                using (BinaryWriter sW = new BinaryWriter(fs))
                {
                    foreach (string item in vs)
                    {
                        sW.Write(item);
                    }
                }
            }
        }
    }
}
