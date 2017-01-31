using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadestand
{
    public class Sugar : Supply
    {
        public Sugar()
        {
            this.price = .25;
        }
        public void SetName()
        {
            name = "sugar";
        }
        public void SetPrice()
        {
            price = .25;
        }
    }
}
