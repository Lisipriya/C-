using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class ValueReferenceTypes
    {
        static void Main5(string[] args)
        {
            int a = 3;
            int b = a;
            b++;
            Console.WriteLine(string.Format("a is {0} and b is {1}", a, b));
            

            var array1 = new int[3] {1, 2, 3 };
            var array2 = array1;
            array2[2] = 4;
            Console.WriteLine(string.Format("array1[2] is {0} and array2[2] is {1}", array1[2], array2[2]));

        }


     }
}
