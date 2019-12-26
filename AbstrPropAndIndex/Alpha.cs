using System;
using System.Collections.Generic;
using System.Text;

namespace AbstrPropAndIndex
{
    class Alpha : Base
    {
        // Закрытое поле, являющееся ссылкой на массив:
        private char[] symbs;
        // Конструктор:
        public Alpha(string t) : base()
        {
            // Текстовому свойству присваивается значение:
            text = t;
        }

        // Переопределение текстового свойства:
        public override string text
        {
            get
            {
                // Результатом является тестовая строка:
                return new string(symbs);
            }
            set
            {
                // Создание символьного массива и присваивание
                // значения полю:
                symbs = value.ToCharArray();
            }
        }

        // Переопределение целочисленного свойства:
        public override int length
        {
            get
            {
                // Размер массива:
                return symbs.Length;
            }
        }

        // Переопределение индексатора:
        public override char this[int k]
        {
            get
            {
                // Значение элемента символьного массива:
                return symbs[k];
            }
        }
    }
}
