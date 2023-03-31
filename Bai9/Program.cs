using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Moi nhap so hang n \t");
            int n = int.Parse(Console.ReadLine());
            string s = "";

            for (int row = 1; row <= n; row++)
            {
                s += "*";
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }
    }
}
