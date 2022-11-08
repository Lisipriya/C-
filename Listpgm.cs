using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class Listpgm
    {
        static void Main12(string[] args)
        {
            var numbers = new List<int>() { 1, 2, 3, 4};
            numbers.Add(1);
            numbers.AddRange(new int[3] { 9, 1, 2});

            foreach (var number in numbers)
                Console.WriteLine(number);

            Console.WriteLine("Index of first 1: " + numbers.IndexOf(1));
            Console.WriteLine("Index of last 1: " + numbers.LastIndexOf(1));
            Console.WriteLine("Count of elements in the list: "+ numbers.Count);

            numbers.Remove(1);
            Console.WriteLine("Remove only one 1: ");
            foreach (var number in numbers)
                Console.WriteLine(number);

            Console.WriteLine("Removing all 1's in the list");
            for(int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                    numbers.Remove(numbers[i]);
            }
            foreach (var number in numbers)
                Console.WriteLine(number);

            numbers.Clear();
            Console.WriteLine("After clearing elements");
            Console.WriteLine("Count of elements in the list: " + numbers.Count);
        }
    }
}
