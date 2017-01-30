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
            Console.WriteLine("Welcome to the store! While you are here you can buy the necessary items to make your lemonade. What would you like to do:'buy' ingredients, 'check' inventory, 'leave' store?");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "buy":
                    Console.WriteLine("Decide how much of each supply you would like to buy. If you do not want to buy an item, type 0.\n\n PRICES:\n\nLemons: $1.00\nSugar: $.75\nIce: $.50\nCups: $.50");
                    int lemon = PlayerBuyLemon(player);
                    int sugar = PlayerBuySugar(player);
                    int ice = PlayerBuyIce(player);
                    int cup = PlayerBuyCup(player);
                    double lemonExpense = GetLemonExpense(lemon, player);
                    WithdrawLemonMoney(player,lemonExpense);
                    double sugarExpense = GetSugarExpense(sugar, player);
                    WithdrawSugarMoney(player, sugarExpense);
                    double iceExpense = GetIceExpense(ice, player);
                    WithdrawIceMoney(player, iceExpense);
                    double cupExpense = GetCupExpense(cup, player);
                    WithdrawCupMoney(player, cupExpense);

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
        public double GetLemonExpense(int lemon, Player player)
        {
            double expense;
            expense = lemon * new Lemon().price;
            return expense;
        }
        public bool WithdrawLemonMoney(Player player, double expense)
        {
            if (player.inventory.money > expense)
            {
                player.inventory.money -= expense;
                return true;
            }
                Console.WriteLine("You do not have enough money to complete this transaction.");
                return false;
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
        public double GetSugarExpense(int sugar, Player player)
        {
            double expense;
            expense = sugar * new Sugar().price;
            return expense;
        }
        public bool WithdrawSugarMoney(Player player, double expense)
        {
            if (player.inventory.money > expense)
            {
                player.inventory.money -= expense;
                return true;
            }
          
            Console.WriteLine("You do not have enough money to complete this transaction.");
            return false;
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
        public double GetIceExpense(int ice, Player player)
        {
            double expense;
            expense = ice * new Ice().price;
            return expense;
        }
        public bool WithdrawIceMoney(Player player, double expense)
        {
            if (player.inventory.money > expense)
            {
                player.inventory.money -= expense;
                return true;
            }

            Console.WriteLine("You do not have enough money to complete this transaction.");
            return false;
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
        public double GetCupExpense(int cup, Player player)
        {
            double expense; 
            expense = cup * new Cup().price;
            return expense;
        }
        public bool WithdrawCupMoney(Player player, double expense)
        {
            if (player.inventory.money > expense)
            {
                player.inventory.money -= expense;
                return true;
            }
            Console.WriteLine("You do not have enough money to complete this transaction.");
            return false;
        }

        public void AddToMoney(double amountToAdd)
        {
            //inventory.money += amountToAdd;
        }

        
    }
}
