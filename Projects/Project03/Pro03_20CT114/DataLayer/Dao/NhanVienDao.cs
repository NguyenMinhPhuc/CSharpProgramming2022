using Pro03_20CT114.DataLayer.DatabaseType;
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
        Database database;
        public NhanVienDao(TypeDatabase type)
        {
            database = new Database(type);
        }
        public List<NhanVien> GetDanhSachNhanVien(string path)
        {
            List<NhanVien> nhanViens = new List<NhanVien>();
            List<string> listString = new List<string>();
            listString = database.DatabaseFac.Connect.DocFile(path);
            NhanVien nhanVien;
            foreach (string item in listString)
            {
                string[] vs = item.Split(',');
                nhanVien = new NhanVien()
                {
                    MaNhanVien = vs[0],
                    TenNhanVien = vs[1],
                    PhongBan = vs[2]
                };
                nhanViens.Add(nhanVien);
            }
            return nhanViens;
        }
        
        public void GhiNhanVienBinary(string path,List<NhanVien> nhanViens)
        {
            database = new Database(TypeDatabase.BINARY);
            List<string> vs = new List<string>();
            foreach (NhanVien item in nhanViens)
            {
                vs.Add(string.Format("{0},{1},{2}", item.MaNhanVien,item.TenNhanVien,item.PhongBan));
            }
            database.DatabaseFac.Connect.GhiFile(path, vs);
        }
    }
}
