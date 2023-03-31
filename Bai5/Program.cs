using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Moi nhap mot thang bat ky trong nam");
            int n = int.Parse(Console.ReadLine());

            switch(n)
            {
                case 2:
                    Console.WriteLine("Thang Hai co 28 hoac 29 ngay");
                    break;
                case int i when (i==1|| i==3||i==5 || i == 7 || i == 8 || i == 10 || i == 12):
                    Console.WriteLine("Thang {0} co 31 ngay",n);
                    break;
                default:
                    Console.WriteLine("Thang {0} co 30 ngay", n);
                    break;
            }
            Console.ReadLine();
        }
    }
}
