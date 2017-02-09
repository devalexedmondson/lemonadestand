using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadestand
{
    public class Customer
    {
        public Demand demand;

        public Customer()
        {
            demand = new Demand();
        }
        public void BuyLemonade(Demand demand, Player player)
        {
            if (demand.priceDemand == 3)
            {
                for (int i = 0; i < player.inventory.supplies[4].Count; i++) 
                {
                    player.inventory.supplies[4].RemoveAt(0);
                }
            }
            else if (demand.priceDemand == 2)
            {//buy 75% of lemonade
                for (int i = 0; i < player.inventory.supplies[4].Count * .75 ; i++)
                {
                    player.inventory.supplies[4].RemoveAt(0);
                }
            }
            else if (demand.priceDemand == 1)
            {//buy 25% of lemonade
                for (int i = 0; i < player.inventory.supplies[4].Count * .25; i++)
                {
                    player.inventory.supplies[4].RemoveAt(0);
                }
            }
            else if (demand.priceDemand == 0)
            {//buy no lemonade
                for (int i = 0; i < player.inventory.supplies[4].Count * 0; i++)
                {
                    player.inventory.supplies[4].RemoveAt(0);
                }
            }
        }
    }
}
