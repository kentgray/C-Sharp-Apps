using System;

namespace Treehouse.CodeChallenges
{
    class Program
    {
        static void Main()
        {
            var runningTotal = 0.0;
            
            while(true)
            {
                Console.Write("Enter the number of times to print \"Yay!\": ");
                var entry = Console.Readline();

                      
              try
              {
                 var number = double.Parse(entry);

                 if (number > 0)
                 {
                    Console.WriteLine(number * "Yay!");
                    continue;
                 }
                 else
                 {
                   Console.WriteLine("No YAY's for You!!");
                 }

                runningTotal *= number;
               }

              catch(FormatException)
                {
                    Console.WriteLine("That is not valid input.");
                }
            }
        }
    }
 }

