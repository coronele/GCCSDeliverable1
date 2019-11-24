// Erwin Coronel
// coronele@hotmail.com
// Grand Circus C#.NET Boot Camp Unit 1 Lab - Deliverable 1


using System;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            string vacationType="";   /* Choice of event type */
            int groupSize=0;          /* Party size           */
            string destination="";       /* Destination          */
            string travel="";            /* Travel suggestion    */

            // Loop prompt for vacation type until accepted format entered
            while (vacationType != "musical" && vacationType != "tropical" && vacationType != "adventurous")
            {
                Console.Write("What kind of trip would you like to go on, musical, tropical, or adventurous? ");
                vacationType = Console.ReadLine();
                if (vacationType != "musical" && vacationType != "tropical" && vacationType != "adventurous")
                {
                    Console.WriteLine("Invalid input. Please try again.");
                    Console.WriteLine();
                }
            }

            // Evaluate vacation destination based on type chosen
            switch(vacationType)
            {
                case "musical":
                    destination = "New Orleans";
                    break;
                case "tropical":
                    destination = "a beach vacation in Mexico";
                    break;
                case "adventurous":
                    destination = "go whitewater rafting in the Grand Canyon";
                    break;
            }

            // Loop prompt for group size until acceptable value is entered
            while (groupSize==0)
            {
                Console.Write("How many are in your group? ");
                groupSize = int.Parse(Console.ReadLine());
                
                if (groupSize < 1)
                {
                        Console.WriteLine("Nope, try again!");
                        Console.WriteLine();
                        groupSize = 0;
                }
            }

            // Evaluate travel method based on group size provided
            if (groupSize>=6)
            {
                travel = "charter flight";
            } else if (groupSize>=3)
            {
                travel = "helicopter";
            } else
            {
                travel = "first class flight";
            }
            
            // print suggestion to screen.  Evaluate OCD grammar/correct article used based on whether adventurous is chosen or not.
            string result = ("Since you’re a group of " + groupSize + " going on "+ (vacationType=="adventurous"?"an ":"a ")+ vacationType + " vacation, you should take a "+travel+" to "+destination+".");
            Console.WriteLine(result);


        }
    }
}
