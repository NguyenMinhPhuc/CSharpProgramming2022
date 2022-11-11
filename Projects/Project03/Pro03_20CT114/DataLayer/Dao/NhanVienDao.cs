using Pro03_20CT114.DataLayer.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro03_20CT114.DataLayer.Dao
{
   public class NhanVienDao
    {
        public List<NhanVien> GetDanhSachNhanVien(string path)
        {
            List<NhanVien> nhanViens = null;
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    string line = string.Empty;
                    NhanVien nhanVien;
                    nhanViens = new List<NhanVien>();
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (!string.IsNullOrEmpty(line))
                        {
                            string[] vs = line.Split(',');
                            nhanVien = new NhanVien()
                            {
                                MaNhanVien = vs[0],
                                TenNhanVien = vs[1],
                                PhongBan = vs[2]
                            };
                            nhanViens.Add(nhanVien);
                        }
                    }
                }
            }
            return nhanViens;
        }
    }
}
