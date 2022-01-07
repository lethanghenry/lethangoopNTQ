using System;

namespace HelloWorld
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name + "!");
            Console.WriteLine("Welcome to NTQ");
           
            int b;
            int[] a = { 1, 4, 3, 2 };
            int n = a.Length;

            for (int i = 0; i < n-1; i++)
            {
                for (int j = 0; j < n-1; j++)
                {
                    if (a[j] < a[j + 1])
                    {
                        b = a[j+1];
                        a[j+1] = a[j];
                        a[j] = b;
                    }
                }
            }
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }


            //int[] arr = { 78, 55, 45, 98, 13 };
            //int temp;
            //for (int j = 0; j <= arr.Length - 2; j++)
            //{
            //    for (int i = 0; i <= arr.Length - 2; i++)
            //    {
            //        if (arr[i] > arr[i + 1])
            //        {
            //            temp = arr[i + 1];
            //            arr[i + 1] = arr[i];
            //            arr[i] = temp;
            //        }
            //    }
            //}
            //Console.WriteLine("Sorted:");
            //foreach (int p in arr)
            //    Console.Write(p + " ");
            Console.Read();
        }
    }
}
