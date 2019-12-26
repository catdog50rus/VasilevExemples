using System;

namespace _1._6.InterfaceVarDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Целочисленная переменная:
            int m = 5;
            
            // Интерфейсная переменная:
            IMyInterface R;

            // Создается объект класса Alpha и ссылка на него
            // записывается в интерфейсную переменную:
            R = new Alpha('F');

            // Вызов метода через интерфейсную переменную:
            Console.WriteLine($"Символы от '{R.getChar(-m)}' до '{R.getChar(m)}': ");
            
            // Индексирование объекта через
            // интерфейсную переменную:
            for (int i = -m; i <= m; i++)
            {
                Console.Write($"{R[i]} ");
            }
            Console.WriteLine();
            
            // Создается объект класса Bravo и ссылка на него
            // записывается в интерфейсную переменную:
            R = new Bravo("bravo");

            // Вызов метода через интерфейсную переменную:
            Console.WriteLine($"Символы от '{R.getChar(0)}' до '{R.getChar(2 * m + 1)}': ");
            
            // Индексирование объекта через
            // интерфейсную переменную:
            for (int i = 0; i <= 2 * m + 1; i++)
            {
                Console.Write($" {R[i]}");
            }
            Console.WriteLine();
        }
    }
}
