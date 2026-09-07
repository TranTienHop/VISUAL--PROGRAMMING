using System;
using System.Collections.Generic;

namespace QuanLySanPhamCuaHang
{
    class SanPham
    {
        private string maSP;
        private string tenSP;
        private decimal gia;
        private int soLuongTon;

        public SanPham(string maSP, string tenSP, decimal gia, int soLuongTon)
        {
            maSP = maSP;
            tenSP = tenSP;
            gia = gia;
            soLuongTon = soLuongTon;
        }

        public string MaSP
        {
            get { return maSP; }
            set { maSP = value; }
        }

        public string TenSP
        {
            get { return tenSP; }
            set { tenSP = value; }
        }

        public decimal Gia
        {
            get { return gia; }
            set { gia = value; }
        }

        public int SoLuongTon
        {
            get { return soLuongTon; }
            set { soLuongTon = value; }
        }

        public virtual decimal TinhGiaBan()
        {
            return gia;
        }

        public virtual string MoTa()
        {
            return "Mã SP: " + MaSP +
                   ", Tên SP: " + TenSP +
                   ", Giá: " + TinhGiaBan() +
                   ", Số lượng tồn: " + SoLuongTon;
        }
    }

    class SanPhamThucPham : SanPham
    {
        private DateTime ngayHetHan;
        private int nhietDoBaoQuan;

        public SanPhamThucPham(
            string maSP,
            string tenSP,
            decimal gia,
            int soLuongTon,
            DateTime ngayHetHan,
            int nhietDoBaoQuan)
            : base(maSP, tenSP, gia, soLuongTon)
        {
            ngayHetHan = ngayHetHan;
            nhietDoBaoQuan = nhietDoBaoQuan;
        }

        public DateTime NgayHetHan
        {
            get { return ngayHetHan; }
            set { ngayHetHan = value; }
        }

        public int NhietDoBaoQuan
        {
            get { return nhietDoBaoQuan; }
            set { nhietDoBaoQuan = value; }
        }

        public override decimal TinhGiaBan()
        {
            TimeSpan khoangCach = NgayHetHan.Date - DateTime.Now.Date;

            if (khoangCach.TotalDays <= 3 && khoangCach.TotalDays >= 0)
            {
                return Gia * 0.7m;
            }

            return Gia;
        }

        public override string MoTa()
        {
            return "Thực phẩm - " +
                   "Mã SP: " + MaSP +
                   ", Tên SP: " + TenSP +
                   ", Giá bán: " + TinhGiaBan() +
                   ", Hạn sử dụng: " + NgayHetHan.ToString("dd/MM/yyyy") +
                   ", Nhiệt độ bảo quản: " + NhietDoBaoQuan + "°C" +
                   ", Số lượng tồn: " + SoLuongTon;
        }
    }

    class SanPhamDienTu : SanPham
    {
        private int baoHanhThang;
        private string hangSanXuat;

        public SanPhamDienTu(
            string maSP,
            string tenSP,
            decimal gia,
            int soLuongTon,
            int baoHanhThang,
            string hangSanXuat)
            : base(maSP, tenSP, gia, soLuongTon)
        {
            baoHanhThang = baoHanhThang;
            hangSanXuat = hangSanXuat;
        }

        public int BaoHanhThang
        {
            get { return baoHanhThang; }
            set { baoHanhThang = value; }
        }

        public string HangSanXuat
        {
            get { return hangSanXuat; }
            set { hangSanXuat = value; }
        }

        public override decimal TinhGiaBan()
        {
            if (BaoHanhThang > 12)
            {
                return Gia * 1.1m;
            }

            return Gia;
        }

        public override string MoTa()
        {
            return "Điện tử - " +
                   "Mã SP: " + MaSP +
                   ", Tên SP: " + TenSP +
                   ", Giá bán: " + TinhGiaBan() +
                   ", Bảo hành: " + BaoHanhThang + " tháng" +
                   ", Hãng sản xuất: " + HangSanXuat +
                   ", Số lượng tồn: " + SoLuongTon;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            List<SanPham> danhSach = new List<SanPham>
            {
                new SanPham
                (
                    "SP001",
                    "Bàn học",
                    500000,
                    10
                ),

                new SanPhamThucPham
                (
                    "TP001",
                    "Sữa tươi",
                    30000,
                    50,
                    DateTime.Now.AddDays(2),
                    4
                ),

                new SanPhamDienTu
                (
                    "DT001",
                    "Laptop",
                    20000000,
                    5,
                    24,
                    "Dell"
                )
            };

            Console.WriteLine("===== DANH SÁCH SẢN PHẨM =====");

            decimal tongGiaTriKho = 0;

            foreach (SanPham sanPham in danhSach)
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine(sanPham.MoTa());
                Console.WriteLine("Giá bán thực tế: " +
                                  sanPham.TinhGiaBan().ToString("N0") +
                                  " VNĐ");

                tongGiaTriKho += sanPham.TinhGiaBan() * sanPham.SoLuongTon;
            }

            Console.WriteLine("------------------------------");
            Console.WriteLine("TỔNG GIÁ TRỊ KHO: " +
                              tongGiaTriKho.ToString("N0") +
                              " VNĐ");

            Console.ReadKey();
        }
    }
}