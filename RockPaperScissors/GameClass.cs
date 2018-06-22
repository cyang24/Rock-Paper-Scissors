using System;
using System.Collections.Generic;

namespace RockPaperScissors
{
    public class GameClass
    {
        // member variables (HAS A relationship)
        // create new players

        public PlayerClass player1;
        public PlayerClass player2;
        public string playerSelectionInput;
        bool playerTurn = true;
        double player1Score = 0;
        double player2Score = 0;

        public void ScoreBoard()
        {
            Console.WriteLine("Current Score Player1: " + player1Score + " Player2: " + player2Score);

        }

        // NumberOfPlayers

        public void  NumberOfPlayers()
        {
            Console.WriteLine("How many players are playing today?");
            playerSelectionInput = Console.ReadLine();

            if (playerSelectionInput == "1")
            {
                player1 = new Human();
                Console.WriteLine("What is your name Player 1?");
                player1.SetPLayerName(Console.ReadLine());
                player1.GetPlayerName();
                player2 = new Computer();
                player2.SetPLayerName("Computer");
                player2.GetPlayerName();
            }

            else if (playerSelectionInput == "2")
            {
                player1 = new Human();
                Console.WriteLine("What is your name Player 1?");
                player1.SetPLayerName(Console.ReadLine());
                player1.GetPlayerName();
                Console.WriteLine("What is your name Player 2?");
                player2 = new Human();
                player2.SetPLayerName(Console.ReadLine());
                player2.GetPlayerName();
           }
        }

        // Player Turns 1) rock, 2) paper, 3) scissors, 4) spock or 5) lizard

        public void Player1Turn()
        {

            UserGestures gestures = new UserGestures(); 
                                                
        }

        public void Player2Turn()
        {
            UserGestures gestures = new UserGestures();

        }

        // Runs Game

        public void RunGame()
        {   Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard or Spock");
            NumberOfPlayers();
            Console.WriteLine("All set! First player to 3 wins takes the victory");
            Console.WriteLine("Let's Begin");
            do
            {
                Console.WriteLine("Your turn " + player1.GetPlayerName());
                Player1Turn();
                Console.WriteLine("Your turn Player2");
                Player2Turn();

                //player1Score;
                //player2Score;
            }

            while (player1Score < 3 || player2Score < 3);
        }

       
    }
}
