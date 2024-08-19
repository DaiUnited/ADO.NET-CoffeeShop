using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HoaDon
    {
        public int MaHoaDon { get; set; }
        public DateTime NgayLap { get; set; }
        public string MaBan { get; set; }
        public string MaNhanVien{get;set;}
        public float ThanhTien { get; set; }
        public string TrangThai { get; set; }
    }
}
