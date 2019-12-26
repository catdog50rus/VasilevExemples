using System;
using System.Collections.Generic;
using System.Text;

namespace _1._10.DZ
{
    public abstract class Base
    {
        public abstract int Number { get; set; }
        public abstract int this[int index] { get;set; }
        public abstract void Show();

    }
}
