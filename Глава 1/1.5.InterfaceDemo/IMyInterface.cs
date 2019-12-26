using System;
using System.Collections.Generic;
using System.Text;

namespace _1._5.InterfaceDemo
{
    interface IMyInterface: IFirst, ISecond
    {
        // Метод:
        void show();
    }
}
