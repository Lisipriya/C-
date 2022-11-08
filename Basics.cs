using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class Basics
    {
        static void Main2(string[] args)
        {
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);

            //Type Conversion
            byte b = 1;
            int i = b;
            Console.WriteLine(i);
            
            int j = 1;
            byte c = (byte)j;
            Console.WriteLine(c);

            String s = "123";
            int t = Convert.ToInt32(s);
            Console.WriteLine(t);

            //Operators
            var l = 1;
            var m = 2;
            var n = 3;
            Console.WriteLine(l < m && n == m);
            Console.WriteLine(l < m || n == m);
        }
    }
}
