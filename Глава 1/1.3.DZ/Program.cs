using System;

namespace _1._3.DZ
{
    class Program
    {
        static void Main(string[] args)
        {
            int digit = 3;
            EvenSum a = new EvenSum(digit);
            OddSum b = new OddSum(digit);

            Console.WriteLine($"Сумма четных чисел = {a.Sum()}");
            Console.WriteLine($"Сумма нечетных чисел = {b.Sum()}");

            IDigit iA, iB;
            iA = new EvenSum(5);
            iB = new OddSum(2);

            Console.WriteLine($"Сумма четных чисел с интерфейса = {iA.Sum()}");
            Console.WriteLine($"Сумма нечетных чисел с интерфейса = {iB.Sum()}");


        }
    }
}
