using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadestand
{
    public class Inventory
    {
        public double money = 20.00;
        public List<List<Supply>> supplies;
        public double profit;

        public Inventory()
        {
            supplies = new List<List<Supply>>();
            List<Supply> lemon = new List<Supply>();
            List<Supply> sugar = new List<Supply>();
            List<Supply> ice = new List<Supply>();
            List<Supply> cup = new List<Supply>();
            supplies.Add(lemon);
            supplies.Add(sugar);
            supplies.Add(ice);
            supplies.Add(cup);
            //this adds the supplies to the list so they can be placeholders. 
        }
        
        public void AddLemon(Lemon lemon)
        {
            supplies[0].Add(lemon);
        }
        public void AddSugar(Sugar sugar)
        {
            supplies[1].Add(sugar);
        }
        public void AddIce(Ice ice)
        {
            supplies[2].Add(ice);
        }
        public void AddCup(Cup cup)
        {
            supplies[3].Add(cup);
        }

        public void DisplayInventory()
        {
            Console.WriteLine($"Your current inventory:\n\n Money: ${money}\n Lemons: {supplies[0].Count}\n Sugar: {supplies[1].Count}\n Ice: {supplies[2].Count}\n Cups: {supplies[3].Count}");
            Console.ReadKey();
            Console.Clear();
        }
        
        //public void AddToWallet()
        //{
        //    if (/*what customer bought > money*/)
        //    {
        //        //money += what customer bought 
        //    }
        //    else
        //    {
        //        //do nothing 
        //    }
        //}
        //public void AddToProfit()
        //{
        //    if (what customer bought > money)
        //    {
        //        what customer bought - total of supplies bought by player
        //    }
        //    else 
        //    {
        //       do nothing
        //    }
        //}
        //public void DisplayProfit()
        //{
        //    Console.WriteLine($"Your total profit is {variable that is equals to AddTotalProfit}");
        //}
    }
}
