using Pro03_20CT114.DataLayer.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro03_20CT114.DataLayer.DatabaseType
{
    public class DatabaseConnectWithINI : IDatabaseConnect
    {
        public List<string> DocFile(string path)
        {
            List<string> listString = new List<string>();
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    string line = string.Empty;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if(!string.IsNullOrEmpty(line))
                        {
                            listString.Add(line);
                        }
                    }
                }
            }
            return listString;
        }

        public void GhiFile(string path, List<string> vs)
        {
            if (File.Exists(path))
                File.Delete(path);
            using(FileStream fs=new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.Write))
            {
                using(StreamWriter sw=new StreamWriter(fs))
                {
                    foreach (string item in vs)
                    {
                        sw.WriteLine(item);
                    }
                }
            }
        }
    }
}
