using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _100以内奇数相加
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0,i=1;
            for (; i < 100; i = i + 2)
            {
                sum = sum + i;
            }
            Console.WriteLine("100以内的奇数相加为："+sum.ToString());
        }
    }
}
