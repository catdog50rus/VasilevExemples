using System;
using System.Collections.Generic;
using System.Text;

namespace _1._9.DZ
{
    public class MyClass : Base, IMyIntergace
    {
        public MyClass(string txt) : base(txt)
        {
            SetArr(txt);
        }
        
        public override void SetArr(int num, char sym)
        {
            Arr[num] = sym;
        }



        public char this[int index] 
        {
            get 
            {
                if (index >= 0 && index < Arr.Length)
                {
                    return GetArr(index);
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine($"В экземпляре нет индекса со значением {index}");
                    return ' ';
                }
                
            } 
            set
            {
                if(index >= 0 && index < Arr.Length)
                {
                    SetArr(index, value);
                }
                else
                {
                    Console.WriteLine($"Символ '{value}' не может быть присвоен индексу {index}");
                    Console.WriteLine();
                }
                
            }
        }

        public void SetArr(string txt)
        {
            Arr = txt.ToCharArray();
        }
    }
}
