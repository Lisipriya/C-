using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class Exercise3_Arrays_Lists
    {
        public static void Main(string[] args)
        {

            //When you post a message on Facebook, depending on the number of people who
            //like your post, Facebook displays different information.
            //If no one likes your post, it doesn't display anything.
            //If only one person likes your post, it displays: [Friend's Name] likes your post.
            //If two people like your post, it displays: [Friend 1] and[Friend 2] like your post.
            //If more than two people like your post, it displays: [Friend 1], [Friend 2]
            //and[Number of Other People] others like your post.
            //Write a program and continuously ask the user to enter different names,
            //until the user presses Enter(without supplying a name). Depending on the
            //number of names provided, display a message based on the above pattern.
            int j = 0;
            var nameArrays = new List<string>();
            while (true)
            {
                Console.Write("Enter Name: ");
                var names = Console.ReadLine();               
                if(names.Length == 0)
                {
                    if(nameArrays.Count == 0)
                        break;
                    else if(nameArrays.Count <= 1)
                    {
                        Console.WriteLine(nameArrays[0] + " & likes your post.");
                        break;
                    }
                    else if(nameArrays.Count <= 2)
                    {
                        Console.WriteLine(nameArrays[0] + " &" + nameArrays[1] + 
                            " & likes your post.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine(nameArrays[0] + " &" + nameArrays[1] + " &" +
                              (nameArrays.Count -2) + " & others likes your post.");
                        break;
                    }                        
                }

                else
                {
                    nameArrays.Add(names);
                    j++;
                    foreach (var chars in nameArrays)
                        Console.WriteLine(chars);
                }
                    
            }
            
            //Write a program and ask the user to enter their name.
            //Use an array to reverse the name and then store the result
            //in a new string. Display the reversed name on the console.

            Console.Write("Enter your name: ");
            var name = Console.ReadLine();
            var reversedName = "";
            var nameArray = new char[name.Length];
            for (int i = 0; i < name.Length; i++)
            {
                nameArray[i] = name[i];
            }
            Array.Reverse(nameArray);
            foreach (var chars in nameArray)
                reversedName += chars;
            Console.WriteLine(reversedName);

            //3- Write a program and ask the user to enter 5 numbers.
            //If a number has been previously entered, display an
            //error message and ask the user to re-try. Once the
            //user successfully enters 5 unique numbers, sort them and
            //display the result on the console.

                int value;
                Console.WriteLine("Enter 5 unique numbers");
                var numbers = new List<int>();
                for(int i= 0; i < 5; i++)
                {
                    value = Convert.ToInt32(Console.ReadLine());
                    if(numbers.Contains(value))
                    {
                        Console.WriteLine("Retry");
                        break;
                    }                        
                    else
                        numbers.Add(value);
                }
                numbers.Sort();
                foreach (var num in numbers)
                    Console.WriteLine(num);

            
        }
    }
}
