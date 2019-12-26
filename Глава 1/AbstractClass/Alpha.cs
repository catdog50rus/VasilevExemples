using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    class Alpha : Base
    {
        // Защищенное целочисленное поле:
        protected int val;
        // Конструктор:
        public Alpha(int n) : base(n)
        {
            // Вызов метода:
            show();
        }
        // Переопределение абстрактного метода:
        public override void show()
        {
            // Отображение сообщения:
            Console.WriteLine("Alpha: {0}, {1} и {2}", num, val, get());
        }
        // Переопределение абстрактного метода:
        public override void set(int n)
        {
            // Присваивание значений полям:
            num = n;
            val = n % 10;
        }
        // Переопределение абстрактного метода:
        public override int get()
        {
            return num / 10;
        }
    }
}
