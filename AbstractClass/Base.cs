using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    abstract class Base
    {
        // Защищенное целочисленное поле:
        protected int num;
        // Конструктор:
        public Base(int n)
        {
            // Вызов метода:
            set(n);
        }
        // Абстрактные методы:
        public abstract void show();
        public abstract void set(int n);
        public abstract int get();
    }
}
