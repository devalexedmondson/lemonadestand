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
            Console.WriteLine("Time to make your recipe! To make one cup of lemonade you need 1 lemons, 2 sugar, and 3 ice. Try changing up your recipe to see what works best for you and your customers. Remember, the weather will affect how many customers are out that day, and your recipe will affect how many customers will buy your product. MAKE YOUR RECIPE AND THEN MAKE SURE TO SET THE PRICE FOR EACH CUP. \n\n");
            Console.WriteLine("What would you like to do: 'make' recipe, 'check' inventory, 'set' lemonade price, 'display' recipe, 'leave'?");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "make":
                    player.inventory.DisplayInventory();
                    lemon = PickLemons();
                    CheckLemonInventory(player, lemon);
                    RemoveLemons(player, lemon);
                    sugar = PickSugar();
                    CheckSugarInventory(player, sugar);
                    RemoveSugar(player, sugar);
                    ice = PickIce();
                    CheckIceInventory(player, ice);
                    RemoveIce(player, ice);
                    player.inventory.DisplayInventory();
                    Console.Clear();
                    RecipeStart(player);
                    break;

                case "check":
                    player.inventory.DisplayInventory();
                    RecipeStart(player);
                    break;
                case "set":
                    DisplayRecipe(lemon, sugar, ice);
                    PickLemonadePrice();
                    return;
                case "display":
                    DisplayRecipe(lemon,  sugar, ice);
                    MakeLemonade(lemon, sugar, ice, cup, player);
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
        public int PickLemons()
        {
            Console.WriteLine("How many lemons would you like to put in your recipe?");
            int lemon = Int32.Parse(Console.ReadLine());
            return lemon;
        }
        public bool CheckLemonInventory(Player player, int lemon)
        {//program will catch the user the first time and no matter what number is entered the second time, will throw error. 
            if (player.inventory.supplies[0].Count < lemon) 
            {
                Console.WriteLine("You do not have that many lemons!");
                PickLemons();
            }
            return true;
        }
        public void RemoveLemons(Player player, int lemon)
        { 
            for (int i = 0; i < lemon; i++)
            {
                player.inventory.supplies[0].RemoveAt(0);
            }
        }
        public int PickSugar()
        {
            Console.WriteLine("How much sugar would you like to put in your recipe?");
            int sugar = int.Parse(Console.ReadLine());
            return sugar;
        }
        public bool CheckSugarInventory(Player player, int sugarCount)
        {//program will catch the user the first time and no matter what number is entered the second time, will throw error.
            if (player.inventory.supplies[1].Count < sugar)
            {
                Console.WriteLine("You do not have that much sugar!");
                PickSugar();
            }
            return true;
        }
        public void RemoveSugar(Player player, int sugar)
        {
            for (int i = 0; i < sugar; i++)
            {
                player.inventory.supplies[1].RemoveAt(0);
            }
        }
        public int PickIce()
        {
            Console.WriteLine("How much ice would you like to put in your recipe?");
            int ice = int.Parse(Console.ReadLine());
            return ice;
        }
        public bool CheckIceInventory(Player player, int iceCount)
        {//program will catch the user the first time and no matter what number is entered the second time, will throw error.
            if (player.inventory.supplies[2].Count < iceCount)
            {
                Console.WriteLine("You do not have that much ice!");
                PickIce();
            }
            return true;
        }
        public void RemoveIce(Player player, int ice)
        {
            for (int i = 0; i < ice; i++)
            {
                player.inventory.supplies[2].RemoveAt(0);
            }
        }
        public double PickLemonadePrice()
        {
            Console.WriteLine("How much would you like to sell each cup of your lemonade for?");
            lemonadePrice = double.Parse(Console.ReadLine());
            return lemonadePrice;
        }
        public void DisplayRecipe(int lemon, int sugar, int ice)
        {
            Console.WriteLine($"Your current recipe includes: \nLemons: {lemon}  \nSugar: {sugar} \nIce: {ice}");
            Console.ReadKey();
            Console.Clear();
        }
        public void PickCup()
        {
            Console.WriteLine("How many cups of lemonade would you like to make?");
            int madeCups = int.Parse(Console.ReadLine());
        }
        public bool CheckCupInventory(Player player, int cupCount)
        {//program will catch the user the first time and no matter what number is entered the second time, will throw error.
            if (player.inventory.supplies[2].Count < cupCount)
            {
                Console.WriteLine("You do not have that many cups!");
                PickCup();
            }
            return true;
        }
        public void MakeLemonade(int lemon, int sugar, int ice, int cup, Player player)
        {

        }
        //public void MakeLemonade(int lemon, int sugar, int ice, int cup, Player player)
        //{//make lemonade w/ equation
        //    //for every 1 lemon, 2 sugars, and 3 ice, make one cup of lemonade
        //    //take those cups away from inventory list 
        //    //add items that were not used back into inventory or let them go to waste
        //    for (int i = 0; i < player.inventory.supplies[3].Count; i++)
        //    {
               
        //        if ()
        //        {
        //            player.inventory.supplies[3].RemoveAt(0);
        //        }
        //    }
        //}
    }
}
