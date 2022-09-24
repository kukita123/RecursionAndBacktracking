using System;
/*
 Дадени са n на брой диска с различни диаметри и три стълба A, B и C. Дисковете са нанизани върху първия стълб по реда на 
 намаляване на размера им и образуват кула. Трябва да се прехвърлят от първия стълб върху последния при спазване на 
 следните правила:
    1. При всеки ход може да бъде преместен един диск и този диск трябва да бъде най-горен за някой от стълбовете.
    2. Диск с по-голям диаметър не може да бъде поставен върху такъв с по-малък.
 */
namespace HanoiTowers
{
    class Program
    {
        /*
         Идеята е, че, за да преместим n на брой дискa от стълб A на стълб C, е необходимо да преместим n–1 диска 
         от стълб A на стълб B, след което да преместим диска с номер n (който е най-големият измежду тях) 
         от стълб A на стълб C и накрая да преместим останалите n–1 диска от стълб B на стълб C.
        */

        #region 1stWay-charRods
        public static void DiskMove(int n, char a, char b)
        {
            Console.WriteLine("Преместете диск {0} от {1} на {2}.", n, a, b);
        }

        public static void Hanoi1(char a, char c, char b, int numb)
        {
            if (numb == 1)
                DiskMove(1, a, c);
            else
            {
                Hanoi1(a, b, c, numb - 1);
                DiskMove(numb, a, c);
                Hanoi1(b, c, a, numb - 1);
            }
        }
        #endregion

        #region 2ndWay-intRods
        public static void PrintMove(int start, int end)
        {
            Console.WriteLine(start + " -> " + end);
        }

        public static void Hanoi2(int n, int start, int end)
        {
            //Base case:
            if (n == 1)
                PrintMove(start, end);
            else
            {
                int middle = 6 - (start + end);  // because 1+2+3=6 => middle=6-(1+3)=6-4=2
                Hanoi2(n - 1, start, middle);
                PrintMove(start, end);
                Hanoi2(n - 1, middle, end);
            }

        }
        #endregion

        static void Main(string[] args)
        {
            Console.Write("Discs number: ");
            int discs = int.Parse(Console.ReadLine());

            #region CharNamedRods-Apply
            //Console.WriteLine("Char named rods:");
            //Hanoi1('A','B','C',discs);
            #endregion

            Console.WriteLine();
            Console.WriteLine("Moves from disc to disc:");
            Hanoi2(discs, 1, 3);
            Console.ReadKey();
        }
    }
}
