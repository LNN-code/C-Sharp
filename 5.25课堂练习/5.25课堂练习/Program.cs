using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5._25课堂练习
{
        class Rect
        {
            private double length = 0, width = 0;
            public void setlength(double len)
            {
                length = len;
                if (length < 0 | length > 50) Console.WriteLine("数值不符");
            }
            public void setwidth(double wid)
            {
                width = wid;
                if (width  < 0 | width > 50) Console.WriteLine("数值不符");
            }
            
            public double GetPreimiter()//求周长
            {
                return (length + width) * 2;
            }
        }
        class Program
        {
             static void Main(string[] args)
             {
               Rect box= new Rect();
               double c;
               box.setlength(20.0);
               box.setwidth(30.0);
               c = box.GetPreimiter();
               Console.WriteLine("周长是：{0}", c);
               Console.ReadKey();
                


              }
    }
}
