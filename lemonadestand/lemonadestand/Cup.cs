﻿using System;
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

        }
        public void SetName()
        {
            name = "cup";
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
