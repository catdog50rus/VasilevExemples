using System;
using System.Collections.Generic;
using System.Text;

namespace _1._10.DZ
{
    public class MyClass : Base, IInterface1, IInterface2
    {
        
        private int sum { get; set; }
        public override int Number { get; set; }
        int IInterface1.Number { get; set; }
        int IInterface2.Number { get; set; }

        
        public override int this[int index] 
        {
            get
            {
                return sum + index;
            }
            set
            {
                sum = index + value;
            }
        }
        
        int IInterface1.this[int index]
        {
            get
            {
                return Number;
            }
            set
            {
                sum = index + Number;
            }
        }
        
        
        
        
        int IInterface2.this[int index]
        {
            get
            {
                return index;
            }
            set
            {
                sum = index;
            }
        }

        





        public override void Show()
        {
            Console.WriteLine($"данные класса: Сумма = {sum}");
        }

        void IInterface1.Show()
        {
            Console.WriteLine($"данные IInterface1: Сумма = {sum}");
        }

        void IInterface2.Show()
        {
            Console.WriteLine($"данные IInterface2: Сумма = {sum}");
        }
    }
}
