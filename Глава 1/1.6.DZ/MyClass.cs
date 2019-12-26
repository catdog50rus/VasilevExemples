using System;
using System.Collections.Generic;
using System.Text;

namespace _1._6.DZ
{
    class MyClass : IIndexChar, IIndexInt
    {
        public char this[int index] { get { return (char)index; } }
        
        public int this[char index] { get { return index; } }
            
    }
}
