using System;
using System.Collections.Generic;

namespace RockPaperScissors
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            GameClass NewGame = new GameClass(); 
            NewGame.RunGame();
            Console.ReadLine();
        }
    }
}
