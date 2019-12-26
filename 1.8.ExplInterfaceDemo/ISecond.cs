using System;
using System.Collections.Generic;
using System.Text;

namespace _1._8.ExplInterfaceDemo
{
    interface ISecond
    {
        // Свойство:
        char symbol { get; }

        // Индексатор:
        int this[int k] { get; }

        // Метод:
        void show();

    }
}
