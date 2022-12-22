using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanhSachBanVeTauLua
{
    public class Ve
    {
        string maKH;
        string tenKH;
        string diaChi;
        string ngheNghiep;
        string soLuongVe;
        string donGia;
        string thanhTien;
        string thue;
        string giamGia;
        string tongTien;
        public Ve()
        {

        }

        public string MaKH { get => maKH; set => maKH = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string NgheNghiep { get => ngheNghiep; set => ngheNghiep = value; }
        public string SoLuongVe { get => soLuongVe; set => soLuongVe = value; }
        public string DonGia { get => donGia; set => donGia = value; }
        public string ThanhTien { get => thanhTien; set => thanhTien = value; }
        public string Thue { get => thue; set => thue = value; }
        public string GiamGia { get => giamGia; set => giamGia = value; }
        public string TongTien { get => tongTien; set => tongTien = value; }
    }
}
