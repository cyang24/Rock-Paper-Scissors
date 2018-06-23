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
        public string player1Input;
        public string player2Input;
        public string gestureInput;
        public bool playerWin = false;
       
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
                player1.SetPlayerScore(0);
                player2 = new Computer();
                player2.SetPlayerName("Computer");
                player2.GetPlayerName();
                player2.SetPlayerScore(0);
            }

            else if (playerSelectionInput == "2")
            {
                player1 = new Human();
                Console.WriteLine("What is your name Player 1?");
                player1.SetPlayerName(Console.ReadLine());
                player1.GetPlayerName();
                player1.SetPlayerScore(0);
                Console.WriteLine("What is your name Player 2?");
                player2 = new Human();
                player2.SetPlayerName(Console.ReadLine());
                player2.GetPlayerName();
                player2.SetPlayerScore(0);
           }
        }

        // Player Turns 1) rock, 2) paper, 3) scissors, 4) spock or 5) lizard


        public void Player1Turn()
        {
            UserGestures gestures = new UserGestures();
            player1Input = player1.GetGestureInput();

        }

        public void Player2Turn()
        {
            UserGestures gestures = new UserGestures();
            player2Input = player2.GetGestureInput();
           
        }

            //Game Results

            public void GesturesConditions(string player1Input , string player2Input)
            {
            if (player1Input == "rock" && player2Input == "paper") //Rock eats paper
            {
                playerWin = true;
            }
            else if (player1Input == "scissors" && player2Input == "paper") //scissors beats paper
            {
                playerWin = true;
            }
            else if (player1Input == "paper" && player2Input == "rock")
            {
                playerWin = true;
            }
            else if (player1Input == "rock" && player2Input == "lizard")
            {
                playerWin = true;
            }
            else if (player1Input == "lizard" && player2Input == "spock")
            {
                playerWin = true;
            }
            else if (player1Input == "spock" && player2Input == "scissors")
            {
                playerWin = true;
            }
            else if (player1Input == "lizard" && player2Input == "paper")
            {
                playerWin = true;
            }
            else if (player1Input == "paper" && player2Input == "spock")
            {
                playerWin = true;
            }
            else if (player1Input == "spock" && player2Input == "rock")
            {
                playerWin = true;
            }
            else if (player1Input == player2Input)
            {
                Console.WriteLine("It's a Tie!");
            }

            if (playerWin == true)
                {
                player1.SetPlayerScore(player1.playerScore +=1);
                Console.WriteLine("You Win!");
                }

                else
                {
                player2.SetPlayerScore(player2.playerScore += 1);
                Console.WriteLine("Sorry You Lose!");
                }
            }

            
            // Runs Game

            public void RunGame()
            {
                Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard or Spock");
                NumberOfPlayers();
                Console.WriteLine("All set! First player to 3 wins, takes the victory");
                Console.WriteLine("Let's Begin");

                do
                {
                    Console.WriteLine("Your turn " + player1.GetPlayerName());
                    Player1Turn();
                    Console.WriteLine("Your turn " + player2.GetPlayerName());
                    Player2Turn();
                    GesturesConditions(player1Input, player2Input);
                    

                    Console.WriteLine("Current Score " + player1.GetPlayerName() + " is " + player1.GetPlayerScore());
                    Console.WriteLine("Current Score " + player2.GetPlayerName() + " is " + player2.GetPlayerScore());
                    
                    Console.ReadLine();
                }
                
                while (player1.GetPlayerScore() < 3 && player2.GetPlayerScore() < 3);
            }
    }
}
