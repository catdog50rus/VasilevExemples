using System;

namespace _1._2.DZ
{
    class Program
    {
        static void Main(string[] args)
        {
            Class myClass = new Class("Hi!");
            myClass.Show();

            Print(myClass);

            myClass.SetText("Сам привет!");
            myClass.Show();

        }

        static void Print(Class myClass)
        {
            Console.Write($"Коды текстового поля: ");
            var k = myClass.Length;
            for (var i = 0; i < k; i++)
            {
                Console.Write($"{myClass[i]} ");
            }
            Console.WriteLine();
        }
    }
}
