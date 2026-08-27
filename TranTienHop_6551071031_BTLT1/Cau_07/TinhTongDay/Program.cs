using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        int n;
        long tong = 0;
        long tongChan = 0;
        long tongLe = 0;
        long giaiThua = 1;

        Console.Write("Nhập số nguyên dương n: ");
        n = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("===========================");
        Console.WriteLine("MSSV: 6551071031");
        Console.WriteLine("===========================");
        Console.WriteLine();

        for (int i = 1; i <= n; i++)
        {
            tong += i;

            if (i % 2 == 0)
            {
                tongChan += i;
            }
            else
            {
                tongLe += i;
            }
        }

        int j = 1;

        while (j <= n)
        {
            giaiThua *= j;
            j++;
        }

        Console.WriteLine("Tổng 1 + 2 + ... + n = " + tong);
        Console.WriteLine("Tổng các số chẵn từ 1 đến n = " + tongChan);
        Console.WriteLine("Tổng các số lẻ từ 1 đến n = " + tongLe);
        Console.WriteLine("Giai thừa n! = " + giaiThua);
    }
}