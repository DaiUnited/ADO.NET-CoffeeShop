using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_ChiTietHoaDon : DataConnection
    {
        public DAL_ChiTietHoaDon() { }

        public List<DTO_ChiTietHoaDon> GetAll()
        {
            using (var context = new QuanLyQuanCafeDataContext(connectionString))
            {
                return context.ChiTietHoaDons.Select(c => new DTO_ChiTietHoaDon
                {
                    MaHoaDon = c.MaHoaDon,
                    MaDoUong = c.MaDoUong,
                    SoLuong = (int)c.SoLuong,
                    TongTien = (float)c.TongTien,
                }).ToList();
            }
        }
        public List<DTO_ChiTietHoaDon> GetAll(int mahoadon)
        {
            using (var context = new QuanLyQuanCafeDataContext(connectionString))
            {
                return context.ChiTietHoaDons
                    .Where(c => c.MaHoaDon == mahoadon)
                    .Select(c => new DTO_ChiTietHoaDon
                {
                    MaHoaDon = c.MaHoaDon,
                    MaDoUong = c.MaDoUong,
                    SoLuong = (int)c.SoLuong,
                    TongTien = (float)c.TongTien,
                }).ToList();
            }
        }

        public DTO_ChiTietHoaDon GetByID(int MaHoaDon, string madouong)
        {
            using (var context = new QuanLyQuanCafeDataContext(connectionString))
            {
                var item = context.ChiTietHoaDons.SingleOrDefault(c => c.MaHoaDon == MaHoaDon && c.MaDoUong == madouong);
                if (item != null)
                {
                    return new DTO_ChiTietHoaDon
                    {
                        MaHoaDon = item.MaHoaDon,
                        MaDoUong = item.MaDoUong,
                        SoLuong = (int)item.SoLuong,
                        TongTien = (float)item.TongTien,
                    };
                }
                return null;
            }
        }
        public void Add(DTO_ChiTietHoaDon dto)
        {
            using (var context = new QuanLyQuanCafeDataContext(connectionString))
            {
                var itemdouong = context.DoUongs.SingleOrDefault(c => c.MaDoUong == dto.MaDoUong);

                if (itemdouong != null)
                {
                    var item = new ChiTietHoaDon
                    {
                        MaHoaDon = dto.MaHoaDon,
                        MaDoUong = dto.MaDoUong,
                        SoLuong = (int)dto.SoLuong,
                        TongTien = (float)dto.SoLuong * itemdouong.GiaTien,
                    };

                    context.ChiTietHoaDons.InsertOnSubmit(item);
                    context.SubmitChanges();
                }
            }
        }

        public void Update(DTO_ChiTietHoaDon dto)
        {
            using (var context = new QuanLyQuanCafeDataContext(connectionString))
            {
                var item = context.ChiTietHoaDons.SingleOrDefault(c => c.MaHoaDon == dto.MaHoaDon && c.MaDoUong == dto.MaDoUong);
                if (item != null)
                {
                    item.SoLuong += dto.SoLuong;
                    var itemdouong = context.DoUongs.SingleOrDefault(c => c.MaDoUong == dto.MaDoUong);
                    if (itemdouong != null)
                    {
                        item.TongTien = (float)item.SoLuong * itemdouong.GiaTien;
                        context.SubmitChanges();
                    }
                }
            }
        }

        public void Delete(int mahoadon,string madouong)
        {
            using (var context = new QuanLyQuanCafeDataContext(connectionString))
            {
                var item = context.ChiTietHoaDons.SingleOrDefault(c => c.MaHoaDon == mahoadon && c.MaDoUong == madouong);
                if (item != null)
                {
                    context.ChiTietHoaDons.DeleteOnSubmit(item);
                    context.SubmitChanges();
                }
            }
        }

        public void Delete(int mahoadon)
        {
            using (var context = new QuanLyQuanCafeDataContext(connectionString))
            {
                var items = context.ChiTietHoaDons.Where(c => c.MaHoaDon == mahoadon).ToList();
                if (items.Count > 0)
                {
                    foreach (var item in items)
                    {
                        context.ChiTietHoaDons.Detach(item);
                    }
                    context.SubmitChanges();
                }
            }
        }
    }
}
