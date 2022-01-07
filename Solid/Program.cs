using System;
using System.Collections.Generic;

namespace Solid
{

    class Program
    {
        static void Main(string[] args)
        {

            List<NhaKhoaHoc> listNhaKhoaHoc = new List<NhaKhoaHoc>();
            int n;
            n = listNhaKhoaHoc.Count;
            Console.WriteLine("Nhap so Nha Khoa Hoc");
            n = int.Parse(Console.ReadLine());


            List<NhaQuanLy> listNhaQuanLy = new List<NhaQuanLy>();
            int m;
            m = listNhaQuanLy.Count;
            Console.WriteLine("Nhap so Nha QuanLy");
            m = int.Parse(Console.ReadLine());

            List<NhanVienPhongThiNghiem> listNhanVienPhongThiNghiem = new List<NhanVienPhongThiNghiem>();
            int p;
            p = listNhanVienPhongThiNghiem.Count;
            Console.WriteLine("Nhap so Nhan Vien");
            p = int.Parse(Console.ReadLine());

            int tong1 = 0;
            for (int i = 0; i < n; i++)
            {

                NhaKhoaHoc a = new NhaKhoaHoc();
                a.Nhap();
                listNhaKhoaHoc.Add(a);
                tong1 = tong1 + a.Calculate();
            }

            int tong2 = 0;
            for (int i = 0; i < m; i++)
            {
                NhaQuanLy b = new NhaQuanLy();
                b.Nhap();
                listNhaQuanLy.Add(b);
                tong2 = tong2 + b.Calculate();
            }

            int tong3 = 0;
            for (int i = 0; i < p; i++)
            {
                NhanVienPhongThiNghiem c = new NhanVienPhongThiNghiem();
                c.Nhap();
                listNhanVienPhongThiNghiem.Add(c);
                tong3 += c.Calculate();
            }
            Console.WriteLine("Xuat Nha Khoa Hoc: \t");
            Console.Write("Ho Ten: \t");
            Console.Write("Nam Sinh: \t");
            Console.Write("Bang Cap: \t");
            Console.Write("Chuc Vu: \t");
            Console.Write("So Bai Bao: \t");
            Console.Write("So Ngay Cong: \t");
            Console.Write("Bac Luong: \t");
            Console.Write("Luong: \t");
            Console.WriteLine();
            foreach (var item1 in listNhaKhoaHoc)
            {
                item1.Xuat();
                Console.WriteLine();
            }
            Console.Write("Tong Luong Nha Khoa Hoc: \t");
            Console.WriteLine(tong1);


            Console.WriteLine("Xuat Nha Quan Ly: \t");
            Console.Write("Ho Ten: \t");
            Console.Write("Nam Sinh: \t");
            Console.Write("Bang Cap: \t");
            Console.Write("Chuc Vu: \t");
            Console.Write("So Ngay Cong: \t");
            Console.Write("Bac Luong: \t");
            Console.Write("Luong: \t");
            Console.WriteLine();

            foreach (var item2 in listNhaQuanLy)
            {
                item2.Xuat();
                Console.WriteLine();
            }
            Console.Write("Tong Luong Nha Quan Ly: \t");
            Console.WriteLine(tong2);

            Console.WriteLine("Xuat Phong Thi Nghiem: \t");
            Console.Write("Ho Ten: \t");
            Console.Write("Nam Sinh: \t");
            Console.Write("Bang Cap: \t");
            Console.Write("Luong Theo Thang: \t");
            Console.WriteLine();

            foreach (var item3 in listNhanVienPhongThiNghiem)
            {
                item3.Xuat();
                Console.WriteLine();
            }

            Console.Write("Tong Luong Nhan Vien Phong Thuc Tap: \t");
            Console.WriteLine(tong3);

            Console.ReadLine();
            Console.WriteLine("Hello World!");
        }
    }
}
