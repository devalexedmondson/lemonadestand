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

        }
        public void SetName()
        {
            name = "ice";
        }
        public void SetAmount()
        {
            amount = 0;
        }
        public void SetPrice()
        {
            price = .50;
        }
    }
}
