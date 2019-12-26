using System;

namespace _1._7.DZ
{
    class Program
    {
        static void Main(string[] args)
        {
            IInt A = new MyClass();
            IString B = new MyClass();

            A.Number = 5;
            A.Show();

            B.Text = "Help!";
            B.Show();
        }
    }
}
