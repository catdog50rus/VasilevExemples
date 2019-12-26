using System;

namespace _1._1DZ
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass(5);
            for(var i = 0; i < obj.Length; i++)
            {
                obj[i] = (i * 2 + obj.Length);
            }
            obj.ShowArr(); 
            for (var i = 0; i < obj.Length; i++)
            {
                Console.Write($"{obj[i]}, ");
            }
        }
    }
}
