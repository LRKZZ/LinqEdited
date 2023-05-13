using System;
using System.Linq;
using System.Security.Cryptography;

namespace LinqEdited
{
    class Program
    {
        static void Main()
        {
            int[] mass = { -2, -5, 0, 5, 7, 9, 10, 12, 31 };
            int negativeNums = (from check in mass
                                where check > 0
                                select check).Count();
            int positiveNums = (from check in mass
                                where check < 0
                                select check).Count();
            int evenSum = (from check in mass
                                where check % 2 == 0
                                select check).Sum();





            Console.WriteLine($"Кол-во отрицательных: {negativeNums}");
            Console.WriteLine($"Кол-во положительных: {positiveNums}");
            Console.WriteLine($"Сумма чётных: {evenSum}");
        }
    }
}
