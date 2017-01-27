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
        public void BuyLemon(Supply lemon)
        {//buy/order ingredients option
            inventory.supplies[0].Add(lemon);
        }
        public void AddSupplies()
        {
            inventory.AddLemon(new Lemon());
            inventory.AddSugar(new Sugar());
            inventory.AddIce(new Ice());
            inventory.AddCup(new Cup());
        }






        //public void MakeRecipe()
        //{
        //    Console.WriteLine("How many lemons would you like to add?");
        //}
        //adds ingredient to the inventory list and subtracts the price of that StoreSupply from inventory of player

        //a certain amount of ingredients will automatically create a pitcher
    }
}
