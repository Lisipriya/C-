using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CSharp
{
    internal class Exercise1_Controlflow
    {
        static void Main9(string[] args)
        {
            //1 - Write a program and ask the user to enter a number.
            //The number should be between 1 to 10.If the user enters a valid number,
            //display "Valid" on the console.Otherwise, display "Invalid". 
            Console.Write("Enter number to find Valid or Invalid: ");
            int num = Convert.ToInt32(Console.ReadLine());
            //int num = 2;
            if (num <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }

            //2 - Write a program which takes two numbers from the console and
            //displays the maximum of the two.
            Console.Write("Enter number1 : ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number2: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            var max = (number1 > number2) ? number1 : number2;
            Console.WriteLine(max);

            //3 - Write a program and ask the user to enter the width
            //and height of an image.Then tell if the image is landscape or portrait.

            //Note : A Portrait orientation refers to a book that has a width dimension
            //smaller than its height dimension. A Landscape orientation refers to a book
            //that has a width dimension larger than its height dimension
            Console.Write("Enter Width: ");            
            int width = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Height: ");
            int height = Convert.ToInt32(Console.ReadLine());
            if(width > height) 
                Console.WriteLine("The image is landscape");
            else if (width < height){
                Console.WriteLine("The image is portrait");
            }
            else
            {
                Console.WriteLine("The Dimension provided is incorrect");
            }

            //4- Your job is to write a program for a speed camera. For simplicity,
            //ignore the details such as camera, sensors, etc and focus purely on
            //the logic. Write a program that asks the user to enter the speed limit.
            //Once set, the program asks for the speed of a car. If the user enters a
            //value less than the speed limit, program should display Ok on the console.
            //If the value is above the speed limit, the program should calculate the
            //number of demerit points. For every 5km/hr above the speed limit, 1 demerit
            //points should be incurred and displayed on the console. If the number of
            //demerit points is above 12, the program should display License Suspended.
            Console.Write("Enter Speed Limit: ");
            int speedLimit = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Speed of a Car: ");
            int speedofCar = Convert.ToInt32(Console.ReadLine());
            if (speedofCar < speedLimit)
                {
                    Console.WriteLine("You speed limit is okay");
                }
                else
                {
                    int demeritPoints = (speedofCar - speedLimit) / 5;
                    Console.WriteLine("Your demerit points is " + demeritPoints);
                    if (demeritPoints >= 12)
                        Console.WriteLine("Your License is Suspended due to over speeding");
                }
                  
        }
    }
}
