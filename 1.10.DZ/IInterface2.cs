using System;
using System.Collections.Generic;
using System.Text;

namespace _1._10.DZ
{
    interface IInterface2
    {
        int Number { get; set; }
        int this[int index] { get; set; }
        void Show();
    }
}
