using System;
using System.Collections.Generic;
using System.Text;

namespace _1._4.DZ
{
    class MyClass : Base, IMethod
    {
        public MyClass(int a1, int b1) : base(a1, b1)
        {
            
        }

        public override int this[int index]
        {
            get
            {
                if(index % 2 == 0)
                {
                    return A;
                }
                else
                {
                    return B;
                }
            }
        }

        public int Multiplicated(int n)
        {
            return (A + B) * n;
        }
    }
}
