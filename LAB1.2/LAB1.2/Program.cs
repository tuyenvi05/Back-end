using System;

class Program
{
    // Bài 1: Tổng số chẵn trong mảng
    static int TongSoChan(int[] arr)
    {
        int tong = 0;
        foreach (int x in arr)
        {
            if (x % 2 == 0)
                tong += x;
        }
        return tong;
    }

    // Bài 2: Kiểm tra số nguyên tố
    static bool LaSoNguyenTo(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
            if (n % i == 0) return false;
        return true;
    }

    // Bài 3: Đếm số âm và dương
    static void DemAmDuong(int[] arr)
    {
        int demAm = 0, demDuong = 0;
        foreach (int x in arr)
        {
            if (x < 0) demAm++;
            else if (x > 0) demDuong++;
        }
        Console.WriteLine($"Số âm: {demAm}, Số dương: {demDuong}");
    }

    // Bài 4: Tìm số lớn thứ 2
    static int SoLonThuHai(int[] arr)
    {
        int max1 = int.MinValue, max2 = int.MinValue;
        foreach (int x in arr)
        {
            if (x > max1)
            {
                max2 = max1;
                max1 = x;
            }
            else if (x > max2 && x != max1)
            {
                max2 = x;
            }
        }
        return max2;
    }

    // Bài 5: Hoán vị 2 số nguyên
    static void HoanVi(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    // Bài 6: Sắp xếp mảng tăng dần
    static void SapXepTangDan(float[] arr)
    {
        Array.Sort(arr);
    }

    static void Main()
    {
       
        Console.Write("Nhap so phan tu cua mang: ");
        int n = int.Parse(Console.ReadLine());
        int[] mang = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"phan tu {i}: ");
            mang[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nBAi 1: tong cac so chan = " + TongSoChan(mang));

        Console.WriteLine("\nBài 2: Cac so nguyen to trong mang:");
        for (int i = 0; i < n; i++)
        {
            if (LaSoNguyenTo(mang[i]))
                Console.WriteLine($"Chi so {i}, Gia Tri = {mang[i]}");
        }

        Console.WriteLine("\nBài 3: Đem so am va duong:");
        DemAmDuong(mang);

        Console.WriteLine("\nBài 4: So lon thu 2 trong mang la: " + SoLonThuHai(mang));

        Console.WriteLine("\nBài 5: Hoan vi");
        Console.Write("Nhập a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Nhập b = ");
        int b = int.Parse(Console.ReadLine());
        HoanVi(ref a, ref b);
        Console.WriteLine($"Sau khi hoan vi: a = {a}, b = {b}");

        Console.WriteLine("\nBài 6: Sap xep tang dan:");
        float[] mangThuc = new float[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Phan tu thuc {i}: ");
            mangThuc[i] = float.Parse(Console.ReadLine());
        }
        SapXepTangDan(mangThuc);
        Console.WriteLine("Sau khi sap ep:");
        foreach (float x in mangThuc)
            Console.Write(x + " ");
    }
}
