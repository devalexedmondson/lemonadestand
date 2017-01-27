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
            player.AddSupplies();
            player.inventory.DisplayInventory();
            runDay.GetWeather();


        }
    }   
}
