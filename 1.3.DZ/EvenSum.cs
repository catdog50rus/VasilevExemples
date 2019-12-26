using System;
using System.Collections.Generic;
using System.Text;

namespace _1._3.DZ
{
    class EvenSum : IDigit
    {
        
        private int Digit { get; set; }

        public EvenSum(int dig)
        {
            Digit = dig;
        }
        
        public int Sum()
        {
            int result = 0;
            for(int i = 1; i < (Digit + 1); i++)
            {
               
                result += i * 2;
            }
            return result;
        }
    }
}
