using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int num=10;num<=99;num++)
                
            {
                int a = num / 10;
                int b = num % 10;

                int number = num;
                int p = a + b;
                int q = a * b;

                if (number - q == 4 * p)
                {
                    Console.WriteLine("the number is:" + num);

                }

            }
        }
    }
}
