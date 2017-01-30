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
       public Game()
        {
            player = new Player();
            UI = new UserInterface();
            runDay= new Day();
        }
        public void RunGame()
        {
            UI.WelcomePlayer();
            Console.Clear();
            player.inventory.DisplayInventory();
            player.PlayerBuyLemon(new Lemon());
            player.PlayerBuySugar(new Sugar()); 
            player.PlayerBuyIce(new Ice());
            player.PlayerBuyCup(new Cup());
            Console.Clear();
            player.inventory.DisplayInventory();
            runDay.GetWeather();
            runDay.GetForecast();


        }
    }   
}
