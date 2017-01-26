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
       public Game()
        {
            player = new Player();
            UI = new UserInterface();
        }
        public void RunGame()
        {
            UI.WelcomePlayer();
        }
        

    }   
}
