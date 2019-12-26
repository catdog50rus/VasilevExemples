using System;

namespace _1._10.DZ
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass instance = new MyClass();
            instance.Number = 100;
            instance[15] = 2;

            Console.WriteLine($"Значение индексатора класса: {instance[10]}");
            Console.WriteLine($"Значение поля Number класса: {instance.Number}");
            instance.Show();

            Console.WriteLine();

            IInterface1 Iinst = instance;
            Iinst.Number = 200;
            Iinst[15] = 2;
            Console.WriteLine($"Значение индексатора IInterface1: {Iinst[10]}");
            Console.WriteLine($"Значение поля Number IInterface1: {Iinst.Number}");

            Iinst.Show();

            Console.WriteLine();

            IInterface2 Iinst2 = instance;
            Iinst2.Number = 200;
            Iinst2[15] = 2;
            Console.WriteLine($"Значение индексатора IInterface2: {Iinst2[10]}");
            Console.WriteLine($"Значение поля Number IInterface2: {Iinst2.Number}");

            Iinst2.Show();

        }
    }
}
