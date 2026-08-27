using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Nhập số a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Nhập số b: ");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("===========================");
        Console.WriteLine("MSSV: 6551071031");
        Console.WriteLine("===========================");
        Console.WriteLine(); 
        Console.WriteLine("===== KẾT QUẢ =====");
        Console.WriteLine("a + b = " + (a + b));
        Console.WriteLine("a - b = " + (a - b));
        Console.WriteLine("a * b = " + (a * b));
        Console.WriteLine("a / b = " + (a / b));
        Console.WriteLine("(int)a / (int)b = " + ((int)a / (int)b));
        Console.WriteLine("(int)a % (int)b = " + ((int)a % (int)b));
        Console.WriteLine("a ^ b = " + Math.Pow(a, b));
    }
}