using System;
using System.Collections.Generic;

namespace RockPaperScissors
{
    public class UserGestures
    {   
        public string userInput;

        public UserGestures()
        {
            MainMenu();
        }


        public virtual void MainMenu()
        {   
            List<string> gestures = new List<string>();
            gestures.Add("rock");
            gestures.Add("paper");
            gestures.Add("scissors");
            gestures.Add("lizard");
            gestures.Add("spock");

            Console.WriteLine("Please choose a) rock, b) paper, c) scissors, d) spock or e) lizard");
            userInput = Console.ReadLine();

            switch (userInput)
            {
                case "a":
                    Console.WriteLine(gestures[0] + " was chosen");
                    break;
                case "b":
                    Console.WriteLine(gestures[1] + " was chosen");
                    break;
                case "c":
                    Console.WriteLine(gestures[2] + " was chosen");
                    break;
                case "d":
                    Console.WriteLine(gestures[3] + " was chosen");
                    break;
                case "e":
                    Console.WriteLine(gestures[4] + " was chosen");
                    break;
                default:
                    Console.WriteLine("Invalid Entry Try Again.");
                    MainMenu();
                    break;
            }

        }
    }
}
