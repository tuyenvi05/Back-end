using System;

class Program
{
    static void Main()
    {
        int chon;
        do
        {
            Console.WriteLine("1. Xin chao ten va tuoi");
            Console.WriteLine("2. Tinh dien tich hinh chu nhat");
            Console.WriteLine("3. Chuyen doi do C sang do F");
            Console.WriteLine("4. Kiem tra so chan");
            Console.WriteLine("5. Tong va tich hai so");
            Console.WriteLine("6. Kiem tra duong, am, khong");
            Console.WriteLine("7. Kiem tra nam nhuan");
            Console.WriteLine("8. In bang cuu chuong");
            Console.WriteLine("9. Tinh giai thua");
            Console.WriteLine("10. Kiem tra so nguyen to");
            Console.WriteLine("0. Thoat");
            Console.Write("Chon chuc nang (0-10): ");
            chon = int.Parse(Console.ReadLine());

            Console.WriteLine();

            switch (chon)
            {
                case 1:
                    Bai1();
                    break;
                case 2:
                    Bai2();
                    break;
                case 3:
                    Bai3();
                    break;
                case 4:
                    Bai4();
                    break;
                case 5:
                    Bai5();
                    break;
                case 6:
                    Bai6();
                    break;
                case 7:
                    Bai7();
                    break;
                case 8:
                    Bai8();
                    break;
                case 9:
                    Bai9();
                    break;
                case 10:
                    Bai10();
                    break;
                case 0:
                    Console.WriteLine("Tam biet!");
                    break;
                default:
                    Console.WriteLine("Chuc nang khong hop le. Vui long chon lai.");
                    break;
            }

            Console.WriteLine();
        }
        while (chon != 0);
    }

    static void Bai1()
    {
        Console.Write("Nhap ten: ");
        string ten = Console.ReadLine();

        Console.Write("Nhap tuoi: ");
        int tuoi = int.Parse(Console.ReadLine());

        Console.WriteLine("Xin chao " + ten + ", ban " + tuoi + " tuoi!");
    }

    static void Bai2()
    {
        Console.Write("Nhap chieu dai: ");
        double dai = double.Parse(Console.ReadLine());

        Console.Write("Nhap chieu rong: ");
        double rong = double.Parse(Console.ReadLine());

        double dienTich = dai * rong;
        Console.WriteLine("Dien tich la: " + dienTich);
    }

    static void Bai3()
    {
        Console.Write("Nhap nhiet do C: ");
        double c = double.Parse(Console.ReadLine());

        double f = (c * 9 / 5) + 32;
        Console.WriteLine("Nhiet do F la: " + f);
    }

    static void Bai4()
    {
        Console.Write("Nhap mot so nguyen: ");
        int so = int.Parse(Console.ReadLine());

        if (so % 2 == 0)
            Console.WriteLine("Day la so chan");
        else
            Console.WriteLine("Day la so le");
    }

    static void Bai5()
    {
        Console.Write("Nhap so thu nhat: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Nhap so thu hai: ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Tong: " + (a + b));
        Console.WriteLine("Tich: " + (a * b));
    }

    static void Bai6()
    {
        Console.Write("Nhap mot so: ");
        int so = int.Parse(Console.ReadLine());

        if (so > 0)
            Console.WriteLine("Day la so duong");
        else if (so < 0)
            Console.WriteLine("Day la so am");
        else
            Console.WriteLine("Day la so khong");
    }

    static void Bai7()
    {
        Console.Write("Nhap nam: ");
        int nam = int.Parse(Console.ReadLine());

        if ((nam % 4 == 0 && nam % 100 != 0) || (nam % 400 == 0))
            Console.WriteLine("Day la nam nhuan");
        else
            Console.WriteLine("Day khong phai nam nhuan");
    }

    static void Bai8()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("Bang nhan " + i);
            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine(i + " x " + j + " = " + (i * j));
            }
            Console.WriteLine();
        }
    }

    static void Bai9()
    {
        Console.Write("Nhap so nguyen duong: ");
        int n = int.Parse(Console.ReadLine());
        int gt = 1;

        for (int i = 1; i <= n; i++)
        {
            gt *= i;
        }

        Console.WriteLine("Giai thua cua " + n + " la: " + gt);
    }

    static void Bai10()
    {
        Console.Write("Nhap so nguyen: ");
        int n = int.Parse(Console.ReadLine());
        bool laSoNguyenTo = true;

        if (n < 2)
        {
            laSoNguyenTo = false;
        }
        else
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    laSoNguyenTo = false;
                    break;
                }
            }
        }

        if (laSoNguyenTo)
            Console.WriteLine(n + " la so nguyen to");
        else
            Console.WriteLine(n + " khong phai la so nguyen to");
    }
}
