using System;
using System.Collections.Generic;

namespace RockPaperScissors
{
    public abstract class PlayerClass
    {
        //Member Variables (HAS A)

        public string playerName;
        public string userInput;

        UserGestures gestures = new UserGestures();

            //Can Do's

            public void MainMenu(List<string> gestures)
            {
                Console.WriteLine("Please choose 1) rock, 2) paper, 3) scissors, 4) spock or 5) lizard!");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Console.WriteLine(gestures[0] + "Was Thrown");
                        break;
                    case "2":
                        Console.WriteLine(gestures[1] + "Was Thrown");
                        break;
                    case "3":
                        Console.WriteLine(gestures[2] + "Was Thrown");
                        break;
                    case "4":
                        Console.WriteLine(gestures[3] + "Was Thrown");
                        break;
                    case "5":
                        Console.WriteLine(gestures[4] + "Was Thrown");
                        break;
                    default:
                        Console.WriteLine("Invalid Entry Try Again.");
                        break;
                }

            //MainMenu(List<string> gestures);
            }
    }
}
