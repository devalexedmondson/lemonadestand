using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Threading.Tasks;

namespace lemonadestand
{
    public class Weather
    {
        public string temperature;
        public string condition;
        public Weather()
        {

        }
        public int GetTemp()
        {
            Random rnd = new Random();
            int temperature = rnd.Next(1, 6);

            switch (temperature)
            {
                case 1:
                    this.temperature = "Warm";
                    break;
                case 2:
                    this.temperature = "Hot";
                    break;
                case 3:
                    this.temperature = "Cold";
                    break;
                case 4:
                    this.temperature = "Frigid";
                    break;
                case 5:
                    this.temperature = "Moderate temperature";
                    break;
                default:
                    Console.WriteLine("There was an error getting the report");
                    break;
            }
            return temperature;
        }
        public int GetOvercast()
        {
            Random rnd = new Random();
            int condition = rnd.Next(1, 4);

            switch (condition)
            {
                case 1:
                    this.condition = "and sunny";
                    break;
                case 2:
                    this.condition = "and cloudy";
                    break;
                case 3:
                    this.condition = "with thunderstorms";
                    break;
                default:
                    Console.WriteLine("There was an error getting the report");
                    break;
            }
            return condition;
        }
        public void DisplayWeather()
        {
            Console.WriteLine($"Today's forcast is: {temperature} {condition}");
        }
    }
}
