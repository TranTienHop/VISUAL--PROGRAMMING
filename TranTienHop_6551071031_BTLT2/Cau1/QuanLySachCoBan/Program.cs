using System;

namespace QuanLySachCoBan
{
    class Sach
    {
        private string maSach;
        private string tenSach;
        private string tacGia;
        private int namXuatBan;
        private double giaBan;

        public Sach(string maSach, string tenSach, string tacGia,
                    int namXuatBan, double giaBan)
        {
            this.maSach = maSach;
            TenSach = tenSach;
            this.tacGia = tacGia;
            NamXuatBan = namXuatBan;
            this.giaBan = giaBan;
        }

        public Sach()
        {
            maSach = "S000";
            tenSach = "Chưa có tên";
            tacGia = "Chưa có tác giả";
            namXuatBan = DateTime.Now.Year;
            giaBan = 0;
        }

        public string MaSach
        {
            get { return maSach; }
            set {  maSach = value; }
        }

        public string TenSach
        {
            get { return tenSach; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Tên sách không được rỗng!");

                tenSach = value;
            }
        }

        public string TacGia
        {
            get { return tacGia; }
            set { tacGia = value; }
        }


        public int NamXuatBan
        {
            get { return namXuatBan; }
            set
            {
                int namHienTai = DateTime.Now.Year;

                if (value < 1900 || value > namHienTai)
                    throw new Exception(
                        "Năm xuất bản phải từ 1900 đến " + namHienTai);

                namXuatBan = value;
            }
        }

        public double GiaBan
        {
            get { return giaBan; }
            set { giaBan = value; }

        }

        public void HienThiThongTin()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("Mã sách      : " + MaSach);
            Console.WriteLine("Tên sách     : " + TenSach);
            Console.WriteLine("Tác giả      : " + TacGia);
            Console.WriteLine("Năm xuất bản : " + NamXuatBan);
            Console.WriteLine("Giá bán      : " + GiaBan + " VNĐ");
            Console.WriteLine("------------------------------");
        }

        public override string ToString()
        {
            return MaSach + " - " +
                   TenSach + " - " +
                   TacGia + " - " +
                   NamXuatBan + " - " +
                   GiaBan + " VNĐ";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Sach sach1 = new Sach(
                "S001",
                "Lập trình C#",
                "Nguyễn Văn A",
                2023,
                150000
            );

            Sach sach2 = new Sach();

            sach2.MaSach = "S002";
            sach2.TenSach = "Cơ Sở Dữ Liệu";
            sach2.TacGia = "Trần Văn B";
            sach2.NamXuatBan = 2022;
            sach2.GiaBan = 510;

            Sach sach3 = new Sach(
                "S003",
                "Sách 3",
                "Tác Giả C",
                2020,
                200000
            )
            {
                TenSach = "Lập Trình Hướng Đối Tượng",
                TacGia = "Lê Văn C",
                NamXuatBan = 2024
            };

            Console.WriteLine("===== THÔNG TIN SÁCH =====");

            sach1.HienThiThongTin();
            sach2.HienThiThongTin();
            sach3.HienThiThongTin();

            Console.WriteLine("\n===== KIỂM TRA LỖI =====");

            try
            {
                sach1.NamXuatBan = 1800;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }

            try
            {
                sach2.TenSach = "";
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }

            Console.WriteLine("\n===== TOSTRING =====");
            Console.WriteLine(sach1.ToString());
            Console.WriteLine(sach2.ToString());
            Console.WriteLine(sach3.ToString());

            Console.ReadKey();
        }
    }
}