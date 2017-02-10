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
            double dayProfit = runDay.CalculateDayProfit(store);
            double totalProfit = CalculateTotalProfit(dayProfit);
            runDay.DisplayDayProfit();
            DisplayTotalProfit(totalProfit);
            AddProfit(totalProfit);
            player.CheckSpoilInventory();
            Console.Clear();
            EndOfDay();
            NewDay();
        }
        public double CalculateTotalProfit(double dayProfit)
        {
            //TODO
            double totalProfit = dayProfit + 5;
          
           return totalProfit;
        }
        public void DisplayTotalProfit(double totalProfit)
        {
            Console.WriteLine($"Your total profit is: ${totalProfit}!");
            Console.ReadKey();
        }
        public void AddProfit(double totalProfit)
        {
            player.inventory.money = totalProfit + player.inventory.money;
        }
        public void EndOfDay()
        {
            if (player.inventory.money < 0)
            {
                Console.WriteLine("You have no more money!");
                Console.WriteLine("GAME OVER");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else
            {
                runDay.day++;
            }
        }
        public void NewDay()
        {
            for (int i = 0; i < 8; i++)
            {
                if (runDay.day <= 7)
                {
                    runDay.DisplayDay();
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
                    double dayProfit = runDay.CalculateDayProfit(store);
                    double totalProfit = CalculateTotalProfit(dayProfit);
                    runDay.DisplayDayProfit();
                    DisplayTotalProfit(totalProfit);
                    AddProfit(totalProfit);
                    player.CheckSpoilInventory();
                    Console.Clear();
                    EndOfDay();
                    NewDay();
                }
                else 
                {
                    Console.WriteLine("Congrats on making it through a whole week with your lemonade stand!\n\n Game Over :D");
                    Console.ReadKey();
                    player.inventory.DisplayInventory();
                    return;
                }
            }
        }
    }
}
