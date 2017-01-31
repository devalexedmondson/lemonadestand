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
        public Recipe recipe;
        public Random rnd;
       public Game()
        {
            player = new Player();
            UI = new UserInterface();
            runDay= new Day();
            store = new Store();
            recipe = new Recipe();
            rnd = new Random();

        }
        public void RunGame()
        {
            UI.WelcomePlayer();
            Console.Clear();
            player.inventory.DisplayInventory();
            store.StoreStart(player);
            Console.Clear();
            runDay.GetWeather(rnd);//make sure to add 
            runDay.GetForecast(rnd);
            recipe.RecipeStart(player);
            Console.Clear();
            player.inventory.DisplayInventory();
            runDay.GetTotalCustomers(rnd);
            
            
        }
        public void NextDay()
        {
            player.inventory.DisplayInventory();
            store.StoreStart(player);
            Console.Clear();
            runDay.GetWeather(rnd);//make sure to add 
            runDay.GetForecast(rnd);
            recipe.RecipeStart(player);
            Console.Clear();
            player.inventory.DisplayInventory();
            runDay.GetTotalCustomers(rnd);
        }

    }
}
