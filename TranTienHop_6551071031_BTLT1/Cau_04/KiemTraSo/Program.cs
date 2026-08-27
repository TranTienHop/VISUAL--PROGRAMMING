using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        int so;

        Console.Write("Nhập một số nguyên: ");
        so = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("===========================");
        Console.WriteLine("MSSV: 6551071031");
        Console.WriteLine("===========================");
        Console.WriteLine();

        if (so > 0)
        {
            Console.WriteLine("Số đó là số dương");
        }
        else if (so < 0)
        {
            Console.WriteLine("Số đó là số âm");
        }
        else
        {
            Console.WriteLine("Số đó bằng 0");
        }

        if (so % 2 == 0)
        {
            Console.WriteLine("Số đó là số chẵn");
        }
        else
        {
            Console.WriteLine("Số đó là số lẻ");
        }

        if (so % 3 == 0)
        {
            Console.WriteLine("Số đó chia hết cho 3");
        }
        else
        {
            Console.WriteLine("Số đó không chia hết cho 3");
        }

        if (so % 2 == 0 && so % 3 == 0)
        {
            Console.WriteLine("Số đó chia hết cho cả 2 và 3");
        }
        else
        {
            Console.WriteLine("Số đó không chia hết cho cả 2 và 3");
        }
    }
}