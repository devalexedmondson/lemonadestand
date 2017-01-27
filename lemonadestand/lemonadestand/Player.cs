using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadestand
{
    public class Player
    {
        public string choice;
        public Inventory inventory;

        public Player()
        {
            inventory = new Inventory();
        }
       
        //public void AddSupplies()
        //{ HOW YOU ADD TO THE LIST 
        //    inventory.AddLemon(new Lemon());
        //    inventory.AddSugar(new Sugar());
        //    inventory.AddIce(new Ice());
        //    inventory.AddCup(new Cup());
        //}

        public int PlayerBuyLemon(Supply Lemon)
        {
            Console.WriteLine("How many lemons would you like to buy?");
            int lemon = Int32.Parse(Console.ReadLine());
            return lemon;
        }
        public int PlayerBuySugar(Supply Sugar)
        {
            Console.WriteLine("How many sugar would you like to buy?");
            int sugar = Int32.Parse(Console.ReadLine());
            return sugar;
        }
        public int PlayerBuyIce(Supply Ice)
        {
            Console.WriteLine("How many ice would you like to buy?");
            int ice = Int32.Parse(Console.ReadLine());
            return ice;
        }
        public int PlayerBuyCup(Supply Cup)
        {
            Console.WriteLine("How many cups would you like to buy?");
            int cup = Int32.Parse(Console.ReadLine());
            return cup;
        }







        //public void MakeRecipe()
        //{
        //    Console.WriteLine("How many lemons would you like to add?");
        //}
        //adds ingredient to the inventory list and subtracts the price of that StoreSupply from inventory of player

        //a certain amount of ingredients will automatically create a pitcher
    }
}
