using System;
using System.Collections.Generic;
using System.Text;

namespace AbstrPropAndIndex
{
    abstract class Base
    {
        // Абстрактное текстовое свойство:
        public abstract string text { get; set; }
        // Абстрактный индексатор с целочисленным индексом:
        public abstract char this[int k] { get; }
        // Абстрактное целочисленное свойство:
        public abstract int length { get; }

    }
}
