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
        public void GetWeather(Random rnd)
        {
            weather.GetTemp(rnd);
            weather.GetOvercast(rnd);
            weather.DisplayCurrentWeather();
        }  
        public void GetForecast(Random rnd)
        {
            weather.GetTemp(rnd);
            weather.GetOvercast(rnd);
            weather.DisplayForecast();
        }
        public void GetTotalCustomers(Random rnd)//customers that come out based on weather conditions
        {
            if (weather.temperature == "Hot" && weather.condition == "and sunny")
            {
                int customerNumber = rnd.Next(25, 30);
                for (int i = 0; i < customerNumber; i++)
                {
                    customer.Add(new Customer());
                }  
            }
            else if (weather.temperature == "Hot" && weather.condition == "and cloudy")
            {
                int customerNumber = rnd.Next(20,26);
                for (int i = 0; i < customerNumber; i++)
                {
                    customer.Add(new Customer());
                }
            }
            else if (weather.temperature == "Hot" && weather.condition == "with thunderstorms")
            {
                int customerNumber = rnd.Next(10, 16);
                for (int i = 0; i < customerNumber; i++)
                {
                    customer.Add(new Customer());
                }
            }
            else if (weather.temperature == "Warm" && weather.condition == "and sunny")
            {
                int customerNumber = rnd.Next(15, 21);
                for (int i = 0; i < customerNumber; i++)
                {
                    customer.Add(new Customer());
                }
            }
            else if (weather.temperature == "Warm" && weather.condition == "and cloudy")
            {
                int customerNumber = rnd.Next(10, 16);
                for (int i = 0; i < customerNumber; i++)
                {
                    customer.Add(new Customer());
                }
            }
            else if (weather.temperature == "Warm" && weather.condition == "with thunderstorms")
            {
                int customerNumber = rnd.Next(5, 11);
                for (int i = 0; i < customerNumber; i++)
                {
                    customer.Add(new Customer());
                }
            }
            else if (weather.temperature == "Cold" && weather.condition == "and sunny")
            {
                int customerNumber = rnd.Next(5, 11);
                for (int i = 0; i < customerNumber; i++)
                {
                    customer.Add(new Customer());
                }
            }
            else if (weather.temperature == "Cold" && weather.condition == "and cloudy")
            {
                int customerNumber = rnd.Next(0, 6);
                for (int i = 0; i < customerNumber; i++)
                {
                    customer.Add(new Customer());
                }
            }
            else if (weather.temperature == "Cold" && weather.condition == "with thunderstorms")
            {
                int customerNumber = rnd.Next(0, 2);
                for (int i = 0; i < customerNumber; i++)
                {
                    customer.Add(new Customer());
                }
            }
        }
        public void EndOfDay(Player player, int totalLoss)
        {
            if (totalLoss >= player.inventory.money)
            {
                Console.WriteLine("You have no more money! Game over!");
                //option to play again
            }
            else
            {
                //add profit
                day++;
            }
        }
    }
}
