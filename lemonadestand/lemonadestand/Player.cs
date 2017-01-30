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
        public int PlayerBuyLemon(Supply Lemon)
        {
            Console.WriteLine("How many lemons would you like to buy?");
            int lemon = Int32.Parse(Console.ReadLine());
            for(int i = 0; i < lemon; i++)
            {
                inventory.AddLemon(new Lemon());
            }
            return lemon;
        }
        public void GetTotalExpense()
        {
            //Will be a double:
            //expense = amount of item bought *item price 
        }
        public void PlayerBuySugar(Supply Sugar)
        {
            Console.WriteLine("How much sugar would you like to buy?");
            int sugar = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < sugar; i++)
            {
                inventory.AddSugar(new Sugar());
            }
        }
        public void PlayerBuyIce(Supply Ice)
        {
            Console.WriteLine("How much ice would you like to buy?");
            int ice = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < ice; i++)
            {

                inventory.AddIce(new Ice());
            }
        }
        public void PlayerBuyCup(Supply Cup)
        {
            Console.WriteLine("How many cups would you like to buy?");
            int cup = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < cup; i++)
            {

                inventory.AddCup(new Cup());
            }
        }







        //public void MakeRecipe()
        //{
        //    Console.WriteLine("How many lemons would you like to add?");
        //}
        //adds ingredient to the inventory list and subtracts the price of that StoreSupply from inventory of player

        //SellLemonade

        //a certain amount of ingredients will automatically create a pitcher
    }
}
