using System;

namespace MangHaiChieu
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m;
            Console.WriteLine("Nhap mang 2 chieu;");
            Console.WriteLine("Nhap m: ");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap n: ");
            n = int.Parse(Console.ReadLine());
            int[,] arr=new int[m,n];
            Nhap(arr, m, n);
            Xuat(arr, m, n);
        }
        static void Nhap(int[,] a,int m,int n)
        {
            for(int i=0;i<m;i++)
            {
                for(int j=0;j<n;j++)
                {
                    Console.WriteLine("a[" + i + "," + j + "]=");
                    a[i,j] = int.Parse(Console.ReadLine());
                }    
            }    
        }
        static void Xuat(int[,] a, int m, int n)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("a[" + i + "," + j + "]=");
                    Console.WriteLine(a[i,j]);
                }
            }
        }
    }
}
