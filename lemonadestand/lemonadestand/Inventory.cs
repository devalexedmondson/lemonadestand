using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadestand
{
    public class Inventory
    {
        //relates to inventory class in automobiles
        public double money;
        public List<StoreSupply> supplies;


        public Inventory()
        {
            supplies = new List<StoreSupply>();

        }
        //
    }
}
