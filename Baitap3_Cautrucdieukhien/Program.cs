using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap3_Cautrucdieukhien
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Moi nhap so nguyen a");
            int a = int.Parse(Console.ReadLine());

            double b= (double) a % 3; 
            switch(b)
            {
                case 0:
                    Console.WriteLine("{0} chia het cho 3", a);
                    break;
                default:
                    Console.WriteLine("{0} KHONG chia het cho 3", a);
                    break;
            }
            Console.ReadLine();
        }
    }
}
