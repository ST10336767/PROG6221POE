using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221_POE_PART1
{
    public class Recipe //This class store the recipe information
    {
        public string Name { get; set; }//Property to store the name of the recipe
        private string recipeName = "";//Variable to store the name of the recipe
        public String[] Ingredients { get; set; } = null;//Property to store the ingredients of the recipe
        public double[] Quantity { get; set; }//Property to store the quantity of each ingredient
        public string[] Units { get; set; }//Property to store the unit of each ingredient
        public string[] Steps { get; set; }//Property to store the steps of the recipe
        public double ScaleFactor { get; set; } = 1.0; //Property to store the scale of the recipe

        public Recipe()//Default constructor
        {
            Ingredients = new String[0];
            Quantity = new double[0];
            Units = new string[0];
            Steps = new string[0];
        }
        public Recipe(String name, int numIngredients, int numSteps)//Constructor to initialize the arrays
        {
            recipeName = name;
            Ingredients = new String[numIngredients];
            Quantity = new double[numIngredients];
            Units = new string[numIngredients];
            Steps = new string[numSteps];
        }

        public void AddIngredient(int index, string ingredient, double quantity, string unit)//Method to add an ingredient to the recipe
        {

            Ingredients[index] = ingredient; //Add the ingredient to the Ingredients array
            Quantity[index] = quantity*ScaleFactor; //Add the quantity to the Quantity array
            Units[index] = unit; //Add the unit to the Units array
        }

        public void DisplayRecipe()//Method to display the recipe
        {
            if (Ingredients == null || Ingredients.Length == 0 || recipeName.Equals("")) //Check if the recipe has no ingredients
            {
                Console.WriteLine("No recipes have been entered. Please enter a recipe and try again.");//Display an error message
            }
            else
            {
                Console.WriteLine("Recipe: " + recipeName); //Display the name of the recipe
                Console.WriteLine("Ingredients: "); //Display the ingredients
                for (int i = 0; i < Ingredients.Length; i++) //Loop to display each ingredient
                {
                    Console.WriteLine(Ingredients[i] + ": " + Quantity[i] + " " + Units[i]);
                }
                Console.WriteLine("Steps: "); //Display the steps
                for (int i = 0; i < Steps.Length; i++) //Loop to display each step
                {
                    Console.WriteLine((i + 1) + ". " + Steps[i]);
                }
            }
        }

        public void ScaleRecipe()//Method to scale the recipe
        {
            Console.WriteLine("Enter the scale factor (0.5/2/3): "); //Prompt the user to enter the scale factor
            double scaleFactor = Convert.ToDouble(Console.ReadLine()); //Read the scale factor from the user
            ScaleFactor = scaleFactor; //Set the scale factor
            for (int i = 0; i < Quantity.Length; i++) //Loop to scale the quantity of each ingredient
            {
                Quantity[i] = Quantity[i] * scaleFactor;
            }
        }

        public void ResetScale()//Method to reset the scale of the recipe
        {
            for (int i = 0; i < Quantity.Length; i++) //Loop to reset the quantity of each ingredient
            {
                Quantity[i] = Quantity[i] / ScaleFactor;
            }
        }

        public void DeleteRecipe()//Method to delete the recipe
        {
            Name = null; //Set the name of the recipe to null
            Ingredients = null; //Set the ingredients array to null
            Quantity = null; //Set the quantity array to null
            Units = null; //Set the units array to null
            Steps = null; //Set the steps array to null
        }

        public void AddStep(int index, string step)//Method to add a step to the recipe
        {
            Steps[index] = step; //Add the step to the Steps array
        }

    }

}
