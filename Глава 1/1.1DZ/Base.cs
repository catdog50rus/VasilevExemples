using System;
using System.Collections.Generic;
using System.Text;

namespace _1._1DZ
{
    abstract class Base
    {
        protected int[] Arr;
        public int Length { get; set; }

        public Base(int n)
        {
            Length = n;
            Arr = new int [Length];
            
        }

        public abstract void ShowArr();
        
        public abstract int this[int k] { get; set; }
    }
}
