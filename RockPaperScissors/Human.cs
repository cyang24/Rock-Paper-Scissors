using System;
using System.Collections.Generic;

namespace RockPaperScissors
{
    public class Human : PlayerClass
    {
        //member variables

     

        //Constructor 

        public Human()
        {
            SetPLayerName();
        }

        public void SetPLayerName()
        {
            Console.WriteLine("What is your Player Name?");
            this.playerName = Console.ReadLine();
        }


        //member methods


    }
}
