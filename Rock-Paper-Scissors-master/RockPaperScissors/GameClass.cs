using System;
using System.Collections.Generic;

namespace RockPaperScissors
{
    public class GameClass
    {
        // member variables (HAS A relationship)

        public PlayerClass player1;
        public PlayerClass player2;
        public string playerSelectionInput;
        public string player1GestureInput;
        public string player2GestureInput;
        public string gestureInput;
        public bool playerWin;
        public bool playAgain = true;
       
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
            else
            {
               Console.WriteLine("Invalid entry please choose 1 or 2");
                NumberOfPlayers();    
            }
        }

        // Player Turns 1) rock, 2) paper, 3) scissors, 4) spock or 5) lizard


        public void Player1Turn()
        {   
            player1.MainMenu();
            player1GestureInput = player1.GetGestureInput();
            //player1.GetGestureInput();
        }

        public void Player2Turn()
        {   
            player2.MainMenu();
            player2GestureInput = player2.GetGestureInput();
            //player2.GetGestureInput();
        }

        //Game Results

        public void GesturesConditions(string player1GestureInput, string player2GestureInput)
        {
            if (player1GestureInput == player2GestureInput)
            {
                Console.WriteLine("It's a Tie No Winners!");
            }

            else{
                
                if (player1GestureInput == "rock" && player2GestureInput == "scissors")
                {
                    playerWin = true;
                }
                else if (player1GestureInput == "scissors" && player2GestureInput == "paper")
                {
                    playerWin = true;
                }
                else if (player1GestureInput == "paper" && player2GestureInput == "rock")
                {
                    playerWin = true;
                }
                else if (player1GestureInput == "rock" && player2GestureInput == "lizard")
                {
                    playerWin = true;
                }
                else if (player1GestureInput == "lizard" && player2GestureInput == "Spock")
                {
                    playerWin = true;
                }
                else if (player1GestureInput == "Spock" && player2GestureInput == "scissors")
                {
                    playerWin = true;
                }
                else if (player1GestureInput == "scissors" && player2GestureInput == "lizard")
                {
                    playerWin = true;
                }
                else if (player1GestureInput == "lizard" && player2GestureInput == "paper")
                {
                    playerWin = true;
                }
                else if (player1GestureInput == "paper" && player2GestureInput == "Spock")
                {
                    playerWin = true;
                }
                else if (player1GestureInput == "Spock" && player2GestureInput == "rock")
                {
                    playerWin = true;
                }
                else
                {
                    playerWin = false;
                }

                BattleResults();
            
            }
        }

        public void BattleResults()
        {
            if (playerWin == true)
            {
                player1.SetPlayerScore(player1.playerScore += 1);
                Console.WriteLine("Geat Win! " + player1.GetPlayerName());
            }
            else if (playerWin == false)
            {
                player2.SetPlayerScore(player2.playerScore += 1);
                Console.WriteLine("Geat Win! " + player2.GetPlayerName());
            }
            else if (playerWin == true && playerWin == false)
            {
              Console.WriteLine("It's a Tie! No Winners");
            }
        }


        //Play Again
        public void PlayAgain()
        {
            do
            {
                Console.WriteLine("\n");
                Console.WriteLine("Play Again? Y or N");
                string userChoice = Console.ReadLine().ToUpper();
                RunGame();

            } 
            while (Console.ReadLine() == "Y");
        }

        // Runs Game

        public void RunGame()
        {

            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard or Spock \nFirst player to 3 wins, takes the victory \nLet's Begin");
            Console.WriteLine("\n");
            NumberOfPlayers();
            Console.WriteLine("\n");

            do
            {
                Console.WriteLine("Your turn " + player1.GetPlayerName());
                Player1Turn();
                Console.WriteLine("\n");
                Console.WriteLine("Your turn " + player2.GetPlayerName());
                Player2Turn();
                Console.WriteLine("\n");
                GesturesConditions(player1GestureInput, player2GestureInput);
                Console.WriteLine("\n");

                Console.WriteLine("Current Score " + player1.GetPlayerName() + " is " + player1.GetPlayerScore());
                Console.WriteLine("Current Score " + player2.GetPlayerName() + " is " + player2.GetPlayerScore());
                Console.WriteLine("\n");

            }

            while (player1.GetPlayerScore() < 3 && player2.GetPlayerScore() < 3);

            if (player1.GetPlayerScore() == 3)
            {
                Console.WriteLine(player1.GetPlayerName() + " takes the set!! Great Win!");
            }
            else if (player2.GetPlayerScore() == 3)
            {
                Console.WriteLine(player2.GetPlayerName() + " takes the set!! Great Win!");

            }

            PlayAgain();
        }
    }
}
