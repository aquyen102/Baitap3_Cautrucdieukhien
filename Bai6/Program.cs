using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Moi nhap so nguyen duong n");
            int n = int.Parse(Console.ReadLine());
            double s = 0;
            for (int i = 1; i <= n; i++)
            {
                s += (double) Math.Pow(i,i) ;
            }
            Console.WriteLine("Tong cua 1 + 2^2 + ...+ {0}^{0} = " + s, n);
            Console.ReadLine();
        }
    }
}
