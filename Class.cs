using CSharp.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class Class
    {        static void Main3(string[] args)
        {
            Person lisi = new Person();
            lisi.FirstName = "Lisi";
            lisi.LastName = "Priya";
            lisi.Introduce();

            Calculator calculator = new Calculator();
            Console.WriteLine(calculator.add(2, 4)); 
                
        }
    }
}
