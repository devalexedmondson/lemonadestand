using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadestand
{
    public class Store
    {
        public Store()
        {
        }
        public void StoreStart(Player player)
        {
            Console.WriteLine("Welcome to the store! While you are here you can buy the necessary items to make your lemonade. What would you like to do, 'buy' ingredients, 'check' inventory, 'leave' store?");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "buy":
                    PlayerBuyLemon(player);
                    PlayerBuySugar(player);
                    PlayerBuyIce(player);
                    PlayerBuyCup(player);
                    player.inventory.DisplayInventory();
                    Console.Clear();
                    StoreStart(player);
                    break;

                case "check":
                    player.inventory.DisplayInventory();
                    StoreStart(player);
                    break;

                case "leave":
                    
                    break;

                default:
                    Console.WriteLine("User error, please select one of the options.");
                    Console.ReadKey();
                    Console.Clear();
                    StoreStart(player);
                    break;
            }
        }
        public int PlayerBuyLemon(Player player)
        {
            Console.WriteLine("How many lemons would you like to buy?");
            int lemon = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < lemon; i++)
            {
                player.inventory.AddLemon(new Lemon());
            }
            return lemon;
        }
        public int PlayerBuySugar(Player player)
        {
            Console.WriteLine("How much sugar would you like to buy?");
            int sugar = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < sugar; i++)
            {
                player.inventory.AddSugar(new Sugar());
            }
            return sugar;
        }
        public int PlayerBuyIce(Player player)
        {
            Console.WriteLine("How much ice would you like to buy?");
            int ice = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < ice; i++)
            {

                player.inventory.AddIce(new Ice());
            }
            return ice;
        }
        public int PlayerBuyCup(Player player)
        {
            Console.WriteLine("How many cups would you like to buy?");
            int cup = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < cup; i++)
            {

                player.inventory.AddCup(new Cup());
            }
            return cup;
        }

        public void GetTotalExpense()
        {
            //Will be a double:
            //expense = amount of item bought *item price 
        }
        public void AddToMoney(double amountToAdd)
        {
            //inventory.money += amountToAdd;
        }

        public bool WithdrawFromMoney(double amountToWithdraw)
        {
            //if (inventory.money > amountToWithdraw)
            {
                //inventory.money -= amountToWithdraw;
                return true;
            }
            return false;
        }
    }
}
