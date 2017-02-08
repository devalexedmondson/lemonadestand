using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadestand
{
    public class Demand
    {
        public int priceDemand;
        public int weatherDemand;

        public Demand()
        {
            
        }
        public int GetCustomersBuying(Recipe recipe)
        {
            if (recipe.lemonadePrice <= 1.00)
            {
                priceDemand = 3;
            }
            else if (recipe.lemonadePrice >= 1.01 && recipe.lemonadePrice <= 1.50)
            {
                priceDemand = 2;
            }
            else if (recipe.lemonadePrice >= 1.51 && recipe.lemonadePrice <= 2.00)
            {
                priceDemand = 1;
            }
            else if (recipe.lemonadePrice >= 2.01)
            {
                priceDemand = 0;
            }
            return priceDemand;
        }
        public int GetWeatherDemand(Weather weather)
        {
            if (weather.temperature == "hot")
            {
                weatherDemand = 3;
            }
            else if (weather.temperature == "Warm")
            {
                weatherDemand = 2;
            }
            else if (weather.temperature == "Cold")
            {
                weatherDemand = 1;
            }
            else if ((weather.temperature == "Cold") && (weather.condition == "with thunderstorms"))
            {
                weatherDemand = 0;
            }
            return weatherDemand;
        }
    }
}