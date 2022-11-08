using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class Exercise2_Controlflow
    {
        static void Main10(string[] args)
        {
            //1- Write a program to count how many numbers between 1 and 100
            //are divisible by 3 with no remainder. Display the count on the console.
            int counter = 0;
            for (int i = 1; i <= 100; i++)
            {
                if(i%3 == 0)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);

            //2- Write a program and continuously ask the user to enter a number or
            //"ok" to exit. Calculate the sum of all the previously entered numbers
            //and display it on the console.
            int value = 0;
            while (true)
            {
                int numericValue;
                Console.Write("Enter a number or 'ok' to exit: ");
                var stringNumber = Console.ReadLine();
                if (stringNumber.ToLower() == "ok") {
                    Console.WriteLine(value);
                    break;
                }             
                bool isNumber = int.TryParse(stringNumber, out numericValue);
                if (isNumber)
                    value += numericValue;
                else
                    Console.WriteLine("Input is invalid");
            }

            //3- Write a program and ask the user to enter a number.
            //Compute the factorial of the number and print it on the console.
            //For example, if the user enters 5, the program should calculate
            //5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
            int factorial = 1;
            Console.Write("Enter a number to get factorial: ");
            int fact = Convert.ToInt32(Console.ReadLine());
            for (int i = fact; i > 0; i--)
            {
                factorial*= i;
            }
            Console.WriteLine(factorial);

            //4- Write a program that picks a random number between 1 and 10.
            //Give the user 4 chances to guess the number. If the user guesses
            //the number, display “You won"; otherwise, display “You lost".
            //(To make sure the program is behaving correctly, you can display
            //the secret number on the console first.)
            
            int chance = 1;
            var rand = new System.Random();
            int random_number = rand.Next(1, 10);
            Console.WriteLine(random_number);
            while (chance <= 4)
            {
                Console.Write("Enter a number: ");
                int number = Int32.Parse(Console.ReadLine());
                if (number == random_number)
                {
                    Console.WriteLine("You Won");
                    break;
                }
                else if (chance == 4)
                    Console.WriteLine("You Lose the correct number is: " + random_number);
                else
                    Console.WriteLine("You Lose");
                chance++;
            }

            //5- Write a program and ask the user to enter a series of numbers
            //separated by comma. Find the maximum of the numbers and display it
            //on the console. For example, if the user enters “5, 3, 8, 1, 4",
            //the program should display 8.

            int[] anArray = new int[5];
            
            
            for (int i = 0; i < 5; i++)
            {
                Console.Write("element - {0} : ", i);
                anArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            int max = anArray.Max();
            Console.WriteLine(max);

            //or this method
            Console.Write("Input 5 elements separated by comma: ");
            var stringNumbers = Console.ReadLine();
            String[] strlist = stringNumbers.Split(',');
            Console.WriteLine(strlist.Max());
        }
    }
}
