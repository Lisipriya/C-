using System;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Overflow
            Console.WriteLine("{0} {1}",byte.MinValue, byte.MaxValue);
            byte number = 255;
            number = (byte)(number + 1);
            Console.WriteLine("number: " + number);
            /*Exception will be thrown if the values exceeds the byte limit
             * for the below commented lines*/
            try
            {
                checked
                {
                    byte number1 = 255;
                    number1 = (byte)(number1 + 1);
                    Console.WriteLine("number: " + number1);
                }

            }
            catch (Exception)
            {

                Console.WriteLine("The Overflow exception occurs"); ;
            }
                    
           
            
        }
    }
}
