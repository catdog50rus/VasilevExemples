using System;
using System.Collections.Generic;
using System.Text;

namespace _1._5.InterfaceDemo
{
    class MyClass : IMyInterface
    {
        private int num;
        public int number { get { return getNum(); } set { setNum(value); } }
        //public int number { get; set; }

        public MyClass(int n)
        {
            number = n;
            show();
        }
        
        public void show()
        {
            Console.WriteLine($"Свойство number= {number}");
        }

        
        public int getNum()
        {
            return num;
        }

        public void setNum(int n)
        {
            num = n;
        }
        
        public int this[int k]
        {
            get
            {
                int r = number;
                for(var i = 0; i < k; i++)
                {
                    r /= 10;
                }
                return r % 10;
            }
        }

        
    }
}
