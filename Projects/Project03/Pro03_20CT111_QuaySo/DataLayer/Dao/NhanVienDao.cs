using Pro03_20CT111_QuaySo.DataLayer.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro03_20CT111_QuaySo.DataLayer.Dao
{
    public class NhanVienDao
    {
        //Read
        public List<NhanVien> LayDanhSachNhanVien(string path)
        {
            List<NhanVien> nhanViens = new List<NhanVien>();
            using (FileStream fs=new FileStream(path,FileMode.Open,FileAccess.Read,FileShare.Read))
            {
                using (StreamReader sr=new StreamReader(fs))
                {
                    string line = string.Empty;
                    NhanVien nhanVien;
                    while ((line=sr.ReadLine())!=null)
                    {
                        if(!string.IsNullOrEmpty(line))
                        {
                            string[] vs = line.Split(',');
                            nhanVien = new NhanVien();
                            nhanVien.MaNhanVien = vs[0];
                            nhanVien.TenNhanVien = vs[1];
                            nhanVien.PhongBan = vs[2];
                            nhanViens.Add(nhanVien);
                        }
                    }
                }
            }
            return nhanViens;
        }
        //write

        public void GhiDanhSachTrungGiai(string path,List<NhanVienNhanGiai> nhanVienNhanGiais)
        {
            if (File.Exists(path))
                File.Delete(path);
            using(FileStream fs=new FileStream(path,FileMode.Create,FileAccess.Write,FileShare.Write))
            {
                using(StreamWriter sw=new StreamWriter(fs))
                {
                    foreach (NhanVienNhanGiai item in nhanVienNhanGiais)
                    {
                        sw.WriteLine(item.ToString());
                    }
                }
            }
        }
    }
}
