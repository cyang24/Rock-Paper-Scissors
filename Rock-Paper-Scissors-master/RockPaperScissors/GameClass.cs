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

        //public void ScoreBoard()
        //{
        //    Console.WriteLine("Current Score Player1: " + player1.GetPlayerScore() + " Player2: " + player2.GetPlayerScore())

        //}

        // NumberOfPlayers

        public void  NumberOfPlayers()
        {
            Console.WriteLine("How many players are playing today?");
            playerSelectionInput = Console.ReadLine();

            if (playerSelectionInput == "1")
            {
                player1 = new Human();
                Console.WriteLine("What is your name Player 1?");
                player1.SetPlayerName(Console.ReadLine());
                player1.GetPlayerName();
                player2 = new Computer();
                player2.SetPlayerName("Computer");
                player2.GetPlayerName();
            }

            else if (playerSelectionInput == "2")
            {
                player1 = new Human();
                Console.WriteLine("What is your name Player 1?");
                player1.SetPlayerName(Console.ReadLine());
                player1.GetPlayerName();
                Console.WriteLine("What is your name Player 2?");
                player2 = new Human();
                player2.SetPlayerName(Console.ReadLine());
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


        //Game Results

        public void GesturesConditions(playerOneInput, playerTwoInput)
        {
            Boolean win = false;

            if (playerOne.GetGesture().Equals("rock") && playerTwo.GetGesture().Equals("paper"))
            {
                win = true;
            }
            else if (playerOne.GetGesture().Equals("scissors") && playerTwo.GetGesture().Equals("paper"))
            {
                win = true;
            }
            else if (playerOne.GetGesture().Equals("paper") && playerTwo.GetGesture().Equals("rock"))
            {
                win = true;
            }
            else if (playerOne.GetGesture().Equals("rock") && playerTwo.GetGesture().Equals("lizard"))
            {
                win = true;
            }
            else if (playerOne.GetGesture().Equals("lizard") && playerTwo.GetGesture().Equals("spock"))
            {
                win = true;
            }
            else if (playerOne.GetGesture().Equals("spock") && playerTwo.GetGesture().Equals("scissors"))
            {
                win = true;
            }
            else if (playerOne.GetGesture().Equals("lizard") && playerTwo.GetGesture().Equals("paper"))
            {
                win = true;
            }
            else if (playerOne.GetGesture().Equals("paper") && playerTwo.GetGesture().Equals("spock"))
            {
                win = true;
            }
            else if (playerOne.GetGesture().Equals("spock") && playerTwo.GetGesture().Equals("rock"))
            {
                win = true;
            }
            else
            {
                win = false;
            }

            if (win)
            {
                player1.GetPlayerScore(player1.GetPlayerScore() + 1);
                Console.Write(player1.GetPlayerScore());
            }
            else
            {
                player2.GetPlayerScore(player2.GetPlayerScore() + 1);
                Console.Write(player2.GetPlayerScore());
            }
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

                GesturesConditions(playerOneInput, playerTwoInput);

                //player1Score;
                //player2Score;
            }

            while (player1.GetPlayerScore() < 3 || player2.GetPlayerScore() < 3);
        }

       
    }
}
