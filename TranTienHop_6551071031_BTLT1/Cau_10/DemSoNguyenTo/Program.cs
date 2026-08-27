using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        int n;
        int soLuong = 0;

        try
        {
            Console.Write("Nhập số nguyên dương n (n <= 1000): ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("===========================");
            Console.WriteLine("MSSV: 6551071031");
            Console.WriteLine("===========================");
            Console.WriteLine();

            if (n <= 0 || n > 1000)
            {
                Console.WriteLine("Số không hợp lệ! Vui lòng nhập n trong khoảng 1 đến 1000.");
            }
            else
            {
                Console.WriteLine("Các số nguyên tố từ 2 đến " + n + ":");

                for (int i = 2; i <= n; i++)
                {
                    bool laSoNguyenTo = true;

                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            laSoNguyenTo = false;
                            break;
                        }
                    }

                    if (laSoNguyenTo)
                    {
                        Console.Write(i + " ");
                        soLuong++;
                    }
                }

                Console.WriteLine();
                Console.WriteLine("Tổng số lượng số nguyên tố = " + soLuong);
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Lỗi: Vui lòng nhập một số nguyên!");
        }
    }
}