using System;
using System.Collections.Generic;
using System.Text;

namespace _1._5.DZ
{
    class MyClass : INum, IChar
    {
        public char Char(int num)
        {
            return (char)num;
        }

        public int Num(char i)
        {
            return (int)i;
        }
    }
}
