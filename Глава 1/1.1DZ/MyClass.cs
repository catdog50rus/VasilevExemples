using System;
using System.Collections.Generic;
using System.Text;

namespace _1._1DZ
{
    class MyClass : Base
    {

        public MyClass(int n) : base(n) 
        {
            
        }

        public override int this[int k]
        {
            get
            {
                return Arr[k];
            }

            set
            {
                Arr[k] = value;
            }
            
        }

        

        public override void ShowArr()
        {
            Console.WriteLine($"Массив:");
            Console.WriteLine();
        }
    }
}
