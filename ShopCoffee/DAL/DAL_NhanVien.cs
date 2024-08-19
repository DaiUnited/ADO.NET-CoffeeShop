using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_NhanVien : DataConnection
    {
        public DAL_NhanVien() { }

        public List<DTO_NhanVien> GetAll()
        {
            using (var context = new QuanLyQuanCafeDataContext(connectionString))
            {
                return context.NhanViens.Select(c => new DTO_NhanVien
                {
                    MaNhanVien = c.MaNhanVien,
                    MatKhau = c.MatKhau,
                    TenNhanVien = c.TenNhanVien,
                    SoDienThoai = c.SoDienThoai,
                    NamSinh = (int)c.NamSinh,
                    GioiTinh = c.GioiTinh
                }).ToList();
            }
        }

        public DTO_NhanVien GetByID(string ma)
        {
            using (var context = new QuanLyQuanCafeDataContext(connectionString))
            {
                var item = context.NhanViens.SingleOrDefault(c => c.MaNhanVien == ma);
                if (item != null)
                {
                    return new DTO_NhanVien
                    {
                        MaNhanVien = item.MaNhanVien,
                        MatKhau = item.MatKhau,
                        TenNhanVien = item.TenNhanVien,
                        SoDienThoai = item.SoDienThoai,
                        NamSinh = (int)item.NamSinh,
                        GioiTinh = item.GioiTinh
                    };
                }
                return null;
            }
        }

        public DTO_NhanVien GetByID(string ma,string mk)
        {
            using (var context = new QuanLyQuanCafeDataContext(connectionString))
            {
                var item = context.NhanViens.SingleOrDefault(c => c.MaNhanVien == ma && c.MatKhau ==mk);
                if (item != null)
                {
                    return new DTO_NhanVien
                    {
                        MaNhanVien = item.MaNhanVien,
                        MatKhau = item.MatKhau,
                        TenNhanVien = item.TenNhanVien,
                        SoDienThoai = item.SoDienThoai,
                        NamSinh = (int)item.NamSinh,
                        GioiTinh = item.GioiTinh
                    };
                }
                return null;
            }
        }

        public void Add(DTO_NhanVien dto)
        {
            using (var context = new QuanLyQuanCafeDataContext(connectionString))
            {
                var item = new NhanVien
                {
                    MaNhanVien = dto.MaNhanVien,
                    MatKhau = dto.MatKhau,
                    TenNhanVien = dto.TenNhanVien,
                    SoDienThoai = dto.SoDienThoai,
                    NamSinh = (int)dto.NamSinh,
                    GioiTinh = dto.GioiTinh
                };

                context.NhanViens.InsertOnSubmit(item);
                context.SubmitChanges();
            }
        }

        public void Update(DTO_NhanVien dto)
        {
            using (var context = new QuanLyQuanCafeDataContext(connectionString))
            {
                var item = context.NhanViens.SingleOrDefault(c => c.MaNhanVien == dto.MaNhanVien);
                if (item != null)
                {
                    item.MatKhau = dto.MatKhau;
                    item.TenNhanVien = dto.TenNhanVien;
                    item.SoDienThoai = dto.SoDienThoai;
                    item.NamSinh = (int)dto.NamSinh;
                    item.GioiTinh = dto.GioiTinh;

                    context.SubmitChanges();
                }
            }
        }

        public void Delete(string ma)
        {
            using (var context = new QuanLyQuanCafeDataContext(connectionString))
            {
                var item = context.NhanViens.SingleOrDefault(c => c.MaNhanVien == ma);
                if (item != null)
                {
                    context.NhanViens.DeleteOnSubmit(item);
                    context.SubmitChanges();
                }
            }
        }
    }
}
