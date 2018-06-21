using System;
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


        public void UserGestures()
        {
            Console.WriteLine("Please choose 1)rock, 2)paper, 3)scissors, 4)spock or 5)lizard!");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    Console.WriteLine("ROCK was chosen");
                    break;
                case "2":
                    Console.WriteLine("PAPER was chosen");
                    break;
                case "3":
                    Console.WriteLine("SCISSORS was chosen");
                    break;
                case "4":
                    Console.WriteLine("SPOCK was chosen");
                    break;
                case "5":
                    Console.WriteLine("LIZARD was chosen");
                    break;
                default:
                    Console.WriteLine("Invalid Entry Try Again.");
                    break;
            }
           UserGestures(); 
        }
    }
}
