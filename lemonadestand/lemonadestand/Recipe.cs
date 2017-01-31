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
            Console.WriteLine("Time to make your recipe! To make one cup of lemonade you need 2 lemons, 2 sugar, and 3 ice. Try changing up your recipe to see what works best for you and your customers. Remember, your recipe will affect how many customers will buy your product. After you make your recipe set the price for each cup of lemonade.\n\n");
            Console.WriteLine("What would you like to do: 'make' recipe, 'check' inventory,'leave' store?");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "make":
                    player.inventory.DisplayInventory();
                    int lemon = PickLemons(player);
                    int sugar = PickSugar(player);
                    int ice = PickIce(player);
                    int cup = PickCup(player);
                    player.inventory.DisplayInventory();
                    Console.Clear();
                    PickLemonadePrice();
                    RecipeStart(player);
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
        public int PickCup(Player player)
        {
            Console.WriteLine("How many cups would you like to use for your recipe?");
            int cup = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < cup; i++)
            {
                player.inventory.supplies[3].RemoveAt(0);
            }
            return cup;
        }
        public double PickLemonadePrice()
        {
            Console.WriteLine("How much would you like to see your lemonade for?");
            double lemonadeprice = double.Parse(Console.ReadLine());
            return lemonadeprice;
        }

    }
}
