using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Validation
    {

        // Method to Get Valid String
        public static string GetValidString()
        {
            string Input = Console.ReadLine().ToUpper();

            // Validate Input
            while ((string.IsNullOrEmpty(Input)) || (string.IsNullOrWhiteSpace(Input) || (Input.Length == 0)))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.Write("You Must Enter a Word  --->   ");
                Console.ForegroundColor = ConsoleColor.Green;
                Input = Console.ReadLine().ToUpper(); ;

            }
            return Input;
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
                    Console.ForegroundColor = ConsoleColor.Red;  // Red to Alert User Input is Invalid
                Console.WriteLine("Please Enter Y or N");
                Console.ForegroundColor = ConsoleColor.Green;   // Green to Go Back to Original Color
            }
        }
    }
}
