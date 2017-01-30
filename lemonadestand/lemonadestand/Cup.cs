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
            this.price = .50;
        }
        public void SetName()
        {
            name = "cup";
        }
        public void SetPrice()
        {
            price = .50;
        }
    }
}
