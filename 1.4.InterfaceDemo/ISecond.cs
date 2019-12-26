using System;
using System.Collections.Generic;
using System.Text;

namespace _1._4.InterfaceDemo
{
    interface ISecond
    {
        // Объявление индексатора:
        int this[int k]
        {
            get;
        }
    }
}
