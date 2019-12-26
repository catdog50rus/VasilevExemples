using System;

namespace _1._7.ImplInterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание объекта:
            MyClass obj = new MyClass();

            // Ссылка на объект записывается
            // в интерфейсные переменные:
            IFirst A = obj;
            ISecond B = obj;

            // Вызовы метода через разные переменные:
            obj.show();
            A.show();
            B.show();
            
        }
    }
}
