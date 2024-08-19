using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Ban : DataConnection
    {
        public DAL_Ban() { }

        public List<DTO_Ban> GetAll()
        {
            using (var context = new QuanLyQuanCafeDataContext(connectionString))
            {
                return context.Bans.Select(c => new DTO_Ban
                {
                    MaBan = c.MaBan,
                    TenBan = c.TenBan,
                    TrangThai = c.TrangThai,
                }).ToList();
            }
        }

        public DTO_Ban GetByID(string ma)
        {
            using (var context = new QuanLyQuanCafeDataContext(connectionString))
            {
                var item = context.Bans.SingleOrDefault(c => c.MaBan == ma);
                if (item != null)
                {
                    return new DTO_Ban
                    {
                        MaBan = item.MaBan,
                        TenBan = item.TenBan,
                        TrangThai = item.TrangThai,
                    };
                }
                return null;
            }
        }
        public void Add(DTO_Ban dto)
        {
            using (var context = new QuanLyQuanCafeDataContext(connectionString))
            {
                var item = new Ban
                {
                    MaBan = dto.MaBan,
                    TenBan = dto.TenBan,
                    TrangThai = dto.TrangThai,
                };

                context.Bans.InsertOnSubmit(item);
                context.SubmitChanges();
            }
        }

        public void Update(DTO_Ban dto)
        {
            using (var context = new QuanLyQuanCafeDataContext(connectionString))
            {
                var item = context.Bans.SingleOrDefault(c => c.MaBan == dto.MaBan);
                if (item != null)
                {
                    item.TenBan = dto.TenBan;
                    item.TrangThai = dto.TrangThai;
                    context.SubmitChanges();
                }
            }
        }

        public void Delete(string ma)
        {
            using (var context = new QuanLyQuanCafeDataContext(connectionString))
            {
                var item = context.Bans.SingleOrDefault(c => c.MaBan == ma);
                if (item != null)
                {
                    context.Bans.DeleteOnSubmit(item);
                    context.SubmitChanges();
                }
            }
        }
    }
}
