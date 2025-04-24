using System;

class CanBo
{
    public string HoTen;
    public int NamSinh;
    public string GioiTinh;
    public string DiaChi;

    public void Nhap()
    {
        Console.Write("Nhap ho ten: ");
        HoTen = Console.ReadLine();
        Console.Write("Nhap nam sinh: ");
        NamSinh = int.Parse(Console.ReadLine());
        Console.Write("Nhap gioi tinh: ");
        GioiTinh = Console.ReadLine();
        Console.Write("Nhap dia chi: ");
        DiaChi = Console.ReadLine();
    }

    public void HienThi()
    {
        Console.WriteLine("Ho ten: " + HoTen);
        Console.WriteLine("Nam sinh: " + NamSinh);
        Console.WriteLine("Gioi tinh: " + GioiTinh);
        Console.WriteLine("Dia chi: " + DiaChi);
    }
}

class CongNhan : CanBo
{
    public string Bac;

    public new void Nhap()
    {
        base.Nhap();
        Console.Write("Nhap bac cong nhan (vi du: 3/7): ");
        Bac = Console.ReadLine();
    }

    public new void HienThi()
    {
        base.HienThi();
        Console.WriteLine("Chuc vu: Cong nhan");
        Console.WriteLine("Bac: " + Bac);
    }
}

class KySu : CanBo
{
    public string Nganh;

    public new void Nhap()
    {
        base.Nhap();
        Console.Write("Nhap nganh dao tao: ");
        Nganh = Console.ReadLine();
    }

    public new void HienThi()
    {
        base.HienThi();
        Console.WriteLine("Chuc vu: Ky su");
        Console.WriteLine("Nganh dao tao: " + Nganh);
    }
}

class NhanVien : CanBo
{
    public string CongViec;

    public new void Nhap()
    {
        base.Nhap();
        Console.Write("Nhap cong viec: ");
        CongViec = Console.ReadLine();
    }

    public new void HienThi()
    {
        base.HienThi();
        Console.WriteLine("Chuc vu: Nhan vien");
        Console.WriteLine("Cong viec: " + CongViec);
    }
}

class bai1
{
    static void Main()
    {
        CanBo[] ds = new CanBo[100];
        int n = 0;
        int chon;

        do
        {
            Console.WriteLine("\n=== MENU ===");
            Console.WriteLine("1. Them cong nhan");
            Console.WriteLine("2. Them ky su");
            Console.WriteLine("3. Them nhan vien");
            Console.WriteLine("4. Tim theo ten");
            Console.WriteLine("5. Hien thi danh sach");
            Console.WriteLine("6. Thoat");
            Console.Write("Chon: ");
            chon = int.Parse(Console.ReadLine());

            if (chon == 1)
            {
                CongNhan cn = new CongNhan();
                cn.Nhap();
                ds[n++] = cn;
            }
            else if (chon == 2)
            {
                KySu ks = new KySu();
                ks.Nhap();
                ds[n++] = ks;
            }
            else if (chon == 3)
            {
                NhanVien nv = new NhanVien();
                nv.Nhap();
                ds[n++] = nv;
            }
            else if (chon == 4)
            {
                Console.Write("Nhap ten can tim: ");
                string ten = Console.ReadLine();
                bool timThay = false;
                for (int i = 0; i < n; i++)
                {
                    if (ds[i].HoTen.Contains(ten))
                    {
                        ds[i].HienThi();
                        Console.WriteLine("------------------");
                        timThay = true;
                    }
                }
                if (!timThay)
                    Console.WriteLine("Khong tim thay!");
            }
            else if (chon == 5)
            {
                Console.WriteLine("\n--- DANH SACH ---");
                for (int i = 0; i < n; i++)
                {
                    ds[i].HienThi();
                    Console.WriteLine("------------------");
                }
            }
            else if (chon == 6)
            {
                Console.WriteLine("Tam biet!");
            }
            else
            {
                Console.WriteLine("Chon sai, vui long chon lai!");
            }

        } while (chon != 6);
    }
}
