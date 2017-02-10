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

        public Demand(Recipe recipe, Weather weather)
        {
            GetPriceDemand(recipe);
            GetWeatherDemand(weather);
        }
        public int GetPriceDemand(Recipe recipe)
        {
            if (recipe.lemonadePrice <= .50)
            {
                priceDemand = 4;
            }
            else if (recipe.lemonadePrice >= .51 && recipe.lemonadePrice <= .75)
            {
                priceDemand = 3;
            }
            else if (recipe.lemonadePrice >= .76 && recipe.lemonadePrice <= 1.00)
            {
                priceDemand = 2;
            }
            else if (recipe.lemonadePrice >= 1.01)
            {
                priceDemand = 1;
            }
            return priceDemand;
        }
        public int GetWeatherDemand(Weather weather)
        {
            if (weather.temperature == "hot")
            {
                weatherDemand = 4;
            }
            else if (weather.temperature == "Warm")
            {
                weatherDemand = 3;
            }
            else if (weather.temperature == "Cold")
            {
                weatherDemand = 2;
            }
            else if ((weather.temperature == "Cold") && (weather.condition == "with thunderstorms"))
            {
                weatherDemand = 1;
            }
            return weatherDemand;
        }
    }
}