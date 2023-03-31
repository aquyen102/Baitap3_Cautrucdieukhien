using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Moi nhap so nguyen duong n");
            int n = int.Parse(Console.ReadLine());

            if(Kiemtrasochinhphuong(n))
            {
                Console.WriteLine("{0} la so chinh phuong", n);
            }
            else
            {
                Console.WriteLine("{0} KHONG LA so chinh phuong", n);
            }
            Console.ReadLine();
        }

        private static bool Kiemtrasochinhphuong(int n)
        {
            double c = n%Math.Sqrt(n);
            switch(c)
            {
                case 0:
                    return true;
                    break;
                default:
                    return false;
                    break;
            }
        }
    }
}
