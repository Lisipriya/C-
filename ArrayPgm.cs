using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class ArrayPgm
    {
        static void Main11(string[] args)
        {
            var numbers = new[] { 1, 4, 6, 5, 8, 21, 3, 75 };

            //Length
            Console.WriteLine("Length of an array: ");
            Console.WriteLine(numbers.Length);

            //Index of
            Console.WriteLine("Index of:");
            Console.WriteLine(Array.IndexOf(numbers, 8));

            //Sort
            Console.WriteLine("Sorted Array:");
            Array.Sort(numbers);
            foreach (var number in numbers)
                Console.WriteLine(number);

            //Reverse
            Console.WriteLine("Reversed Array:");
            Array.Reverse(numbers);
            foreach (var number in numbers)
                Console.WriteLine(number);

            //Copy
            Console.WriteLine("Effect of Copy");
            var anotherArray = new int[3];
            Array.Copy(numbers, anotherArray, 3);
            foreach (var number in anotherArray)
                Console.WriteLine(number);

            //Clear
            Array.Clear(numbers, 3, 4);
            Console.WriteLine("Effect of Clear");
            foreach (var number in numbers)
                Console.WriteLine(number);

            
        }
    }
}
