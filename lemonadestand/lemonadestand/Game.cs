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
            runDay.GetWeather(rnd);
            runDay.GetForecast(rnd);
            recipe.RecipeStart(player);
            Console.Clear();
            player.inventory.DisplayInventory();
            runDay.GetTotalCustomers(rnd);

            NewDay();
        }
        public void NewDay()
        {
            for (int i = 0; i < 7; i++)
            {
                if (runDay.day <= 7)
                {
                    player.inventory.DisplayInventory();
                    store.StoreStart(player);
                    Console.Clear();
                    runDay.GetWeather(rnd);
                    runDay.GetForecast(rnd);
                    recipe.RecipeStart(player);
                    Console.Clear();
                    player.inventory.DisplayInventory();
                    runDay.GetTotalCustomers(rnd);
                }
                else
                {
                    Console.WriteLine("Congrats on making it through a whole week with your lemonade stand!");
                    player.inventory.DisplayInventory();
                    //add option to play again
                }
            }
        }
    }
}
