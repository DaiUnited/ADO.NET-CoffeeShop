using Castle.Components.DictionaryAdapter;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_HoaDon : DataConnection
    {
        public DAL_HoaDon() { }

        public List<DTO_HoaDon> GetAll()
        {
            using (var context = new QuanLyQuanCafeDataContext(connectionString))
            {
                return context.HoaDons.Select(c => new DTO_HoaDon
                {
                    MaHoaDon = c.MaHoaDon,
                    NgayLap = (DateTime)c.NgayLap,
                    MaBan = c.MaBan,
                    MaNhanVien = c.MaNhanVien,
                    ThanhTien = (float)c.ThanhTien,
                    TrangThai = c.TrangThai
                }).ToList();
            }
        }

        public DTO_HoaDon GetByID(int ma)
        {
            using (var context = new QuanLyQuanCafeDataContext(connectionString))
            {
                var item = context.HoaDons.SingleOrDefault(c => c.MaHoaDon == ma);
                if (item != null)
                {
                    return new DTO_HoaDon
                    {
                        MaHoaDon = item.MaHoaDon,
                        NgayLap = (DateTime)item.NgayLap,
                        MaBan = item.MaBan,
                        MaNhanVien = item.MaNhanVien,
                        ThanhTien = (float)item.ThanhTien,
                        TrangThai = item.TrangThai
                    };
                }
                return null;
            }
        }

        public DTO_HoaDon GetByMaBanAndTrangThai(string maban,string trangthai)
        {
            using (var context = new QuanLyQuanCafeDataContext(connectionString))
            {
                var item = context.HoaDons.SingleOrDefault(c => c.MaBan == maban && c.TrangThai == trangthai);
                if (item != null)
                {
                    return new DTO_HoaDon
                    {
                        MaHoaDon = item.MaHoaDon,
                        NgayLap = (DateTime)item.NgayLap,
                        MaBan = item.MaBan,
                        MaNhanVien = item.MaNhanVien,
                        ThanhTien = (float)item.ThanhTien,
                        TrangThai = item.TrangThai
                    };
                }
                return null;
            }
        }

        public void Add(DTO_HoaDon dto)
        {
            using (var context = new QuanLyQuanCafeDataContext(connectionString))
            {
                var item = new HoaDon
                {
                    MaHoaDon = dto.MaHoaDon,
                    NgayLap = (DateTime)dto.NgayLap,
                    MaBan = dto.MaBan,
                    MaNhanVien = dto.MaNhanVien,
                    ThanhTien = (float)dto.ThanhTien,
                    TrangThai= dto.TrangThai
                };

                context.HoaDons.InsertOnSubmit(item);
                context.SubmitChanges();
            }
        }

        public void Update(DTO_HoaDon dto)
        {
            using (var context = new QuanLyQuanCafeDataContext(connectionString))
            {
                var item = context.HoaDons.SingleOrDefault(c => c.MaHoaDon == dto.MaHoaDon);
                if (item != null)
                {
                    item.NgayLap = (DateTime)dto.NgayLap;
                    item.MaBan = dto.MaBan;
                    item.MaNhanVien = dto.MaNhanVien;
                    item.ThanhTien = (float)dto.ThanhTien;
                    item.TrangThai = dto.TrangThai;
                    context.SubmitChanges();
                }
            }
        }

        public void Delete(int ma)
        {
            using (var context = new QuanLyQuanCafeDataContext(connectionString))
            {
                var item = context.HoaDons.SingleOrDefault(c => c.MaHoaDon == ma);
                if (item != null)
                {
                    context.HoaDons.DeleteOnSubmit(item);
                    context.SubmitChanges();
                }
            }
        }
    }
}