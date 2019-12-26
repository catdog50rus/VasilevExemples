using System;
using System.Collections.Generic;
using System.Text;

namespace _1._6.InterfaceVarDemo
{
    // Первый класс, реализующий интерфейс:
    class Alpha : IMyInterface
    {
        // Закрытое символьное поле:
        private char symb;

        // Конструктор с символьным аргументом:
        public Alpha(char s)
        {
            // Полю присваивается значение:
            symb = s;
        }

        // Описание метода:
        public char getChar(int n)
        {
            // Результат:
            return (char)(symb + n);
        }

        // Описание индексатора:
        public char this[int k]
        {
            // Аксессор для считывания значения:
            get
            {
                // Результат:
                return getChar(k);
            }
        }
    }
}
