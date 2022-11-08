using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class Random
    {
        static void Main8(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            var r = new System.Random();

            for (int i = 0; i <= 10; i++)
                //range of numbers between 2 values
                Console.WriteLine(r.Next(1, n));

                //Range of chars from ascii code
                Console.WriteLine((char)r.Next(97, 122));

            int passwordLength = Convert.ToInt32(Console.ReadLine());
            var buffer = new char[passwordLength];
            for(int i = 0; i < passwordLength; i++)
            {
                buffer[i] = (char)('a' + r.Next(0, 26));
            }
            var password = new string(buffer);
            Console.WriteLine(password);
        }

    }
}
