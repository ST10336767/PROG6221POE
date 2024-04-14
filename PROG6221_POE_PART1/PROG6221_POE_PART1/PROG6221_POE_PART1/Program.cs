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
            Recipe recipe = new Recipe();//Creating an object of the Recipe class
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
                        EnterRecipeDetails();//Calling the EnterRecipeDetails method
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

        public static void EnterRecipeDetails()//Method to enter the recipe details
        {      
            Console.WriteLine("Enter the name of the recipe: ");//Prompt the user to enter the name of the recipe
            String name = Console.ReadLine();//Read the name of the recipe
            
            int numIngredients = 0;//Variable to store the number of ingredients
            int numSteps = 0;//Variable to store the number of steps
            Console.WriteLine("Enter the number of ingredients: ");//Prompt the user to enter the number of ingredients
            String numOfIngredients = Console.ReadLine();//Read the number of ingredients
            Console.WriteLine("Enter the number of steps: ");//Prompt the user to enter the number of steps
            String numOfSteps = Console.ReadLine();//Read the number of steps
            try
            {
                if (numOfIngredients == "" || numOfSteps == "")
                {
                    throw new Exception("Number of ingredients cannot be 0");//Throw an exception if the user enters an empty string
                }

                if (!numOfIngredients.All(char.IsDigit) || !numOfSteps.All(char.IsDigit))
                {
                    throw new Exception("Please enter a valid number");//Throw an exception if the user enters a non-numeric value
                    
                }
                else
                {
                    numIngredients = Convert.ToInt32(numOfIngredients);//Convert the number of ingredients to an integer
                    numSteps = Convert.ToInt32(numOfSteps);//Convert the number of steps to an integer
                }

                
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);//Display the error message
                EnterRecipeDetails();//Calling the EnterRecipeDetails method
            }
           
        }
    }
}
