using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadestand
{
    public class Player
    {
        public Inventory inventory;
        public double soldInventory;

        public Player()
        {
            inventory = new Inventory();
        }
        public void SellLemonade(Demand demand)
        {//need dif look or way to get customers to buy
            if (demand.priceDemand == 3)
            {
                for (int i = 0; i < inventory.supplies[4].Count; i++)
                {
                   inventory.supplies[4].RemoveAt(0);
                }
            }
            else if (demand.priceDemand == 2)
            {//buy 75% of lemonade
                for (int i = 0; i < inventory.supplies[4].Count * .75; i++)
                {
                    inventory.supplies[4].RemoveAt(0);
                }
            }
            else if (demand.priceDemand == 1)
            {//buy 25% of lemonade
                for (int i = 0; i < inventory.supplies[4].Count * .25; i++)
                {
                    inventory.supplies[4].RemoveAt(0);
                }
            }
            else if (demand.priceDemand == 0)
            {//buy no lemonade
                for (int i = 0; i < inventory.supplies[4].Count * 0; i++)
                {
                    inventory.supplies[4].RemoveAt(0);
                }
            }
        }
        public void CheckSpoilInventory()
        {
            while (inventory.supplies[4].Count > 0)
            {
                     inventory.supplies[4].RemoveAt(0);
            }
        }
        public void EndOfDay(double dayProfit)
        {
            if (dayProfit >= inventory.money)
            {
                Console.WriteLine("You have no more money! Game over!");
                //option to play again
            }
            else
            {
                //add profit
                //day++;
            }
        }
    }
}
