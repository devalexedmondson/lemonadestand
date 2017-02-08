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
        public void BuyLemonade(Demand demand)
        {
            
            if (demand.priceDemand == 3)
            {
                //Player.inventory.supplies[3]
                //take from the list of lemonade
            }
            else if (demand.priceDemand == 2)
            {
                //buy 75% of lemonade
            }
            else if (demand.priceDemand == 1)
            {
                //buy 25% of lemonade
            }
            else if (demand.priceDemand == 0)
            {
                //buy no lemonade
            }
        }
    }
}
