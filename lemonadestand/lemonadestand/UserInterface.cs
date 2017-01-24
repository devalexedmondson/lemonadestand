using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadestand
{
    public class UserInterface
    {
        public UserInterface()
        {
            
        }
        public void WelcomePlayer()
        {
            Console.WriteLine("Welcome to Lemonade stand!");
            Console.WriteLine("Your objective is to try and sell as much lemonade as you can in the 7 days given to you.\n\n You will start off the game with a set amount of money and then you will shop for your three ingredients, lemons, sugar, and ice.\n\nThe things that affect your choices are the ingredients that you buy and the weather of the day.\n After each day your total profit or loss will be displayed. The goal is to make as much money possible. Good luck!");
        }
        //display inventory of player
    }
}
