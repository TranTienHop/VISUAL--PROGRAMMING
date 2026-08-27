using System;

class Program
{
    static void Main()
    {


        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Nhập nhiệt độ Celsius: ");
        decimal celsius = decimal.Parse(Console.ReadLine());

        decimal fahrenheit = celsius * 9 / 5 + 32;
        decimal kelvin = celsius + 273.15m;

        Console.WriteLine();
        Console.WriteLine("===========================");
        Console.WriteLine("MSSV: 6551071031");
        Console.WriteLine("===========================");
        Console.WriteLine();
        Console.WriteLine("===== KẾT QUẢ =====");
        Console.WriteLine("Fahrenheit = {0:F2}", fahrenheit);
        Console.WriteLine("Kelvin = {0:F2}", kelvin);
    }
}