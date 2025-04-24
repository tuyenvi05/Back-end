using System;
using System.Collections.Generic;

class Nguoi
{
    public string CMND;
    public string HoTen;
    public int Tuoi;
    public int NamSinh;
    public string NgheNghiep;

    public void Nhap()
    {
        Console.Write("Nhap so CMND: ");
        CMND = Console.ReadLine();
        Console.Write("Nhap ho ten: ");
        HoTen = Console.ReadLine();
        Console.Write("Nhap tuoi: ");
        Tuoi = int.Parse(Console.ReadLine());
        Console.Write("Nhap nam sinh: ");
        NamSinh = int.Parse(Console.ReadLine());
        Console.Write("Nhap nghe nghiep: ");
        NgheNghiep = Console.ReadLine();
    }

    public void HienThi()
    {
        Console.WriteLine($"CMND: {CMND}, Ho ten: {HoTen}, Tuoi: {Tuoi}, Nam sinh: {NamSinh}, Nghe nghiep: {NgheNghiep}");
    }
}

class HoDan
{
    public int SoNguoi;
    public string SoNha;
    public List<Nguoi> DanhSachNguoi = new List<Nguoi>();

    public void Nhap()
    {
        Console.Write("Nhap so nha: ");
        SoNha = Console.ReadLine();
        Console.Write("Nhap so nguoi trong ho: ");
        SoNguoi = int.Parse(Console.ReadLine());

        for (int i = 0; i < SoNguoi; i++)
        {
            Console.WriteLine($"Nhap thong tin nguoi thu {i + 1}:");
            Nguoi n = new Nguoi();
            n.Nhap();
            DanhSachNguoi.Add(n);
        }
    }

    public void HienThi()
    {
        Console.WriteLine($"So nha: {SoNha}, So nguoi: {SoNguoi}");
        foreach (var n in DanhSachNguoi)
        {
            n.HienThi();
        }
    }

    public bool CoNguoiTen(string ten)
    {
        foreach (var n in DanhSachNguoi)
        {
            if (n.HoTen.ToLower().Contains(ten.ToLower()))
                return true;
        }
        return false;
    }
}

class KhuPho
{
    List<HoDan> danhSachHoDan = new List<HoDan>();

    public void NhapDanhSachHoDan()
    {
        Console.Write("Nhap so ho dan: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nNhap ho dan thu {i + 1}:");
            HoDan hd = new HoDan();
            hd.Nhap();
            danhSachHoDan.Add(hd);
        }
    }

    public void HienThiTatCa()
    {
        Console.WriteLine("\nThong tin tat ca ho dan trong khu pho:");
        foreach (var hd in danhSachHoDan)
        {
            hd.HienThi();
            Console.WriteLine("---------------------------");
        }
    }

    public void TimKiem()
    {
        Console.WriteLine("\n1. Tim theo ho ten");
        Console.WriteLine("2. Tim theo so nha");
        Console.Write("Chon kieu tim kiem: ");
        int chon = int.Parse(Console.ReadLine());

        if (chon == 1)
        {
            Console.Write("Nhap ho ten can tim: ");
            string ten = Console.ReadLine();
            bool timThay = false;
            foreach (var hd in danhSachHoDan)
            {
                if (hd.CoNguoiTen(ten))
                {
                    hd.HienThi();
                    Console.WriteLine("---------------------------");
                    timThay = true;
                }
            }
            if (!timThay) Console.WriteLine("Khong tim thay ho dan co nguoi ten do.");
        }
        else if (chon == 2)
        {
            Console.Write("Nhap so nha can tim: ");
            string soNha = Console.ReadLine();
            bool timThay = false;
            foreach (var hd in danhSachHoDan)
            {
                if (hd.SoNha.ToLower() == soNha.ToLower())
                {
                    hd.HienThi();
                    Console.WriteLine("---------------------------");
                    timThay = true;
                }
            }
            if (!timThay) Console.WriteLine("Khong tim thay ho dan co so nha do.");
        }
        else
        {
            Console.WriteLine("Lua chon khong hop le!");
        }
    }

    public void Menu()
    {
        int chon;
        do
        {
            Console.WriteLine("\n====== MENU ======");
            Console.WriteLine("1. Nhap danh sach ho dan");
            Console.WriteLine("2. Hien thi tat ca ho dan");
            Console.WriteLine("3. Tim kiem ho dan");
            Console.WriteLine("0. Thoat");
            Console.Write("Chon: ");
            chon = int.Parse(Console.ReadLine());

            switch (chon)
            {
                case 1: NhapDanhSachHoDan(); break;
                case 2: HienThiTatCa(); break;
                case 3: TimKiem(); break;
                case 0: Console.WriteLine("Da thoat!"); break;
                default: Console.WriteLine("Chon sai!"); break;
            }

        } while (chon != 0);
    }
}

class Program
{
    static void Main(string[] args)
    {
        KhuPho khu = new KhuPho();
        khu.Menu();
    }
}
