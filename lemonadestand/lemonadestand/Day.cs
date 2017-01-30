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
        public int day;
        public List<Customer> customer;
        public Day()
        {
            weather = new Weather();
            customer = new List<Customer>();
        }
        public void GetWeather()
        {
            weather.GetTemp();
            weather.GetOvercast();
            weather.DisplayCurrentWeather();
            //each time a day is called
        }  
        public void GetForecast()
        {
            weather.GetTemp();
            weather.GetOvercast();
            weather.DisplayForecast();
        }

        
    }
}
