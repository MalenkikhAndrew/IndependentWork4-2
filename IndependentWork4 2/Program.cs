using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndependentWork4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, s;
            Console.WriteLine("Ввести размеры прямоуголника A,B и размеры квадрата C");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            s = 0;
            int x;
            while ((a - c) >= 0)
            {
                a -= c;
                x = b;
                while (x - c >= 0)

                    x -= c;
                ++s;
            }
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
