using System;

namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Целочисленная переменная:
            int m = 9;
            // Создание объекта:
            MyClass obj = new MyClass(12345);
            
            // Индексирование объекта:
            for (int i = 0; i <= m; i++)
            {
                Console.Write($"{obj[m - i]} ");
            }
            Console.WriteLine();
        }
    }
}
