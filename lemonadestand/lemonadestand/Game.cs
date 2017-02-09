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
        public Demand demand;
        
       public Game()
        {
            player = new Player();
            UI = new UserInterface();
            runDay= new Day();
            store = new Store();
            recipe = new Recipe();
            rnd = new Random();
            demand = new Demand();


        }
        public void RunGame()
        {
            UI.WelcomePlayer();
            Console.Clear();
            runDay.DisplayDay();
            player.inventory.DisplayInventory();
            store.StoreStart(player);
            Console.Clear();
            runDay.GetWeather(rnd);
            runDay.GetForecast(rnd);
            recipe.RecipeStart(player);
            Console.Clear();
            player.inventory.DisplayInventory();
            runDay.GetTotalCustomers(rnd);
            demand.GetCustomersBuying(recipe);
            player.SellLemonade(demand);
            player.inventory.DisplayInventory();
            double dayEarning = runDay.CalculateDaysEarnings(player,recipe);
            double dayProfit = runDay.CalculateDayProfit(dayEarning,store);
            double totalProfit = CalculateTotalProfit(dayProfit);
            DisplayTotalProfit(totalProfit);
            player.CheckSpoilInventory();
            NewDay();
        }
        public double CalculateTotalProfit(double dayProfit)
        {
            double totalprofit = dayProfit += ;
            return totalprofit;
        }
        public void DisplayTotalProfit(double totalProfit)
        {
            Console.WriteLine($"Your total profit is: ${totalProfit}!");
        }
        public void NewDay()
        {
            for (int i = 1; i < 7; i++)
            {
                if (runDay.day <= 7)
                {
                    store.StoreStart(player);
                    Console.Clear();
                    runDay.GetWeather(rnd);
                    runDay.GetForecast(rnd);
                    recipe.RecipeStart(player);
                    Console.Clear();
                    player.inventory.DisplayInventory();
                    runDay.GetTotalCustomers(rnd);
                    demand.GetCustomersBuying(recipe);
                    player.SellLemonade(demand);
                    player.inventory.DisplayInventory();
                    double dayEarning = runDay.CalculateDaysEarnings(player, recipe);
                    double dayProfit = runDay.CalculateDayProfit(dayEarning, store);
                    double totalProfit = CalculateTotalProfit(dayProfit);
                    DisplayTotalProfit(totalProfit);
                    player.CheckSpoilInventory();
                    NewDay();
                }
                else if (i > 7)
                {
                    Console.WriteLine("Congrats on making it through a whole week with your lemonade stand!");
                    Console.ReadKey();
                    player.inventory.DisplayInventory();
                    //add option to play again
                }
            }
        }
    }
}
