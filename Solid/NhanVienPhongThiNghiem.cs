using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    class NhanVienPhongThiNghiem : ITinhLuong, NhanVien
    {
        public int luongTheoThang { get; set; }
        public string hoTen { get; set; }
        public int namSinh { get; set; }
        public string bangCap { get; set; }

        public int Calculate()
        {
            return luongTheoThang;
        }
        public void Nhap()
        {
            Console.WriteLine("Nhap Phong Thi Nghiem: ");

            Console.WriteLine("Ho Ten: ");
            hoTen = Console.ReadLine();

            Console.WriteLine("Nam Sinh: ");
            namSinh = int.Parse(Console.ReadLine());

            Console.WriteLine("Bang Cap: ");
            bangCap = Console.ReadLine();

            Console.WriteLine("Luong Theo Thang: ");
            luongTheoThang = int.Parse(Console.ReadLine());

        }
        public void Xuat()
        {
            Console.Write(hoTen + "\t\t" + namSinh + "\t\t" + bangCap + "\t\t" + luongTheoThang+"\t");
            Console.WriteLine();
        }

    }
}
