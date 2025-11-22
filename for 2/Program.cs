using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int big = 1; big <= 999; big++)
            {
                if (big % 10 == 1)
                    {
                    int small = big / 10;

                    if (big - small == 64)
                    { Console.WriteLine("the biggest is" + big);
                        Console.WriteLine("the smallest is" + small);
                    }

                }
            }
        
    

            




        }
    }
}
