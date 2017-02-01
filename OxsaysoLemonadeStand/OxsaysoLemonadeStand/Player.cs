using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OxsaysoLemonadeStand
{
    class Player
    {
        public int cupCount;
        public int iceCount;
        public Inventory inventory;
        public Pitcher lemonade;
        public int lemonCount;
        public string name;
        public double pitcherCount;
        public double pitcherTotal; 
        public int sugarCount;
        public double totalPrice;
        public Wallet wallet; 
        public Player()
        {
            inventory = new Inventory();
            lemonade = new Pitcher();
            wallet = new Wallet();
        }
        public void BuyCups()
        {

        }
        public void BuyIce()
        {

        }
        public void BuyLemons()
        {

        }
        public void BuySugar()
        {

        }
        public void DisplayMakeLemonade()
        {

        }
        public void GetIngredients()
        {

        }
        public string GetPitcherAmount()
        {

        }
        public void GetPlayerName()
        {

        }
        public void PitcherAmount(string)
        {

        }
        public void PrintPlayerName()
        {

        }
        public void RemoveIce()
        {

        }
        public void RemoveLemons()
        {

        }
        public void RemoveSugar()
        {

        }
    }
}
