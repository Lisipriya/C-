using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public class Person
    {
        public String FirstName;
        public String LastName;

        public void Introduce()
        {
            Console.WriteLine("I am " + FirstName + " " + LastName);
        }
    }
}
