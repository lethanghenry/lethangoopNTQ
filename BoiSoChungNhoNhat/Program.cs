using System;

namespace BoiSoChungNhoNhat
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n1, n2, j, hcf = 1, bscnn;
            Console.Write("Nhap so thu nhat: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            n2 = int.Parse(Console.ReadLine());

            j = (n1 < n2) ? n1 : n2;

            for (i = 1; i <= j; i++)
            {

                if (n1 % i == 0 && n2 % i == 0)
                {
                    hcf = i;
                }
            }
            bscnn = (n1 * n2) / hcf;

            Console.Write("\nBSCNN cua {0} va {1} la: {2}\n\n", n1, n2, bscnn);
            Console.ReadKey();
        }
    }
}
