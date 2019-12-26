using System;
using System.Collections.Generic;
using System.Text;

namespace _1._2.DZ
{
    public abstract class Base
    {
        protected string text;

        public abstract int Length { get; }

        public Base(string t)
        {

        }

        public abstract int this[int k] { get; }
        public abstract void SetText(string txt);
        public abstract void Show();

    }
}
