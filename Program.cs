/*
 * Writer: Kaley Liburd
 * Due Date: 01/30/2020
 * Comments: This project is going to illustrate the use of iteration statements.
 * I chose to illustrate the "For" loop iteration. An iternation statement is a basically a loop.
 * It uses a set of numbers of times until you tell it to stop with a true of false statement.
 */
using System;

namespace Deliverable2_IterationStatements_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for an input
            Console.WriteLine("Please enter a vaule beteween 0 and 100: \n");

            // Here I will use the try-catch method to validate the users inputs
            try
            {
                // This will be used to collect the user's inputs
                string input = Console.ReadLine();

                // Here is where the integer will be stored
                int number = int.Parse(input);

                // This will validate the input by the user
                if (number < 0 || number >100)
                {
                    Console.WriteLine("\nInteger value has to be between 0 and 100!");
                    return;
                }

                // Space
                Console.WriteLine("\n");

                // This will display multiple loop messages, as long as the vaules the users enters the correct vaules.
                for (int i = 1; i <= number; i++)
                {
                    Console.WriteLine("The number you have entered is" + number + "Current value of the integer in the loop:" + i);
                }

            } //end of try
            catch
            {
                Console.WriteLine("\nPlease use the correct integer data type!");
                Console.WriteLine("Hit any key to exit the program...");
                Console.ReadKey(true);
            } //end of catch
        }
    }
}
