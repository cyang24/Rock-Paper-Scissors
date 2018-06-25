using System;
using System.Collections.Generic;

namespace RockPaperScissors
{
    public class Computer : PlayerClass
    {
        Random random = new Random();

        public override void MainMenu()
        {
            List<string> gestures = new List<string>();
            gestures.Add("rock");
            gestures.Add("paper");
            gestures.Add("scissors");
            gestures.Add("lizard");
            gestures.Add("Spock");

            gestureInput = random.Next(1, 5).ToString();

            switch (gestureInput)
            {
                case "1":
                    Console.WriteLine(playerName + " chose " + gestures[0]);
                    gestureInput = gestures[0];
                    break;
                case "2":
                    Console.WriteLine(playerName + " chose " + gestures[1]);
                    gestureInput = gestures[1];
                    break;
                case "3":
                    Console.WriteLine(playerName + " chose "+ gestures[2]);
                    gestureInput = gestures[2];
                    break;
                case "4":
                    Console.WriteLine(playerName + " chose "+ gestures[3]);
                    gestureInput = gestures[3];
                    break;
                case "5":
                    Console.WriteLine(playerName + " chose "+ gestures[4]);
                    gestureInput = gestures[4];
                    break;
            }
        }
    }
}
    
