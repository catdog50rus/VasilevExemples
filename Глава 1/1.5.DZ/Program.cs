using System;

namespace _1._5.DZ
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            char sym = 'F';
            int num = 105;
            
            Console.WriteLine($"Код символа '{sym}' = {obj.Num(sym)}");
            Console.WriteLine($"Символ кода '{num}' = {obj.Char(num)}");
            Console.WriteLine();

            IChar I = new MyClass();
            INum N = new MyClass();
            Console.WriteLine($"Символ кода '{num}' = {I.Char(num)}");
            Console.WriteLine($"Код символа '{sym}' = {N.Num(sym)}");

        }
    }
}
