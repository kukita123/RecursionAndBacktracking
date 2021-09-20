using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeastCommonMultiple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a [Sample: 6]=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b [Sample: 15]=");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Least Common Multiple [Sample: 30] = {0}", lcm(a, b)); // gcd = 7

            Console.ReadKey();
        }

        // Метод за намиране на най-малко общо кратно:
        private static int lcm(int a, int b)
        {
            return (a * b) / gcd(a, b);
        }

        // Рекурсивен метод за намиране на най-голям общ делител чрез изваждане:
        private static int gcd(int a, int b)
        {
            if (a == b)
                return a;
            if (a > b)
                return gcd(a - b, b);
            else
                return gcd(a, b - a);
        }

        //Итеративен метод за намиране на най-голям общ делител чрез деление:
        private static int gcd2(int a, int b)
        {
            while(b != 0)
            {
                int r = b;
                b = a % b;
                a = r;
            }
            return a;
        }
    }
}
