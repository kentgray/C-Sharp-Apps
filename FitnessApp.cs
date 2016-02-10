using System;

namespace Treehouse.FitnessFrog
{
  class Program
  {
      static void Main()
      {
          int runningTotal = 0;
          bool keepGoing = true;
        
          while(keepGoing)
          {                   
            // Prompt the user for minutes exercised
            Console.Write("Enter how many minutes you exercised or type \"quit\" to exit: ");        
            string entry = Console.ReadLine();
            
            if (entry == "quit")
            {
                keepGoing = false;
            }
            else
            {            
              int minutes = int.Parse(entry); 
              
              if(minutes <= 10)
              {
                  Console.WriteLine("Better than nothing, hombre!");
              }
              else if(minutes <= 30)
              {
                  Console.WriteLine("Way to go Champ!");
              }
              else if(minutes <= 60)
              {
                  Console.WriteLine("You must be Unstoppable!");
              }
              else
              {
                  Console.WriteLine("Okay, now you're just showing off!");
              }
                 
              // Add minutes exercised to total
              runningTotal = runningTotal + minutes;
                              
              // Display total minutes exercised to the screen                  
              System.Console.WriteLine("You've entered " + runningTotal + " minutes");
            }
             // Repeat until the user quits
          }
        
        Console.WriteLine("Goodbye");
   }
  }
}