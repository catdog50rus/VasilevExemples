using System;
using System.Collections.Generic;
using System.Text;

namespace _1._9.DZ
{
    public abstract class Base
    {
        protected char[] Arr;

        public Base(string txt) { }

        public char GetArr(int num)
        {
            return Arr[num];
        }

        public abstract void SetArr(int num, char sym);

    }
}
