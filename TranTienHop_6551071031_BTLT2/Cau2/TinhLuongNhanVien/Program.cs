using System;

namespace TinhLuongNhanVien
{
    class NhanVien
    {
        private string maNV;
        private string hoTen;
        private decimal luongCoBan;
        private int soNgayLam;
        private int soNgayNghiPhep;

        public NhanVien()
        {
            maNV = "NV000";
            hoTen = "Chưa có tên";
            luongCoBan = 5000000;
            soNgayLam = 26;
            soNgayNghiPhep = 0;
        }

        public NhanVien(string maNV, string hoTen)
        {
            maNV = maNV;
            hoTen = hoTen;
            luongCoBan = 5000000;
            soNgayLam = 26;
            soNgayNghiPhep = 0;
        }

        public NhanVien(string maNV, string hoTen, decimal luongCoBan,
                        int soNgayLam, int soNgayNghiPhep)
        {
            maNV = maNV;
            hoTen = hoTen;
            LuongCoBan = luongCoBan;
            SoNgayLam = soNgayLam;
            soNgayNghiPhep = soNgayNghiPhep;
        }

        public NhanVien(string maNV, string hoTen,
                        decimal luong = 5000000, int soNgayLam = 26)
        {
            maNV = maNV;
            hoTen = hoTen;
            LuongCoBan = luong;
            SoNgayLam = soNgayLam;
            soNgayNghiPhep = 0;
        }

        public string MaNV
        {
            get { return maNV; }
        }

        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }

        public decimal LuongCoBan
        {
            get { return luongCoBan; }
            set
            {
                if (value < 0)
                    throw new Exception("Lương cơ bản phải lớn hơn hoặc bằng 0!");

                luongCoBan = value;
            }
        }

        public int SoNgayLam
        {
            get { return soNgayLam; }
            set
            {
                if (value < 0 || value > 31)
                    throw new Exception("Số ngày làm phải từ 0 đến 31!");

                soNgayLam = value;
            }
        }

        public decimal LuongThucNhan
        {
            get
            {
                decimal luongTheoNgay = luongCoBan / 26 * soNgayLam;
                decimal khauTruBHXH = luongCoBan * 0.08m;

                return luongTheoNgay - khauTruBHXH;
            }
        }

        public decimal TinhThuong()
        {
            return 0;
        }

        public decimal TinhThuong(decimal heSo)
        {
            return luongCoBan * heSo;
        }

        public decimal TinhThuong(decimal heSo, bool coPhucLoi)
        {
            decimal thuong = luongCoBan * heSo;

            if (coPhucLoi)
                thuong += 500000;

            return thuong;
        }

        public void HienThiThongTin()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("Mã nhân viên  : " + MaNV);
            Console.WriteLine("Họ tên        : " + HoTen);
            Console.WriteLine("Lương cơ bản  : " + LuongCoBan + " VNĐ");
            Console.WriteLine("Số ngày làm   : " + SoNgayLam);
            Console.WriteLine("Lương thực nhận: " + LuongThucNhan + " VNĐ");
            Console.WriteLine("------------------------------");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            NhanVien nv1 = new NhanVien();

            NhanVien nv2 = new NhanVien(
                "NV002",
                "Trần Văn Bình"
            );

            NhanVien nv3 = new NhanVien(
                "NV003",
                "Lê Văn Cường",
                8000000,
                25,
                1
            );

            NhanVien nv4 = new NhanVien(
                maNV: "NV004",
                hoTen: "Nguyễn Văn An",
                soNgayLam: 20
            );

            Console.WriteLine("===== THÔNG TIN NHÂN VIÊN =====");

            nv1.HienThiThongTin();
            nv2.HienThiThongTin();
            nv3.HienThiThongTin();
            nv4.HienThiThongTin();

            Console.WriteLine("\n===== TÍNH THƯỞNG =====");

            Console.WriteLine("Nhân viên: " + nv3.HoTen);

            Console.WriteLine("Thưởng không tham số: "
                + nv3.TinhThuong() + " VNĐ");

            Console.WriteLine("Thưởng hệ số 0.1: "
                + nv3.TinhThuong(0.1m) + " VNĐ");

            Console.WriteLine("Thưởng hệ số 0.1 có phúc lợi: "
                + nv3.TinhThuong(0.1m, true) + " VNĐ");

            Console.WriteLine("\n===== SO SÁNH =====");

            decimal thuong1 = nv3.TinhThuong();
            decimal thuong2 = nv3.TinhThuong(0.1m);
            decimal thuong3 = nv3.TinhThuong(0.1m, true);

            Console.WriteLine("Không tham số       : " + thuong1 + " VNĐ");
            Console.WriteLine("Có hệ số             : " + thuong2 + " VNĐ");
            Console.WriteLine("Có hệ số + phúc lợi  : " + thuong3 + " VNĐ");

            Console.ReadKey();
        }
    }
}