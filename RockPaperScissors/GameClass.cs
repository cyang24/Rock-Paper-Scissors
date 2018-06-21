using System;
using System.Collections.Generic;

namespace RockPaperScissors
{
    public class GameClass
    {
        // member variables (HAS A relationship)
        // create new players

        public Human Human;
        public Computer Computer;
        public string playerSelectionInput;
        bool playerTurn = true;

        // constructor



        public GameClass() //RUNS GAME
        {   

        

        }


        public NumberOfPlayers (string NumberOfPlayers)
        {
            Console.WriteLine("How many players are playing today?");
            playerSelectionInput = int.Parse(Console.ReadLine());


            if (playerSelectionInput = int 1 )
            {
                Human player1 = new Human();
                Computer computer = new Computer();
            }
            else {playerSelectionInput => 2)
            {
                Human player1 = new Human();
                Human player2 = new Computer();
            }

        public void Player1Turn ()
        
                if (bool playerTurn = false) {
                

                }

        }
    }
}
