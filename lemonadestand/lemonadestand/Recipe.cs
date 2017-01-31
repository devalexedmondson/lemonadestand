using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadestand
{
    public class Recipe
    {
        public int lemon;
        public int sugar;
        public int ice;
        public int cup;
        public double lemonadePrice;
        public Recipe()
        {

        }
        public void RecipeStart(Player player)
        {
            Console.WriteLine("RECIPE MAKER\n");
            Console.WriteLine("Time to make your recipe! To make one cup of lemonade you need 2 lemons, 2 sugar, and 3 ice. Try changing up your recipe to see what works best for you and your customers. Remember, the weather will affect how many customers are out that day, and your recipe will affect how many customers will buy your product. MAKE YOUR RECIPE AND THEN MAKE SURE TO SET THE PRICE FOR EACH CUP. \n\n");
            Console.WriteLine("What would you like to do: 'make' recipe, 'check' inventory, 'set' lemonade price, 'display' recipe, 'leave' store?");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "make":
                    player.inventory.DisplayInventory();
                    int lemon = PickLemons(player);
                    int sugar = PickSugar(player);
                    int ice = PickIce(player);
                    player.inventory.DisplayInventory();
                    Console.Clear();
                    RecipeStart(player);
                    break;

                case "check":
                    player.inventory.DisplayInventory();
                    RecipeStart(player);
                    break;
                case "set":
                    DisplayRecipe();
                    PickLemonadePrice();
                    return;
                case "display":
                    DisplayRecipe();
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
        public int PickLemons(Player player)
        {
            Console.WriteLine("How many lemons would you like to put in your recipe?");
            int lemon = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < lemon; i++)
            {
                player.inventory.supplies[0].RemoveAt(0);
            }
            return lemon;
        }

        public int PickSugar(Player player)
        {
            Console.WriteLine("How much sugar would you like to put in your recipe?");
            int sugar = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < sugar; i++)
            {
                player.inventory.supplies[1].RemoveAt(0);
            }
            return sugar;
        }
        public int PickIce(Player player)
        {
            Console.WriteLine("How much ice would you like to put in your recipe?");
            int ice = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < ice; i++)
            {
                player.inventory.supplies[2].RemoveAt(0);
            }
            return ice;
        }
        public double PickLemonadePrice()
        {
            Console.WriteLine("How much would you like to sell each cup of your lemonade for?");
            double lemonadeprice = double.Parse(Console.ReadLine());
            return lemonadeprice;
        }
        public void DisplayRecipe()
        {
            Console.WriteLine($"Your current recipe includes: \n{lemon}: Lemons \n{sugar}: Sugar \n{ice}: Ice");
            Console.ReadKey();
            Console.Clear();
        }
        public void DisplayTotalLemonade()
        {
          //equation that takes in recipe and tells player how many cups they will be making. 
        }
    }
}
