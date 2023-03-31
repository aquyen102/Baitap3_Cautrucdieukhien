using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Moi nhap so nguyen duong n");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("<---------KET QUA--------->");
            for (int i=1;i<=n; i++)
            {
                if (Kiemtrasonguyento(i))
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }

        private static bool Kiemtrasonguyento(int n)
        {
            for (int i=2;i<=(n/2); i++)
            {
                if((double)n%i==0)
                {
                    return false;
                }
                else 
                { 
                    return true;
                }
            }
            return true;
        }
    }
}
