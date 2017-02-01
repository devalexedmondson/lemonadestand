using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OxsaysoLemonadeStand
{
    class Inventory
    {
        public List<Lemon> lemon;
        public List<Sugar> sugar;
        public List<Ice> ice;
        public List<Cup> cup;
        public Inventory()
        {
            lemon = new List<Lemon>();
            sugar = new List<Sugar>();
            ice = new List<Ice>();
            cup = new List<Cup>();
        }
    }
}
