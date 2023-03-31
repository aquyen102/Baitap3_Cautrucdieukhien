using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Moi nhap so nguyen duong n");
            int n = int.Parse(Console.ReadLine());
            int s = 0;
            for (int i=1;i<=n; i++)
            {
                if (Kiemtrasole(i))
                {
                    s += i;
                }
            }
            Console.WriteLine("Tong cac so le tu 1 den {0} = " + s, n);
            Console.ReadLine();
        }

        private static bool Kiemtrasole(int i)
        {
            if ((double)i % 2 != 0)
            {
                return true;
            }
            else { return false; }
        }
    }
}
