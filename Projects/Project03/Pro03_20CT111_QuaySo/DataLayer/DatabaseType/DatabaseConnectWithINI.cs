using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro03_20CT111_QuaySo.DataLayer.DatabaseType
{
    class DatabaseConnectWithINI : IDatabaseConnect
    {
        public List<string> ReadFile(string path)
        {
            List<string> result = new List<string>();
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                using (StreamReader sr=new StreamReader(fs))
                {
                    string line = string.Empty;
                    while ((line = sr.ReadLine()) != null)
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

        public void WriteFile(string path, List<string> listString)
        {
            if (File.Exists(path))
                File.Delete(path);

            using(FileStream fs=new FileStream(path,FileMode.Create,FileAccess.Write,FileShare.Write))
            {
                using (StreamWriter sw=new StreamWriter(fs,Encoding.UTF8))
                {
                    foreach (string item in listString)
                    {
                        sw.WriteLine(item);
                    }
                }
            }
        }
    }
}
