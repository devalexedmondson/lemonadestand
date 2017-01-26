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
           
        }
        public void SetName()
        {
            name = "lemon";
        }
        public void SetAmount()
        {
            amount = 0;
        }
        public void SetPrice()
        {
            price = 1.00;
        }
    }
}
