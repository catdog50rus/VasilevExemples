using System;
using System.Collections.Generic;
using System.Text;

namespace _1._8.ExplInterfaceDemo
{
    class MyClass : Base, IFirst, ISecond
    {
        // Закрытое символьное поле:
        private char smb;

        // Конструктор с символьным аргументом:
        public MyClass(char s) : base()
        {
            smb = s; //А
        }


        // Свойство
        // Описание свойства из абстрактного класса:
        public override char symbol
        {
            get
            {
                return smb; //А
            }
        }

        // Явная реализация свойства из интерфейса First:
        char IFirst.symbol
        {
            get
            {
                return (char)(smb + 1); //В
            }
        }


        // Индексаторы
        // Описание индексатора из базового класса:
        public override int this[int k]
        {
            get
            {
                return smb + k; //65+10=75
            }
        }

        // Явная реализация индексатора из интерфейса Second:
        int ISecond.this[int k]
        {
            get
            {
                return smb - k; //65-10=55
            }
        }


        // Метод show()
        // Описание метода из базового класса:
        public override void show()
        {
            Console.WriteLine($"Базовый класс Base: '{symbol}'");
        }
        // Явная реализация метода из интерфейса First:
        void IFirst.show()
        {
            Console.WriteLine($"   Интерфейс First: '{symbol}'");
        }
        // Явная реализация метода из интерфейса Second:
        void ISecond.show()
        {
            Console.WriteLine($"  Интерфейс Second: '{symbol}'");
        }
    }
}
