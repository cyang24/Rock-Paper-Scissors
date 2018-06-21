using System;
using System.Collections;

namespace RockPaperScissors
{
    public class UserGestures
    {

        Lists<string> gesture = new Lists<string>();
        gesture.add("rock");
        gesture.add("paper");
        gesture.add("scissors");
        gesture.add("lizard");
        gesture.add("spock");


        public void MainMenu()
        {
            Console.WriteLine("Please choose 1) rock, 2) paper, 3) scissors, 4) spock or 5) lizard!");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    gesture[0];
                    break;
                case "2":
                    gesture[1];;
                    break;
                case "3":
                    gesture[2];;
                    break;
                case "4":
                    gesture[3];;
                    break;
                case "5":
                    gesture[4];;
                    break;
                default:
                    Console.WriteLine("Invalid Entry Try Again.");
                    break;
            }
           MainMenu(); 
        }
    }
}
