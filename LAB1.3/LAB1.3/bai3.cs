using System;
using System.Collections.Generic;

class ThiSinh
{
    public string SoBaoDanh;
    public string HoTen;
    public string DiaChi;
    public double UuTien;

    public virtual void Nhap()
    {
        Console.Write("Nhap so bao danh: ");
        SoBaoDanh = Console.ReadLine();
        Console.Write("Nhap ho ten: ");
        HoTen = Console.ReadLine();
        Console.Write("Nhap dia chi: ");
        DiaChi = Console.ReadLine();
        Console.Write("Nhap diem uu tien: ");
        UuTien = double.Parse(Console.ReadLine());
    }

    public virtual void HienThi()
    {
        Console.WriteLine($"SBD: {SoBaoDanh}, Ho ten: {HoTen}, Dia chi: {DiaChi}, Uu tien: {UuTien}");
    }

    public virtual double TongDiem()
    {
        return 0;
    }

    public virtual string KhoiThi()
    {
        return "";
    }
}

class ThiSinhKhoiA : ThiSinh
{
    public double Toan, Ly, Hoa;

    public override void Nhap()
    {
        base.Nhap();
        Console.Write("Nhap diem Toan: ");
        Toan = double.Parse(Console.ReadLine());
        Console.Write("Nhap diem Ly: ");
        Ly = double.Parse(Console.ReadLine());
        Console.Write("Nhap diem Hoa: ");
        Hoa = double.Parse(Console.ReadLine());
    }

    public override void HienThi()
    {
        base.HienThi();
        Console.WriteLine($"Khoi A - Toan: {Toan}, Ly: {Ly}, Hoa: {Hoa}, Tong: {TongDiem()}");
    }

    public override double TongDiem()
    {
        return Toan + Ly + Hoa + UuTien;
    }

    public override string KhoiThi()
    {
        return "A";
    }
}

class ThiSinhKhoiB : ThiSinh
{
    public double Toan, Hoa, Sinh;

    public override void Nhap()
    {
        base.Nhap();
        Console.Write("Nhap diem Toan: ");
        Toan = double.Parse(Console.ReadLine());
        Console.Write("Nhap diem Hoa: ");
        Hoa = double.Parse(Console.ReadLine());
        Console.Write("Nhap diem Sinh: ");
        Sinh = double.Parse(Console.ReadLine());
    }

    public override void HienThi()
    {
        base.HienThi();
        Console.WriteLine($"Khoi B - Toan: {Toan}, Hoa: {Hoa}, Sinh: {Sinh}, Tong: {TongDiem()}");
    }

    public override double TongDiem()
    {
        return Toan + Hoa + Sinh + UuTien;
    }

    public override string KhoiThi()
    {
        return "B";
    }
}

class ThiSinhKhoiC : ThiSinh
{
    public double Van, Su, Dia;

    public override void Nhap()
    {
        base.Nhap();
        Console.Write("Nhap diem Van: ");
        Van = double.Parse(Console.ReadLine());
        Console.Write("Nhap diem Su: ");
        Su = double.Parse(Console.ReadLine());
        Console.Write("Nhap diem Dia: ");
        Dia = double.Parse(Console.ReadLine());
    }

    public override void HienThi()
    {
        base.HienThi();
        Console.WriteLine($"Khoi C - Van: {Van}, Su: {Su}, Dia: {Dia}, Tong: {TongDiem()}");
    }

    public override double TongDiem()
    {
        return Van + Su + Dia + UuTien;
    }

    public override string KhoiThi()
    {
        return "C";
    }
}

class TuyenSinh
{
    List<ThiSinh> danhSach = new List<ThiSinh>();

    public void NhapThiSinh()
    {
        Console.WriteLine("1. Thi sinh khoi A");
        Console.WriteLine("2. Thi sinh khoi B");
        Console.WriteLine("3. Thi sinh khoi C");
        Console.Write("Chon loai thi sinh: ");
        int chon = int.Parse(Console.ReadLine());

        ThiSinh ts = null;
        if (chon == 1) ts = new ThiSinhKhoiA();
        else if (chon == 2) ts = new ThiSinhKhoiB();
        else if (chon == 3) ts = new ThiSinhKhoiC();
        else
        {
            Console.WriteLine("Lua chon khong hop le!");
            return;
        }

        ts.Nhap();
        danhSach.Add(ts);
    }

    public void HienThiTrungTuyen()
    {
        Console.WriteLine("\nDanh sach thi sinh trung tuyen:");
        foreach (var ts in danhSach)
        {
            double tong = ts.TongDiem();
            string khoi = ts.KhoiThi();

            bool trungTuyen = (khoi == "A" && tong >= 15) ||
                              (khoi == "B" && tong >= 16) ||
                              (khoi == "C" && tong >= 13.5);

            if (trungTuyen)
            {
                ts.HienThi();
                Console.WriteLine("------------------------");
            }
        }
    }

    public void TimTheoSoBaoDanh()
    {
        Console.Write("Nhap so bao danh can tim: ");
        string sbd = Console.ReadLine();
        bool timThay = false;

        foreach (var ts in danhSach)
        {
            if (ts.SoBaoDanh == sbd)
            {
                ts.HienThi();
                timThay = true;
                break;
            }
        }

        if (!timThay)
        {
            Console.WriteLine("Khong tim thay thi sinh co so bao danh tren.");
        }
    }

    public void Menu()
    {
        int chon;
        do
        {
            Console.WriteLine("\n===== MENU =====");
            Console.WriteLine("1. Nhap thi sinh");
            Console.WriteLine("2. Hien thi thi sinh trung tuyen");
            Console.WriteLine("3. Tim theo so bao danh");
            Console.WriteLine("0. Thoat");
            Console.Write("Chon: ");
            chon = int.Parse(Console.ReadLine());

            switch (chon)
            {
                case 1: NhapThiSinh(); break;
                case 2: HienThiTrungTuyen(); break;
                case 3: TimTheoSoBaoDanh(); break;
                case 0: Console.WriteLine("Da thoat."); break;
                default: Console.WriteLine("Chon sai!"); break;
            }

        } while (chon != 0);
    }
}

class Program
{
    static void Main(string[] args)
    {
        TuyenSinh ts = new TuyenSinh();
        ts.Menu();
    }
}
