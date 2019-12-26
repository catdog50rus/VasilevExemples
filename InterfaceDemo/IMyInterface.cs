using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceDemo
{
    interface IMyInterface
    {
        // Объявление методов:
        void show();
        void setNum(int n);
        int getNum();

        // Объявление свойства:
        int number { get; set; }

        // Объявление индексатора:
        int this[int k] { get; }

    }
}
