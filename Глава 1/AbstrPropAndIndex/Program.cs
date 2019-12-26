using System;

namespace AbstrPropAndIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ссылка на объект производного класса записывается
            // в объектную переменную базового класса:
            Base obj = new Alpha("Alpha");

            // Отображение значения текстового свойства:
            Console.WriteLine(obj.text);

            // Новое значение текстового свойства:
            obj.text = "Base";
            // Индексирование объекта:
            for (int k = 0; k < obj.length; k++)
            {
                Console.Write($"{obj[k]} ");
            }
            Console.WriteLine();

            // Ссылка на объект производного класса записывается
            // в объектную переменную базового класса:
            obj = new Bravo("Bravo");

            // Отображение значения текстового свойства:
            Console.WriteLine(obj.text);

            // Новое значение текстового свойства:
            obj.text = "Base";
            // Индексирование объекта:
            for (int k = 0; k < obj.length; k++)
            {
                Console.Write($"{obj[k]} ");
            }
            Console.WriteLine();
        }
    }
}
