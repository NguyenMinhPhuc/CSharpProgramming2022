using Pro03_20CT114.DataLayer.Dao;
using Pro03_20CT114.DataLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro03_20CT114.BussinessLayer
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
            return nhanVienDao.GetDanhSachNhanVien(path);
        }
    }
}
