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
        bool playerTurn;

        // constructor



        //public GameClass() //RUNS GAME
        //{
            
        //}

        //public void  RunGame()
        //{
            
        //NumberOfPlayers();


        //}

        public void  NumberOfPlayers()
        {
            Console.WriteLine("How many players are playing today?");
            playerSelectionInput = int.Parse(Console.ReadLine());

            if (playerSelectionInput = 1)
            {
                Human player1 = new Human();
                Computer computer = new Computer();
            }

            else if (playerSelectionInput = 2)
            {
                Human player1 = new Human();
                Human player2 = new Human();

           }
        }


        //public void Player1Turn ()
          
             //Player1
            
                
                
            

       
    }
}
