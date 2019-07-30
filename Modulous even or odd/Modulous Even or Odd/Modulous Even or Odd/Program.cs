using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulous_Even_or_Odd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            int num1 = int.Parse(Console.ReadLine());

            if (num1 % 2==0)
            { Console.WriteLine("Your number is even!");
            }

            else
                { Console.WriteLine("Your number is odd!");
            }

            Console.ReadLine();
                
        }
    }
}
