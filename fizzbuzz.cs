using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayersGuideSandbox
{
    class Program
    {
        static void Main() {
            int index = 1;
            // look mom – i can count to 100!
            while (index < 101)
                {
                // if it's a multiple of 3 and 5
                if (index % 3 == 0 && index % 5 == 0)
                {
                Console.WriteLine("FizzBuzz");
                // if it's a multiple of 3
                }
                else if (index % 3 == 0)
                {
                Console.WriteLine("Fizz");
                // if it's a multiple of 5
                }
                else if (index % 5 == 0 && index % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(index);
                }
                index++;
            }
        }
    }
}
