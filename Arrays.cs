using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class Arrays
    {
        static void Main3(string[] args)
        {
            var num = new int[3];
            num[0] = 1;
            Console.WriteLine(num[0]);
            Console.WriteLine(num[1]);
            Console.WriteLine(num[2]);

            bool[] boole = new bool[3];
            boole[0] = true;
            Console.WriteLine(boole[0]);
            Console.WriteLine(boole[1]);
            Console.WriteLine(boole[2]);

            var names = new string[3] {"lisi", "Devi", "Pandiarajan"};
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);

            //Strings
            var firstName = "Lisi";
            var lastName = "Priya";
            var myFullName = string.Format("my name is {0} {1}", firstName, lastName);
            Console.WriteLine(myFullName);
    }
    }
}
