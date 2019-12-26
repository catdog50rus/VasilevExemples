using System;
using System.Collections.Generic;
using System.Text;

namespace _1._6.InterfaceVarDemo
{
    // Второй класс, реализующий интерфейс:
    class Bravo : IMyInterface
    {
        // Закрытое текстовое поле:
        private string text;

        // Конструктор с текстовым аргументом:
        public Bravo(string t)
        {
            // Полю присваивается значение:
            text = t;
        }

        // Описание метода:
        public char getChar(int k)
        {
            return text[k % text.Length];
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
