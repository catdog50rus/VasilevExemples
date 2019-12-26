using System;

namespace _1._9.DZ
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass instance = new MyClass("Hello");
            Print(instance);

            instance[6] = 'h';
            Print(instance);

        }

        static void Print(MyClass inst)
        {
            
            for(int i = 0; i < 6; i++)
            {
                Console.Write($"{inst[i]}");
            }
            Console.WriteLine();
        }

        
    }
}
