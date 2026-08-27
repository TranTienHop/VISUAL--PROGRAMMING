using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        string hoTen;
        string chuoiTrim;
        string[] danhSachTu;
        string chuoiGhep;

        Console.Write("Nhập họ tên đầy đủ: ");
        hoTen = Console.ReadLine();

        chuoiTrim = hoTen.Trim();
        danhSachTu = chuoiTrim.Split(' ');
        chuoiGhep = String.Join("-", danhSachTu);

        Console.WriteLine();
        Console.WriteLine("===========================");
        Console.WriteLine("MSSV: 6551071031");
        Console.WriteLine("===========================");
        Console.WriteLine();

        Console.WriteLine("Độ dài chuỗi = " + hoTen.Length);
        Console.WriteLine("Chuỗi chữ HOA = " + hoTen.ToUpper());
        Console.WriteLine("Chuỗi chữ thường = " + hoTen.ToLower());
        Console.WriteLine("Chuỗi sau khi Trim = " + chuoiTrim);

        if (hoTen.Contains("Nguyễn"))
        {
            Console.WriteLine("Chuỗi có chứa từ \"Nguyễn\"");
        }
        else
        {
            Console.WriteLine("Chuỗi không chứa từ \"Nguyễn\"");
        }

        Console.WriteLine();
        Console.WriteLine("===== TỪNG TỪ =====");

        foreach (string tu in danhSachTu)
        {
            Console.WriteLine(tu);
        }

        Console.WriteLine();
        Console.WriteLine("Chuỗi sau khi ghép = " + chuoiGhep);
    }
}