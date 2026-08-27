using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        double diemTrungBinh;
        string xepLoai;

        Console.Write("Nhập điểm trung bình: ");
        diemTrungBinh = double.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("===========================");
        Console.WriteLine("MSSV: 6551071031");
        Console.WriteLine("===========================");
        Console.WriteLine();

        if (diemTrungBinh < 0 || diemTrungBinh > 10)
        {
            xepLoai = "Điểm không hợp lệ!";
        }
        else if (diemTrungBinh >= 9.0)
        {
            xepLoai = "Xuất sắc";
        }
        else if (diemTrungBinh >= 8.0)
        {
            xepLoai = "Giỏi";
        }
        else if (diemTrungBinh >= 6.5)
        {
            xepLoai = "Khá";
        }
        else if (diemTrungBinh >= 5.0)
        {
            xepLoai = "Trung bình";
        }
        else
        {
            xepLoai = "Yếu";
        }

        Console.WriteLine("Xếp loại: " + xepLoai);
    }
}