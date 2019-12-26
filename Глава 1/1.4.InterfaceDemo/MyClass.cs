using System;
using System.Collections.Generic;
using System.Text;

namespace _1._4.InterfaceDemo
{
    class MyClass : Base, IFirst, ISecond
    {
        // Закрытое целочисленное поле:
        private int num;

        // Конструктор с одним аргументом:
        public MyClass(int n) : base(n) { }

        // Описание метода из интерфейса First:
        public void setNum(int n)
        {
            // Присваивание значения полю:
            num = n;
        }

        // Описание метода из интерфейса First:
        public int getNum()
        {
            // Значение поля:
            return num;
        }


        // Описание свойства из класса Base:
        public override int number
        {
            // Аксессор для считывания значения:
            get
            {
                // Вызывается метод из интерфейса First:
                return getNum();
            }
            // Аксессор для присваивания значения:
            set
            {
                // Вызывается метод из интерфейса First:
                setNum(value);
            }
        }


        // Описание индексатора из интерфейса Second:
        public int this[int k]
        {
            // Аксессор для считывания значения:
            get
            {
                // Локальная переменная:
                int r = number;
                // "Отбрасывание" цифр в десятичном
                // представлении числа:
                for (int i = 0; i < k; i++)
                {
                    r /= 10;
                }
                // Результат:
                return r % 10;
            }
        }
    }
}
