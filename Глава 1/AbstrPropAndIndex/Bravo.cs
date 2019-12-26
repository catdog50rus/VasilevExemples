using System;
using System.Collections.Generic;
using System.Text;

namespace AbstrPropAndIndex
{
    class Bravo : Base
    {
        // Закрытое тестовое поле:
        private string txt;

        // Конструктор:
        public Bravo(string t) : base()
        {
            // Текстовому свойству присваивается значение:
            text = t;
        }

        // Переопределение текстового свойства:
        public override string text
        {
            get
            {
                // Значение поля:
                return txt;
            }
            set
            {
                // Присваивание значения полю:
                txt = value;
            }
        }

        // Переопределение целочисленного свойства:
        public override int length
        {
            get
            {
                // Количество символов в тексте:
                return txt.Length;
            }
        }

        // Переопределение индексатора:
        public override char this[int k]
        {
            get
            {
                // Символ в тексте:
                return txt[k];
            }
        }
    }
}
