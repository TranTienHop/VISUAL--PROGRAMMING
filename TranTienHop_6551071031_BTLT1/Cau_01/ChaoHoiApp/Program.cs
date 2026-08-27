using System;
class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;


        string hoTen;
        int tuoi;
        double chieuCao;
        float canNang;
        bool daTotNgiep;

        Console.Write("Họ tên: ");
        hoTen= Console.ReadLine();

        Console.Write("Tuổi: ");
        tuoi= int.Parse(Console.ReadLine());

        Console.Write("Chiều cao: ");
        chieuCao= int.Parse(Console.ReadLine());

        Console.Write("Cân nặng (kg): ");
        canNang= float.Parse(Console.ReadLine());

        Console.Write("Đã tốt nghiệp (true/flase): ");
        daTotNgiep=bool.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("===========================");
        Console.WriteLine("MSSV: 6551071031");
        Console.WriteLine("===========================");
        Console.WriteLine();
        Console.WriteLine("Họ tên: " + hoTen);
        Console.WriteLine("Tuổi: " + tuoi);
        Console.WriteLine("Chiều cao: " + chieuCao + "m");
        Console.WriteLine("Cân nặng: " + canNang + "kg");
        Console.WriteLine("Đã tốt nghiệp: " + daTotNgiep);


    }
}