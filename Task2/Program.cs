using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввести последовательность целых чисел, для окончания ввода прописат ноль");
            int a = 1;
            int Sum = 0;
            int b;
            do
            {
                b = Convert.ToInt32(Console.ReadLine());
                if (b > 0)
                    Sum += b;
                else
                    if (b != 0)
                    a *= b;
            }
            while (b != 0);
            if (Sum > a)
                Console.WriteLine("Сумма ({0}) больше произведения ({1})", Sum, a);
            else
                if (Sum < a)
                Console.WriteLine("Произведение ({1}) больше суммы ({0})", Sum, a);
            else
                Console.WriteLine("Произведение ({1}) и сумма ({0}) равны", Sum, a);
            Console.ReadKey();
        }
    }
}
