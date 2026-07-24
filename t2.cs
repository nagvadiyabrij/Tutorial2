using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
     class number
    {
        public void swap(ref int x,ref int y)
        {
            int temp;
            temp = x;
            x = y;
            y = temp;
        } 
        
    }

    class t2
    {
        static void Main(string[] args)
        {
            int a = 50;
            int b = 100;

            Console.WriteLine("before swap a is : " + a);
            Console.WriteLine("before swap b is : " + b);

            number no = new number();
            no.swap(ref a, ref b);

            Console.WriteLine("after swap is a : " + a);
            Console.WriteLine("after swap is b : " + b);

            Console.ReadLine();
        }
    }
}
