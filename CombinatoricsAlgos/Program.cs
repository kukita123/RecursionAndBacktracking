using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombinatoricsAlgos
{
    class Program
    {
        static int[] numbers;
        static int n, m; //number of positions (length of the raw)

        static void ManipulateOutput(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.Write(numbers[i]);
            }
            Console.WriteLine();
        }

        static void Go01(int i)
        {
            if (i == n + 1)
            {
                ManipulateOutput(n);                    
                return;
            }
            numbers[i] = 0;
            Go01(i + 1);

            numbers[i] = 1;
            Go01(i + 1);
        }
        static void Go(int i)
        {
            if (i == n + 1)
            {
                ManipulateOutput(n);
                return;
            }
            for (int j = 0; j < m; j++)
            {
                numbers[i] = j;
                Go(i + 1);
            }
        }

        static void Main(string[] args)
        {
            numbers = new int[10];
            n = 3;
            m = 3;

            Go01(1);
            Console.WriteLine();

            Go(1);
            Console.ReadKey();
        }
    }
}
