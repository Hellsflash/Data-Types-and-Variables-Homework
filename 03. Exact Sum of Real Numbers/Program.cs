using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Exact_Sum_of_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal numbers = decimal.Parse(Console.ReadLine());
            decimal sum = 0;

            for (int count = 0; count <numbers; count++)
            {

                sum += decimal.Parse(Console.ReadLine()); ;
   
            }
            Console.WriteLine(sum);
        }
    }
}
