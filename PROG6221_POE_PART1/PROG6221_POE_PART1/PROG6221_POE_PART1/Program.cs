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
            Recipe recipe = new Recipe();//Initializing the recipe object to null
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

                switch (choice)//Switch statement to handle the user's choice
                {
                    case "1"://If the user chooses to add a recipe
                        recipe = EnterRecipeDetails();//Calling the EnterRecipeDetails method
                        break;
                    case "2"://If the user chooses to display a recipe
                        recipe.DisplayRecipe();//Calling the DisplayRecipe method
                        break;
                    case "3"://If the user chooses to scale a recipe
                        recipe.ScaleRecipe();//Calling the ScaleRecipe method
                        break;
                    case "4"://If the user chooses to reset the scale
                        recipe.ResetScale();//Calling the ResetScale method
                        break;
                    case "5"://If the user chooses to delete a recipe
                        recipe.DeleteRecipe();//Calling the DeleteRecipe method
                        break;
                    case "6"://If the user chooses to exit the program
                        exit = true;//Setting the exit variable to true
                        break;
                    default://If the user enters an invalid choice
                        Console.WriteLine("Invalid choice. Please try again.");//Displaying an error message
                        break;
                }   

            }
        }

        
    }
}
