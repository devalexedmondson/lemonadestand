using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadestand
{
    public class Game
    {
        public Player player;
        public UserInterface UI;
        public Day runDay;
        public Store store;
       public Game()
        {
            player = new Player();
            UI = new UserInterface();
            runDay= new Day();
            store = new Store();
        }
        public void RunGame()
        {
            UI.WelcomePlayer();
            Console.Clear();
            player.inventory.DisplayInventory();
            store.StoreStart(player);
            Console.Clear();
            player.inventory.DisplayInventory();
            runDay.GetWeather();
            runDay.GetForecast();


        }
    }   
}
