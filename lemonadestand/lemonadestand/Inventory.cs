using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadestand
{
    public class Inventory
    {
        //relates to inventory class in automobiles
        public double money = 20.00;
        public List<List<Supply>> supplies;


        public Inventory()
        {
            supplies = new List<List<Supply>>();
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
            playerInventory = money + supplies;
            return playerInventory
        }



    }
}
