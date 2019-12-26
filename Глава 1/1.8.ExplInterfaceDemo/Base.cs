using System;
using System.Collections.Generic;
using System.Text;

namespace _1._8.ExplInterfaceDemo
{
    // Базовый класс:
    abstract class Base
    {
        // Абстрактное свойство:
        public abstract char symbol { get; }
 
        // Абстрактный индексатор:
        public abstract int this[int k] { get; }

        // Абстрактный метод:
        public abstract void show();
    }
}
