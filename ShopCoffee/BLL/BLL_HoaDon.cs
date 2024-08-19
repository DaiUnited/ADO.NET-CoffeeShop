using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_HoaDon
    {
        DAL_HoaDon dal;
        public BLL_HoaDon()
        {
            dal = new DAL_HoaDon();
        }

        public List<DTO_HoaDon> GetAll()
        {
            return dal.GetAll();
        }

        public DTO_HoaDon GetByID(int ma)
        {
            return dal.GetByID(ma);
        }

        public DTO_HoaDon GetByMaBanAndTrangThai(string maban, string trangthai)
        {
            return dal.GetByMaBanAndTrangThai(maban, trangthai);
        }

        public void Add(DTO_HoaDon dto)
        {
            dal.Add(dto);
        }

        public void Update(DTO_HoaDon dto)
        {
            dal.Update(dto);
        }

        public void Delete(int ma)
        {
            dal.Delete(ma);
        }
    }
}

