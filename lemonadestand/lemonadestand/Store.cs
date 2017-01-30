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
        public void StoreStart()
        {
            Console.WriteLine("Welcome to the store. While you are here you can buy the necessary items to make your lemonade. What would you like to do, 'buy' ingredients, 'check' inventory, quit?");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "buy":
                    PlayerBuyLemon(new Lemon());
                    PlayerBuySugar(new Sugar());
                    PlayerBuyIce(new Ice());
                    PlayerBuyCup(new Cup());
                    break;

                case "check":
                    player.inventory.DisplayInventory();
                    break;

                case "quit":

                    break;

                default:

                    StoreStart();
                    break;
            }
        }
        public int PlayerBuyLemon(Supply Lemon)
        {
            Console.WriteLine("How many lemons would you like to buy?");
            int lemon = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < lemon; i++)
            {
                inventory.AddLemon(new Lemon());
            }
            return lemon;
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
