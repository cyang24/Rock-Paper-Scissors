using System;
using System.Collections.Generic;

namespace RockPaperScissors
{
    public class Human : PlayerClass
    {
        //member variables

     

        //Constructor 

        public Human(string playerName)
            :base(playerName)
        {
            this.playerName = playerName;

        }



        //member methods

        public void MainMenu(List<string> gestures);

    }
}
