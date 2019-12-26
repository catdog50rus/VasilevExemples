using System;

namespace _1._8.DZ
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            IString String = obj;
            IText Text = obj;

            

            Console.WriteLine(obj.Text);
            Console.WriteLine(String.Text);
            Console.WriteLine(Text.Text);
        }
    }
}
