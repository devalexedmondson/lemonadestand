using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadestand
{
    public class Ice : Supply
    {
        public Ice()
        {
            this.price = .15;
        }
        public void SetName()
        {
            name = "ice";
        }
        public void SetPrice()
        {
            price = .50;
        }
    }
}
