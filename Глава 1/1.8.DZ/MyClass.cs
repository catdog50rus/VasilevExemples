using System;
using System.Collections.Generic;
using System.Text;

namespace _1._8.DZ
{
    class MyClass : IText, IString
    {
        public string Text { get; }

        string IText.Text { get { return $"{Text} IText"; } }
        string IString.Text { get { return $"{Text} IString"; } }

        public MyClass()
        {
            Text = "Help!";
            
        }
    }
}
