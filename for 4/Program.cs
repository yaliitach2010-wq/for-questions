using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int num = 10; num <= 99; num++)

            {
                int sq = num * num;
                int a = sq  % 1000;
                int d = a % 10;

                if (a /10% 10==d && a/100%10==d )
                {
                    Console.WriteLine("the original number is:" + num);
                    Console.WriteLine("the square is:" + sq);
                }







            }


        }
    }
}
    

