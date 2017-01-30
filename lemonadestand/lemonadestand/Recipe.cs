using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadestand
{
    public class Recipe
    {
        public Recipe()
        {

        }
        public void RecipeStart(Player player)
        {
            Console.WriteLine("RECIPE MAKER\n");
            Console.WriteLine("Time to make your recipe! To make one cup of lemonade you need 2 lemons, 2 sugar, and 3 ice. Try changing up your recipe to see what works best for you and your customers. Remember, your recipe will affect how many customers will buy your product\n\n");
            Console.WriteLine("What would you like to do: 'make' recipe, 'check' inventory, 'leave' store?");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "make":
                    
                    break;

                case "check":
                    player.inventory.DisplayInventory();
                    RecipeStart(player);
                    break;

                case "leave":

                    break;

                default:
                    Console.WriteLine("User error, please select one of the options.");
                    Console.ReadKey();
                    Console.Clear();
                    RecipeStart(player);
                    break;
            }
        }
        public void PickLemons()
        {
            Console.WriteLine("How many lemons would you like to put in your recipe?");
        }
    
    }
}
