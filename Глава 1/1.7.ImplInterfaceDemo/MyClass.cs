using System;
using System.Collections.Generic;
using System.Text;

namespace _1._7.ImplInterfaceDemo
{
    class MyClass : IFirst, ISecond
    {
        void IFirst.show()
        {
            Console.WriteLine("Объект класса MyClass, IFirst");
        }

        void ISecond.show()
        {
            Console.WriteLine("Объект класса MyClass, ISecond");
        }

        public void show()
        {
            Console.WriteLine("Объект класса MyClass");
        }
        
    }
}
