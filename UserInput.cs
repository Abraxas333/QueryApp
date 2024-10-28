using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterApp
{
    internal class UserInput
    {
        // Method that prompts user to choose which query should be executed and returns the users choice
        public static string TakeInput()
        {
            Console.WriteLine("Please choose query: \n1 For all customers from a city.\n2 for customers younger than 30 years\n3 for customers who ordered value above 100€\n4 for customers who ordered electoronic devices\n5 for customers who ordered after the 1st of January 2023\n6 for all customers sorted by name\n7 for all customers grouped by a city\n8 for the three oldest customer");
            string input = Console.ReadLine();

            return input;
        }
    }
}
