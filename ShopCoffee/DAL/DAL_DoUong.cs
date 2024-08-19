using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_DoUong : DataConnection
    {
        public DAL_DoUong() { }

        public List<DTO_DoUong> GetAll()
        {
            using (var context = new QuanLyQuanCafeDataContext(connectionString))
            {
                return context.DoUongs.Select(c => new DTO_DoUong
                {
                    MaDoUong = c.MaDoUong,
                    TenDoUong = c.TenDoUong,
                    GiaTien = (float)c.GiaTien,
                    MaLoaiDoUong = c.MaLoaiDoUong,
                }).ToList();
            }
        }
        public List<DTO_DoUong> GetAllByMaLoai(string maloaidouong)
        {
            using (var context = new QuanLyQuanCafeDataContext(connectionString))
            {
                return context.DoUongs
                    .Where(c => c.MaLoaiDoUong == maloaidouong)
                    .Select(c => new DTO_DoUong
                    {
                        MaDoUong = c.MaDoUong,
                        TenDoUong = c.TenDoUong,
                        GiaTien = (float)c.GiaTien,
                        MaLoaiDoUong = c.MaLoaiDoUong,
                    }).ToList();
            }
        }

        public DTO_DoUong GetByID(string ma)
        {
            using (var context = new QuanLyQuanCafeDataContext(connectionString))
            {
                var item = context.DoUongs.SingleOrDefault(c => c.MaDoUong == ma);
                if (item != null)
                {
                    return new DTO_DoUong
                    {
                        MaDoUong = item.MaDoUong,
                        TenDoUong = item.TenDoUong,
                        GiaTien = (float)item.GiaTien,
                        MaLoaiDoUong = item.MaLoaiDoUong,
                    };
                }
                return null;
            }
        }
        public void Add(DTO_DoUong dto)
        {
            using (var context = new QuanLyQuanCafeDataContext(connectionString))
            {
                var item = new DoUong
                {
                    MaDoUong = dto.MaDoUong,
                    TenDoUong = dto.TenDoUong,
                    GiaTien = (float)dto.GiaTien,
                    MaLoaiDoUong= dto.MaLoaiDoUong,
                };

                context.DoUongs.InsertOnSubmit(item);
                context.SubmitChanges();
            }
        }

        public void Update(DTO_DoUong dto)
        {
            using (var context = new QuanLyQuanCafeDataContext(connectionString))
            {
                var item = context.DoUongs.SingleOrDefault(c => c.MaDoUong == dto.MaDoUong);
                if (item != null)
                {
                    item.TenDoUong = dto.TenDoUong;
                    item.GiaTien = (float)dto.GiaTien;
                    item.MaLoaiDoUong = dto.MaLoaiDoUong;
                    context.SubmitChanges();
                }
            }
        }

        public void Delete(string ma)
        {
            using (var context = new QuanLyQuanCafeDataContext(connectionString))
            {
                var item = context.DoUongs.SingleOrDefault(c => c.MaDoUong == ma);
                if (item != null)
                {
                    context.DoUongs.DeleteOnSubmit(item);
                    context.SubmitChanges();
                }
            }
        }
    }
}