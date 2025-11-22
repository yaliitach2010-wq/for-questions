using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;

            for(int n=13;n<=99;n++)
            {
             sum+=1.0/(n*(n+1));

            }
            Console.WriteLine("the enswer is:"+sum);
        }
    }
}
