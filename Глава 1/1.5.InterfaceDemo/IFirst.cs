using System;
using System.Collections.Generic;
using System.Text;

namespace _1._5.InterfaceDemo
{
    interface IFirst
    {
        // Объявление свойства:
        int number { get; set; }


        // Индексатор:
        int this[int k] { get; }
    }
}
