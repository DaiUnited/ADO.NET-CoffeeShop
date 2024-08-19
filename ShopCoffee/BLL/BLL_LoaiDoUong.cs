using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_LoaiDoUong
    {
        DAL_LoaiDoUong dal;
        public BLL_LoaiDoUong()
        {
            dal = new DAL_LoaiDoUong();
        }

        public List<DTO_LoaiDoUong> GetAll()
        {
            return dal.GetAll();
        }

        public DTO_LoaiDoUong GetByID(string ma)
        {
            return dal.GetByID(ma);
        }

        public void Add(DTO_LoaiDoUong dto)
        {
            dal.Add(dto);
        }

        public void Update(DTO_LoaiDoUong dto)
        {
            dal.Update(dto);
        }

        public void Delete(string ma)
        {
            dal.Delete(ma);
        }
    }
}
