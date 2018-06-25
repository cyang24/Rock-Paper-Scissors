using System;
using System.Collections.Generic;

namespace RockPaperScissors
{
    public abstract class PlayerClass
    {
        public string playerName;
        public double playerScore;
        public string gestureInput;

        public void SetPlayerName(string playerName)
        {
            this.playerName = playerName;
        }
        public string GetPlayerName()
        {
            return playerName;
        }

        public void SetPlayerScore(double playerScore)
        {
            this.playerScore = playerScore;
        }

        public double GetPlayerScore()
        {
            return playerScore;
        }

       
        public virtual void MainMenu()
        {
            List<string> gestures = new List<string>();
            gestures.Add("rock");
            gestures.Add("paper");
            gestures.Add("scissors");
            gestures.Add("lizard");
            gestures.Add("Spock");
        
            Console.WriteLine("Please choose \n1) rock \n2) paper \n3) scissors \n4) spock  \n5) lizard");
            gestureInput = Console.ReadLine();

            switch (gestureInput)
            {
                case "1":
                    Console.WriteLine( playerName + " chose " + gestures[0]);
                    gestureInput = gestures[0];
                    break;
                case "2":
                    Console.WriteLine(playerName + " chose " + gestures[1]);
                    gestureInput = gestures[1];
                    break;
                case "3":
                    Console.WriteLine(playerName + " chose " + gestures[2]);
                    gestureInput = gestures[2];
                    break;
                case "4":
                    Console.WriteLine(playerName + " chose " + gestures[3]);
                    gestureInput = gestures[3];
                    break;
                case "5":
                    Console.WriteLine(playerName + " chose "+ gestures[4]);
                    gestureInput = gestures[4];
                    break;
                default:
                    Console.WriteLine("Invalid Entry Try Again.");
                    MainMenu();
                    break;
            }
        }

        public string GetGestureInput()
        {
            return gestureInput;
        }
    }

  }  
