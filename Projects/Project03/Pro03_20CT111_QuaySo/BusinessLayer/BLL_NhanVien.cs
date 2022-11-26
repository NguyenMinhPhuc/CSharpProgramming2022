using Pro03_20CT111_QuaySo.DataLayer.Dao;
using Pro03_20CT111_QuaySo.DataLayer.DatabaseType;
using Pro03_20CT111_QuaySo.DataLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro03_20CT111_QuaySo.BusinessLayer
{
   public class BLL_NhanVien
    {
        NhanVienDao nhanVienDao;
        public BLL_NhanVien(DataType type)
        {
            nhanVienDao = new NhanVienDao(type);
        }

        public List<NhanVien> LayDanhSachNhanVien(string path)
        {
            return nhanVienDao.LayDanhSachNhanVien(path);
        }

        public void GhiDanhSachTrungGiai(string path,List<NhanVienNhanGiai> nhanVienNhanGiais)
        {
            nhanVienDao.GhiDanhSachTrungGiai(path, nhanVienNhanGiais);
        }
        public void GhiDanhSachTrungGiai(string path, List<string> listString)
        {
            nhanVienDao.GhiDanhSachTrungGiai(path, listString);
        }
    }
}
