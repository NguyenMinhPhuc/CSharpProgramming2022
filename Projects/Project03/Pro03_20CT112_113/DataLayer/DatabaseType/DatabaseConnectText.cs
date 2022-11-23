using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro03_20CT112_113.DataLayer.DatabaseType
{
   public class DatabaseConnectText : IDatabaseConnect
    {
        public List<string> ReadFile(string path)
        {
            List<string> result = new List<string>();
            using(FileStream fs=new FileStream(path,FileMode.Open,FileAccess.Read,FileShare.Read))
            {
                using(StreamReader sr=new StreamReader(fs))
                {
                    string line = string.Empty;
                    while((line=sr.ReadLine())!=null)
                    {
                        if (!string.IsNullOrEmpty(line))
                        {
                            result.Add(line);
                        }
                    }
                }
            }
            return result;
        }

        public void WriteToFile(string path, List<string> vs)
        {
            if (File.Exists(path))
                File.Delete(path);
           using(FileStream fs=new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write, FileShare.Write))
            {
                using (StreamWriter sW=new StreamWriter(fs))
                {
                    foreach (string item in vs)
                    {
                        sW.WriteLine(item);
                    }
                }
            }
        }
    }
}
