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
            inventory = new lemonadestand.Inventory();
        }
        public void AddIngredients(Ingredients supplies)
        {
            inventory.supplies.Add(supplies);
        }
        //buy/order ingredients option

        //adds ingredient to the inventory list and subtracts the price of that StoreSupply from inventory of player

        //a certain amount of ingredients will automatically create a pitcher


    }
}
