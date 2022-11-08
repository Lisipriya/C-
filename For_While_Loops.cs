using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class For_While_Loops
    {
        static void Main7(string[] args)
        {
            //increment order
            for(var i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            //reverse order
            for (var i = 10; i >= 1; i--)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            //For each
            var numbers = new int[] {1,2, 3, 4, 5};
            foreach(var number in numbers)
            {
                Console.WriteLine(number);
            }

            //while loop
            while (true)
            {
                Console.WriteLine("Enter your name: ");
                var input = Console.ReadLine();
                if (String.IsNullOrEmpty(input))
                {
                    break;
                }
                Console.WriteLine("@Echo: "+ input);
            }
        }
    }
}
