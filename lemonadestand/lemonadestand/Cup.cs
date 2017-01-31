using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadestand
{
    public class Cup : Supply
    {
        public Cup()
        {
            this.price = .25;
        }
        public void SetName()
        {
            name = "cup";
        }
        public void SetPrice()
        {
            price = .25;
        }
    }
}
