using Pro03_20CT111_QuaySo.DataLayer.DatabaseType;
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
        private Database database;
        public NhanVienDao(DataType type)
        {
            database = new Database(type);
        }

        public List<NhanVien> LayDanhSachNhanVien(string path)
        {
            List<string> listString = new List<string>();
            listString = database.DatabaseFac.Connect.ReadFile(path);
            List<NhanVien> nhanViens = new List<NhanVien>();
            NhanVien nhanVien;
            foreach (string item in listString)
            {
                nhanVien = new NhanVien();
                string[] vs = item.Split(',');
                nhanVien.MaNhanVien = vs[0];
                nhanVien.TenNhanVien = vs[1];
                nhanVien.PhongBan = vs[2];
                nhanViens.Add(nhanVien);
            }
            return nhanViens;
        }

        public void GhiDanhSachTrungGiai(string path, List<NhanVienNhanGiai> nhanVienNhanGiais)
        {
            List<string> listString = new List<string>();
            string line = string.Empty;
            foreach (NhanVienNhanGiai item in nhanVienNhanGiais)
            {
                line=string.Format("{0},{1},{2},{3}",item.MaNhanVien,item.TenNhanVien,item.PhongBan,item.TenGiaiThuong);
                listString.Add(line);
            }
            database.DatabaseFac.Connect.WriteFile(path, listString);
        }
        public void GhiDanhSachTrungGiai(string path, List<string> listString)
        {
            database.DatabaseFac.Connect.WriteFile(path, listString);
        }
    }
}
