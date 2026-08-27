using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        int[] mang = new int[10];
        int tong = 0;
        double trungBinh;
        int lonNhat;
        int nhoNhat;
        int viTriLonNhat = 0;
        int viTriNhoNhat = 0;
        int soChan = 0;
        int soLe = 0;

        Console.WriteLine("Nhập 10 phần tử của mảng:");

        for (int i = 0; i < mang.Length; i++)
        {
            Console.Write("Phần tử thứ " + i + ": ");
            mang[i] = int.Parse(Console.ReadLine());
        }

        lonNhat = mang[0];
        nhoNhat = mang[0];

        for (int i = 0; i < mang.Length; i++)
        {
            tong += mang[i];

            if (mang[i] > lonNhat)
            {
                lonNhat = mang[i];
                viTriLonNhat = i;
            }

            if (mang[i] < nhoNhat)
            {
                nhoNhat = mang[i];
                viTriNhoNhat = i;
            }

            if (mang[i] % 2 == 0)
            {
                soChan++;
            }
            else
            {
                soLe++;
            }
        }

        trungBinh = (double)tong / mang.Length;

        Console.WriteLine();
        Console.WriteLine("===========================");
        Console.WriteLine("MSSV: 6551071031");
        Console.WriteLine("===========================");
        Console.WriteLine();

        Console.Write("Toàn bộ mảng: ");
        foreach (int phanTu in mang)
        {
            Console.Write(phanTu + " ");
        }

        Console.WriteLine();
        Console.WriteLine("Tổng các phần tử = " + tong);
        Console.WriteLine("Trung bình các phần tử = " + trungBinh);
        Console.WriteLine("Giá trị lớn nhất = " + lonNhat + ", vị trí = " + viTriLonNhat);
        Console.WriteLine("Giá trị nhỏ nhất = " + nhoNhat + ", vị trí = " + viTriNhoNhat);
        Console.WriteLine("Số lượng phần tử chẵn = " + soChan);
        Console.WriteLine("Số lượng phần tử lẻ = " + soLe);

        Console.Write("Mảng sau khi đảo ngược: ");

        for (int i = mang.Length - 1; i >= 0; i--)
        {
            Console.Write(mang[i] + " ");
        }
    }
}