using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Moi nhap so nguyen duong n");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("<---------Day Fibonacci voi {0} phan tu la--------->",n);
            if (n == 0)
            {
                Console.WriteLine("0");
            }
            if (n==1)
            {
                Console.WriteLine("1");
            }
            else
            {
                int a = 0;
                int b = 1;
                int c;
                for (int i =1; i<=n;i++)
                {
                    c = a + b;
                    Console.Write($"{c}\t");
                    a = b;
                    b = c;
                }
            }
            Console.ReadLine();
        }
    }
}
