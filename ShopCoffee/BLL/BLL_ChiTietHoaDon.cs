using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_ChiTietHoaDon
    {
        DAL_ChiTietHoaDon dal;
        public BLL_ChiTietHoaDon()
        {
            dal = new DAL_ChiTietHoaDon();
        }

        public List<DTO_ChiTietHoaDon> GetAll()
        {
            return dal.GetAll();
        }

        public List<DTO_ChiTietHoaDon> GetAll(int mahoadon)
        {
            return dal.GetAll(mahoadon);
        }

        public DTO_ChiTietHoaDon GetByID(int mahoadon,string madouong)
        {
            return dal.GetByID(mahoadon,madouong);
        }

        public void Add(DTO_ChiTietHoaDon dto)
        {
            dal.Add(dto);
        }

        public void Update(DTO_ChiTietHoaDon dto)
        {
            dal.Update(dto);
        }

        public void Delete(int mahoadon,string madouong)
        {
            dal.Delete(mahoadon, madouong);
        }
    }
}
