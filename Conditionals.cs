using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class Conditionals
    {
        static void Main6(string[] args)
        {
            bool isGoldCustomer = true;
            float price;

            // normal if condition
            if (isGoldCustomer)
            {
                price = 19.95f;
            }
            else
            {
                price = 29.95f;
            }
            Console.WriteLine(price);

            //If using conditional operators
            float price1 = (isGoldCustomer) ? 19.95f : 29.95f;
            Console.WriteLine(price1);

            var season = Season.Winter;

            switch (season)
            {
                case Season.Winter:
                    Console.WriteLine("It is COLD outside");
                    break;
                case Season.Spring:
                    Console.WriteLine("It is Spring outside");
                    break;
                case Season.Summer:
                    Console.WriteLine("It is time to go to beach");
                    break;
                default:
                    Console.WriteLine("It is a different season");
                    break;


            }
            
        }

       

    }
}
