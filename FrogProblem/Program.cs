using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogProblem
{
    class Program
    {
        static int FrogProblem(int n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 2;
            if (n == 2)
                return 3;

            return FrogProblem(n - 1) + FrogProblem(n - 2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(FrogProblem(5));
        }
    }
}
