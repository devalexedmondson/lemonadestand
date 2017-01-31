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
            MainMenu();
            player.inventory.DisplayInventory();
            store.StoreStart(player);
            Console.Clear();
            recipe.RecipeStart(player);
            Console.Clear();
            player.inventory.DisplayInventory();
            runDay.GetWeather(rnd);
            runDay.GetForecast(rnd);
        }

        public string MainMenu()
        {
            Console.WriteLine("Welcome to Lemonade stand!\n\n Please type your option: 'start' new game, game 'rules', 'shop' at store, 'make' recipe, 'check' current inventory");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "start":
                    RunGame();
                    break;
                case "rules":
                    Console.WriteLine("GAME RULES\n");
                    Console.WriteLine("You have 7 days to make as much money as possible with the lemonade stand you have just opened. You have complete control over how you're business is run, including pricing, inventory and buying supplies. Buy your supplies, set your recipe, and start making money!\n\n You will start off the game with $20.00 and will have to buy your supplies, lemons, sugar, ice, and cups. After buying your supplies you get to decide your recipe and start making money.\n\n There are a couple of things that affect the way your customers will buy. The first thing is the weather. If the weather is hot and sunny more customers will be willing to buy your lemonade than if it was cold and storming. The next thing that will affect your game is your recipe, try switching it up to see what your customers like.\n\n After each day your total profit or loss will be displayed. The goal is to make as much money possible. Good luck!\n\n Press enter to continue.");
                    MainMenu();
                    break;
                case "shop":
                    store.StoreStart(player);
                    break;
                case "make":
                    recipe.RecipeStart(player);
                    break;
                case "check":
                   player.inventory.DisplayInventory();

                    break;

                default:
                    Console.WriteLine("User error, please type one of the options given.");
                    Console.ReadKey();
                    Console.Clear();
                    MainMenu();
                    break;
            }
            Console.Clear();
            return userInput;
        }
    }
}
