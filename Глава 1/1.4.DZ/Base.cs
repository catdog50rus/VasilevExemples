using System;
using System.Collections.Generic;
using System.Text;

namespace _1._4.DZ
{
    public abstract class Base
    {
        protected int A;
        protected int B;

        public Base(int a1, int b1)
        {
            A = a1;
            B = b1;
        }

        public abstract int this[int index] { get; }

    }
}
