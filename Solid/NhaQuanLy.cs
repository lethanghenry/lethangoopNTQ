using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    class NhaQuanLy : NhanVien, Nha, ITinhLuong
    {
        public int soNgayCong { get; set; }
        public string hoTen { get; set; }
        public int namSinh { get; set; }
        public string bangCap { get; set; }
        public string chucVu { get; set; }
        public int bacLuong { get; set; }

        public NhaQuanLy()
        { }

        public NhaQuanLy(int soNgayCong, string hoTen, int namSinh, string bangCap, string chucVu, int bacLuong)
        {
            this.soNgayCong = soNgayCong;
            this.hoTen = hoTen;
            this.namSinh = namSinh;
            this.bangCap = bangCap;
            this.chucVu = chucVu;
            this.bacLuong = bacLuong;
        }

        public int Calculate()
        {
            return soNgayCong * bacLuong;
        }

        public void Nhap()
        {
            Console.WriteLine("Nhap Nha Quan Ly: ");

            Console.WriteLine("Ho Ten: ");
            hoTen = Console.ReadLine();

            Console.WriteLine("Nam Sinh: ");
            namSinh = int.Parse(Console.ReadLine());

            Console.WriteLine("Bang Cap: ");
            bangCap = Console.ReadLine();

            Console.WriteLine("Chuc Vu: ");
            chucVu = Console.ReadLine();

            Console.WriteLine("So Ngay Cong: ");
            soNgayCong = int.Parse(Console.ReadLine());

            Console.WriteLine("So Bac Luong: ");
            bacLuong = int.Parse(Console.ReadLine());

            Console.WriteLine("Tien Luong: ");
        }
        public void Xuat()
        {
            Console.Write(hoTen + "\t\t" + namSinh + "\t\t" + bangCap + "\t\t" + chucVu + "\t\t" + soNgayCong + "\t\t" + bacLuong + "\t\t" + Calculate());
            Console.WriteLine();

        }
    }
}
