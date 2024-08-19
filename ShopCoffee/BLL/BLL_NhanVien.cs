using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLL_NhanVien
    {
        DAL_NhanVien dal;
        public BLL_NhanVien()
        {
            dal = new DAL_NhanVien();
        }

        public List<DTO_NhanVien> GetAll()
        {
            return dal.GetAll();
        }

        public DTO_NhanVien GetByID(string ma)
        {
            return dal.GetByID(ma);
        }
        public DTO_NhanVien GetByID(string ma,string mk)
        {
            return dal.GetByID(ma,mk);
        }

        public void Add(DTO_NhanVien dto)
        {
            dal.Add(dto);
        }

        public void Update(DTO_NhanVien dto)
        {
            dal.Update(dto);
        }

        public void Delete(string ma)
        {
            dal.Delete(ma);
        }
    }
}
