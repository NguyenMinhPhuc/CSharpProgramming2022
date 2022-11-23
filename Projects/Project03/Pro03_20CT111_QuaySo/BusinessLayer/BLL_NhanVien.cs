using Pro03_20CT111_QuaySo.DataLayer.Dao;
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
        public BLL_NhanVien()
        {
            nhanVienDao = new NhanVienDao();
        }

        public List<NhanVien> LayDanhSachNhanVien(string path)
        {
            return nhanVienDao.LayDanhSachNhanVien(path);
        }

        public void GhiDanhSachTrungGiai(string path,List<NhanVienNhanGiai> nhanVienNhanGiais)
        {
            nhanVienDao.GhiDanhSachTrungGiai(path, nhanVienNhanGiais);
        }
    }
}
