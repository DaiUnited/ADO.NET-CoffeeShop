using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_LoaiDoUong : DataConnection
    {
        public DAL_LoaiDoUong() { }

        public List<DTO_LoaiDoUong> GetAll()
        {
            using (var context = new QuanLyQuanCafeDataContext(connectionString))
            {
                return context.LoaiDoUongs.Select(c => new DTO_LoaiDoUong
                {
                    MaLoaiDoUong = c.MaLoaiDoUong,
                    TenLoaiDoUong = c.TenLoaiDoUong,
                }).ToList();
            }
        }

        public DTO_LoaiDoUong GetByID(string ma)
        {
            using (var context = new QuanLyQuanCafeDataContext(connectionString))
            {
                var item = context.LoaiDoUongs.SingleOrDefault(c => c.MaLoaiDoUong == ma);
                if (item != null)
                {
                    return new DTO_LoaiDoUong
                    {
                        MaLoaiDoUong = item.MaLoaiDoUong,
                        TenLoaiDoUong = item.TenLoaiDoUong,
                    };
                }
                return null;
            }
        }
        public void Add(DTO_LoaiDoUong dto)
        {
            using (var context = new QuanLyQuanCafeDataContext(connectionString))
            {
                var item = new LoaiDoUong
                {
                    MaLoaiDoUong = dto.MaLoaiDoUong,
                    TenLoaiDoUong = dto.TenLoaiDoUong,
                };

                context.LoaiDoUongs.InsertOnSubmit(item);
                context.SubmitChanges();
            }
        }

        public void Update(DTO_LoaiDoUong dto)
        {
            using (var context = new QuanLyQuanCafeDataContext(connectionString))
            {
                var item = context.LoaiDoUongs.SingleOrDefault(c => c.MaLoaiDoUong == dto.MaLoaiDoUong);
                if (item != null)
                {
                    item.TenLoaiDoUong = dto.TenLoaiDoUong;

                    context.SubmitChanges();
                }
            }
        }

        public void Delete(string ma)
        {
            using (var context = new QuanLyQuanCafeDataContext(connectionString))
            {
                var item = context.LoaiDoUongs.SingleOrDefault(c => c.MaLoaiDoUong == ma);
                if (item != null)
                {
                    context.LoaiDoUongs.DeleteOnSubmit(item);
                    context.SubmitChanges();
                }
            }
        }
    }
}