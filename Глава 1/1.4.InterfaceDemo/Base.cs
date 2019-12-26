using System;
using System.Collections.Generic;
using System.Text;

namespace _1._4.InterfaceDemo
{
    abstract class Base
    {
        // Объявление абстрактного свойства:
        public abstract int number { get; set; }
        
        // Конструктор с одним аргументом:
        public Base(int n)
        {
            // Присваивание значения свойству:
            number = n;
            // Вызывается обычный (не абстрактный) метод:
            show();
        }
        
        // Описание обычного (не абстрактного) метода:
        public void show()
        {
            // Отображение значения свойства:
            Console.WriteLine("Свойство number=" + number);
        }
    }
}
