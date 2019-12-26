using System;
using System.Collections.Generic;
using System.Text;

namespace _1._6.InterfaceVarDemo
{
    interface IMyInterface
    {
        // Объявление метода:
        char getChar(int n);

        // Объявление индексатора:
        char this[int k] { get; }
    }
}
