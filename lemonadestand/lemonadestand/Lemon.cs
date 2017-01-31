using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadestand
{
    public class Lemon : Supply
    {
        
        public Lemon()
        {
            this.price = .50;
        }
        public void SetName()
        {
            name = "lemon";
        }
        public void SetPrice()
        {
            price = .50;
        }
    }
}
