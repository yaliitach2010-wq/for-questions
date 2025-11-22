using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int num=10; num<=99; num++)
            {
                int a = num % 10;
                int b = num / 10;

                if(2*(a+b)==a*b)
                {
                    Console.WriteLine("the number is:" + num);
                }
            }
        }
    }
}
