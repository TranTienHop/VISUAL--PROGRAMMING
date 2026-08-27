using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        int n;

        do
        {
            Console.Write("Nhập số nguyên n (1 - 9): ");
            n = int.Parse(Console.ReadLine());

            if (n < 1 || n > 9)
            {
                Console.WriteLine("Số không hợp lệ! Vui lòng nhập lại.");
            }
        }
        while (n < 1 || n > 9);

        Console.WriteLine();
        Console.WriteLine("===========================");
        Console.WriteLine("MSSV: 6551071031");
        Console.WriteLine("===========================");
        Console.WriteLine();

        Console.WriteLine("===== BẢNG CỬU CHƯƠNG " + n + " =====");

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("{0} × {1} = {2}", n, i, n * i);
        }
    }
}