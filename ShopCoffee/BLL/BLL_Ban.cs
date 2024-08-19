using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Ban
    {
        DAL_Ban dal;
        public BLL_Ban()
        {
            dal = new DAL_Ban();
        }

        public List<DTO_Ban> GetAll()
        {
            return dal.GetAll();
        }

        public DTO_Ban GetByID(string ma)
        {
            return dal.GetByID(ma);
        }

        public void Add(DTO_Ban dto)
        {
            dal.Add(dto);
        }

        public void Update(DTO_Ban dto)
        {
            dal.Update(dto);
        }

        public void Delete(string ma)
        {
            dal.Delete(ma);
        }
    }
}
