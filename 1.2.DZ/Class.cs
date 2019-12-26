using System;
using System.Collections.Generic;
using System.Text;

namespace _1._2.DZ
{
    class Class : Base
    {

        public Class(string t) : base(t) 
        {
            text = t;
        }



        public override int Length
        {
            get
            {
                
                return text.Length;
            }
        }


        public override int this[int k]
        {
            get
            {
                return text[k];
            }
        }


        public override void Show()
        {
            Console.WriteLine();
            Console.WriteLine($"Значение текстового поля: {text}");
        }

        public override void SetText(string txt)
        {
            text = txt; 
        }
    }
}
