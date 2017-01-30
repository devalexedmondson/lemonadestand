using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadestand
{
    public class Supply
    { // relates to automobile class and holds the ingredients
        public string name;
        public double price;

        public string Name { get { return name; }set { name = value; } }
        public double Price { get { return price; } set { price = value; } }

        public Supply()
        {
            
        } 
    }
}
