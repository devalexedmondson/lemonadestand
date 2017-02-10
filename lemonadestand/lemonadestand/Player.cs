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
        public void SellLemonade(Demand demand) //TODO
        {//need dif loop or way to get customers to buy
            if (demand.priceDemand == 3)
            {
                for (int i = 0; i < inventory.supplies[4].Count; i++)
                {
                    inventory.supplies[4].RemoveAt(0);
                }
            }
            else if (demand.priceDemand == 2)
            {
                for (int i = 0; i < inventory.supplies[4].Count * .75; i++)
                {
                    inventory.supplies[4].RemoveAt(0);
                }
            }
            else if (demand.priceDemand == 1)
            {
                for (int i = 0; i < inventory.supplies[4].Count * .25; i++)
                {
                    inventory.supplies[4].RemoveAt(0);
                }
            }
            else if (demand.priceDemand == 0)
            {
                for (int i = 0; i < inventory.supplies[4].Count * 0; i++)
                {
                    inventory.supplies[4].RemoveAt(0);
                }
            }
        }
        //public void CalculateSoldLemonade(Player player) TODO
        //{
        //    player.inventory.supplies[4].Count - 5;
        //}
        public void CheckSpoilInventory()
        {
            while (inventory.supplies[4].Count > 0)
            {
                     inventory.supplies[4].RemoveAt(0);
            }
        }
    }
}
