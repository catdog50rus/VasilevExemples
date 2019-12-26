using System;

namespace _1._8.ExplInterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание объекта:
            MyClass obj = new MyClass('A');

            // Интерфейсные переменные:
            IFirst A = obj;
            ISecond B = obj;

            // Вызов метода через переменные:
            obj.show();
            A.show();
            B.show();
            Console.WriteLine();

            // Считывание значения свойства:
            Console.WriteLine($"obj.symbol = '{obj.symbol}' ");
            Console.WriteLine($"  A.symbol = '{A.symbol}' ");
            Console.WriteLine($"  B.symbol = '{B.symbol}' ");
            Console.WriteLine();

            // Индексирование объекта:
            Console.WriteLine($"obj[10] = {obj[10]}");
            Console.WriteLine($"  A[10] = {A[10]}");
            Console.WriteLine($"  B[10] = {B[10]}");
            Console.WriteLine();
        }
    }
}
