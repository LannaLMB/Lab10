using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Validation
    {

        // Method to Get Valid Integer
        public static int GetValidInt()
        {

            int number;

            // Validate Input
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine();

                // Number Validation with Colors
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.Write("You Must Enter a Number:  --->   ");
                Console.ForegroundColor = ConsoleColor.Green;
            }

            return number;
        }




        // Method to Get Input and Validate That Number is Between Min and Max
        public static int GetRange(int min, int max)
        {

            // Get a Valid Int from Previous Method
            int number = GetValidInt();

            while (number < min || number > max)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"You MUST Enter a Number That is in Between {min} and {max}  --->   ");
                Console.ForegroundColor = ConsoleColor.Green;
                number = GetValidInt();
            }

            return number;
        }




        // Method to Continue
        public static bool GetContinue()
        {
            string Continue;

            //Continue Loop
            while (true)
            {
                Console.WriteLine("\n");
                Console.WriteLine("Would You Like to Continue?  (y/n)");
                Continue = Console.ReadLine().ToUpper();
                Console.WriteLine("");
                if (Continue == "Y")
                    return true;

                if (Continue == "N")
                    return false;

                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;  // Red to Alert User Input is Invalid
                    Console.WriteLine("Please Enter Y or N");
                    Console.ForegroundColor = ConsoleColor.Green;   // Green to Go Back to Original Color
                }
            }
        }
    }
}
