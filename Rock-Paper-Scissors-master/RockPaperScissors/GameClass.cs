using System;
using System.Collections.Generic;

namespace RockPaperScissors
{
    public class GameClass
    {
        // member variables (HAS A relationship)

        public PlayerClass player1;
        public PlayerClass player2;
        public string NumberOfplayerSelection;
        public string player1GestureInput;
        public string player2GestureInput;
        public string gestureInput;
        public bool playerWin;
        public bool playGame = true;
       
        // Game Conditions Setup

        public void  NumberOfPlayers()
        {
            Console.WriteLine("How many players are playing today?");
            NumberOfplayerSelection = Console.ReadLine();

            if (NumberOfplayerSelection == "1")
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

            else if (NumberOfplayerSelection == "2")
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

        // Player Turn Gestures

        public void Player1Turn()
        {   
            player1.MainMenu();
            player1GestureInput = player1.GetGestureInput();
        }

        public void Player2Turn()
        {   
            player2.MainMenu();
            player2GestureInput = player2.GetGestureInput();
        }

        //Game Conditions

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
        }


        //Plays Game (Master Method)
        public void PlayGame()
        {
            while (playGame)
            {
                RunGame();
                Console.WriteLine("\n");
                Console.WriteLine("Would you like to play again? Y or N");
                ConsoleKeyInfo cki = Console.ReadKey(); 
                playGame = cki.KeyChar == 'y';
            }
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

                Console.WriteLine("Current Score " + player1.GetPlayerName() + ": " + player1.GetPlayerScore());
                Console.WriteLine("Current Score " + player2.GetPlayerName() + ": " + player2.GetPlayerScore());
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
        }
    }
}
