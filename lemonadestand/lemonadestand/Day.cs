using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadestand
{
    public class Day
    {
        public Weather weather;
        public Day()
        {
            weather = new Weather();
        }
        public void GetWeather()
        {
            weather.GetTemp();
            weather.GetOvercast();
            weather.DisplayWeather();
        }  
    }
}
