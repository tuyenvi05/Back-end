using System;
using System.Collections.Generic;

class TaiLieu
{
    public string MaTaiLieu;
    public string TenNhaXuatBan;
    public int SoBanPhatHanh;

    public virtual void Nhap()
    {
        Console.Write("Nhap ma tai lieu: ");
        MaTaiLieu = Console.ReadLine();
        Console.Write("Nhap ten nha xuat ban: ");
        TenNhaXuatBan = Console.ReadLine();
        Console.Write("Nhap so ban phat hanh: ");
        SoBanPhatHanh = int.Parse(Console.ReadLine());
    }

    public virtual void HienThi()
    {
        Console.WriteLine($"Ma: {MaTaiLieu}, NXB: {TenNhaXuatBan}, So ban: {SoBanPhatHanh}");
    }
}

class Sach : TaiLieu
{
    public string TenTacGia;
    public int SoTrang;

    public override void Nhap()
    {
        base.Nhap();
        Console.Write("Nhap ten tac gia: ");
        TenTacGia = Console.ReadLine();
        Console.Write("Nhap so trang: ");
        SoTrang = int.Parse(Console.ReadLine());
    }

    public override void HienThi()
    {
        base.HienThi();
        Console.WriteLine($"Tac gia: {TenTacGia}, So trang: {SoTrang}");
    }
}

class TapChi : TaiLieu
{
    public int SoPhatHanh;
    public int ThangPhatHanh;

    public override void Nhap()
    {
        base.Nhap();
        Console.Write("Nhap so phat hanh: ");
        SoPhatHanh = int.Parse(Console.ReadLine());
        Console.Write("Nhap thang phat hanh: ");
        ThangPhatHanh = int.Parse(Console.ReadLine());
    }

    public override void HienThi()
    {
        base.HienThi();
        Console.WriteLine($"So phat hanh: {SoPhatHanh}, Thang: {ThangPhatHanh}");
    }
}

class Bao : TaiLieu
{
    public string NgayPhatHanh;

    public override void Nhap()
    {
        base.Nhap();
        Console.Write("Nhap ngay phat hanh (dd/MM/yyyy): ");
        NgayPhatHanh = Console.ReadLine();
    }

    public override void HienThi()
    {
        base.HienThi();
        Console.WriteLine($"Ngay phat hanh: {NgayPhatHanh}");
    }
}

class QuanLyTaiLieu
{
    List<TaiLieu> danhSach = new List<TaiLieu>();

    public void NhapTaiLieu()
    {
        Console.WriteLine("1. Nhap Sach");
        Console.WriteLine("2. Nhap Tap chi");
        Console.WriteLine("3. Nhap Bao");
        Console.Write("Chon loai tai lieu: ");
        int loai = int.Parse(Console.ReadLine());

        TaiLieu tl = null;
        if (loai == 1) tl = new Sach();
        else if (loai == 2) tl = new TapChi();
        else if (loai == 3) tl = new Bao();
        else
        {
            Console.WriteLine("Lua chon khong hop le!");
            return;
        }

        tl.Nhap();
        danhSach.Add(tl);
    }

    public void HienThiTatCa()
    {
        foreach (var tl in danhSach)
        {
            tl.HienThi();
            Console.WriteLine("-------------------");
        }
    }

    public void TimKiemTheoLoai()
    {
        Console.WriteLine("1. Tim Sach");
        Console.WriteLine("2. Tim Tap chi");
        Console.WriteLine("3. Tim Bao");
        Console.Write("Chon loai can tim: ");
        int loai = int.Parse(Console.ReadLine());

        foreach (var tl in danhSach)
        {
            if ((loai == 1 && tl is Sach) ||
                (loai == 2 && tl is TapChi) ||
                (loai == 3 && tl is Bao))
            {
                tl.HienThi();
                Console.WriteLine("-------------------");
            }
        }
    }

    public void Menu()
    {
        int chon;
        do
        {
            Console.WriteLine("\n===== MENU =====");
            Console.WriteLine("1. Nhap tai lieu");
            Console.WriteLine("2. Hien thi tai lieu");
            Console.WriteLine("3. Tim kiem theo loai");
            Console.WriteLine("0. Thoat");
            Console.Write("Chon: ");
            chon = int.Parse(Console.ReadLine());

            switch (chon)
            {
                case 1: NhapTaiLieu(); break;
                case 2: HienThiTatCa(); break;
                case 3: TimKiemTheoLoai(); break;
                case 0: Console.WriteLine("Da thoat chuong trinh."); break;
                default: Console.WriteLine("Chon khong hop le!"); break;
            }

        } while (chon != 0);
    }
}

class Program
{
    static void Main(string[] args)
    {
        QuanLyTaiLieu ql = new QuanLyTaiLieu();
        ql.Menu();
    }
}
