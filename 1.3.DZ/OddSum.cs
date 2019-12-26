using System;
using System.Collections.Generic;
using System.Text;

namespace _1._3.DZ
{
    class OddSum : IDigit
    {
        
        private int Digit { get; set; }

        public OddSum(int dig)
        {
            Digit = dig;
        }
        
        public int Sum()
        {
            int result = 0;
            for(int i = 1; i < (Digit + 1); i++)
            {
               
                result += i * 2 - 1;
            }
            return result;
        }
    }
}
