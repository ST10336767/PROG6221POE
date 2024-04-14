using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221_POE_PART1
{
    class Program
    {

        static void Main(string[] args)//Main method
        {
            bool exit = false;//Boolean variable to control the loop
            while (!exit)//While loop to keep the program running
            {
                Console.WriteLine("Welcome to the Recipe Manager");//Displaying a welcome message
                Console.WriteLine("1. Add a recipe");//Displaying a menu option
                Console.WriteLine("2. Display recipe");//Displaying a menu option
                Console.WriteLine("3. Scale recipe (0.5/2/3)");//Displaying a menu option
                Console.WriteLine("4. Reset scale");//Displaying a menu option
                Console.WriteLine("5. Delete recipe");//Displaying a menu option
                Console.WriteLine("6. Exit");//Displaying a menu option
                String choice = Console.ReadLine();//Reading the user's choice

            }
        }
    }
}
