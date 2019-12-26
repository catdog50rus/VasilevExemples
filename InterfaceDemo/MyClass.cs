using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceDemo
{
    class MyClass : IMyInterface
    {
        // Закрытое целочисленное поле:
        private int num;

        // Конструктор с одним аргументом:
        public MyClass(int n)
        {
            // Присваивание значения свойству:
            number = n;
            // Вызывается метод из интерфейса:
            show();
        }

        //реализация интерфейса
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



        public int number { get { return getNum(); } set { setNum(value); } }


        public int getNum()
        {
            return num;
        }


        public void setNum(int n)
        {
            num = n;
        }

        public void show()
        {
            Console.WriteLine($"Свойство number = {number}");
        }


    }
}
