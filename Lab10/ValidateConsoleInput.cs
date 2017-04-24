using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class ValidateConsoleInput
    {
        public static bool Continue()
        {
            Console.WriteLine("Continue? (y/n)");

            string input = Console.ReadLine();

            if (input.ToLower() == "n")
            {
                return false;
            }
            else if (input.ToLower() == "y")
            {
                Console.Clear();
                return true;
            }
            else
            {
                Console.WriteLine("Invalid input");
                Continue();
                return true;
            }

        }

        // Method to Get Valid String
        public static string GetValidString()
        {
            string[] validCategories = { "scifi", "drama", "horror", "animated" };
            string Input = Console.ReadLine().ToLower();

            // Validate Input
            while ((string.IsNullOrEmpty(Input)) || (string.IsNullOrWhiteSpace(Input) || (Input.Length == 0)) || !(validCategories.Contains(Input)))
            {
                Console.Write("Error: Please enter only the following: animated / drama / horror / scifi: ");
                Input = Console.ReadLine().ToLower();

            }
            return Input;
        }
    }
}
