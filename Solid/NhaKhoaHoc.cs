using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    class NhaKhoaHoc : NhanVien, Nha, ITinhLuong
    {
        public int soBaiBao { get; set; }
        public string hoTen { get; set; }
        public int namSinh { get ; set ; }
        public string bangCap { get; set; }
        public string chucVu { get; set; }
        public int soNgayCong { get; set; }
        public int bacLuong { get; set; }

        public NhaKhoaHoc()
        {

        }
        public NhaKhoaHoc(string hoTen,int namSinh, string bangCap,string chucVu,int soBaiBao,int soNgayCong, int bacLuong)
        {
            this.hoTen = hoTen;
            this.namSinh = namSinh;
            this.chucVu = chucVu;
            this.soBaiBao = soBaiBao;
            this.soNgayCong = soNgayCong;
            this.bacLuong = bacLuong;
        }
        public int Calculate()
        {
            return soNgayCong * bacLuong;
        }

        public void Nhap()
        {
            Console.WriteLine("Nhap Nha Khoa Hoc: ");

            Console.WriteLine("Ho Ten: ");
            hoTen = Console.ReadLine();

            Console.WriteLine("Nam Sinh: ");
            namSinh = int.Parse(Console.ReadLine());

            Console.WriteLine("Bang Cap: ");
            bangCap = Console.ReadLine();

            Console.WriteLine("Chuc Vu: ");
            chucVu = Console.ReadLine();

            Console.WriteLine("So Bai Bao: ");
            soBaiBao = int.Parse(Console.ReadLine());

            Console.WriteLine("So Ngay Cong: ");
            soNgayCong = int.Parse(Console.ReadLine());

            Console.WriteLine("Bac Luong: ");
            bacLuong = int.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.Write(hoTen+"\t\t"+namSinh+"\t\t"+bangCap+"\t\t"+chucVu+"\t\t"+soBaiBao+"\t\t"+soNgayCong+"\t\t"+bacLuong+"\t\t"+Calculate()+"\t\t");
            
        }

    }
}
