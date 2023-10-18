using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabaseLab
{
    internal class Validator
    {
        public static string GetValidCategory()
        {
            string category;
            do
            {
                Console.WriteLine("Select a category by number or enter the category name:");
                Console.WriteLine("1. Animated");
                Console.WriteLine("2. Drama");
                Console.WriteLine("3. Horror");
                Console.WriteLine("4. Sci-Fi");

                string input = Console.ReadLine().Trim().ToLower();

                if (int.TryParse(input, out int categoryNumber) && categoryNumber >= 1 && categoryNumber <= 4)
                {
                    category = GetCategoryName(categoryNumber);
                }
                else
                {
                    category = input;
                }
            } while (!IsValidCategory(category));
            return category;
        }

        public static bool ShouldContinue()
        {
            bool isValidResponse = false;
            bool shouldContinue = false;

            do
            {
                Console.Write("Do you want to continue (yes/no): ");
                string response = Console.ReadLine().Trim().ToLower();

                if (response == "yes")
                {
                    shouldContinue = true;
                    isValidResponse = true;
                }
                else if (response == "no")
                {
                    shouldContinue = false;
                    isValidResponse = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
                }
            } while (!isValidResponse);

            return shouldContinue;
        }

        private static bool IsValidCategory(string category)
        {
            string[] validCategories = { "animated", "drama", "horror", "scifi" };
            return validCategories.Contains(category);
        }

        private static string GetCategoryName(int categoryNumber)
        {
            switch (categoryNumber)
            {
                case 1:
                    return "animated";
                case 2:
                    return "drama";
                case 3:
                    return "horror";
                case 4:
                    return "scifi";
                default:
                    return "";
            }
        }
    }
}
