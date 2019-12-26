using System;
using System.Collections.Generic;
using System.Text;

namespace _1._7.DZ
{
    class MyClass : IString, IInt
    {
        public string Text { get; set; }
        public int Number { get; set; }

        

        void IString.Show()
        {
            Console.WriteLine(Text);
        }

        void IInt.Show()
        {
            Console.WriteLine(Number);
        }
    }
}
