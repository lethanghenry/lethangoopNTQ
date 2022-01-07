using System;

namespace SoSanhMang
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5 };
            int[] b = { 1, 2, 3, 4, 5 };
            int[] c = { 2, 3, 4, 5, 6 };
            if(SoSanh(a,c))
            {
                Console.WriteLine("hai mang bang nhau");
            }    
            else
            {
                Console.WriteLine("Hai mảng khac nhau");
            }    
        }
        static bool SoSanh(int[] a,int[] b)
        {
           
            for(int i=0;i<a.Length;i++)
            {
                if(a[i]==b[i])
                {
                    return true;
                }    
            }
            return false;
        }
    }
}
