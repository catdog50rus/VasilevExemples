using System;

namespace _1._4.DZ
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass(3, 6);
            
            Console.WriteLine($"Значение первого поля: {obj[1]}");
            Console.WriteLine($"Значение второго поля: {obj[2]}");
            Console.WriteLine($"Значение метода: {obj.Multiplicated(5)}");
        }
    }
}
