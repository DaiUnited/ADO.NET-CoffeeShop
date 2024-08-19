using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_DoUong
    {
        DAL_DoUong dal;
        public BLL_DoUong()
        {
            dal = new DAL_DoUong();
        }

        public List<DTO_DoUong> GetAll()
        {
            return dal.GetAll();
        }

        public List<DTO_DoUong> GetAllByMaLoai(string maloaidouong)
        {
            return dal.GetAllByMaLoai(maloaidouong);
        }

        public DTO_DoUong GetByID(string ma)
        {
            return dal.GetByID(ma);
        }

        public void Add(DTO_DoUong dto)
        {
            dal.Add(dto);
        }

        public void Update(DTO_DoUong dto)
        {
            dal.Update(dto);
        }

        public void Delete(string ma)
        {
            dal.Delete(ma);
        }
    }
}
