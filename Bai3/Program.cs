using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Moi nhap so nguyen duong n");
            int n = int.Parse(Console.ReadLine());
            int s = 1;
            for (int i = 1; i <=n; i++) 
            {
                s *= i;
            }
            Console.WriteLine("Tong giai thua tu 1 den {0} = " + s, n);
            Console.ReadLine();
        }
    }
}
