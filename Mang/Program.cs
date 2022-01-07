using System;
using System.Linq;

namespace Mang
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.WriteLine("Nhap so phan tu n: ");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0 || n >= 10000);
            int[] arr = new int[n];

            Nhap(arr, n);
            Xuat(arr, n);

            Console.WriteLine("Mang sau khi sap xep giảm");
            SapXepGiam(arr, n);
            Xuat(arr, n);

            Console.WriteLine("Mang sau khi sap xep tang");
            SapXepTang(arr, n);
            Xuat(arr, n);

            int k;
            do
            {
                Console.WriteLine("Nhap vi tri muon xoa k: ");
                k = int.Parse(Console.ReadLine());
            } while (k < 0 || k > n);

            Console.WriteLine("Mang sau khi xoa");
            arr = arr.Where(i => i != k).ToArray();
            Xuat(arr, n - 1);

            //Console.WriteLine("Mang sau khi xoa");
            //XoaMotPhanTu(arr, n, k);
        }


        static void Nhap(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("a[" + i + "]=");
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        static void Xuat(int[] a, int n)
        {
            Console.Write("Hien thi mang:");
            for (int i = 0; i < n; i++)
                Console.Write(a[i] + " ");
        }

        static void SapXepGiam(int[] a, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (a[j] < a[j + 1])
                    {
                        int b = a[j + 1];
                        a[j + 1] = a[j];
                        a[j] = b;
                    }
                }
            }

        }
        static void SapXepTang(int[] a, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int b = a[j + 1];
                        a[j + 1] = a[j];
                        a[j] = b;
                    }
                }
            }
        }

        //static void XoaMotPhanTu(int[] a,int n, int k)
        //{
        //    for(int i=0;i<n;i++)
        //    {
               
        //        if (i != k) {
        //            Console.WriteLine(a[i]);
        //        }
        //        else
        //        {
        //            continue;
        //        }
        //    }    
        //}

    }
}
